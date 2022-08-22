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
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            PacketNav.Click += delegate { ShowPacketNav?.Invoke(this, EventArgs.Empty); };
            CustomerNav.Click+=delegate { ShowCustomerNav?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowHome;
        public event EventHandler ShowCustomerNav;
        public event EventHandler ShowPacketNav;
        public event EventHandler ShowOrderNav;
        public event EventHandler ShowPaymentNav;
        public event EventHandler ShowRaportNav;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void navMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PacketNav_Click(object sender, EventArgs e)
        {

        }
    }
}
