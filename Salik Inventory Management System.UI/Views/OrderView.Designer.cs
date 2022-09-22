namespace Salik_Inventory_Management_System.UI.Views
{
    partial class OrderView
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
            this.OrderTab = new System.Windows.Forms.TabControl();
            this.OrerHomeTab = new System.Windows.Forms.TabPage();
            this.orderModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllOrdersTab = new System.Windows.Forms.TabPage();
            this.customerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.allOrdersBtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.ordersdatagridView = new System.Windows.Forms.DataGridView();
            this.customerModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerModelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderTab.SuspendLayout();
            this.OrerHomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).BeginInit();
            this.AllOrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersdatagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.OrerHomeTab);
            this.OrderTab.Controls.Add(this.AllOrdersTab);
            this.OrderTab.Controls.Add(this.tabPage1);
            this.OrderTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderTab.Location = new System.Drawing.Point(0, 0);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.SelectedIndex = 0;
            this.OrderTab.Size = new System.Drawing.Size(990, 487);
            this.OrderTab.TabIndex = 0;
            // 
            // OrerHomeTab
            // 
            this.OrerHomeTab.Controls.Add(this.searchbtn);
            this.OrerHomeTab.Controls.Add(this.allOrdersBtn);
            this.OrerHomeTab.Controls.Add(this.searchtxt);
            this.OrerHomeTab.Controls.Add(this.customerDataGridView);
            this.OrerHomeTab.Location = new System.Drawing.Point(4, 29);
            this.OrerHomeTab.Name = "OrerHomeTab";
            this.OrerHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrerHomeTab.Size = new System.Drawing.Size(982, 454);
            this.OrerHomeTab.TabIndex = 0;
            this.OrerHomeTab.Text = "Home";
            this.OrerHomeTab.UseVisualStyleBackColor = true;
            // 
            // orderModelBindingSource
            // 
            this.orderModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.OrderModel);
            // 
            // AllOrdersTab
            // 
            this.AllOrdersTab.Controls.Add(this.button1);
            this.AllOrdersTab.Controls.Add(this.ordersdatagridView);
            this.AllOrdersTab.Location = new System.Drawing.Point(4, 29);
            this.AllOrdersTab.Name = "AllOrdersTab";
            this.AllOrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllOrdersTab.Size = new System.Drawing.Size(982, 454);
            this.AllOrdersTab.TabIndex = 1;
            this.AllOrdersTab.Text = "allOrders";
            this.AllOrdersTab.UseVisualStyleBackColor = true;
            // 
            // customerModelBindingSource
            // 
            this.customerModelBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
            // 
            // customerModelBindingSource1
            // 
            this.customerModelBindingSource1.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
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
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerModelBindingSource2;
            this.customerDataGridView.Location = new System.Drawing.Point(8, 204);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 29;
            this.customerDataGridView.Size = new System.Drawing.Size(968, 242);
            this.customerDataGridView.TabIndex = 1;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(287, 60);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(227, 27);
            this.searchtxt.TabIndex = 2;
            // 
            // allOrdersBtn
            // 
            this.allOrdersBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allOrdersBtn.Location = new System.Drawing.Point(790, 60);
            this.allOrdersBtn.Name = "allOrdersBtn";
            this.allOrdersBtn.Size = new System.Drawing.Size(94, 29);
            this.allOrdersBtn.TabIndex = 3;
            this.allOrdersBtn.Text = "all Orders";
            this.allOrdersBtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(553, 58);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(94, 29);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // ordersdatagridView
            // 
            this.ordersdatagridView.AllowUserToAddRows = false;
            this.ordersdatagridView.AllowUserToDeleteRows = false;
            this.ordersdatagridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersdatagridView.AutoGenerateColumns = false;
            this.ordersdatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersdatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersdatagridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerModelDataGridViewTextBoxColumn,
            this.customerModelIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.totalPaymentAmountDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.ordersdatagridView.DataSource = this.orderModelBindingSource1;
            this.ordersdatagridView.Location = new System.Drawing.Point(8, 6);
            this.ordersdatagridView.Name = "ordersdatagridView";
            this.ordersdatagridView.ReadOnly = true;
            this.ordersdatagridView.RowHeadersWidth = 51;
            this.ordersdatagridView.RowTemplate.Height = 29;
            this.ordersdatagridView.Size = new System.Drawing.Size(614, 440);
            this.ordersdatagridView.TabIndex = 0;
            // 
            // customerModelBindingSource2
            // 
            this.customerModelBindingSource2.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.CustomerModel);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderModelBindingSource1
            // 
            this.orderModelBindingSource1.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.OrderModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerModelDataGridViewTextBoxColumn
            // 
            this.customerModelDataGridViewTextBoxColumn.DataPropertyName = "customerModel";
            this.customerModelDataGridViewTextBoxColumn.HeaderText = "customerModel";
            this.customerModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerModelDataGridViewTextBoxColumn.Name = "customerModelDataGridViewTextBoxColumn";
            this.customerModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerModelIdDataGridViewTextBoxColumn
            // 
            this.customerModelIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerModelId";
            this.customerModelIdDataGridViewTextBoxColumn.HeaderText = "CustomerModelId";
            this.customerModelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerModelIdDataGridViewTextBoxColumn.Name = "customerModelIdDataGridViewTextBoxColumn";
            this.customerModelIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPaymentAmountDataGridViewTextBoxColumn
            // 
            this.totalPaymentAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalPaymentAmount";
            this.totalPaymentAmountDataGridViewTextBoxColumn.HeaderText = "TotalPaymentAmount";
            this.totalPaymentAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPaymentAmountDataGridViewTextBoxColumn.Name = "totalPaymentAmountDataGridViewTextBoxColumn";
            this.totalPaymentAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "add New Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 454);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(Salik_Inventory_Management_System.UI.Models.OrderItem);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(970, 92);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 487);
            this.Controls.Add(this.OrderTab);
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.OrderTab.ResumeLayout(false);
            this.OrerHomeTab.ResumeLayout(false);
            this.OrerHomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource)).EndInit();
            this.AllOrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersdatagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderModelBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl OrderTab;
        private TabPage OrerHomeTab;
        private TabPage AllOrdersTab;
        private BindingSource orderModelBindingSource;
        private BindingSource customerModelBindingSource;
        private BindingSource customerModelBindingSource1;
        private Button searchbtn;
        private Button allOrdersBtn;
        private TextBox searchtxt;
        private DataGridView customerDataGridView;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private BindingSource customerModelBindingSource2;
        private Button button1;
        private DataGridView ordersdatagridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerModelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerModelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPaymentAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private BindingSource orderModelBindingSource1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private BindingSource orderItemBindingSource;
    }
}