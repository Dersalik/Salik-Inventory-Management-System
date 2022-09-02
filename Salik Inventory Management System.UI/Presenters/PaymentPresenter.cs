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
        private CustomerModel SelectedCustomer;
        public PaymentPresenter(IPaymentView view)
        {
          this.view = view;
          PaymentService = new PaymentService();
          customerService=new CustomerService();
          CustomerBindingSource = new BindingSource();
          PaymentBindingSource=new BindingSource();
          this.view.setCustomerBindingSource(CustomerBindingSource);
          this.view.setPaymentBindingSource(PaymentBindingSource);
          view.loadAllPaymentsOfACustomer += LoadAllPaymentsOfACustomer;
          this.view.RefreshCustomerGrid += LoadAllCustomers;
          view.addPayment += addNewPayment;
          view.ChangeSelectedCustomer += ChangeSelectedCustomer;
          view.removePayment += deletePayment;
          view.updatePayment += LoadPaymentToEdit;
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
        private void addNewPayment(object? sender, EventArgs e)
        {
            try
            {
                
                decimal MoneyPaidConvertToDecimal = decimal.Parse(view.newPaymentAmmountToAdd);
                
                if(MoneyPaidConvertToDecimal > 0)
                {
                    try
                    {
                        CustomerModel customerAddPayment = customerService.GetFirstOrDefaultFully(SelectedCustomer.Id);
                        Payment newPayment = new Payment();
                        newPayment.PaymentDate = DateTime.Now;
                        newPayment.PaymentAmount = MoneyPaidConvertToDecimal;
                        newPayment.Customer = customerAddPayment;
                        customerAddPayment.payments.Add(newPayment);
                        customerAddPayment.TotalMoneyOwed -= MoneyPaidConvertToDecimal;
                        customerService.Update(customerAddPayment);
                        view.IsSuccessful = true;
                        view.Message = MoneyPaidConvertToDecimal.ToString() + " " + "به سه ر كه وتووى زيادكرا";


                    }
                    catch (Exception ex)
                    {
                        view.IsSuccessful = false;
                        view.Message = ex.Message + ex.StackTrace + " سه ركه وتوو نه بوو";
                    }
                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "برى باره نابى 0 يان سالب بيت";
                }
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "برى باره به هه له داخل كراوه";
            }
        }
        private void deletePayment(object? sender, EventArgs e)
        {
            Payment paymentToDelete = (Payment)PaymentBindingSource.Current;

            try
            {
                Payment fromDb = PaymentService.GetFirstOrDefaultFully(paymentToDelete.Id);
                PaymentService.Delete(fromDb);

                CustomerModel customerDeletePayment = customerService.GetFirstOrDefaultFully(SelectedCustomer.Id);
                customerDeletePayment.TotalMoneyOwed += fromDb.PaymentAmount;
                customerDeletePayment.payments.Remove(fromDb);
                customerService.Update(customerDeletePayment);
                view.IsSuccessful = true;
                view.Message = "به سه ر كه وتوى ره شكراوه  و باره كه خرايه وه سه ر حسابى كريار وه ك قه رز "+paymentToDelete.PaymentAmount;
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ركه وتوو نه بوو"+" "+ex.Message+ex.StackTrace;
            }
        }

        private void LoadPaymentToEdit(object? sender, EventArgs e)
        {
            Payment payment = (Payment)PaymentBindingSource.Current;
            view.IdEdit = payment.Id.ToString();
            view.DateEdit = payment.PaymentDate.ToString();
            view.PaymentAmountEdit = payment.PaymentAmount.ToString();
        }
        private void LoadAllCustomers()
        {

            var result = customerService.GetAllSortedByTotalMoneyOwed();
            CustomerList = result.ToList();
            CustomerBindingSource.DataSource = CustomerList;
        }
        private void LoadAllCustomers(object? sender, EventArgs e)
        {

            var result = customerService.GetAllSortedByTotalMoneyOwed();
            CustomerList = result.ToList();
            CustomerBindingSource.DataSource = CustomerList;
        }

        private void LoadAllPaymentsOfACustomer(object? sender, EventArgs e)
        {

            try
            {
              CustomerModel customerModel = customerService.GetFirstOrDefaulWithPayments(SelectedCustomer.Id);
              PaymentList = customerModel.payments.ToList(); 
              PaymentBindingSource.DataSource = PaymentList;

              view.LabelName = customerModel.FullName;
              view.TabName = customerModel.FullName;
              //view.MoneyOwed = customerModel.TotalMoneyOwed.ToString();
              view.MoneyOwed=  string.Format(Program.formats, "{0:c}", customerModel.TotalMoneyOwed);

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message=ex.Message+" "+ex.StackTrace;
            }

        }

        private void ChangeSelectedCustomer(object? sender, EventArgs e)
        {
            SelectedCustomer= (CustomerModel)CustomerBindingSource.Current;
        }


    }
}
