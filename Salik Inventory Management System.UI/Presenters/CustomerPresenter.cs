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

            this.view.saveNewlyaddedEvent += AddNewCustomer;
            this.view.cleanNewFormsBoxes += cleanTextBoxesOfAddNewCustomerForm;
            this.view.saveEditedEvent += saveEditedCustomer;
            this.view.deleteEvent += DeleteCustomer;
            this.view.editEvent += LoadSelectedCustomerToEdit;
            this.view.SearchEvent += SearchCustomer;
            this.view.RefreshGrid += LoadAllCustomers;
            this.view.SortByMoneyOwed += SortByTotalAmountMoneyOwed;

            this.view.setCustomerBindingSource(CustomerBindingSource);
            LoadAllCustomers();
            this.view.Show();
        }

        private void LoadSelectedCustomerToEdit(object? sender, EventArgs e)
        {
            CustomerModel CustomerToEdit = (CustomerModel)CustomerBindingSource.Current;
            view.IdEdit = CustomerToEdit.Id.ToString();
            view.fullnameEdit = CustomerToEdit.FullName;
            view.desEdit = CustomerToEdit.Description;
        }
        private void SortByTotalAmountMoneyOwed(object? sender, EventArgs e)
        {
            try
            {

                view.IsSuccessful = true;
                var result = service.GetAllSortedByTotalMoneyOwed();

                CustomerList = result.ToList();

                CustomerBindingSource.DataSource = CustomerList;
            }
            catch (Exception ex)
            {
                view.Message = ex.Message + " " + ex.StackTrace;
                view.IsSuccessful = false;
            }
        }
        private void DeleteCustomer(object? sender, EventArgs e)
        {
            try
            {
                CustomerModel customerToDelete = (CustomerModel)CustomerBindingSource.Current;
                var fully = service.GetFirstOrDefaultFully(customerToDelete.Id);

                if(fully != null)
                {
                    if (fully.Orders.Count == 0)
                    {
                        bool result = service.Delete(customerToDelete);
                       
                            view.Message = $"{customerToDelete.FullName} به سه ركه وتوى ره شكراوه ";
                            view.IsSuccessful = true;
                      
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "ناتوانريت ره شبكريته وه";
                    }
                }
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ر كه وتوو نه بوو";
            }


            
        }

        private void saveEditedCustomer(object? sender, EventArgs e)
        {

            try
            {
                CustomerModel CustomerToEdit = new CustomerModel();
                CustomerToEdit.Id = int.Parse(this.view.IdEdit);
                CustomerToEdit.FullName = this.view.fullnameEdit;
                CustomerToEdit.Description = this.view.desEdit;

                if (!string.IsNullOrEmpty(CustomerToEdit.FullName))
                {
                    CustomerModel CustomerModelFromDatabase = service.GetFirstOrDefault(d => d.Id == CustomerToEdit.Id);
                    CustomerModelFromDatabase.FullName = CustomerToEdit.FullName;
                    CustomerModelFromDatabase.Description = CustomerToEdit.Description;
                    service.Update(CustomerModelFromDatabase);
                    view.IsSuccessful = true;
                    view.Message =$"{CustomerToEdit.FullName} به سه ركه وتوى ده ست كارى كرا";
                }
                else
                {
                    view.IsSuccessful = false;
                    view.Message = "ناوى كريار نابيت به تال بيت";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "سه ر كه وتوو نه بوو" + " " + ex.Message + " " + ex.StackTrace;
            }

        }

        private void cleanTextBoxesOfAddNewCustomerForm(object? sender, EventArgs e)
        {
            view.fullName = "";
            view.description = "";
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
           
                CustomerModel CustomerToAdd = new CustomerModel();
                CustomerToAdd.FullName = this.view.fullName;
                CustomerToAdd.Description = this.view.description;
 
                try
                {
                    if (!string.IsNullOrEmpty(CustomerToAdd.FullName))
                    {
                       service.Add(CustomerToAdd);
                       view.IsSuccessful = true;
                       view.Message = $"{CustomerToAdd.FullName}كريار به سه ركه وتووى زياد كرا";
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        view.Message = "ناوى كريار نابيت به تال بيت";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = "سه ر كه وتوو نه بوو" + " " + ex.Message + " " + ex.StackTrace;
                }
            
         
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
            view.IsSuccessful = true;


        }

        private void LoadAllCustomers(object? sender, EventArgs e)
        {

            var result = service.GetAll();
            CustomerList = result.ToList();
            CustomerBindingSource.DataSource = CustomerList;
            view.IsSuccessful = true;

        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.searchValue);
            try
            {
                if (emptyValue == false)
                {
                  
                    if (view.byOwedMoney == true)
                    {
                        CustomerList = service.SearchByNameAndOrderByTotalMoneyOwed(this.view.searchValue).ToList();
                    }

                    if (view.noSort == true)
                    {
                        CustomerList = service.SearchByName(this.view.searchValue).ToList();

                    }
                    view.IsSuccessful = true;
                }
                else
                {
                    view.IsSuccessful = true;
                    CustomerList = service.GetAll().ToList();

                }

                CustomerBindingSource.DataSource = CustomerList;
            }
            catch (Exception ex)
            {
                view.Message = ex.Message + " " + ex.StackTrace;
                view.IsSuccessful = false;
            }
        }
    }
}
