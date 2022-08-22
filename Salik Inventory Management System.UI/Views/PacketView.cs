using Salik_Inventory_Management_System.UI.Models;
using Salik_Inventory_Management_System.UI.Presenters;
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
        private string updatequafromPrompt;
        private string message;
        private bool isSuccessful;
        BackgroundWorker editBackgroundWorker;
        BackgroundWorker deleteBackgroundWorker;
        BackgroundWorker addBackgroundWorker;
        BackgroundWorker updateQuantityBackgroundWorker;

        //BackgroundWorker editBackgroundWorker;

        public PacketView()
        {
           
            InitializeComponent();
            AssociateAndRaiseEvents();
            PacketTab.TabPages.Remove(addingPacketTab);
            PacketTab.TabPages.Remove(EditPacketTab);

        }
        
        private void AssociateAndRaiseEvents()
        {

            editBackgroundWorker = new BackgroundWorker();
            deleteBackgroundWorker = new BackgroundWorker();
            addBackgroundWorker = new BackgroundWorker();
            updateQuantityBackgroundWorker = new BackgroundWorker();
           


            #region backgroundWorkers
            updateQuantityBackgroundWorker.DoWork += delegate
            {
                UpdateQuantity?.Invoke(this, EventArgs.Empty);
            };
            updateQuantityBackgroundWorker.RunWorkerCompleted += delegate
            {
                if (IsSuccessful == false)
                {
                    addingQuantityBtn.Enabled = true;
                    MessageBox.Show(message);
                }
                else
                {
                    if (string.IsNullOrEmpty(searchtxt.Text))
                    {
                        if (sortByQuantityRadioBtn.Checked == true)
                        {
                            sortByQuantity?.Invoke(this, EventArgs.Empty);

                        }

                        if (sortByPriceRadiotBtn.Checked == true)
                        {
                            sortByPrice?.Invoke(this, EventArgs.Empty);

                        }

                        if (NoSortRadioBtn.Checked == true)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }

                    addingQuantityBtn.Enabled = true;
                    MessageBox.Show(Message);
                }

            };


            editBackgroundWorker.DoWork += delegate {
                saveEditedEvent?.Invoke(this, EventArgs.Empty);
            };

            editBackgroundWorker.RunWorkerCompleted += delegate
            {


                if (IsSuccessful == false)
                {
                    saveBtn.Enabled = true;
                    MessageBox.Show(message);
                }
                else
                {
                    if (string.IsNullOrEmpty(searchtxt.Text))
                    {
                        if (sortByQuantityRadioBtn.Checked == true)
                        {
                            sortByQuantity?.Invoke(this, EventArgs.Empty);

                        }

                        if (sortByPriceRadiotBtn.Checked == true)
                        {
                            sortByPrice?.Invoke(this, EventArgs.Empty);

                        }

                        if (NoSortRadioBtn.Checked == true)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }


                    MessageBox.Show(Message);
                    saveBtn.Enabled = true;
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
                    if (string.IsNullOrEmpty(searchtxt.Text))
                    {
                        if (sortByQuantityRadioBtn.Checked == true)
                        {
                            sortByQuantity?.Invoke(this, EventArgs.Empty);

                        }

                        if (sortByPriceRadiotBtn.Checked == true)
                        {
                            sortByPrice?.Invoke(this, EventArgs.Empty);

                        }

                        if (NoSortRadioBtn.Checked == true)
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
                    addnewpacketbtn.Enabled = true;
                    returnbtnNew.Enabled = true;
                    MessageBox.Show(message);
                }
                else
                {
                    if (string.IsNullOrEmpty(searchtxt.Text))
                    {
                        if (sortByQuantityRadioBtn.Checked == true)
                        {
                            sortByQuantity?.Invoke(this, EventArgs.Empty);

                        }

                        if (sortByPriceRadiotBtn.Checked == true)
                        {
                            sortByPrice?.Invoke(this, EventArgs.Empty);

                        }

                        if (NoSortRadioBtn.Checked == true)
                        {
                            RefreshGrid?.Invoke(this, EventArgs.Empty);

                        }
                    }
                    else
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }

                    MessageBox.Show(Message);
                    addnewpacketbtn.Enabled = true;
                    returnbtnNew.Enabled = true;
                    PacketTab.TabPages.Remove(addingPacketTab);
                    PacketTab.TabPages.Add(PacketHomeTab);
                    cleanNewFormsBoxes.Invoke(this, EventArgs.Empty);
                }





            };



            #endregion




            #region buttons

            sortByPriceRadiotBtn.Click += delegate
            {

                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    if (sortByPriceRadiotBtn.Checked != false)
                    {
                        sortByPrice?.Invoke(this, EventArgs.Empty);
                    }
                    

                }

                searchbtn.Enabled = true;

            };

            sortByQuantityRadioBtn.Click += delegate
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    if (sortByQuantityRadioBtn.Checked != false)
                    {
                        sortByQuantity?.Invoke(this, EventArgs.Empty);
                    }
                   
                }
                searchbtn.Enabled = true;

            };

            NoSortRadioBtn.Click += delegate
            {
                if (string.IsNullOrEmpty(searchtxt.Text))
                {
                    RefreshGrid?.Invoke(this, EventArgs.Empty);

                }
                searchbtn.Enabled = true;

            };
            searchbtn.Enabled = false;
            searchtxt.TextChanged += delegate
            {
                searchbtn.Enabled = true;
            };
            searchbtn.Click += delegate {
                SearchEvent?.Invoke(this,EventArgs.Empty);

                if (IsSuccessful == false)
                {
                    MessageBox.Show(Message);
                }
                searchbtn.Enabled = false;

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

           
            //save for after editing
            saveBtn.Click +=   delegate
            {
                //saveEditedEvent?.Invoke(this, EventArgs.Empty);
                ////await Task.Run(() => saveEditedEvent?.Invoke(this, EventArgs.Empty)).ContinueWith(res => {

                //    RefreshGrid.Invoke(this, EventArgs.Empty);
                //});
                saveBtn.Enabled = false;
               

                editBackgroundWorker.RunWorkerAsync();
             
            };

            addingQuantityBtn.Click += delegate
            {

                string num = Prompt.Prompt.ShowDialog("زيادكردنى زماره ى كارتون", "increasing");
                if(num!= "cancelled" && !string.IsNullOrEmpty(num))
                {
                    addingQuantityBtn.Enabled = false;
                    updateQuantityPrompt = num;


                    updateQuantityBackgroundWorker.RunWorkerAsync();
                }
            };

            deletebtn.Click +=   delegate
            {


                var result = MessageBox.Show("ده ته ويت كالاى دياريكراو ره شكه يته وه", "اكادارى",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    deletebtn.Enabled = false;
                 
                    deleteBackgroundWorker.RunWorkerAsync();

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

         

            addnewpacketbtn.Click +=  delegate
            {
                returnbtnNew.Enabled = false;
                addnewpacketbtn.Enabled = false;
              
                addBackgroundWorker.RunWorkerAsync();

            };
            #endregion




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
        public event EventHandler RefreshGrid;
        public event EventHandler cleanNewFormsBoxes;
        public event EventHandler sortByPrice;
        public event EventHandler sortByQuantity;

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
        public string updateQuantityPrompt { get => updatequafromPrompt; set => updatequafromPrompt=value; }
        public bool byprie { get => sortByPriceRadiotBtn.Checked; }
        public bool byquantity { get => sortByQuantityRadioBtn.Checked;  }
        public bool nosort { get => NoSortRadioBtn.Checked; }

        public void setPacketBindingSource(BindingSource packetList)
        {
            PacketDataGridView.DataSource = packetList;
        }
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

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void editbtn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PacketHomeTab_Click(object sender, EventArgs e)
        {

        }
    }
}
