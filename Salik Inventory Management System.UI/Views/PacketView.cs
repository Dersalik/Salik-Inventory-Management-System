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
        private string message;
        private bool isSuccessful;
        public PacketView()
        {
            
            InitializeComponent();
            AssociateAndRaiseEvents();
            PacketTab.TabPages.Remove(addingPacketTab);
            PacketTab.TabPages.Remove(EditPacketTab);

            
            
            
        }

        private void AssociateAndRaiseEvents()
        {


            
            searchtxt.TextChanged += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);

                if (IsSuccessful==false)
                {
                    MessageBox.Show(Message);
                }
            };

            searchbtn.Click += delegate { SearchEvent?.Invoke(this,EventArgs.Empty);

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

            addbtn.Click += delegate { addEvent?.Invoke(this, EventArgs.Empty);
                PacketTab.TabPages.Remove(PacketHomeTab);
                PacketTab.TabPages.Remove(EditPacketTab);
                PacketTab.TabPages.Add(addingPacketTab);
            };

            editbtn.Click+=delegate { editEvent?.Invoke(this, EventArgs.Empty);
                PacketTab.TabPages.Remove(PacketHomeTab);
                PacketTab.TabPages.Remove(addingPacketTab);
                PacketTab.TabPages.Add(EditPacketTab);
            };

           

            saveBtn.Click +=  async delegate
            {
                saveEditedEvent?.Invoke(this, EventArgs.Empty);
                //await Task.Run(() => saveEditedEvent?.Invoke(this, EventArgs.Empty));
                if (isSuccessful)
                {
                    PacketTab.TabPages.Remove(EditPacketTab);
                    PacketTab.TabPages.Add(PacketHomeTab);
                }
                MessageBox.Show(Message);
            };

            deletebtn.Click +=  async delegate
            {
               
                var result = MessageBox.Show("ده ته ويت كالاى دياريكراو ره شكه يته وه", "اكادارى",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                  
                    //  deleteEvent?.Invoke(this, EventArgs.Empty);
                  
                    Task d=await Task.Run(()=>deleteEvent?.Invoke(this, EventArgs.Empty));
                   
                }

                
            };

            returnbtnNew.Click += delegate
            {
                ReturnToHomeEvent?.Invoke(this, EventArgs.Empty);

                PacketTab.TabPages.Remove(addingPacketTab);
                PacketTab.TabPages.Add(PacketHomeTab);
            };

             returnedit.Click+= delegate
             {
                 ReturnToHomeEvent?.Invoke(this, EventArgs.Empty);

                 PacketTab.TabPages.Remove(EditPacketTab);
                 PacketTab.TabPages.Add(PacketHomeTab);
             };

         

            addnewpacketbtn.Click += async delegate
            {
                //saveNewlyaddedEvent?.Invoke(this, EventArgs.Empty);
                await Task.Run(() => saveNewlyaddedEvent?.Invoke(this, EventArgs.Empty));
                if (isSuccessful)
                {
                    PacketTab.TabPages.Remove(addingPacketTab);
                    PacketTab.TabPages.Add(PacketHomeTab);
                }
               
              
                RefreshGrid.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
                cleanNewFormsBoxes.Invoke(this, EventArgs.Empty);
            };
        }

        private static PacketView instance;

        public event EventHandler SearchEvent;
        public event EventHandler editEvent;
        public event EventHandler deleteEvent;
        public event EventHandler addEvent;
        public event EventHandler UpdateQuantity;
        public event EventHandler SaveEvent;
        public event EventHandler saveEditedEvent;
        public event EventHandler ReturnToHomeEvent;
        public event EventHandler saveNewlyaddedEvent;
        public Task EventHandler RefreshGrid;
        public event EventHandler cleanNewFormsBoxes;

        public string? ItemName { get => nametxt.Text; set => nametxt.Text=value; }
        public string ItemPrice { get => pricetxt.Text; set => pricetxt.Text=value; }
        public string ItemQuantity { get => quantitytxt.Text; set => quantitytxt.Text=value; }
        public string? Description { get => destxt.Text; set => destxt.Text=value; }
        public string searchValue { get => searchtxt.Text; set => searchtxt.Text=value; }
       
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful=value; }
        public string Message { get => message; set => message=value; }

        public string? ItemNameedit { get => editName.Text; set => editName.Text=value; }
        public string ItemPriceedit { get => editPrice.Text; set => editPrice.Text=value; }
        public string ItemQuantityedit { get => editquantity.Text; set => editquantity.Text=value; }
        public string? Descriptionedit { get => editdes.Text; set => editdes.Text=value; }
        public string IdEdit { get => IdPacket.Text; set => IdPacket.Text=value; }

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

        private void PacketView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPacketTab_Click(object sender, EventArgs e)
        {

        }

        public void setPacketBindingSource(BindingSource packetList)
        {
            PacketDataGridView.DataSource= packetList;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
