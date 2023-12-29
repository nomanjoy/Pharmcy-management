namespace Pharmacy_Management_Application
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnnotifications = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnorders = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnnotifications);
            this.panelMenu.Controls.Add(this.btnsettings);
            this.panelMenu.Controls.Add(this.btnReporting);
            this.panelMenu.Controls.Add(this.btncustomer);
            this.panelMenu.Controls.Add(this.btnorders);
            this.panelMenu.Controls.Add(this.btnproducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 723);
            this.panelMenu.TabIndex = 0;
            // 
            // btnsettings
            // 
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Vrinda", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, 329);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsettings.Size = new System.Drawing.Size(209, 62);
            this.btnsettings.TabIndex = 7;
            this.btnsettings.Text = "   Manage User";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnnotifications
            // 
            this.btnnotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnotifications.FlatAppearance.BorderSize = 0;
            this.btnnotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotifications.Font = new System.Drawing.Font("Vrinda", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotifications.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnnotifications.Image = ((System.Drawing.Image)(resources.GetObject("btnnotifications.Image")));
            this.btnnotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotifications.Location = new System.Drawing.Point(0, 391);
            this.btnnotifications.Name = "btnnotifications";
            this.btnnotifications.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnnotifications.Size = new System.Drawing.Size(209, 62);
            this.btnnotifications.TabIndex = 6;
            this.btnnotifications.Text = "   Notifications";
            this.btnnotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnotifications.UseVisualStyleBackColor = true;
            this.btnnotifications.Click += new System.EventHandler(this.btnnotifications_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Vrinda", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 267);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(209, 62);
            this.btnReporting.TabIndex = 5;
            this.btnReporting.Text = "   Reporting";
            this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Vrinda", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncustomer.Image = ((System.Drawing.Image)(resources.GetObject("btncustomer.Image")));
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(0, 205);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btncustomer.Size = new System.Drawing.Size(209, 62);
            this.btncustomer.TabIndex = 4;
            this.btncustomer.Text = "   Customers";
            this.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnorders
            // 
            this.btnorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnorders.FlatAppearance.BorderSize = 0;
            this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorders.Font = new System.Drawing.Font("Vrinda", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorders.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnorders.Image = ((System.Drawing.Image)(resources.GetObject("btnorders.Image")));
            this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.Location = new System.Drawing.Point(0, 143);
            this.btnorders.Name = "btnorders";
            this.btnorders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnorders.Size = new System.Drawing.Size(209, 62);
            this.btnorders.TabIndex = 3;
            this.btnorders.Text = "   Orders";
            this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnorders.UseVisualStyleBackColor = true;
            this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("Vrinda", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnproducts.Image = ((System.Drawing.Image)(resources.GetObject("btnproducts.Image")));
            this.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.Location = new System.Drawing.Point(0, 81);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnproducts.Size = new System.Drawing.Size(209, 62);
            this.btnproducts.TabIndex = 2;
            this.btnproducts.Text = "   Products";
            this.btnproducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblBrand);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(209, 81);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.LogoPannel_Paint);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Forte", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrand.Location = new System.Drawing.Point(11, 23);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(185, 27);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "LIFE PHARMA";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.bntMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(209, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(883, 81);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 2;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Transformers Movie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(784, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 32);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "0";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // bntMinimize
            // 
            this.bntMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMinimize.FlatAppearance.BorderSize = 2;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Transformers Movie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMinimize.ForeColor = System.Drawing.Color.White;
            this.bntMinimize.Location = new System.Drawing.Point(818, 3);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.Size = new System.Drawing.Size(28, 32);
            this.bntMinimize.TabIndex = 3;
            this.bntMinimize.Text = "-";
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(852, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 81);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(392, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(209, 81);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(883, 642);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 723);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnnotifications;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnorders;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}

