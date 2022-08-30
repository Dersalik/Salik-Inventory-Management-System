using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salik_Inventory_Management_System.UI.Views
{
    public partial class CustomerView : Form,ICustomerView
    {
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            CustomerTab.TabPages.Remove(editCustomerTab);
            CustomerTab.TabPages.Remove(addCustomerTab);
    
        }
        private bool issuccessful;
        private string message;
        private static CustomerView instance;
        BackgroundWorker editBackgroundWorker;
        BackgroundWorker deleteBackgroundWorker;
        BackgroundWorker addBackgroundWorker;
        public string fullName { get => CustomerNametxt.Text; set=> CustomerNametxt.Text=value; }
        public string description { get => customerDescriptiontxt.Text; set => customerDescriptiontxt.Text=value; }
        public string fullnameEdit { get => CustomerNameEdit.Text; set => CustomerNameEdit.Text=value; }
        public string desEdit { get => CustomerDesEdit.Text; set => CustomerDesEdit.Text=value; }
        public string searchValue { get => searchtxt.Text; set => searchtxt.Text=value; }
        public bool IsSuccessful { get => issuccessful; set => issuccessful=value; }
        public string Message { get => message; set => message=value; }
        public string IdEdit { get => IdEdittxt.Text; set => IdEdittxt.Text=value; }
        public bool byOwedMoney { get => sortByMoneyOwedradiobtn.Checked; }
        public bool noSort { get => noSortradiobtn.Checked;  }

        public event EventHandler LoadCustomerData;
        public event EventHandler AssignCustomerData;
        public event EventHandler SearchEvent;
        public event EventHandler editEvent;
        public event EventHandler saveEditedEvent;
        public event EventHandler ReturnToHomeEvent;
        public event EventHandler deleteEvent;
        public event EventHandler addEvent;
        public event EventHandler saveNewlyaddedEvent;
        public event EventHandler RefreshGrid;
        public event EventHandler cleanNewFormsBoxes;
        public event EventHandler SortByMoneyOwed;

        public static CustomerView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }

            return instance;
        }

        private void AssociateAndRaiseEvents()
        {

            editBackgroundWorker = new BackgroundWorker();
            deleteBackgroundWorker = new BackgroundWorker();
            addBackgroundWorker = new BackgroundWorker();

            #region backgroundWorkers
            editBackgroundWorker.DoWork += delegate {
                saveEditedEvent?.Invoke(this, EventArgs.Empty);
            };

            editBackgroundWorker.RunWorkerCompleted += delegate
            {


                if (IsSuccessful == false)
                {
                    saveEditedBtn.Enabled = true;
                    MessageBox.Show(message);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(searchtxt.Text))
                    {
                        if (sortByMoneyOwedradiobtn.Checked)
                        {
                            SortByMoneyOwed?.Invoke(this, EventArgs.Empty);
                        }
                        if (noSortradiobtn.Checked)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }
                    MessageBox.Show(Message);
                    saveEditedBtn.Enabled = true;
                }


            };

            deleteBackgroundWorker.DoWork += delegate {
                deleteEvent?.Invoke(this, EventArgs.Empty);
            };

            deleteBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful == false)
                {
                    deletebtn.Enabled = true;
                    MessageBox.Show(message);
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(searchtxt.Text))
                    {
                        if (sortByMoneyOwedradiobtn.Checked)
                        {
                            SortByMoneyOwed?.Invoke(this, EventArgs.Empty);
                        }
                        if (noSortradiobtn.Checked)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }

                    MessageBox.Show(Message);
                   deletebtn.Enabled = true;

                }
            };


            addBackgroundWorker.DoWork += delegate {
                saveNewlyaddedEvent?.Invoke(this, EventArgs.Empty);
            };


            addBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful == false)
                {
                  
                    MessageBox.Show(message);
                    addNewCustomerBtn.Enabled = true;
                    backToHomeFromnewbtn.Enabled = true;
                }
                else
                {

                    if (string.IsNullOrWhiteSpace(searchtxt.Text))
                    {
                        if (sortByMoneyOwedradiobtn.Checked)
                        {
                            SortByMoneyOwed?.Invoke(this, EventArgs.Empty);
                        }
                        if (noSortradiobtn.Checked)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }

                    MessageBox.Show(Message);
                    addNewCustomerBtn.Enabled = true;
                    backToHomeFromnewbtn.Enabled = true;
                    CustomerTab.TabPages.Remove(addCustomerTab);
                    CustomerTab.TabPages.Add(CustomerHomeTab);
                    cleanNewFormsBoxes?.Invoke(this, EventArgs.Empty);
                }





            };
            #endregion


            #region button

            searchbtn.Enabled = false;

            searchtxt.TextChanged += delegate
            {
                searchbtn.Enabled = true;
            };

            searchbtn.Click += delegate {
                searchbtn.Enabled = false;
                SearchEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful == false)
                {
                    MessageBox.Show(Message);
             

                }


            };

            searchtxt.KeyDown += (s, e) =>
            {

                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    if (IsSuccessful == false)
                    {
                        MessageBox.Show(Message);
                    };
                }

            };

            searchtxt.TextChanged += delegate
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    RefreshGrid?.Invoke(this, EventArgs.Empty);
                }
            };

            sortByMoneyOwedradiobtn.MouseClick += delegate
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    if (sortByMoneyOwedradiobtn.Checked != false)
                    {
                        SortByMoneyOwed?.Invoke(this, EventArgs.Empty);
                    }


                }

                if (!string.IsNullOrWhiteSpace(searchtxt.Text))
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);

                }


            };

            noSortradiobtn.MouseClick += delegate
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    if (noSortradiobtn.Checked != false)
                    {
                        RefreshGrid?.Invoke(this, EventArgs.Empty);
                    }

                }

                if (!string.IsNullOrWhiteSpace(searchtxt.Text))
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }

            };
            addbtn.Click += delegate {
                addEvent?.Invoke(this, EventArgs.Empty);
                CustomerTab.TabPages.Remove(CustomerHomeTab);
                CustomerTab.TabPages.Remove(editCustomerTab);
                CustomerTab.TabPages.Add(addCustomerTab);
            };

            editbtn.Click += delegate {
                editEvent?.Invoke(this, EventArgs.Empty);
                CustomerTab.TabPages.Remove(CustomerHomeTab);
                CustomerTab.TabPages.Remove(addCustomerTab);
                CustomerTab.TabPages.Add(editCustomerTab);
            };


            //save for after editing
            saveEditedBtn.Click += delegate
            {

                saveEditedBtn.Enabled = false;


                editBackgroundWorker.RunWorkerAsync();

            };

            deletebtn.Click += delegate
            {
                var result = MessageBox.Show("ده ته ويت كريارى دياريكراو ره شكه يته وه", "اكادارى",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    deletebtn.Enabled = false;

                    deleteBackgroundWorker.RunWorkerAsync();

                }

            };

            backToHomeFromnewbtn.Click += delegate
            {
                ReturnToHomeEvent?.Invoke(this, EventArgs.Empty);

                CustomerTab.TabPages.Remove(addCustomerTab);
                CustomerTab.TabPages.Add(CustomerHomeTab);
            };

            ReturnToHomeFromEditbtn.Click += delegate
            {
                ReturnToHomeEvent?.Invoke(this, EventArgs.Empty);

                CustomerTab.TabPages.Remove(editCustomerTab);
                CustomerTab.TabPages.Add(CustomerHomeTab);
            };



            addNewCustomerBtn.Click += delegate
            {
                backToHomeFromnewbtn.Enabled = false;
                addNewCustomerBtn.Enabled = false;

                addBackgroundWorker.RunWorkerAsync();

            };


            #endregion
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void addingQuantityBtn_Click(object sender, EventArgs e)
        {

        }

        public void setCustomerBindingSource(BindingSource CustomerList)
        {
            customerDataGridView.DataSource = CustomerList;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void editCustomerTab_Click(object sender, EventArgs e)
        {

        }

        private void noSortradiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
