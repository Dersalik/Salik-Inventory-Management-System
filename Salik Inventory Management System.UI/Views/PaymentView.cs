using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Views.view_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salik_Inventory_Management_System.UI.Views
{
    public partial class PaymentView : Form,IPaymentView
    {
        public PaymentView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            paymentTab.TabPages.Remove(PaymentsOfCustomerTab);
            paymentTab.TabPages.Remove(EditTab);

        }
        BackgroundWorker editBackgroundWorker;
        BackgroundWorker deleteBackgroundWorker;
        BackgroundWorker addBackgroundWorker;
        private void AssociateAndRaiseEvents()
        {
           
          
            this.customerPaymentsGridView.Columns["paymentAmountDataGridViewTextBoxColumn"].DefaultCellStyle.FormatProvider=Program.formats;
            this.customerPaymentsGridView.Columns["paymentAmountDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "c";
            this.ListOfCustomersGridView.Columns["totalMoneyOwedDataGridViewTextBoxColumn"].DefaultCellStyle.FormatProvider = Program.formats;
            this.ListOfCustomersGridView.Columns["totalMoneyOwedDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "c";
          

            #region backgroundWorker 
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
                    loadAllPaymentsOfACustomer?.Invoke(this, EventArgs.Empty);
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
                    loadAllPaymentsOfACustomer?.Invoke(this, EventArgs.Empty);
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
                    loadAllPaymentsOfACustomer?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);

                }
                if (!IsSuccessful)
                {
                    MessageBox.Show(message);

                }
                saveeditBtn.Enabled = true;

            };
            #endregion




            #region button
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
                var result = MessageBox.Show($"$ده ته ويت برى باره زياد بكه يت{PaymentAmountTxt.Text}", "اكادارى",
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
               
                var result = MessageBox.Show($"ده ته ويت برى باره ى دياريكراو ره شكه يه وه بيخه يته سه ر حيسابى كريار وه ك قه رز", "اكادارى",
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

            AllPaymentsbtn.Click += delegate
            {
                ChangeSelectedCustomer?.Invoke(this, EventArgs.Empty);
                loadAllPaymentsOfACustomer?.Invoke(this, EventArgs.Empty);
                paymentTab.TabPages.Remove(AllCustomersTab);
                paymentTab.TabPages.Remove(EditTab);
                paymentTab.TabPages.Add(PaymentsOfCustomerTab);

            };
            EditPaymentBtn.Click += delegate
            {
                updatePayment?.Invoke(this, EventArgs.Empty);
                paymentTab.TabPages.Remove(PaymentsOfCustomerTab);
                paymentTab.TabPages.Add(EditTab);
            };
            returnToPaymentsbtn.Click += delegate
            {
                paymentTab.TabPages.Remove(AllCustomersTab);
                paymentTab.TabPages.Remove(EditTab);
                paymentTab.TabPages.Add(PaymentsOfCustomerTab);
            };
            returnbtn.Click += delegate
            {
                RefreshCustomerGrid?.Invoke(this, EventArgs.Empty);
                paymentTab.TabPages.Remove(PaymentsOfCustomerTab);
                paymentTab.TabPages.Add(AllCustomersTab);
            };
            #endregion



        }
        private bool isSuccessful;
        private static PaymentView instance;
        private string message;

        public event EventHandler loadAllPaymentsOfACustomer;
        public event EventHandler RefreshCustomerGrid;
        public event EventHandler RefreshPaymentGrid;
        public event EventHandler addPayment;
        public event EventHandler removePayment;
        public event EventHandler updatePayment;
        public event EventHandler ChangeSelectedCustomer;
        public event EventHandler saveUpdatePayment;

        public string TabName { get => PaymentsOfCustomerTab.Text; set => PaymentsOfCustomerTab.Text=value; }
        public string LabelName { get => customernamelbl.Text; set => customernamelbl.Text = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful=value; }
        public string Message { get => message; set => message=value; }
        public string MoneyOwed { get => MoneyOwedlbl.Text; set => MoneyOwedlbl.Text=value; }
        public string newPaymentAmmountToAdd { get => PaymentAmountTxt.Text; set => PaymentAmountTxt.Text=value; }
        public string IdEdit { get => IdEdittxt.Text; set => IdEdittxt.Text=value; }
        public string DateEdit { get => Dateedittxt.Text; set => Dateedittxt.Text=value; }
        public string PaymentAmountEdit { get => paymentAmountedittxt.Text; set => paymentAmountedittxt.Text=value; }

        public static PaymentView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PaymentView();
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

        public void setCustomerBindingSource(BindingSource customerList)
        {
            ListOfCustomersGridView.DataSource = customerList;
        }

        public void setPaymentBindingSource(BindingSource paymentList)
        {
            customerPaymentsGridView.DataSource=paymentList;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllPaymentsTab_Click(object sender, EventArgs e)
        {

        }

        private void AllPaymentsbtn_Click(object sender, EventArgs e)
        {

        }

        private void PaymentsOfCustomerTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Paybtn_Click(object sender, EventArgs e)
        {

        }

        private void PaymentView_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
