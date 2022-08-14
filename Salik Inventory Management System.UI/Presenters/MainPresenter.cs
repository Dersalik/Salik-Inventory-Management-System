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
        }

        public void ShowPacketNav(object sender, EventArgs e)
        {
            IPacketView packetView = PacketView.GetInstace((MainView)mainView);
            new PacketPresenter(packetView);
        }
    }
}
