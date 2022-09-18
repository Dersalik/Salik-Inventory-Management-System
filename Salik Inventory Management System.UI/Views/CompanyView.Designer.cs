namespace Salik_Inventory_Management_System.UI.Views
{
    partial class CompanyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyView));
            this.companyPaymentTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentAmountTxt = new System.Windows.Forms.TextBox();
            this.EditPaymentBtn = new System.Windows.Forms.Button();
            this.deletePaymentBtn = new System.Windows.Forms.Button();
            this.Paybtn = new System.Windows.Forms.Button();
            this.returnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MoneyOwedlbl = new System.Windows.Forms.Label();
            this.CompanyPaymentGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyHomeTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InterestMoneylbl = new System.Windows.Forms.Label();
            this.TotalMoneyReceivedFromCustomerslbl = new System.Windows.Forms.Label();
            this.TotalMoneyOwedByCustomerslbl = new System.Windows.Forms.Label();
            this.CompanyPaymentbtn = new System.Windows.Forms.Button();
            this.CompanyTab = new System.Windows.Forms.TabControl();
            this.editPaymentTab = new System.Windows.Forms.TabPage();
            this.returnToPaymentsbtn = new System.Windows.Forms.Button();
            this.saveeditBtn = new System.Windows.Forms.Button();
            this.Dateedittxt = new System.Windows.Forms.TextBox();
            this.paymentAmountedittxt = new System.Windows.Forms.TextBox();
            this.IdEdittxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.companyPaymentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPaymentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPaymentBindingSource)).BeginInit();
            this.companyHomeTab.SuspendLayout();
            this.CompanyTab.SuspendLayout();
            this.editPaymentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyPaymentTab
            // 
            this.companyPaymentTab.Controls.Add(this.label3);
            this.companyPaymentTab.Controls.Add(this.PaymentAmountTxt);
            this.companyPaymentTab.Controls.Add(this.EditPaymentBtn);
            this.companyPaymentTab.Controls.Add(this.deletePaymentBtn);
            this.companyPaymentTab.Controls.Add(this.Paybtn);
            this.companyPaymentTab.Controls.Add(this.returnbtn);
            this.companyPaymentTab.Controls.Add(this.label2);
            this.companyPaymentTab.Controls.Add(this.MoneyOwedlbl);
            this.companyPaymentTab.Controls.Add(this.CompanyPaymentGridView);
            this.companyPaymentTab.Location = new System.Drawing.Point(4, 29);
            this.companyPaymentTab.Name = "companyPaymentTab";
            this.companyPaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyPaymentTab.Size = new System.Drawing.Size(999, 411);
            this.companyPaymentTab.TabIndex = 1;
            this.companyPaymentTab.Text = "باره دانى كؤمبانيا";
            this.companyPaymentTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(879, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "برى باره";
            // 
            // PaymentAmountTxt
            // 
            this.PaymentAmountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentAmountTxt.Location = new System.Drawing.Point(608, 272);
            this.PaymentAmountTxt.Name = "PaymentAmountTxt";
            this.PaymentAmountTxt.PlaceholderText = "برى باره ى دراو بنوسه";
            this.PaymentAmountTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaymentAmountTxt.Size = new System.Drawing.Size(246, 27);
            this.PaymentAmountTxt.TabIndex = 17;
            // 
            // EditPaymentBtn
            // 
            this.EditPaymentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPaymentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditPaymentBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditPaymentBtn.Image")));
            this.EditPaymentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditPaymentBtn.Location = new System.Drawing.Point(671, 116);
            this.EditPaymentBtn.Name = "EditPaymentBtn";
            this.EditPaymentBtn.Size = new System.Drawing.Size(138, 52);
            this.EditPaymentBtn.TabIndex = 16;
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
            this.deletePaymentBtn.Location = new System.Drawing.Point(843, 116);
            this.deletePaymentBtn.Name = "deletePaymentBtn";
            this.deletePaymentBtn.Size = new System.Drawing.Size(148, 52);
            this.deletePaymentBtn.TabIndex = 15;
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
            this.Paybtn.Location = new System.Drawing.Point(866, 318);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(111, 52);
            this.Paybtn.TabIndex = 14;
            this.Paybtn.Text = "باره دان";
            this.Paybtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Paybtn.UseVisualStyleBackColor = true;
            // 
            // returnbtn
            // 
            this.returnbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnbtn.Image = ((System.Drawing.Image)(resources.GetObject("returnbtn.Image")));
            this.returnbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbtn.Location = new System.Drawing.Point(431, 345);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.Size = new System.Drawing.Size(112, 49);
            this.returnbtn.TabIndex = 13;
            this.returnbtn.Text = "كه رانه وه";
            this.returnbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(802, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = ":كؤى قه رز";
            // 
            // MoneyOwedlbl
            // 
            this.MoneyOwedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyOwedlbl.AutoSize = true;
            this.MoneyOwedlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MoneyOwedlbl.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyOwedlbl.Location = new System.Drawing.Point(652, 29);
            this.MoneyOwedlbl.Name = "MoneyOwedlbl";
            this.MoneyOwedlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MoneyOwedlbl.Size = new System.Drawing.Size(157, 28);
            this.MoneyOwedlbl.TabIndex = 11;
            this.MoneyOwedlbl.Text = "MoneyAmount";
            // 
            // CompanyPaymentGridView
            // 
            this.CompanyPaymentGridView.AllowUserToAddRows = false;
            this.CompanyPaymentGridView.AllowUserToDeleteRows = false;
            this.CompanyPaymentGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyPaymentGridView.AutoGenerateColumns = false;
            this.CompanyPaymentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyPaymentGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CompanyPaymentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyPaymentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn});
            this.CompanyPaymentGridView.DataSource = this.companyPaymentBindingSource;
            this.CompanyPaymentGridView.Location = new System.Drawing.Point(3, 3);
            this.CompanyPaymentGridView.Name = "CompanyPaymentGridView";
            this.CompanyPaymentGridView.ReadOnly = true;
            this.CompanyPaymentGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyPaymentGridView.RowHeadersWidth = 51;
            this.CompanyPaymentGridView.RowTemplate.Height = 29;
            this.CompanyPaymentGridView.Size = new System.Drawing.Size(422, 405);
            this.CompanyPaymentGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "برى باره";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "كاتى زيادكردنى باره دان";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyPaymentBindingSource
            // 
            this.companyPaymentBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CompanyPayment);
            // 
            // companyHomeTab
            // 
            this.companyHomeTab.Controls.Add(this.label8);
            this.companyHomeTab.Controls.Add(this.label7);
            this.companyHomeTab.Controls.Add(this.label1);
            this.companyHomeTab.Controls.Add(this.InterestMoneylbl);
            this.companyHomeTab.Controls.Add(this.TotalMoneyReceivedFromCustomerslbl);
            this.companyHomeTab.Controls.Add(this.TotalMoneyOwedByCustomerslbl);
            this.companyHomeTab.Controls.Add(this.CompanyPaymentbtn);
            this.companyHomeTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyHomeTab.Location = new System.Drawing.Point(4, 29);
            this.companyHomeTab.Name = "companyHomeTab";
            this.companyHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyHomeTab.Size = new System.Drawing.Size(999, 411);
            this.companyHomeTab.TabIndex = 0;
            this.companyHomeTab.Text = "كؤمبانيا";
            this.companyHomeTab.UseVisualStyleBackColor = true;
            this.companyHomeTab.Click += new System.EventHandler(this.companyHomeTab_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(881, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "قازانج";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(822, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "كؤى باره ى وه ركيراو";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(826, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "كؤى قه رزى كرياران";
            // 
            // InterestMoneylbl
            // 
            this.InterestMoneylbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InterestMoneylbl.AutoSize = true;
            this.InterestMoneylbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.InterestMoneylbl.Location = new System.Drawing.Point(486, 211);
            this.InterestMoneylbl.Name = "InterestMoneylbl";
            this.InterestMoneylbl.Size = new System.Drawing.Size(160, 28);
            this.InterestMoneylbl.TabIndex = 3;
            this.InterestMoneylbl.Text = "InterestMoneylbl";
            // 
            // TotalMoneyReceivedFromCustomerslbl
            // 
            this.TotalMoneyReceivedFromCustomerslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalMoneyReceivedFromCustomerslbl.AutoSize = true;
            this.TotalMoneyReceivedFromCustomerslbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TotalMoneyReceivedFromCustomerslbl.Location = new System.Drawing.Point(486, 145);
            this.TotalMoneyReceivedFromCustomerslbl.Name = "TotalMoneyReceivedFromCustomerslbl";
            this.TotalMoneyReceivedFromCustomerslbl.Size = new System.Drawing.Size(330, 28);
            this.TotalMoneyReceivedFromCustomerslbl.TabIndex = 2;
            this.TotalMoneyReceivedFromCustomerslbl.Text = "TotalMoneyReceivedFromCustomers";
            // 
            // TotalMoneyOwedByCustomerslbl
            // 
            this.TotalMoneyOwedByCustomerslbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TotalMoneyOwedByCustomerslbl.AutoSize = true;
            this.TotalMoneyOwedByCustomerslbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TotalMoneyOwedByCustomerslbl.Location = new System.Drawing.Point(486, 82);
            this.TotalMoneyOwedByCustomerslbl.Name = "TotalMoneyOwedByCustomerslbl";
            this.TotalMoneyOwedByCustomerslbl.Size = new System.Drawing.Size(279, 28);
            this.TotalMoneyOwedByCustomerslbl.TabIndex = 1;
            this.TotalMoneyOwedByCustomerslbl.Text = "TotalMoneyOwedByCustomers";
            // 
            // CompanyPaymentbtn
            // 
            this.CompanyPaymentbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CompanyPaymentbtn.Image = ((System.Drawing.Image)(resources.GetObject("CompanyPaymentbtn.Image")));
            this.CompanyPaymentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompanyPaymentbtn.Location = new System.Drawing.Point(641, 35);
            this.CompanyPaymentbtn.Name = "CompanyPaymentbtn";
            this.CompanyPaymentbtn.Size = new System.Drawing.Size(192, 44);
            this.CompanyPaymentbtn.TabIndex = 0;
            this.CompanyPaymentbtn.Text = "باره دانى كؤمبانيا";
            this.CompanyPaymentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompanyPaymentbtn.UseVisualStyleBackColor = true;
            // 
            // CompanyTab
            // 
            this.CompanyTab.Controls.Add(this.companyHomeTab);
            this.CompanyTab.Controls.Add(this.companyPaymentTab);
            this.CompanyTab.Controls.Add(this.editPaymentTab);
            this.CompanyTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyTab.Location = new System.Drawing.Point(0, 0);
            this.CompanyTab.Name = "CompanyTab";
            this.CompanyTab.SelectedIndex = 0;
            this.CompanyTab.Size = new System.Drawing.Size(1007, 444);
            this.CompanyTab.TabIndex = 0;
            // 
            // editPaymentTab
            // 
            this.editPaymentTab.Controls.Add(this.returnToPaymentsbtn);
            this.editPaymentTab.Controls.Add(this.saveeditBtn);
            this.editPaymentTab.Controls.Add(this.Dateedittxt);
            this.editPaymentTab.Controls.Add(this.paymentAmountedittxt);
            this.editPaymentTab.Controls.Add(this.IdEdittxt);
            this.editPaymentTab.Controls.Add(this.label6);
            this.editPaymentTab.Controls.Add(this.label5);
            this.editPaymentTab.Controls.Add(this.label4);
            this.editPaymentTab.Location = new System.Drawing.Point(4, 29);
            this.editPaymentTab.Name = "editPaymentTab";
            this.editPaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.editPaymentTab.Size = new System.Drawing.Size(999, 411);
            this.editPaymentTab.TabIndex = 2;
            this.editPaymentTab.Text = "ده ستكارى باره دان";
            this.editPaymentTab.UseVisualStyleBackColor = true;
            // 
            // returnToPaymentsbtn
            // 
            this.returnToPaymentsbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnToPaymentsbtn.Image = ((System.Drawing.Image)(resources.GetObject("returnToPaymentsbtn.Image")));
            this.returnToPaymentsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnToPaymentsbtn.Location = new System.Drawing.Point(145, 287);
            this.returnToPaymentsbtn.Name = "returnToPaymentsbtn";
            this.returnToPaymentsbtn.Size = new System.Drawing.Size(136, 50);
            this.returnToPaymentsbtn.TabIndex = 15;
            this.returnToPaymentsbtn.Text = "كه رانه وه";
            this.returnToPaymentsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnToPaymentsbtn.UseVisualStyleBackColor = true;
            // 
            // saveeditBtn
            // 
            this.saveeditBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveeditBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveeditBtn.Image")));
            this.saveeditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveeditBtn.Location = new System.Drawing.Point(677, 287);
            this.saveeditBtn.Name = "saveeditBtn";
            this.saveeditBtn.Size = new System.Drawing.Size(177, 50);
            this.saveeditBtn.TabIndex = 14;
            this.saveeditBtn.Text = "خه زن كردن";
            this.saveeditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveeditBtn.UseVisualStyleBackColor = true;
            // 
            // Dateedittxt
            // 
            this.Dateedittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dateedittxt.Location = new System.Drawing.Point(256, 142);
            this.Dateedittxt.Name = "Dateedittxt";
            this.Dateedittxt.ReadOnly = true;
            this.Dateedittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dateedittxt.Size = new System.Drawing.Size(275, 27);
            this.Dateedittxt.TabIndex = 13;
            // 
            // paymentAmountedittxt
            // 
            this.paymentAmountedittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentAmountedittxt.Location = new System.Drawing.Point(256, 205);
            this.paymentAmountedittxt.Name = "paymentAmountedittxt";
            this.paymentAmountedittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentAmountedittxt.Size = new System.Drawing.Size(275, 27);
            this.paymentAmountedittxt.TabIndex = 12;
            // 
            // IdEdittxt
            // 
            this.IdEdittxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdEdittxt.Location = new System.Drawing.Point(256, 74);
            this.IdEdittxt.Name = "IdEdittxt";
            this.IdEdittxt.ReadOnly = true;
            this.IdEdittxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IdEdittxt.Size = new System.Drawing.Size(275, 27);
            this.IdEdittxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "برى باره";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "كاتى باره دان";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 444);
            this.Controls.Add(this.CompanyTab);
            this.Name = "CompanyView";
            this.Text = "CompanyView";
            this.companyPaymentTab.ResumeLayout(false);
            this.companyPaymentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPaymentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyPaymentBindingSource)).EndInit();
            this.companyHomeTab.ResumeLayout(false);
            this.companyHomeTab.PerformLayout();
            this.CompanyTab.ResumeLayout(false);
            this.editPaymentTab.ResumeLayout(false);
            this.editPaymentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage companyPaymentTab;
        private DataGridView CompanyPaymentGridView;
        private BindingSource companyPaymentBindingSource;
        private TabPage companyHomeTab;
        private Label InterestMoneylbl;
        private Label TotalMoneyReceivedFromCustomerslbl;
        private Label TotalMoneyOwedByCustomerslbl;
        private Button CompanyPaymentbtn;
        private TabControl CompanyTab;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private Label label3;
        private TextBox PaymentAmountTxt;
        private Button EditPaymentBtn;
        private Button deletePaymentBtn;
        private Button Paybtn;
        private Button returnbtn;
        private Label label2;
        private Label MoneyOwedlbl;
        private TabPage editPaymentTab;
        private Button returnToPaymentsbtn;
        private Button saveeditBtn;
        private TextBox Dateedittxt;
        private TextBox paymentAmountedittxt;
        private TextBox IdEdittxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label1;
    }
}