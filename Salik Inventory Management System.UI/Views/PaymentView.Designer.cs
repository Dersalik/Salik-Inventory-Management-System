namespace Salik_Inventory_Management_System.UI.Views
{
    partial class PaymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditTab = new System.Windows.Forms.TabPage();
            this.returnToPaymentsbtn = new System.Windows.Forms.Button();
            this.saveeditBtn = new System.Windows.Forms.Button();
            this.Dateedittxt = new System.Windows.Forms.TextBox();
            this.paymentAmountedittxt = new System.Windows.Forms.TextBox();
            this.IdEdittxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PaymentsOfCustomerTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentAmountTxt = new System.Windows.Forms.TextBox();
            this.EditPaymentBtn = new System.Windows.Forms.Button();
            this.deletePaymentBtn = new System.Windows.Forms.Button();
            this.Paybtn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoneyOwedlbl = new System.Windows.Forms.Label();
            this.customerPaymentsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernamelbl = new System.Windows.Forms.Label();
            this.AllCustomersTab = new System.Windows.Forms.TabPage();
            this.AllPaymentsbtn = new System.Windows.Forms.Button();
            this.ListOfCustomersGridView = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTab = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.EditTab.SuspendLayout();
            this.PaymentsOfCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsGridView)).BeginInit();
            this.AllCustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomersGridView)).BeginInit();
            this.paymentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.Payment);
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.Payment);
            // 
            // EditTab
            // 
            this.EditTab.Controls.Add(this.returnToPaymentsbtn);
            this.EditTab.Controls.Add(this.saveeditBtn);
            this.EditTab.Controls.Add(this.Dateedittxt);
            this.EditTab.Controls.Add(this.paymentAmountedittxt);
            this.EditTab.Controls.Add(this.IdEdittxt);
            this.EditTab.Controls.Add(this.label6);
            this.EditTab.Controls.Add(this.label5);
            this.EditTab.Controls.Add(this.label4);
            this.EditTab.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditTab.Location = new System.Drawing.Point(4, 34);
            this.EditTab.Name = "EditTab";
            this.EditTab.Padding = new System.Windows.Forms.Padding(3);
            this.EditTab.Size = new System.Drawing.Size(1023, 469);
            this.EditTab.TabIndex = 2;
            this.EditTab.Text = "ده ستكارى باره دان";
            this.EditTab.UseVisualStyleBackColor = true;
            // 
            // returnToPaymentsbtn
            // 
            this.returnToPaymentsbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnToPaymentsbtn.Image = ((System.Drawing.Image)(resources.GetObject("returnToPaymentsbtn.Image")));
            this.returnToPaymentsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnToPaymentsbtn.Location = new System.Drawing.Point(171, 326);
            this.returnToPaymentsbtn.Name = "returnToPaymentsbtn";
            this.returnToPaymentsbtn.Size = new System.Drawing.Size(136, 50);
            this.returnToPaymentsbtn.TabIndex = 7;
            this.returnToPaymentsbtn.Text = "كه رانه وه";
            this.returnToPaymentsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnToPaymentsbtn.UseVisualStyleBackColor = true;
            // 
            // saveeditBtn
            // 
            this.saveeditBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveeditBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveeditBtn.Image")));
            this.saveeditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveeditBtn.Location = new System.Drawing.Point(703, 326);
            this.saveeditBtn.Name = "saveeditBtn";
            this.saveeditBtn.Size = new System.Drawing.Size(177, 50);
            this.saveeditBtn.TabIndex = 6;
            this.saveeditBtn.Text = "خه زن كردن";
            this.saveeditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveeditBtn.UseVisualStyleBackColor = true;
            // 
            // Dateedittxt
            // 
            this.Dateedittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dateedittxt.Location = new System.Drawing.Point(282, 181);
            this.Dateedittxt.Name = "Dateedittxt";
            this.Dateedittxt.ReadOnly = true;
            this.Dateedittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dateedittxt.Size = new System.Drawing.Size(275, 38);
            this.Dateedittxt.TabIndex = 5;
            this.Dateedittxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // paymentAmountedittxt
            // 
            this.paymentAmountedittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentAmountedittxt.Location = new System.Drawing.Point(282, 244);
            this.paymentAmountedittxt.Name = "paymentAmountedittxt";
            this.paymentAmountedittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentAmountedittxt.Size = new System.Drawing.Size(275, 38);
            this.paymentAmountedittxt.TabIndex = 4;
            // 
            // IdEdittxt
            // 
            this.IdEdittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdEdittxt.Location = new System.Drawing.Point(282, 113);
            this.IdEdittxt.Name = "IdEdittxt";
            this.IdEdittxt.ReadOnly = true;
            this.IdEdittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IdEdittxt.Size = new System.Drawing.Size(275, 38);
            this.IdEdittxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "برى باره";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "كاتى باره دان";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // PaymentsOfCustomerTab
            // 
            this.PaymentsOfCustomerTab.Controls.Add(this.label3);
            this.PaymentsOfCustomerTab.Controls.Add(this.PaymentAmountTxt);
            this.PaymentsOfCustomerTab.Controls.Add(this.EditPaymentBtn);
            this.PaymentsOfCustomerTab.Controls.Add(this.deletePaymentBtn);
            this.PaymentsOfCustomerTab.Controls.Add(this.Paybtn);
            this.PaymentsOfCustomerTab.Controls.Add(this.returnbtn);
            this.PaymentsOfCustomerTab.Controls.Add(this.label2);
            this.PaymentsOfCustomerTab.Controls.Add(this.label1);
            this.PaymentsOfCustomerTab.Controls.Add(this.MoneyOwedlbl);
            this.PaymentsOfCustomerTab.Controls.Add(this.customerPaymentsGridView);
            this.PaymentsOfCustomerTab.Controls.Add(this.customernamelbl);
            this.PaymentsOfCustomerTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentsOfCustomerTab.Location = new System.Drawing.Point(4, 34);
            this.PaymentsOfCustomerTab.Name = "PaymentsOfCustomerTab";
            this.PaymentsOfCustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsOfCustomerTab.Size = new System.Drawing.Size(1023, 469);
            this.PaymentsOfCustomerTab.TabIndex = 1;
            this.PaymentsOfCustomerTab.UseVisualStyleBackColor = true;
            this.PaymentsOfCustomerTab.Click += new System.EventHandler(this.PaymentsOfCustomerTab_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(903, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "برى باره";
            // 
            // PaymentAmountTxt
            // 
            this.PaymentAmountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentAmountTxt.Location = new System.Drawing.Point(632, 339);
            this.PaymentAmountTxt.Name = "PaymentAmountTxt";
            this.PaymentAmountTxt.PlaceholderText = "برى باره ى دراو بنوسه";
            this.PaymentAmountTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaymentAmountTxt.Size = new System.Drawing.Size(246, 31);
            this.PaymentAmountTxt.TabIndex = 9;
            // 
            // EditPaymentBtn
            // 
            this.EditPaymentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPaymentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditPaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditPaymentBtn.Image")));
            this.EditPaymentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditPaymentBtn.Location = new System.Drawing.Point(695, 183);
            this.EditPaymentBtn.Name = "EditPaymentBtn";
            this.EditPaymentBtn.Size = new System.Drawing.Size(138, 52);
            this.EditPaymentBtn.TabIndex = 8;
            this.EditPaymentBtn.Text = "ده ستكارى";
            this.EditPaymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditPaymentBtn.UseVisualStyleBackColor = true;
            // 
            // deletePaymentBtn
            // 
            this.deletePaymentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePaymentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletePaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("deletePaymentBtn.Image")));
            this.deletePaymentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletePaymentBtn.Location = new System.Drawing.Point(867, 183);
            this.deletePaymentBtn.Name = "deletePaymentBtn";
            this.deletePaymentBtn.Size = new System.Drawing.Size(148, 52);
            this.deletePaymentBtn.TabIndex = 7;
            this.deletePaymentBtn.Text = "ره شكردنه وه";
            this.deletePaymentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletePaymentBtn.UseVisualStyleBackColor = true;
            // 
            // Paybtn
            // 
            this.Paybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Paybtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Paybtn.Image = ((System.Drawing.Image)(resources.GetObject("Paybtn.Image")));
            this.Paybtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paybtn.Location = new System.Drawing.Point(890, 385);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(111, 52);
            this.Paybtn.TabIndex = 6;
            this.Paybtn.Text = "باره دان";
            this.Paybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Paybtn.UseVisualStyleBackColor = true;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnbtn.Image = ((System.Drawing.Image)(resources.GetObject("returnbtn.Image")));
            this.returnbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbtn.Location = new System.Drawing.Point(455, 412);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(112, 49);
            this.returnbtn.TabIndex = 5;
            this.returnbtn.Text = "كه رانه وه";
            this.returnbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(826, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = ":كؤى قه رز";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(826, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = ":ناوى كريار";
            // 
            // MoneyOwedlbl
            // 
            this.MoneyOwedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyOwedlbl.AutoSize = true;
            this.MoneyOwedlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoneyOwedlbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyOwedlbl.Location = new System.Drawing.Point(676, 96);
            this.MoneyOwedlbl.Name = "MoneyOwedlbl";
            this.MoneyOwedlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MoneyOwedlbl.Size = new System.Drawing.Size(157, 28);
            this.MoneyOwedlbl.TabIndex = 2;
            this.MoneyOwedlbl.Text = "MoneyAmount";
            // 
            // customerPaymentsGridView
            // 
            this.customerPaymentsGridView.AllowUserToAddRows = false;
            this.customerPaymentsGridView.AllowUserToDeleteRows = false;
            this.customerPaymentsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerPaymentsGridView.AutoGenerateColumns = false;
            this.customerPaymentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerPaymentsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerPaymentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerPaymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerPaymentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn});
            this.customerPaymentsGridView.DataSource = this.paymentBindingSource1;
            this.customerPaymentsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerPaymentsGridView.Location = new System.Drawing.Point(3, 3);
            this.customerPaymentsGridView.MultiSelect = false;
            this.customerPaymentsGridView.Name = "customerPaymentsGridView";
            this.customerPaymentsGridView.ReadOnly = true;
            this.customerPaymentsGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerPaymentsGridView.RowHeadersWidth = 51;
            this.customerPaymentsGridView.RowTemplate.Height = 29;
            this.customerPaymentsGridView.Size = new System.Drawing.Size(430, 463);
            this.customerPaymentsGridView.TabIndex = 1;
            this.customerPaymentsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "كاتى داخل كردنى باره دان";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "PaymentAmount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "برى باره ى دراو";
            this.paymentAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            this.paymentAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customernamelbl
            // 
            this.customernamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customernamelbl.AutoSize = true;
            this.customernamelbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customernamelbl.Location = new System.Drawing.Point(632, 22);
            this.customernamelbl.Name = "customernamelbl";
            this.customernamelbl.Size = new System.Drawing.Size(173, 28);
            this.customernamelbl.TabIndex = 0;
            this.customernamelbl.Text = "Customer Name";
            this.customernamelbl.Click += new System.EventHandler(this.customernamelbl_Click);
            // 
            // AllCustomersTab
            // 
            this.AllCustomersTab.Controls.Add(this.AllPaymentsbtn);
            this.AllCustomersTab.Controls.Add(this.ListOfCustomersGridView);
            this.AllCustomersTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllCustomersTab.Location = new System.Drawing.Point(4, 34);
            this.AllCustomersTab.Name = "AllCustomersTab";
            this.AllCustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllCustomersTab.Size = new System.Drawing.Size(1023, 469);
            this.AllCustomersTab.TabIndex = 0;
            this.AllCustomersTab.Text = "باره دان";
            this.AllCustomersTab.UseVisualStyleBackColor = true;
            this.AllCustomersTab.Click += new System.EventHandler(this.AllPaymentsTab_Click);
            // 
            // AllPaymentsbtn
            // 
            this.AllPaymentsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPaymentsbtn.Image = ((System.Drawing.Image)(resources.GetObject("AllPaymentsbtn.Image")));
            this.AllPaymentsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllPaymentsbtn.Location = new System.Drawing.Point(752, 43);
            this.AllPaymentsbtn.Name = "AllPaymentsbtn";
            this.AllPaymentsbtn.Size = new System.Drawing.Size(199, 48);
            this.AllPaymentsbtn.TabIndex = 1;
            this.AllPaymentsbtn.Text = "هه مو باره دانه كان";
            this.AllPaymentsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllPaymentsbtn.UseVisualStyleBackColor = true;
            this.AllPaymentsbtn.Click += new System.EventHandler(this.AllPaymentsbtn_Click);
            // 
            // ListOfCustomersGridView
            // 
            this.ListOfCustomersGridView.AllowUserToAddRows = false;
            this.ListOfCustomersGridView.AllowUserToDeleteRows = false;
            this.ListOfCustomersGridView.AllowUserToOrderColumns = true;
            this.ListOfCustomersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfCustomersGridView.AutoGenerateColumns = false;
            this.ListOfCustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListOfCustomersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListOfCustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfCustomersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.totalMoneyOwedDataGridViewTextBoxColumn});
            this.ListOfCustomersGridView.DataSource = this.customerModelBindingSource;
            this.ListOfCustomersGridView.Location = new System.Drawing.Point(3, 119);
            this.ListOfCustomersGridView.MultiSelect = false;
            this.ListOfCustomersGridView.Name = "ListOfCustomersGridView";
            this.ListOfCustomersGridView.ReadOnly = true;
            this.ListOfCustomersGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListOfCustomersGridView.RowHeadersWidth = 51;
            this.ListOfCustomersGridView.RowTemplate.Height = 29;
            this.ListOfCustomersGridView.Size = new System.Drawing.Size(966, 314);
            this.ListOfCustomersGridView.TabIndex = 0;
            this.ListOfCustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ناوى كريار";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalMoneyOwedDataGridViewTextBoxColumn
            // 
            this.totalMoneyOwedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalMoneyOwedDataGridViewTextBoxColumn.DataPropertyName = "TotalMoneyOwed";
            this.totalMoneyOwedDataGridViewTextBoxColumn.HeaderText = "كوى كشتى قه رز";
            this.totalMoneyOwedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMoneyOwedDataGridViewTextBoxColumn.Name = "totalMoneyOwedDataGridViewTextBoxColumn";
            this.totalMoneyOwedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTab
            // 
            this.paymentTab.Controls.Add(this.AllCustomersTab);
            this.paymentTab.Controls.Add(this.PaymentsOfCustomerTab);
            this.paymentTab.Controls.Add(this.EditTab);
            this.paymentTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentTab.Location = new System.Drawing.Point(0, 0);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.SelectedIndex = 0;
            this.paymentTab.Size = new System.Drawing.Size(1031, 507);
            this.paymentTab.TabIndex = 0;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 507);
            this.Controls.Add(this.paymentTab);
            this.Name = "PaymentView";
            this.Text = "PaymentView";
            this.Load += new System.EventHandler(this.PaymentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.EditTab.ResumeLayout(false);
            this.EditTab.PerformLayout();
            this.PaymentsOfCustomerTab.ResumeLayout(false);
            this.PaymentsOfCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsGridView)).EndInit();
            this.AllCustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomersGridView)).EndInit();
            this.paymentTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource customerModelBindingSource;
        private BindingSource paymentBindingSource;
        private BindingSource paymentBindingSource1;
        private TabPage EditTab;
        private TabPage PaymentsOfCustomerTab;
        private Label label3;
        private TextBox PaymentAmountTxt;
        private Button EditPaymentBtn;
        private Button deletePaymentBtn;
        private Button Paybtn;
        private Button returnbtn;
        private Label label2;
        private Label label1;
        private Label MoneyOwedlbl;
        private DataGridView customerPaymentsGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private Label customernamelbl;
        private TabPage AllCustomersTab;
        private Button AllPaymentsbtn;
        private DataGridView ListOfCustomersGridView;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMoneyOwedDataGridViewTextBoxColumn;
        private TabControl paymentTab;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Dateedittxt;
        private TextBox paymentAmountedittxt;
        private TextBox IdEdittxt;
        private Button returnToPaymentsbtn;
        private Button saveeditBtn;
    }
}