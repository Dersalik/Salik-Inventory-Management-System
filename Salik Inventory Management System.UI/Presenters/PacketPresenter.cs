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
            this.view.saveNewlyaddedEvent += addnewpacketbtn;
            this.view.setPacketBindingSource(PacketBindingSource);
            LoadAllPackets();
            this.view.Show();
        }

        private async void addnewpacketbtn(object? sender, EventArgs e)
        {


            try
            {
                double.Parse(this.view.ItemQuantity);
                Decimal.Parse(this.view.ItemPrice);

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
        //event EventHandler editEvent;
        //event EventHandler saveEditedEvent;
        //event EventHandler ReturnToHomeEvent;
        //event EventHandler deleteEvent;
        //event EventHandler addEvent;
        //event EventHandler saveNewlyaddedEvent;
        //event EventHandler UpdateQuantity;
        private async void LoadAllPackets()
        {
            var result =await service.GetAll();
            ItemList = result.ToList();
            PacketBindingSource.DataSource=ItemList;
        }
        private async void searchItem(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.searchValue);

            if (emptyValue == false)
            {
                var result =await service.SearchByName(this.view.searchValue);
                var df = (IEnumerable<ItemModel>)result;
                ItemList = df.ToList(); 
            }
           PacketBindingSource.DataSource= ItemList;
        }
    }
}
