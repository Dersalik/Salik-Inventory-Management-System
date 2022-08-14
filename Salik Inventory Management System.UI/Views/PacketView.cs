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
    public partial class PacketView : Form,IPacketView
    {
        public PacketView()
        {
            InitializeComponent();
        }

        private static PacketView instance;
        public static PacketView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PacketView();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
