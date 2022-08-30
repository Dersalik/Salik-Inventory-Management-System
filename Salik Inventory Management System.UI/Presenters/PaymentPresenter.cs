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
    public class PaymentPresenter
    {
        private PaymentService PaymentService;
        private IPaymentView view;
        private BindingSource CustomerBindingSource;
        private IEnumerable<CustomerModel> CustomerList;
        private BindingSource PaymentBindingSource;
        private IEnumerable<Payment> PaymentList;
        private CustomerService customerService;
        public PaymentPresenter(IPaymentView view)
        {
          this.view = view;
          PaymentService = new PaymentService();
          customerService=new CustomerService();
          CustomerBindingSource = new BindingSource();
          PaymentBindingSource=new BindingSource();
          view.loadAllPaymentsOfACustomer += LoadAllPaymentsOfACustomer;
          this.view.setCustomerBindingSource(CustomerBindingSource);
          this.view.setPaymentBindingSource(PaymentBindingSource);
        }
        public void showView()
        {
            LoadAllCustomers();
            this.view.Show();

        }

        private static PaymentPresenter instance;
        public static PaymentPresenter GetInstace(IPaymentView view)
        {
            if (instance == null)
            {
                instance = new PaymentPresenter(view);
                return instance;
            }
            else
            {
                return instance;
            }

        }
        private void LoadAllCustomers()
        {

            var result = customerService.GetAll();
            CustomerList = result.ToList();
            CustomerBindingSource.DataSource = CustomerList;
        }

        private void LoadAllPaymentsOfACustomer(object? sender, EventArgs e)
        {
            CustomerModel customer = (CustomerModel)CustomerBindingSource.Current;

            view.LabelName = customer.FullName;
            view.TabName = customer.FullName;

            try
            {
              CustomerModel customerModel = customerService.GetFirstOrDefaultFully(customer.Id);
              PaymentBindingSource.DataSource = customer.payments.ToList(); 
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message=ex.Message+" "+ex.StackTrace;
            }

        }
    }
}
