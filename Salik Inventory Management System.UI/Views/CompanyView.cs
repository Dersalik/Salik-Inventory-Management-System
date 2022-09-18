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
    public partial class CompanyView : Form,ICompanyView
    {
        public CompanyView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            CompanyTab.TabPages.Remove(editPaymentTab);
            CompanyTab.TabPages.Remove(companyPaymentTab);
        }

        public void setPaymentBindingSource(BindingSource CustomerList)
        {
            CompanyPaymentGridView.DataSource = CustomerList;
        }
        private void AssociateAndRaiseEvents()
        {
            this.CompanyPaymentGridView.Columns["amountDataGridViewTextBoxColumn"].DefaultCellStyle.FormatProvider = Program.formats;
            this.CompanyPaymentGridView.Columns["amountDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "c";
            #region backgroundWorkers
            editBackgroundWorker = new BackgroundWorker();
            deleteBackgroundWorker = new BackgroundWorker();
            addBackgroundWorker = new BackgroundWorker();


            addBackgroundWorker.DoWork += delegate
            {
                addPayment?.Invoke(this, EventArgs.Empty);
            };
            addBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful)
                {
                    RefreshPaymentGrid?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);

                }
                if (!IsSuccessful)
                {
                    MessageBox.Show(message);

                }
                Paybtn.Enabled = true;
                PaymentAmountTxt.Text = "";

            };

            deleteBackgroundWorker.DoWork += delegate
            {


                removePayment?.Invoke(this, EventArgs.Empty);
            };
            deleteBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful)
                {
                    RefreshPaymentGrid?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);

                }
                if (!IsSuccessful)
                {
                    MessageBox.Show(message);

                }
                deletePaymentBtn.Enabled = true;
            };

            editBackgroundWorker.DoWork += delegate
            {
                this.saveUpdatePayment?.Invoke(this, EventArgs.Empty);
            };
            editBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful)
                {
                    RefreshPaymentGrid?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);

                }
                if (!IsSuccessful)
                {
                    MessageBox.Show(message);

                }
                saveeditBtn.Enabled = true;

            };
            #endregion
            #region buttons
            paymentAmountedittxt.TextChanged += delegate
            {
                saveeditBtn.Enabled = true;

            };


            saveeditBtn.Click += delegate
            {
                saveeditBtn.Enabled = false;
                try
                {
                    editBackgroundWorker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.StackTrace);
                }
            };

            Paybtn.Click += delegate
            {
                Paybtn.Enabled = false;
                var result = MessageBox.Show($"$ده ته ويت برى باره بده ى{PaymentAmountTxt.Text}", "اكادارى",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        addBackgroundWorker.RunWorkerAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " " + ex.StackTrace);
                    }
                }
                else
                {
                    Paybtn.Enabled = true;

                }
            };

            deletePaymentBtn.Click += delegate
            {

                var result = MessageBox.Show($"ده ته ويت برى باره ى دياريكراو ره شكه يه وه", "اكادارى",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        deleteBackgroundWorker.RunWorkerAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " " + ex.StackTrace);
                    }
                }
                else
                {
                    deletePaymentBtn.Enabled = true;
                }
            };
            CompanyPaymentbtn.Click += delegate
            {

                RefreshPaymentGrid?.Invoke(this, EventArgs.Empty);
                CompanyTab.TabPages.Remove(companyHomeTab);
                CompanyTab.TabPages.Remove(editPaymentTab);
                CompanyTab.TabPages.Add(companyPaymentTab);

            };
            EditPaymentBtn.Click += delegate
            {
                updatePayment?.Invoke(this, EventArgs.Empty);
                CompanyTab.TabPages.Remove(companyPaymentTab);
                CompanyTab.TabPages.Add(editPaymentTab);
                saveeditBtn.Enabled = false;

            };

            returnToPaymentsbtn.Click += delegate
            {
                CompanyTab.TabPages.Remove(companyHomeTab);
                CompanyTab.TabPages.Remove(editPaymentTab);
                CompanyTab.TabPages.Add(companyPaymentTab);
            };

            returnbtn.Click += delegate
            {

                RefreshHomeTab?.Invoke(this, EventArgs.Empty);

                CompanyTab.TabPages.Remove(companyPaymentTab);
                CompanyTab.TabPages.Add(companyHomeTab);
            };
            #endregion

        }
        BackgroundWorker editBackgroundWorker;
        BackgroundWorker deleteBackgroundWorker;
        BackgroundWorker addBackgroundWorker;
        private static CompanyView instance;

        public event EventHandler RefreshPaymentGrid;
        public event EventHandler addPayment;
        public event EventHandler removePayment;
        public event EventHandler updatePayment;
        public event EventHandler saveUpdatePayment;
        public event EventHandler RefreshHomeTab;

        private bool issuccessful;
        private string message;
        public string interestMoney { get => InterestMoneylbl.Text; set => InterestMoneylbl.Text=value; }
        public string totalMoneyReceivedFromCustomers { get => TotalMoneyReceivedFromCustomerslbl.Text; set => TotalMoneyReceivedFromCustomerslbl.Text=value; }
        public string TotalMoneyOwedByCustomer { get => TotalMoneyOwedByCustomerslbl.Text; set => TotalMoneyOwedByCustomerslbl.Text=value; }
        public string PaymentAmount { get => PaymentAmountTxt.Text; set => PaymentAmountTxt.Text=value; }
        public string Id { get => IdEdittxt.Text; set => IdEdittxt.Text=value; }
        public string PaymentDate { get => Dateedittxt.Text; set => Dateedittxt.Text=value; }
        public string PaymentAmountEdit { get => paymentAmountedittxt.Text; set => paymentAmountedittxt.Text=value; }
        public bool IsSuccessful { get => issuccessful; set => issuccessful=value; }
        public string Message { get => message; set => message=value; }

        public static CompanyView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CompanyView();
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

        private void companyHomeTab_Click(object sender, EventArgs e)
        {

        }
    }
}
