using Salik_Inventory_Management_System.UI.Views;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        
        public MainPresenter(IMainView mainView)
        {
            this.mainView = mainView;
            this.mainView.ShowPacketNav += ShowPacketNav;
            this.mainView.ShowCustomerNav += ShowCustomerNav;
        }

        public void ShowPacketNav(object sender, EventArgs e)
        {
            IPacketView packetView = PacketView.GetInstace((MainView)mainView);
            //will cause duplicate presenter if we declare a new presenter everytime
            //PacketPresenter presenter =  new PacketPresenter(packetView);
            PacketPresenter presenter = PacketPresenter.GetInstace(packetView);

        }

        public void ShowCustomerNav(object sender, EventArgs e)
        {
            ICustomerView customerView =CustomerView.GetInstace((MainView)mainView);
            //will cause duplicate presenter if we declare a new presenter everytime
            //PacketPresenter presenter =  new PacketPresenter(packetView);
            CustomerPresenter presenter = CustomerPresenter.GetInstace(customerView);

        }
    }
}
