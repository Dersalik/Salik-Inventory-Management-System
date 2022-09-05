using Salik_Inventory_Management_System.UI.Services;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.Presenters
{
    public class OrderPresenter
    {
        private IOrderView view;
        private CustomerService service;
        private OrderPresenter(IOrderView view)
        {
            this.view = view;
            service=new CustomerService();
        }
        public void showView()
        {
            this.view.Show();

        }

        private static OrderPresenter instance;
        public static OrderPresenter GetInstace(IOrderView view)
        {
            if (instance == null)
            {
                instance = new OrderPresenter(view);
                return instance;
            }
            else
            {
                return instance;
            }

        }
    }
}
