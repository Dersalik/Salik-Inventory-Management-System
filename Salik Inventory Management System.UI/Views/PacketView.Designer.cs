namespace Salik_Inventory_Management_System.UI.Views
{
    partial class PacketView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacketView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacketTab = new System.Windows.Forms.TabControl();
            this.PacketHomeTab = new System.Windows.Forms.TabPage();
            this.NoSortRadioBtn = new System.Windows.Forms.RadioButton();
            this.sortByQuantityRadioBtn = new System.Windows.Forms.RadioButton();
            this.sortByPriceRadiotBtn = new System.Windows.Forms.RadioButton();
            this.addingQuantityBtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.PacketDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditPacketTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.ItemPriceBoughtEdittxt = new System.Windows.Forms.TextBox();
            this.IdPacket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.returnedit = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editdes = new System.Windows.Forms.TextBox();
            this.editquantity = new System.Windows.Forms.TextBox();
            this.EditSellingPricetxt = new System.Windows.Forms.TextBox();
            this.editName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addingPacketTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.buyingPricetxt = new System.Windows.Forms.TextBox();
            this.returnbtnNew = new System.Windows.Forms.Button();
            this.addnewpacketbtn = new System.Windows.Forms.Button();
            this.destxt = new System.Windows.Forms.TextBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.sellingPricetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            this.PacketTab.SuspendLayout();
            this.PacketHomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacketDataGridView)).BeginInit();
            this.EditPacketTab.SuspendLayout();
            this.addingPacketTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemModelBindingSource
            // 
            this.itemModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.ItemModel);
            // 
            // PacketTab
            // 
            this.PacketTab.Controls.Add(this.PacketHomeTab);
            this.PacketTab.Controls.Add(this.EditPacketTab);
            this.PacketTab.Controls.Add(this.addingPacketTab);
            this.PacketTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PacketTab.Location = new System.Drawing.Point(0, 0);
            this.PacketTab.Name = "PacketTab";
            this.PacketTab.SelectedIndex = 0;
            this.PacketTab.Size = new System.Drawing.Size(995, 504);
            this.PacketTab.TabIndex = 0;
            // 
            // PacketHomeTab
            // 
            this.PacketHomeTab.Controls.Add(this.NoSortRadioBtn);
            this.PacketHomeTab.Controls.Add(this.sortByQuantityRadioBtn);
            this.PacketHomeTab.Controls.Add(this.sortByPriceRadiotBtn);
            this.PacketHomeTab.Controls.Add(this.addingQuantityBtn);
            this.PacketHomeTab.Controls.Add(this.deletebtn);
            this.PacketHomeTab.Controls.Add(this.editbtn);
            this.PacketHomeTab.Controls.Add(this.addbtn);
            this.PacketHomeTab.Controls.Add(this.searchbtn);
            this.PacketHomeTab.Controls.Add(this.searchtxt);
            this.PacketHomeTab.Controls.Add(this.PacketDataGridView);
            this.PacketHomeTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PacketHomeTab.Location = new System.Drawing.Point(4, 29);
            this.PacketHomeTab.Name = "PacketHomeTab";
            this.PacketHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.PacketHomeTab.Size = new System.Drawing.Size(987, 471);
            this.PacketHomeTab.TabIndex = 0;
            this.PacketHomeTab.Text = "ليستى باكه ته كان";
            this.PacketHomeTab.UseVisualStyleBackColor = true;
            this.PacketHomeTab.Click += new System.EventHandler(this.PacketHomeTab_Click);
            // 
            // NoSortRadioBtn
            // 
            this.NoSortRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoSortRadioBtn.AutoSize = true;
            this.NoSortRadioBtn.Checked = true;
            this.NoSortRadioBtn.Location = new System.Drawing.Point(233, 128);
            this.NoSortRadioBtn.Name = "NoSortRadioBtn";
            this.NoSortRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoSortRadioBtn.Size = new System.Drawing.Size(104, 29);
            this.NoSortRadioBtn.TabIndex = 14;
            this.NoSortRadioBtn.TabStop = true;
            this.NoSortRadioBtn.Text = "ريزنه كراو";
            this.NoSortRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sortByQuantityRadioBtn
            // 
            this.sortByQuantityRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByQuantityRadioBtn.AutoSize = true;
            this.sortByQuantityRadioBtn.Location = new System.Drawing.Point(343, 128);
            this.sortByQuantityRadioBtn.Name = "sortByQuantityRadioBtn";
            this.sortByQuantityRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortByQuantityRadioBtn.Size = new System.Drawing.Size(185, 29);
            this.sortByQuantityRadioBtn.TabIndex = 13;
            this.sortByQuantityRadioBtn.Text = "ريزكردن به بيي زماره";
            this.sortByQuantityRadioBtn.UseVisualStyleBackColor = true;
            // 
            // sortByPriceRadiotBtn
            // 
            this.sortByPriceRadiotBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByPriceRadiotBtn.AutoSize = true;
            this.sortByPriceRadiotBtn.Location = new System.Drawing.Point(524, 128);
            this.sortByPriceRadiotBtn.Name = "sortByPriceRadiotBtn";
            this.sortByPriceRadiotBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortByPriceRadiotBtn.Size = new System.Drawing.Size(175, 29);
            this.sortByPriceRadiotBtn.TabIndex = 12;
            this.sortByPriceRadiotBtn.Text = "ريزكردن به بيي نرخ";
            this.sortByPriceRadiotBtn.UseVisualStyleBackColor = true;
            this.sortByPriceRadiotBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // addingQuantityBtn
            // 
            this.addingQuantityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addingQuantityBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addingQuantityBtn.Image = ((System.Drawing.Image)(resources.GetObject("addingQuantityBtn.Image")));
            this.addingQuantityBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addingQuantityBtn.Location = new System.Drawing.Point(421, 266);
            this.addingQuantityBtn.Name = "addingQuantityBtn";
            this.addingQuantityBtn.Size = new System.Drawing.Size(241, 52);
            this.addingQuantityBtn.TabIndex = 11;
            this.addingQuantityBtn.Text = "زياد كردنى زماره ى باكه ت";
            this.addingQuantityBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addingQuantityBtn.UseVisualStyleBackColor = true;
            this.addingQuantityBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(262, 264);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(141, 54);
            this.deletebtn.TabIndex = 10;
            this.deletebtn.Text = "ره شكردنه وه";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editbtn.Image = ((System.Drawing.Image)(resources.GetObject("editbtn.Image")));
            this.editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.Location = new System.Drawing.Point(683, 266);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(149, 52);
            this.editbtn.TabIndex = 9;
            this.editbtn.Text = "ده ست كارى";
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.Location = new System.Drawing.Point(847, 266);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(129, 52);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "زيادكردن";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(547, 71);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(122, 44);
            this.searchbtn.TabIndex = 7;
            this.searchbtn.Text = "كه ران";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            this.searchtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchtxt.Location = new System.Drawing.Point(300, 80);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PlaceholderText = "نا وى با كه ت بنوسه";
            this.searchtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchtxt.Size = new System.Drawing.Size(241, 31);
            this.searchtxt.TabIndex = 3;
            // 
            // PacketDataGridView
            // 
            this.PacketDataGridView.AllowUserToAddRows = false;
            this.PacketDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PacketDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PacketDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PacketDataGridView.AutoGenerateColumns = false;
            this.PacketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PacketDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PacketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.ItemPriceBought,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.PacketDataGridView.DataSource = this.itemModelBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PacketDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.PacketDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PacketDataGridView.Location = new System.Drawing.Point(3, 336);
            this.PacketDataGridView.MultiSelect = false;
            this.PacketDataGridView.Name = "PacketDataGridView";
            this.PacketDataGridView.ReadOnly = true;
            this.PacketDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PacketDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PacketDataGridView.RowHeadersWidth = 51;
            this.PacketDataGridView.RowTemplate.Height = 29;
            this.PacketDataGridView.Size = new System.Drawing.Size(976, 78);
            this.PacketDataGridView.TabIndex = 2;
            this.PacketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ناوى با كه ت";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemPriceBought
            // 
            this.ItemPriceBought.DataPropertyName = "ItemPriceBought";
            this.ItemPriceBought.HeaderText = "نرخى كرين";
            this.ItemPriceBought.MinimumWidth = 6;
            this.ItemPriceBought.Name = "ItemPriceBought";
            this.ItemPriceBought.ReadOnly = true;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "نرخى فرؤشتن";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "زماره ى باكه ت";
            this.itemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "شيكردنه وه";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EditPacketTab
            // 
            this.EditPacketTab.Controls.Add(this.label10);
            this.EditPacketTab.Controls.Add(this.ItemPriceBoughtEdittxt);
            this.EditPacketTab.Controls.Add(this.IdPacket);
            this.EditPacketTab.Controls.Add(this.label9);
            this.EditPacketTab.Controls.Add(this.returnedit);
            this.EditPacketTab.Controls.Add(this.saveBtn);
            this.EditPacketTab.Controls.Add(this.editdes);
            this.EditPacketTab.Controls.Add(this.editquantity);
            this.EditPacketTab.Controls.Add(this.EditSellingPricetxt);
            this.EditPacketTab.Controls.Add(this.editName);
            this.EditPacketTab.Controls.Add(this.label5);
            this.EditPacketTab.Controls.Add(this.label6);
            this.EditPacketTab.Controls.Add(this.label7);
            this.EditPacketTab.Controls.Add(this.label8);
            this.EditPacketTab.Location = new System.Drawing.Point(4, 29);
            this.EditPacketTab.Name = "EditPacketTab";
            this.EditPacketTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditPacketTab.Size = new System.Drawing.Size(987, 471);
            this.EditPacketTab.TabIndex = 1;
            this.EditPacketTab.Text = "زانيارى با كه ت";
            this.EditPacketTab.UseVisualStyleBackColor = true;
            this.EditPacketTab.Click += new System.EventHandler(this.EditPacketTab_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(593, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "نرخى كرين";
            // 
            // ItemPriceBoughtEdittxt
            // 
            this.ItemPriceBoughtEdittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemPriceBoughtEdittxt.Location = new System.Drawing.Point(321, 129);
            this.ItemPriceBoughtEdittxt.Name = "ItemPriceBoughtEdittxt";
            this.ItemPriceBoughtEdittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemPriceBoughtEdittxt.Size = new System.Drawing.Size(239, 27);
            this.ItemPriceBoughtEdittxt.TabIndex = 22;
            this.ItemPriceBoughtEdittxt.TextChanged += new System.EventHandler(this.ItemPriceBoughttxt_TextChanged);
            // 
            // IdPacket
            // 
            this.IdPacket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdPacket.Location = new System.Drawing.Point(321, 28);
            this.IdPacket.Name = "IdPacket";
            this.IdPacket.ReadOnly = true;
            this.IdPacket.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IdPacket.Size = new System.Drawing.Size(239, 27);
            this.IdPacket.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Id";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // returnedit
            // 
            this.returnedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnedit.BackgroundImage")));
            this.returnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnedit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnedit.Location = new System.Drawing.Point(88, 352);
            this.returnedit.Name = "returnedit";
            this.returnedit.Size = new System.Drawing.Size(137, 46);
            this.returnedit.TabIndex = 19;
            this.returnedit.Text = "كه رانه وه";
            this.returnedit.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.Location = new System.Drawing.Point(728, 352);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(119, 46);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "خه زن كردن";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // editdes
            // 
            this.editdes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editdes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editdes.Location = new System.Drawing.Point(234, 256);
            this.editdes.Multiline = true;
            this.editdes.Name = "editdes";
            this.editdes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editdes.Size = new System.Drawing.Size(326, 90);
            this.editdes.TabIndex = 17;
            // 
            // editquantity
            // 
            this.editquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editquantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editquantity.Location = new System.Drawing.Point(321, 218);
            this.editquantity.Name = "editquantity";
            this.editquantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editquantity.Size = new System.Drawing.Size(239, 32);
            this.editquantity.TabIndex = 16;
            // 
            // EditSellingPricetxt
            // 
            this.EditSellingPricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditSellingPricetxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditSellingPricetxt.Location = new System.Drawing.Point(321, 171);
            this.EditSellingPricetxt.Name = "EditSellingPricetxt";
            this.EditSellingPricetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EditSellingPricetxt.Size = new System.Drawing.Size(239, 32);
            this.EditSellingPricetxt.TabIndex = 15;
            // 
            // editName
            // 
            this.editName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editName.Location = new System.Drawing.Point(321, 72);
            this.editName.Name = "editName";
            this.editName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.editName.Size = new System.Drawing.Size(239, 32);
            this.editName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(593, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "شيكردنه وه";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(593, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "زماره";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(593, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "نرخى فرؤشتن";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(593, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "ناوى با كه ت";
            // 
            // addingPacketTab
            // 
            this.addingPacketTab.Controls.Add(this.label11);
            this.addingPacketTab.Controls.Add(this.buyingPricetxt);
            this.addingPacketTab.Controls.Add(this.returnbtnNew);
            this.addingPacketTab.Controls.Add(this.addnewpacketbtn);
            this.addingPacketTab.Controls.Add(this.destxt);
            this.addingPacketTab.Controls.Add(this.quantitytxt);
            this.addingPacketTab.Controls.Add(this.sellingPricetxt);
            this.addingPacketTab.Controls.Add(this.nametxt);
            this.addingPacketTab.Controls.Add(this.label4);
            this.addingPacketTab.Controls.Add(this.label3);
            this.addingPacketTab.Controls.Add(this.label2);
            this.addingPacketTab.Controls.Add(this.label1);
            this.addingPacketTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addingPacketTab.Location = new System.Drawing.Point(4, 29);
            this.addingPacketTab.Name = "addingPacketTab";
            this.addingPacketTab.Padding = new System.Windows.Forms.Padding(3);
            this.addingPacketTab.Size = new System.Drawing.Size(987, 471);
            this.addingPacketTab.TabIndex = 3;
            this.addingPacketTab.Text = "زياد كردنى باكه ت";
            this.addingPacketTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(561, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "نرخى كرين";
            // 
            // buyingPricetxt
            // 
            this.buyingPricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buyingPricetxt.Location = new System.Drawing.Point(255, 71);
            this.buyingPricetxt.Name = "buyingPricetxt";
            this.buyingPricetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buyingPricetxt.Size = new System.Drawing.Size(239, 31);
            this.buyingPricetxt.TabIndex = 24;
            // 
            // returnbtnNew
            // 
            this.returnbtnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnbtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnbtnNew.BackgroundImage")));
            this.returnbtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnbtnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnbtnNew.Location = new System.Drawing.Point(32, 332);
            this.returnbtnNew.Name = "returnbtnNew";
            this.returnbtnNew.Size = new System.Drawing.Size(137, 46);
            this.returnbtnNew.TabIndex = 9;
            this.returnbtnNew.Text = "كه رانه وه";
            this.returnbtnNew.UseVisualStyleBackColor = true;
            this.returnbtnNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // addnewpacketbtn
            // 
            this.addnewpacketbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addnewpacketbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addnewpacketbtn.BackgroundImage")));
            this.addnewpacketbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addnewpacketbtn.Location = new System.Drawing.Point(672, 332);
            this.addnewpacketbtn.Name = "addnewpacketbtn";
            this.addnewpacketbtn.Size = new System.Drawing.Size(119, 54);
            this.addnewpacketbtn.TabIndex = 8;
            this.addnewpacketbtn.Text = "زيادكردن";
            this.addnewpacketbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addnewpacketbtn.UseVisualStyleBackColor = true;
            // 
            // destxt
            // 
            this.destxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.destxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.destxt.Location = new System.Drawing.Point(201, 208);
            this.destxt.Multiline = true;
            this.destxt.Name = "destxt";
            this.destxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.destxt.Size = new System.Drawing.Size(326, 90);
            this.destxt.TabIndex = 7;
            this.destxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // quantitytxt
            // 
            this.quantitytxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantitytxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantitytxt.Location = new System.Drawing.Point(255, 158);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantitytxt.Size = new System.Drawing.Size(239, 32);
            this.quantitytxt.TabIndex = 6;
            // 
            // sellingPricetxt
            // 
            this.sellingPricetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sellingPricetxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellingPricetxt.Location = new System.Drawing.Point(255, 111);
            this.sellingPricetxt.Name = "sellingPricetxt";
            this.sellingPricetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sellingPricetxt.Size = new System.Drawing.Size(239, 32);
            this.sellingPricetxt.TabIndex = 5;
            // 
            // nametxt
            // 
            this.nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametxt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametxt.Location = new System.Drawing.Point(255, 22);
            this.nametxt.Name = "nametxt";
            this.nametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nametxt.Size = new System.Drawing.Size(239, 32);
            this.nametxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(561, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "شيكردنه وه";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(561, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "زماره";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(561, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "نرخى فرؤشتن";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(561, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ناوى با كه ت";
            // 
            // PacketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 504);
            this.Controls.Add(this.PacketTab);
            this.Name = "PacketView";
            this.Text = "PacketView";
            this.Load += new System.EventHandler(this.PacketView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            this.PacketTab.ResumeLayout(false);
            this.PacketHomeTab.ResumeLayout(false);
            this.PacketHomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacketDataGridView)).EndInit();
            this.EditPacketTab.ResumeLayout(false);
            this.EditPacketTab.PerformLayout();
            this.addingPacketTab.ResumeLayout(false);
            this.addingPacketTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource itemModelBindingSource;
        private TabControl PacketTab;
        private TabPage PacketHomeTab;
        private TabPage EditPacketTab;
        private DataGridView PacketDataGridView;
        private Button searchbtn;
        private TextBox searchtxt;
        private TabPage addingPacketTab;
        private Button addingQuantityBtn;
        private Button deletebtn;
        private Button editbtn;
        private Button addbtn;
        private Button returnbtnNew;
        private Button addnewpacketbtn;
        private TextBox destxt;
        private TextBox quantitytxt;
        private TextBox sellingPricetxt;
        private TextBox nametxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button returnedit;
        private Button saveBtn;
        private TextBox editdes;
        private TextBox editquantity;
        private TextBox EditSellingPricetxt;
        private TextBox editName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox IdPacket;
        private Label label9;
        private RadioButton sortByQuantityRadioBtn;
        private RadioButton sortByPriceRadiotBtn;
        private RadioButton NoSortRadioBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ItemPriceBought;
        private DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private Label label10;
        private TextBox ItemPriceBoughtEdittxt;
        private Label label11;
        private TextBox buyingPricetxt;
    }
}