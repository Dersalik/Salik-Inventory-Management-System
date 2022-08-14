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
        private BindingSource petsBindingSource;
        public PacketPresenter(IPacketView view)
        {
            this.view = view;
            this.service = new ItemService();
            this.view.Show();
        }
    }
}
