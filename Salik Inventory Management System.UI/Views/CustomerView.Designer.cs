namespace Salik_Inventory_Management_System.UI.Views
{
    partial class CustomerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            this.CustomerTab = new System.Windows.Forms.TabControl();
            this.CustomerHomeTab = new System.Windows.Forms.TabPage();
            this.noSortradiobtn = new System.Windows.Forms.RadioButton();
            this.sortByMoneyOwedradiobtn = new System.Windows.Forms.RadioButton();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCustomerTab = new System.Windows.Forms.TabPage();
            this.backToHomeFromnewbtn = new System.Windows.Forms.Button();
            this.addNewCustomerBtn = new System.Windows.Forms.Button();
            this.customerDescriptiontxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editCustomerTab = new System.Windows.Forms.TabPage();
            this.IdEdittxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReturnToHomeFromEditbtn = new System.Windows.Forms.Button();
            this.saveEditedBtn = new System.Windows.Forms.Button();
            this.CustomerDesEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerNameEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerTab.SuspendLayout();
            this.CustomerHomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            this.addCustomerTab.SuspendLayout();
            this.editCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.CustomerHomeTab);
            this.CustomerTab.Controls.Add(this.addCustomerTab);
            this.CustomerTab.Controls.Add(this.editCustomerTab);
            this.CustomerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerTab.Location = new System.Drawing.Point(0, 0);
            this.CustomerTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.SelectedIndex = 0;
            this.CustomerTab.Size = new System.Drawing.Size(865, 420);
            this.CustomerTab.TabIndex = 0;
            // 
            // CustomerHomeTab
            // 
            this.CustomerHomeTab.Controls.Add(this.noSortradiobtn);
            this.CustomerHomeTab.Controls.Add(this.sortByMoneyOwedradiobtn);
            this.CustomerHomeTab.Controls.Add(this.searchbtn);
            this.CustomerHomeTab.Controls.Add(this.searchtxt);
            this.CustomerHomeTab.Controls.Add(this.deletebtn);
            this.CustomerHomeTab.Controls.Add(this.editbtn);
            this.CustomerHomeTab.Controls.Add(this.addbtn);
            this.CustomerHomeTab.Controls.Add(this.customerDataGridView);
            this.CustomerHomeTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerHomeTab.Location = new System.Drawing.Point(4, 29);
            this.CustomerHomeTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerHomeTab.Name = "CustomerHomeTab";
            this.CustomerHomeTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerHomeTab.Size = new System.Drawing.Size(857, 387);
            this.CustomerHomeTab.TabIndex = 0;
            this.CustomerHomeTab.Text = "كرياره كان";
            this.CustomerHomeTab.UseVisualStyleBackColor = true;
            // 
            // noSortradiobtn
            // 
            this.noSortradiobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.noSortradiobtn.AutoSize = true;
            this.noSortradiobtn.Checked = true;
            this.noSortradiobtn.Location = new System.Drawing.Point(541, 155);
            this.noSortradiobtn.Name = "noSortradiobtn";
            this.noSortradiobtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noSortradiobtn.Size = new System.Drawing.Size(111, 29);
            this.noSortradiobtn.TabIndex = 19;
            this.noSortradiobtn.TabStop = true;
            this.noSortradiobtn.Text = "ريز نه كراو";
            this.noSortradiobtn.UseVisualStyleBackColor = true;
            this.noSortradiobtn.CheckedChanged += new System.EventHandler(this.noSortradiobtn_CheckedChanged);
            // 
            // sortByMoneyOwedradiobtn
            // 
            this.sortByMoneyOwedradiobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByMoneyOwedradiobtn.AutoSize = true;
            this.sortByMoneyOwedradiobtn.Location = new System.Drawing.Point(658, 155);
            this.sortByMoneyOwedradiobtn.Name = "sortByMoneyOwedradiobtn";
            this.sortByMoneyOwedradiobtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sortByMoneyOwedradiobtn.Size = new System.Drawing.Size(185, 29);
            this.sortByMoneyOwedradiobtn.TabIndex = 18;
            this.sortByMoneyOwedradiobtn.Text = "ريزكردن به بيي قه رز";
            this.sortByMoneyOwedradiobtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchbtn.Enabled = false;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(470, 34);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(122, 44);
            this.searchbtn.TabIndex = 17;
            this.searchbtn.Text = "كه ران";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // searchtxt
            // 
            this.searchtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchtxt.Location = new System.Drawing.Point(223, 43);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PlaceholderText = "نا وى كريار بنوسه";
            this.searchtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchtxt.Size = new System.Drawing.Size(241, 31);
            this.searchtxt.TabIndex = 16;
            // 
            // deletebtn
            // 
            this.deletebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.Location = new System.Drawing.Point(438, 233);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(126, 57);
            this.deletebtn.TabIndex = 14;
            this.deletebtn.Text = "ره شكردنه وه";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editbtn.Image = ((System.Drawing.Image)(resources.GetObject("editbtn.Image")));
            this.editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.Location = new System.Drawing.Point(570, 233);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(130, 57);
            this.editbtn.TabIndex = 13;
            this.editbtn.Text = "ده ست كارى";
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.Location = new System.Drawing.Point(706, 233);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(143, 58);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "زيادكردنى كريار";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.totalMoneyOwedDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerModelBindingSource;
            this.customerDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customerDataGridView.Location = new System.Drawing.Point(4, 297);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 29;
            this.customerDataGridView.Size = new System.Drawing.Size(849, 87);
            this.customerDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ناوى كريار";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMoneyOwedDataGridViewTextBoxColumn
            // 
            this.totalMoneyOwedDataGridViewTextBoxColumn.DataPropertyName = "TotalMoneyOwed";
            this.totalMoneyOwedDataGridViewTextBoxColumn.HeaderText = "كؤى كشتى قه رز";
            this.totalMoneyOwedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMoneyOwedDataGridViewTextBoxColumn.Name = "totalMoneyOwedDataGridViewTextBoxColumn";
            this.totalMoneyOwedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "زانيارى";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
            // 
            // addCustomerTab
            // 
            this.addCustomerTab.Controls.Add(this.backToHomeFromnewbtn);
            this.addCustomerTab.Controls.Add(this.addNewCustomerBtn);
            this.addCustomerTab.Controls.Add(this.customerDescriptiontxt);
            this.addCustomerTab.Controls.Add(this.label2);
            this.addCustomerTab.Controls.Add(this.CustomerNametxt);
            this.addCustomerTab.Controls.Add(this.label1);
            this.addCustomerTab.Location = new System.Drawing.Point(4, 29);
            this.addCustomerTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addCustomerTab.Name = "addCustomerTab";
            this.addCustomerTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addCustomerTab.Size = new System.Drawing.Size(857, 387);
            this.addCustomerTab.TabIndex = 1;
            this.addCustomerTab.Text = "زيادكردنى كريار";
            this.addCustomerTab.UseVisualStyleBackColor = true;
            // 
            // backToHomeFromnewbtn
            // 
            this.backToHomeFromnewbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backToHomeFromnewbtn.Image = ((System.Drawing.Image)(resources.GetObject("backToHomeFromnewbtn.Image")));
            this.backToHomeFromnewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backToHomeFromnewbtn.Location = new System.Drawing.Point(24, 293);
            this.backToHomeFromnewbtn.Name = "backToHomeFromnewbtn";
            this.backToHomeFromnewbtn.Size = new System.Drawing.Size(146, 57);
            this.backToHomeFromnewbtn.TabIndex = 5;
            this.backToHomeFromnewbtn.Text = "كه رانه وه";
            this.backToHomeFromnewbtn.UseVisualStyleBackColor = true;
            // 
            // addNewCustomerBtn
            // 
            this.addNewCustomerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNewCustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addNewCustomerBtn.Image")));
            this.addNewCustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewCustomerBtn.Location = new System.Drawing.Point(665, 293);
            this.addNewCustomerBtn.Name = "addNewCustomerBtn";
            this.addNewCustomerBtn.Size = new System.Drawing.Size(159, 57);
            this.addNewCustomerBtn.TabIndex = 4;
            this.addNewCustomerBtn.Text = "زيادكردنى كريار";
            this.addNewCustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewCustomerBtn.UseVisualStyleBackColor = true;
            // 
            // customerDescriptiontxt
            // 
            this.customerDescriptiontxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customerDescriptiontxt.Location = new System.Drawing.Point(222, 145);
            this.customerDescriptiontxt.Multiline = true;
            this.customerDescriptiontxt.Name = "customerDescriptiontxt";
            this.customerDescriptiontxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerDescriptiontxt.Size = new System.Drawing.Size(355, 85);
            this.customerDescriptiontxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "زانيارى كريار";
            // 
            // CustomerNametxt
            // 
            this.CustomerNametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNametxt.Location = new System.Drawing.Point(277, 96);
            this.CustomerNametxt.Name = "CustomerNametxt";
            this.CustomerNametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNametxt.Size = new System.Drawing.Size(300, 27);
            this.CustomerNametxt.TabIndex = 1;
            this.CustomerNametxt.TextChanged += new System.EventHandler(this.CustomerNametxt_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ناوى كريار";
            // 
            // editCustomerTab
            // 
            this.editCustomerTab.Controls.Add(this.IdEdittxt);
            this.editCustomerTab.Controls.Add(this.label5);
            this.editCustomerTab.Controls.Add(this.ReturnToHomeFromEditbtn);
            this.editCustomerTab.Controls.Add(this.saveEditedBtn);
            this.editCustomerTab.Controls.Add(this.CustomerDesEdit);
            this.editCustomerTab.Controls.Add(this.label3);
            this.editCustomerTab.Controls.Add(this.CustomerNameEdit);
            this.editCustomerTab.Controls.Add(this.label4);
            this.editCustomerTab.Location = new System.Drawing.Point(4, 29);
            this.editCustomerTab.Name = "editCustomerTab";
            this.editCustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.editCustomerTab.Size = new System.Drawing.Size(857, 387);
            this.editCustomerTab.TabIndex = 2;
            this.editCustomerTab.Text = "ده ستكاريكردنى زانيارى كريار";
            this.editCustomerTab.UseVisualStyleBackColor = true;
            this.editCustomerTab.Click += new System.EventHandler(this.editCustomerTab_Click);
            // 
            // IdEdittxt
            // 
            this.IdEdittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdEdittxt.Location = new System.Drawing.Point(456, 19);
            this.IdEdittxt.Name = "IdEdittxt";
            this.IdEdittxt.ReadOnly = true;
            this.IdEdittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IdEdittxt.Size = new System.Drawing.Size(125, 27);
            this.IdEdittxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // ReturnToHomeFromEditbtn
            // 
            this.ReturnToHomeFromEditbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnToHomeFromEditbtn.Image = ((System.Drawing.Image)(resources.GetObject("ReturnToHomeFromEditbtn.Image")));
            this.ReturnToHomeFromEditbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnToHomeFromEditbtn.Location = new System.Drawing.Point(28, 263);
            this.ReturnToHomeFromEditbtn.Name = "ReturnToHomeFromEditbtn";
            this.ReturnToHomeFromEditbtn.Size = new System.Drawing.Size(146, 57);
            this.ReturnToHomeFromEditbtn.TabIndex = 11;
            this.ReturnToHomeFromEditbtn.Text = "كه رانه وه";
            this.ReturnToHomeFromEditbtn.UseVisualStyleBackColor = true;
            // 
            // saveEditedBtn
            // 
            this.saveEditedBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveEditedBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveEditedBtn.Image")));
            this.saveEditedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveEditedBtn.Location = new System.Drawing.Point(705, 263);
            this.saveEditedBtn.Name = "saveEditedBtn";
            this.saveEditedBtn.Size = new System.Drawing.Size(123, 57);
            this.saveEditedBtn.TabIndex = 10;
            this.saveEditedBtn.Text = "خه زن كردن";
            this.saveEditedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveEditedBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerDesEdit
            // 
            this.CustomerDesEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerDesEdit.Location = new System.Drawing.Point(226, 115);
            this.CustomerDesEdit.Multiline = true;
            this.CustomerDesEdit.Name = "CustomerDesEdit";
            this.CustomerDesEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerDesEdit.Size = new System.Drawing.Size(355, 85);
            this.CustomerDesEdit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "زانيارى كريار";
            // 
            // CustomerNameEdit
            // 
            this.CustomerNameEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNameEdit.Location = new System.Drawing.Point(281, 66);
            this.CustomerNameEdit.Name = "CustomerNameEdit";
            this.CustomerNameEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerNameEdit.Size = new System.Drawing.Size(300, 27);
            this.CustomerNameEdit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ناوى كريار";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 420);
            this.Controls.Add(this.CustomerTab);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.CustomerTab.ResumeLayout(false);
            this.CustomerHomeTab.ResumeLayout(false);
            this.CustomerHomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            this.addCustomerTab.ResumeLayout(false);
            this.addCustomerTab.PerformLayout();
            this.editCustomerTab.ResumeLayout(false);
            this.editCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl CustomerTab;
        private TabPage CustomerHomeTab;
        private TabPage addCustomerTab;
        private BindingSource bindingSource1;
        private DataGridView customerDataGridView;
        private Button deletebtn;
        private Button editbtn;
        private Button addbtn;
        private Button searchbtn;
        private TextBox searchtxt;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMoneyOwedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource customerModelBindingSource;
        private Button backToHomeFromnewbtn;
        private Button addNewCustomerBtn;
        private TextBox customerDescriptiontxt;
        private Label label2;
        private TextBox CustomerNametxt;
        private Label label1;
        private TabPage editCustomerTab;
        private Button ReturnToHomeFromEditbtn;
        private Button saveEditedBtn;
        private TextBox CustomerDesEdit;
        private Label label3;
        private TextBox CustomerNameEdit;
        private Label label4;
        private TextBox IdEdittxt;
        private Label label5;
        private RadioButton noSortradiobtn;
        private RadioButton sortByMoneyOwedradiobtn;
    }
}