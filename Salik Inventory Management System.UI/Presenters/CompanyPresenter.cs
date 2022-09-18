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
    public class CompanyPresenter
    {
        private ICompanyView view;
        private UserService userservice;
        private CompanyPaymentService companyPaymentService;
        private MardService mardservice;
        private BindingSource PaymentBindingSource;
        private IEnumerable<CompanyPayment> PaymentList;
        private CustomerService CustomerService;

        public CompanyPresenter(ICompanyView view)
        {
              this.view = view;
              userservice=new UserService() ;
              companyPaymentService=new CompanyPaymentService();
              mardservice = new MardService();
              PaymentBindingSource=new BindingSource();
            CustomerService = new CustomerService();
            view.addPayment += addNewPayment;
              view.setPaymentBindingSource(PaymentBindingSource);
            this.view.RefreshPaymentGrid += LoadALlPayments;
            this.view.removePayment += deletePayment;
            this.view.updatePayment += LoadPaymentToEdit;
            this.view.saveUpdatePayment += editPayment;
        }
        public void showView()
        {
            refreshHomePage();
            LoadALlPayments();
            this.view.Show();

        }
        private void LoadALlPayments(object? sender, EventArgs e)
        {
            refreshHomePage();
            var result = companyPaymentService.GetAll().OrderByDescending(d=>d.PaymentDate);
            PaymentList = result.ToList();
            PaymentBindingSource.DataSource = PaymentList;
        }
        private void LoadALlPayments()
        {
            refreshHomePage();
            var result = companyPaymentService.GetAll().OrderByDescending(d => d.PaymentDate);
            PaymentList = result.ToList();
            PaymentBindingSource.DataSource = PaymentList;
        }
        private void refreshHomePage()
        {

            var totalReceivedFromCustomers = userservice.GetFirstOrDefaultFully().TotalMoneyReceivedFromCustomers;
            var totalOwedByCustomer = CustomerService.GetAll().Sum(d => d.TotalMoneyOwed);
            view.totalMoneyReceivedFromCustomers = string.Format(Program.formats, "{0:c}", totalReceivedFromCustomers);
            view.TotalMoneyOwedByCustomer = string.Format(Program.formats, "{0:c}", totalOwedByCustomer);
            var interest = ((totalReceivedFromCustomers + totalOwedByCustomer) - mardservice.GetFirstOrDefaultFully().TotalMoneyOwedByUserToTheCompany);
            view.interestMoney = string.Format(Program.formats, "{0:c}", interest);
        }
        private static CompanyPresenter instance;
        public static CompanyPresenter GetInstace(ICompanyView view)
        {
            if (instance == null)
            {
                instance = new CompanyPresenter(view);
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

                decimal MoneyPaidConvertToDecimal = decimal.Parse(view.PaymentAmount);

                if (MoneyPaidConvertToDecimal > 0)
                {
                    try
                    {
                        CompanyPayment newPayment = new CompanyPayment();
                        newPayment.PaymentDate = DateTime.Now;
                        newPayment.Amount = MoneyPaidConvertToDecimal;

                        companyPaymentService.Add(newPayment);

                       var company= mardservice.GetFirstOrDefaultFully();
                        company.TotalMoneyOwedByUserToTheCompany-=newPayment.Amount;
                        mardservice.Update(company);

                        var user = userservice.GetFirstOrDefaultFully();
                        user.TotalMoneyReceivedFromCustomers-=MoneyPaidConvertToDecimal;
                        userservice.Update(user);
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
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "برى باره به هه له داخل كراوه";
            }
        }
        private void editPayment(object? sender, EventArgs e)
        {
            CompanyPayment paymentToEdit = (CompanyPayment)PaymentBindingSource.Current;

            try
            {
                if (string.IsNullOrWhiteSpace(view.PaymentAmountEdit))
                {
                    throw new ArgumentNullException();
                }
                decimal InputtedPayment = decimal.Parse(view.PaymentAmountEdit);
                try
                {
                    var user = userservice.GetFirstOrDefaultFully();
                    var company = mardservice.GetFirstOrDefaultFully();
                    if (InputtedPayment > paymentToEdit.Amount)
                    {
                        decimal difference = InputtedPayment - paymentToEdit.Amount;
                        user.TotalMoneyReceivedFromCustomers -= difference;
                        company.TotalMoneyOwedByUserToTheCompany -=difference;
                        CompanyPayment payment = companyPaymentService.GetFirstOrDefault(d => d.Id == paymentToEdit.Id);
                        payment.Amount = InputtedPayment;
                        userservice.Update(user);
                        mardservice.Update(company);
                        companyPaymentService.Update(payment);
                        
                        view.IsSuccessful = true;
                        view.Message = "برى باره ده ستكارى كرا" ;
                    }

                    if (InputtedPayment < paymentToEdit.Amount && InputtedPayment > 0)
                    {
                        decimal difference = InputtedPayment - paymentToEdit.Amount;
                        user.TotalMoneyReceivedFromCustomers += difference;
                        company.TotalMoneyOwedByUserToTheCompany += difference;
                        CompanyPayment payment = companyPaymentService.GetFirstOrDefault(d => d.Id == paymentToEdit.Id);
                        payment.Amount = InputtedPayment;
                        userservice.Update(user);
                        mardservice.Update(company);
                        companyPaymentService.Update(payment);
                        view.IsSuccessful = true;
                        view.Message = "برى باره ده ستكارى كرا";

                    }
                    if (InputtedPayment <= 0)
                    {
                        view.IsSuccessful = false;
                        view.Message = "برى باره به هه له داخل كراوه";
                    }
                    if (paymentToEdit.Amount == InputtedPayment)
                    {
                        view.IsSuccessful = false;
                        view.Message = "برى باره هه مان بره ";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = "سه ركه وتوو نه بوو" + " " + ex.Message + ex.StackTrace;
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "برى باره به هه له داخل كراوه";
            }

        }
        private void deletePayment(object? sender, EventArgs e)
        {
            CompanyPayment paymentToDelete = (CompanyPayment)PaymentBindingSource.Current;

            try
            {
                CompanyPayment fromdb = companyPaymentService.GetFirstOrDefault(d => d.Id == paymentToDelete.Id);
                companyPaymentService.Delete(fromdb);

                var company = mardservice.GetFirstOrDefaultFully();
                company.TotalMoneyOwedByUserToTheCompany += paymentToDelete.Amount;
                mardservice.Update(company);

                var user = userservice.GetFirstOrDefaultFully();
                user.TotalMoneyReceivedFromCustomers += paymentToDelete.Amount;

                view.IsSuccessful = true;
                view.Message = "به سه ر كه وتوى ره شكراوه   " + paymentToDelete.Amount;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ركه وتوو نه بوو" + " " + ex.Message + ex.StackTrace;
            }
        }
        private void LoadPaymentToEdit(object? sender, EventArgs e)
        {
            CompanyPayment payment = (CompanyPayment)PaymentBindingSource.Current;
            view.Id = payment.Id.ToString();
            view.PaymentDate = payment.PaymentDate.ToString();
            view.PaymentAmountEdit = payment.Amount.ToString();
        }

    }
}
