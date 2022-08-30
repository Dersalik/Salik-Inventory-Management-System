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
    public partial class PaymentView : Form,IPaymentView
    {
        public PaymentView()
        {
            InitializeComponent();
            AssociateAndRaiseEvents();
            paymentTab.TabPages.Remove(PaymentsOfCustomerTab);

        }

        private void AssociateAndRaiseEvents()
        {
            #region button
            AllPaymentsbtn.Click += delegate
            {
                loadAllPaymentsOfACustomer?.Invoke(this, EventArgs.Empty);
                paymentTab.TabPages.Remove(AllCustomersTab);
                paymentTab.TabPages.Add(PaymentsOfCustomerTab);

            };
            #endregion

            #region backgroundWorker
            #endregion


        }
        private bool isSuccessful;
        private static PaymentView instance;
        private string message;

        public event EventHandler loadAllPaymentsOfACustomer;

        public string TabName { get => PaymentsOfCustomerTab.Text; set => PaymentsOfCustomerTab.Text=value; }
        public string LabelName { get => customernamelbl.Text; set => customernamelbl.Text = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful=value; }
        public string Message { get => message; set => message=value; }

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
    }
}
