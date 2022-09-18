using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Services;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Presenters
{
    public class PacketPresenter
    {
        private IPacketView view;
        private ItemService service;
        private MardService mardService;
        private BindingSource PacketBindingSource;
        private IEnumerable<ItemModel> ItemList;
        private  PacketPresenter(IPacketView view)
        {
            this.view = view;
            this.service = new ItemService();
            this.mardService=new MardService();
            this.PacketBindingSource = new BindingSource();
            this.view.SearchEvent += searchItem;
            this.view.saveNewlyaddedEvent += addnewpacket;
            this.view.editEvent += LoadSelectedItemToEdit;
            this.view.saveEditedEvent +=  saveEditedItem;
            this.view.deleteEvent += DeleteItem;
            this.view.RefreshGrid += LoadAllPackets;
            this.view.UpdateQuantity += updateSelectedItemsQuantity;
            this.view.setPacketBindingSource(PacketBindingSource);
            this.view.cleanNewFormsBoxes += cleanAddNewFields;
            this.view.sortByPrice += sortByPrice;
            this.view.sortByQuantity += sortByQuantity;

            LoadAllPackets();
        }

        public void showView()
        {
            LoadAllPackets();
            this.view.Show();

        }
        private static PacketPresenter instance;
        public static PacketPresenter GetInstace(IPacketView view)
        {
            if (instance == null )
            {
                instance = new PacketPresenter(view);
                return instance;
            }
            else
            {
                return instance;
            }
          
        }

        private void sortByPrice(object? sender, EventArgs e)
        {
            try
            {
               
                    view.IsSuccessful = true;
                    var result = service.GetAllSortedByPrice();
                    
                    ItemList = result.ToList();

                PacketBindingSource.DataSource = ItemList;
            }
            catch (Exception ex)
            {
                view.Message = ex.Message + " " + ex.StackTrace;
                view.IsSuccessful = false;
            }
        }

        private void sortByQuantity(object? sender, EventArgs e)
        {
            try
            {

                view.IsSuccessful = true;
                var result = service.GetAllSortedByQuantity();

                ItemList = result.ToList();

                PacketBindingSource.DataSource = ItemList;
            }
            catch (Exception ex)
            {
                view.Message = ex.Message + " " + ex.StackTrace;
                view.IsSuccessful = false;
            }
        }

        private void DeleteItem(object? sender, EventArgs e)
        {
            try
            {
                
                ItemModel itemToDelete = (ItemModel)PacketBindingSource.Current;
               var fully=  service.GetFirstOrDefaultFully(itemToDelete.Id);
                if (fully != null)
                {
                    if (fully.ItemOrderedList.Count == 0)
                    {
                        var d = service.Delete(fully);

                        view.Message = "به سه ركه وتوى ره شكراوه";
                        view.IsSuccessful = true;

                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "ناتوانريت ره شبكريته وه";
                    }
                }
             
            }
           catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ر كه وتوو نه بوو"+" "+ex.Message+" " +ex.StackTrace;
            }
        }

        private void LoadSelectedItemToEdit(object? sender, EventArgs e)
        {
            ItemModel itemToEdit = (ItemModel)PacketBindingSource.Current;
            view.IdEdit = itemToEdit.Id.ToString();
            view.ItemNameedit = itemToEdit.ItemName;
            view.ItemPriceedit = itemToEdit.ItemPrice.ToString();
            view.ItemBuyingPriceEdit = itemToEdit.ItemPriceBought.ToString();
            view.ItemQuantityedit = itemToEdit.ItemQuantity.ToString();
            view.Descriptionedit = itemToEdit.Description;
        }

        private void updateSelectedItemsQuantity(object?sender,EventArgs e)
        {
            
            ItemModel itemToEdit = (ItemModel)PacketBindingSource.Current;
            try
            {
                itemToEdit.ItemQuantity = itemToEdit.ItemQuantity+ double.Parse(view.updateQuantityPrompt);
                double newQuantity= double.Parse(view.updateQuantityPrompt);
                try
                {
                    
                    service.Update(itemToEdit);
                    var company = mardService.GetFirstOrDefaultFully();
                    company.TotalMoneyOwedByUserToTheCompany += itemToEdit.ItemPriceBought * ((decimal)newQuantity);
                    mardService.Update(company);
                    view.IsSuccessful = true;
                    view.Message = $"{itemToEdit.ItemName} زماره ى نوى زيادكرا بو كارتونى ";
                }
                catch(Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message =" سه ركه وتوو نه بوو" +" " + ex.Message + " " + ex.StackTrace;
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = " هه له له زماره ى داخل كراو هه يه" ; 
            }
        }
        private  void saveEditedItem(object? sender, EventArgs e)
        {
            try
            {
                
                ItemModel ItemToUpdate = new ItemModel();
                double newQuantity= double.Parse(view.ItemQuantityedit);
                ItemToUpdate.Id=Convert.ToInt32(view.IdEdit);
                ItemToUpdate.ItemName = this.view.ItemNameedit;
                ItemToUpdate.Description = this.view.Descriptionedit;
                ItemToUpdate.ItemPrice = Decimal.Parse(this.view.ItemPriceedit);
                ItemToUpdate.ItemPriceBought = Decimal.Parse(this.view.ItemBuyingPriceEdit);
                //ItemToUpdate.ItemQuantity = newQuantity;
                
               
                try
                {
                    view.IsSuccessful = true;
                    view.Message = "به سه ركه وتوى ده ست كارى كرا";
                    var item = service.GetFirstOrDefault(d => d.Id == ItemToUpdate.Id);
                    if(newQuantity > item.ItemQuantity)
                    {
                        var IncreaseOwedMoney = ((decimal)(newQuantity - item.ItemQuantity)) * ItemToUpdate.ItemPrice;
                        var company = mardService.GetFirstOrDefaultFully();
                        company.TotalMoneyOwedByUserToTheCompany += IncreaseOwedMoney;
                        mardService.Update(company);
                    }
                    if (newQuantity < item.ItemQuantity)
                    {
                        var DecreasedOwedMoneyAmount = ((decimal)(item.ItemQuantity - newQuantity)) * ItemToUpdate.ItemPrice;
                        var company = mardService.GetFirstOrDefaultFully();
                        company.TotalMoneyOwedByUserToTheCompany -= DecreasedOwedMoneyAmount;
                        mardService.Update(company);
                    }
                    service.Update(ItemToUpdate);
                 
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = "سه ر كه وتوو نه بوو" + " " + ex.Message + " " + ex.StackTrace;
                    //MessageBox.Show(view.Message);
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "زانياريه كان به هه له بركراو نه ته وه" ;          
            }
        }

    

        //event EventHandler UpdateQuantity;
        private  void addnewpacket(object? sender, EventArgs e)
        {
            try
            {
                ItemModel ItemToAdd = new ItemModel();
                ItemToAdd.ItemName = this.view.ItemName;
                ItemToAdd.Description = this.view.Description;
                ItemToAdd.ItemPrice = Decimal.Parse(this.view.ItemPrice);
                ItemToAdd.ItemPriceBought = Decimal.Parse(this.view.ItemBuyingPrice);
                ItemToAdd.ItemQuantity = double.Parse(this.view.ItemQuantity);
                try
                {
                    if(!string.IsNullOrEmpty(ItemToAdd.ItemName))
                    {
                        if (ItemToAdd.ItemPrice > 0 && ItemToAdd.ItemQuantity > 0 && ItemToAdd.ItemPriceBought > 0)
                        {
                            view.IsSuccessful = true;
                            view.Message = "به سه ركه وتوى زياد كرا";
                            service.Add(ItemToAdd);
                            var company = mardService.GetFirstOrDefaultFully();
                            company.TotalMoneyOwedByUserToTheCompany += ItemToAdd.ItemPriceBought*((decimal)ItemToAdd.ItemQuantity);
                            mardService.Update(company);
                        }
                        else
                        {
                            view.IsSuccessful = false;

                            view.Message = "نرخ و زماره نابى سفر بن";
                        }
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "ناوى كالأ نابيت به تال بيت";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = "سه ر كه وتوو نه بوو" + " " + ex.Message + " " + ex.StackTrace;
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "زانياريه كان به هه له بركراو نه ته وه";
            }
            
        }

        private void cleanAddNewFields(object? sender, EventArgs e)
        {
            view.ItemName = "";
            view.ItemQuantity = "";
            view.ItemPrice = "";
            view.ItemBuyingPrice = "";
            view.Description = "";

        }
   
        private  void LoadAllPackets(object? sender, EventArgs e)
        {
            
            var result = service.GetAll();
            ItemList = result.ToList();
            PacketBindingSource.DataSource=ItemList;
        }
         public void LoadAllPackets()
        {

            var result = service.GetAll();
            ItemList = result.ToList();
            PacketBindingSource.DataSource = ItemList;
        }
        private  void searchItem(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.searchValue);
            try
            {
                if (emptyValue != true)
                {
                  

                    if (view.byprie)
                    {
                        ItemList=service.SearchAndSortByPrice(view.searchValue).ToList();
                    }

                    if(view.byquantity)
                    {
                        ItemList= service.SearchAndSortyByQuantity(view.searchValue).ToList();

                    }
                    if (view.nosort)
                    {
                        ItemList = service.SearchByName(this.view.searchValue).ToList(); ;
                    }
                    view.IsSuccessful = true;

                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "ناوى كارتون بنوسه";
                }
                
                PacketBindingSource.DataSource = ItemList;
            }
            catch(Exception ex)
            {
               view.Message=ex.Message + " " + ex.StackTrace;
                view.IsSuccessful = false;
            }
        }
    }
}
