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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paymentTab = new System.Windows.Forms.TabControl();
            this.AllCustomersTab = new System.Windows.Forms.TabPage();
            this.AllPaymentsbtn = new System.Windows.Forms.Button();
            this.ListOfCustomersGridView = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyOwedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentsOfCustomerTab = new System.Windows.Forms.TabPage();
            this.customerPaymentsGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customernamelbl = new System.Windows.Forms.Label();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTab.SuspendLayout();
            this.AllCustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            this.PaymentsOfCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentTab
            // 
            this.paymentTab.Controls.Add(this.AllCustomersTab);
            this.paymentTab.Controls.Add(this.PaymentsOfCustomerTab);
            this.paymentTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentTab.Location = new System.Drawing.Point(0, 0);
            this.paymentTab.Name = "paymentTab";
            this.paymentTab.SelectedIndex = 0;
            this.paymentTab.Size = new System.Drawing.Size(980, 474);
            this.paymentTab.TabIndex = 0;
            // 
            // AllCustomersTab
            // 
            this.AllCustomersTab.Controls.Add(this.AllPaymentsbtn);
            this.AllCustomersTab.Controls.Add(this.ListOfCustomersGridView);
            this.AllCustomersTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllCustomersTab.Location = new System.Drawing.Point(4, 34);
            this.AllCustomersTab.Name = "AllCustomersTab";
            this.AllCustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllCustomersTab.Size = new System.Drawing.Size(972, 436);
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
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
            // 
            // PaymentsOfCustomerTab
            // 
            this.PaymentsOfCustomerTab.Controls.Add(this.customerPaymentsGridView);
            this.PaymentsOfCustomerTab.Controls.Add(this.customernamelbl);
            this.PaymentsOfCustomerTab.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentsOfCustomerTab.Location = new System.Drawing.Point(4, 34);
            this.PaymentsOfCustomerTab.Name = "PaymentsOfCustomerTab";
            this.PaymentsOfCustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentsOfCustomerTab.Size = new System.Drawing.Size(972, 436);
            this.PaymentsOfCustomerTab.TabIndex = 1;
            this.PaymentsOfCustomerTab.UseVisualStyleBackColor = true;
            this.PaymentsOfCustomerTab.Click += new System.EventHandler(this.PaymentsOfCustomerTab_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerPaymentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerPaymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerPaymentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn});
            this.customerPaymentsGridView.DataSource = this.paymentBindingSource1;
            this.customerPaymentsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customerPaymentsGridView.Location = new System.Drawing.Point(3, 3);
            this.customerPaymentsGridView.Name = "customerPaymentsGridView";
            this.customerPaymentsGridView.ReadOnly = true;
            this.customerPaymentsGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerPaymentsGridView.RowHeadersWidth = 51;
            this.customerPaymentsGridView.RowTemplate.Height = 29;
            this.customerPaymentsGridView.Size = new System.Drawing.Size(379, 430);
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
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.Payment);
            // 
            // customernamelbl
            // 
            this.customernamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customernamelbl.AutoSize = true;
            this.customernamelbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customernamelbl.Location = new System.Drawing.Point(500, 38);
            this.customernamelbl.Name = "customernamelbl";
            this.customernamelbl.Size = new System.Drawing.Size(419, 31);
            this.customernamelbl.TabIndex = 0;
            this.customernamelbl.Text = "customerName hasan sahduch bamarni";
            this.customernamelbl.Click += new System.EventHandler(this.customernamelbl_Click);
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.Payment);
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 474);
            this.Controls.Add(this.paymentTab);
            this.Name = "PaymentView";
            this.Text = "PaymentView";
            this.paymentTab.ResumeLayout(false);
            this.AllCustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            this.PaymentsOfCustomerTab.ResumeLayout(false);
            this.PaymentsOfCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerPaymentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl paymentTab;
        private TabPage AllCustomersTab;
        private TabPage PaymentsOfCustomerTab;
        private DataGridView ListOfCustomersGridView;
        private BindingSource customerModelBindingSource;
        private BindingSource paymentBindingSource;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalMoneyOwedDataGridViewTextBoxColumn;
        private Button AllPaymentsbtn;
        private Label customernamelbl;
        private DataGridView customerPaymentsGridView;
        private BindingSource paymentBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
    }
}