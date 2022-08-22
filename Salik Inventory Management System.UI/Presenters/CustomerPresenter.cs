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
    public class CustomerPresenter
    {
        private ICustomerView view;
        private CustomerService service;
        private BindingSource CustomerBindingSource;
        private IEnumerable<CustomerModel> CustomerList;

        public CustomerPresenter(ICustomerView view)
        {
            this.view = view;
            this.service = new CustomerService();
            CustomerBindingSource = new BindingSource();
            this.view.setCustomerBindingSource(CustomerBindingSource);
            LoadAllCustomers();
            this.view.Show();
        }

        private static CustomerPresenter instance;
        public static CustomerPresenter GetInstace(ICustomerView view)
        {
            if (instance == null)
            {
                instance = new CustomerPresenter(view);
                return instance;
            }
            else
            {
                return instance;
            }

        }
        private void LoadAllCustomers()
        {

            var result = service.GetAll();
            CustomerList = result.ToList();
            CustomerBindingSource.DataSource = CustomerList;
        }
    }
}
