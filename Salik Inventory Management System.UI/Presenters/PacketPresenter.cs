using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Services;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Presenters
{
    public class PacketPresenter
    {
        private IPacketView view;
        private ItemService service;
        private BindingSource PacketBindingSource;
        private IEnumerable<ItemModel> ItemList;
        public PacketPresenter(IPacketView view)
        {
            this.view = view;
            this.service = new ItemService();
            this.PacketBindingSource = new BindingSource();
            this.view.SearchEvent += searchItem;
            this.view.saveNewlyaddedEvent += addnewpacket;
            this.view.editEvent += LoadSelectedItemToEdit;
            this.view.saveEditedEvent +=  saveEditedItem;
            this.view.deleteEvent += DeleteItemAsync;
            this.view.setPacketBindingSource(PacketBindingSource);
            LoadAllPackets();
            this.view.Show();
        }

        private async void DeleteItemAsync(object? sender, EventArgs e)
        {
            try
            {
                ItemModel itemToDelete = (ItemModel)PacketBindingSource.Current;
               var fully= await service.GetFirstOrDefaultFully(itemToDelete.Id);
             
                if (fully.ItemOrderedList.Count ==0)
                {
                    view.Message = "به سه ركه وتوى ره شكراوه";
                    var d= await service.Delete(fully);
                    if (d)
                    {
                        view.Message = "به سه ركه وتوى ره شكراوه";
                        view.IsSuccessful = true;
                        MessageBox.Show(view.Message);
                    }
                    LoadAllPackets();
                    

                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "ناتوانريت ره شبكريته وه";
                    MessageBox.Show(view.Message);

                }
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ر كه وتوو نه بوو";
                MessageBox.Show(view.Message);

            }
        }

        private void LoadSelectedItemToEdit(object? sender, EventArgs e)
        {
            ItemModel itemToEdit = (ItemModel)PacketBindingSource.Current;
            view.IdEdit = itemToEdit.Id.ToString();
            view.ItemNameedit = itemToEdit.ItemName;
            view.ItemPriceedit = itemToEdit.ItemPrice.ToString();
            view.ItemQuantityedit = itemToEdit.ItemQuantity.ToString();
            view.Descriptionedit = itemToEdit.Description;
        }

        private async void saveEditedItem(object? sender, EventArgs e)
        {
            try
            {
                

                ItemModel ItemToUpdate = new ItemModel();
                ItemToUpdate.Id=Convert.ToInt32(view.IdEdit);
                ItemToUpdate.ItemName = this.view.ItemNameedit;
                ItemToUpdate.Description = this.view.Descriptionedit;
                ItemToUpdate.ItemPrice = Decimal.Parse(this.view.ItemPriceedit);
                ItemToUpdate.ItemQuantity = double.Parse(this.view.ItemQuantityedit);

                try
                {


                    view.IsSuccessful = true;
                    view.Message = "به سه ركه وتوى ده ست كارى كرا";
                  
                    await service.Update(ItemToUpdate);

                   await LoadAllPackets();
                    cleanAddNewFields();

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

    


        

        //event EventHandler UpdateQuantity;
        private async void addnewpacket(object? sender, EventArgs e)
        {


            try
            {
           

                ItemModel ItemToAdd = new ItemModel();
                ItemToAdd.ItemName = this.view.ItemName;
                ItemToAdd.Description = this.view.Description;
                ItemToAdd.ItemPrice = Decimal.Parse(this.view.ItemPrice);
                ItemToAdd.ItemQuantity = double.Parse(this.view.ItemQuantity);

                try
                {


                    view.IsSuccessful = true;
                    view.Message = "به سه ركه وتوى زياد كرا";
                    await service.Add(ItemToAdd);


                    LoadAllPackets();
                    cleanAddNewFields();

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

        private void cleanAddNewFields()
        {
            view.ItemName = "";
            view.ItemQuantity = "";
            view.ItemPrice = "";
            view.Description = "";


        }
   
        private async Task LoadAllPackets()
        {
            var result =await service.GetAll();
            ItemList = result.ToList();
            PacketBindingSource.DataSource=ItemList;
        }
        private async void searchItem(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.searchValue);

            try
            {
                if (emptyValue == false)
                {
                    view.IsSuccessful = true;
                    var result = await service.SearchByName(this.view.searchValue);
                    var df = (IEnumerable<ItemModel>)result;
                    
                    ItemList = df.ToList();
                   
                }
                else
                {
                    view.IsSuccessful = true;
                    ItemList = await service.GetAll();
                   
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
