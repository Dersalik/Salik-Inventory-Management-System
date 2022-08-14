using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Views.view_Interfaces
{
    public interface IMainView
    {
        event EventHandler ShowHome;
        event EventHandler ShowCustomerNav;
        event EventHandler ShowPacketNav;
        event EventHandler ShowOrderNav;
        event EventHandler ShowPaymentNav;
        event EventHandler ShowRaportNav;

    }
}
