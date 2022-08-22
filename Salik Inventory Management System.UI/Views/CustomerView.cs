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
        }

        private static CustomerView instance;

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
    }
}
