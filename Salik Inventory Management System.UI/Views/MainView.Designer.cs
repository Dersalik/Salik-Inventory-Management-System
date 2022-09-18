namespace Salik_Inventory_Management_System.UI.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.navMenu = new System.Windows.Forms.Panel();
            this.CompanyNav = new System.Windows.Forms.Button();
            this.PaymentNav = new System.Windows.Forms.Button();
            this.PacketNav = new System.Windows.Forms.Button();
            this.CustomerNav = new System.Windows.Forms.Button();
            this.OrderNav = new System.Windows.Forms.Button();
            this.HomeNav = new System.Windows.Forms.Button();
            this.navMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.navMenu.Controls.Add(this.CompanyNav);
            this.navMenu.Controls.Add(this.PaymentNav);
            this.navMenu.Controls.Add(this.PacketNav);
            this.navMenu.Controls.Add(this.CustomerNav);
            this.navMenu.Controls.Add(this.OrderNav);
            this.navMenu.Controls.Add(this.HomeNav);
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.navMenu.Location = new System.Drawing.Point(720, 0);
            this.navMenu.Name = "navMenu";
            this.navMenu.Size = new System.Drawing.Size(239, 538);
            this.navMenu.TabIndex = 1;
            this.navMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.navMenu_Paint);
            // 
            // CompanyNav
            // 
            this.CompanyNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CompanyNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompanyNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompanyNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompanyNav.ForeColor = System.Drawing.SystemColors.Control;
            this.CompanyNav.Image = ((System.Drawing.Image)(resources.GetObject("CompanyNav.Image")));
            this.CompanyNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompanyNav.Location = new System.Drawing.Point(0, 361);
            this.CompanyNav.Name = "CompanyNav";
            this.CompanyNav.Size = new System.Drawing.Size(239, 79);
            this.CompanyNav.TabIndex = 9;
            this.CompanyNav.Text = "كؤمبانيا";
            this.CompanyNav.UseVisualStyleBackColor = true;
            // 
            // PaymentNav
            // 
            this.PaymentNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentNav.BackgroundImage")));
            this.PaymentNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PaymentNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentNav.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentNav.Location = new System.Drawing.Point(0, 292);
            this.PaymentNav.Name = "PaymentNav";
            this.PaymentNav.Size = new System.Drawing.Size(239, 69);
            this.PaymentNav.TabIndex = 7;
            this.PaymentNav.Text = "با ره دان";
            this.PaymentNav.UseVisualStyleBackColor = true;
            // 
            // PacketNav
            // 
            this.PacketNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PacketNav.BackgroundImage")));
            this.PacketNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PacketNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.PacketNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PacketNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PacketNav.ForeColor = System.Drawing.SystemColors.Control;
            this.PacketNav.Location = new System.Drawing.Point(0, 223);
            this.PacketNav.Name = "PacketNav";
            this.PacketNav.Size = new System.Drawing.Size(239, 69);
            this.PacketNav.TabIndex = 6;
            this.PacketNav.Text = "باكه ته كان";
            this.PacketNav.UseVisualStyleBackColor = true;
            this.PacketNav.Click += new System.EventHandler(this.PacketNav_Click);
            // 
            // CustomerNav
            // 
            this.CustomerNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CustomerNav.BackgroundImage")));
            this.CustomerNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomerNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerNav.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomerNav.Location = new System.Drawing.Point(0, 154);
            this.CustomerNav.Name = "CustomerNav";
            this.CustomerNav.Size = new System.Drawing.Size(239, 69);
            this.CustomerNav.TabIndex = 5;
            this.CustomerNav.Text = "كرياره كان";
            this.CustomerNav.UseVisualStyleBackColor = true;
            // 
            // OrderNav
            // 
            this.OrderNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderNav.BackgroundImage")));
            this.OrderNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNav.ForeColor = System.Drawing.SystemColors.Control;
            this.OrderNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderNav.Location = new System.Drawing.Point(0, 78);
            this.OrderNav.Name = "OrderNav";
            this.OrderNav.Size = new System.Drawing.Size(239, 76);
            this.OrderNav.TabIndex = 4;
            this.OrderNav.Text = "قائمه";
            this.OrderNav.UseVisualStyleBackColor = true;
            this.OrderNav.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HomeNav
            // 
            this.HomeNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeNav.BackgroundImage")));
            this.HomeNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeNav.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeNav.ForeColor = System.Drawing.SystemColors.Control;
            this.HomeNav.Location = new System.Drawing.Point(0, 0);
            this.HomeNav.Name = "HomeNav";
            this.HomeNav.Size = new System.Drawing.Size(239, 78);
            this.HomeNav.TabIndex = 3;
            this.HomeNav.Text = "ماله وه";
            this.HomeNav.UseVisualStyleBackColor = true;
            this.HomeNav.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 538);
            this.Controls.Add(this.navMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel navMenu;
        private Button HomeNav;
        private Button OrderNav;
        private Button CustomerNav;
        private Button PaymentNav;
        private Button PacketNav;
        private Button CompanyNav;
    }
}