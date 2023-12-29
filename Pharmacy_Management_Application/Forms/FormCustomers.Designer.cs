namespace Pharmacy_Management_Application.Forms
{
    partial class FormCustomers
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
            this.lblName = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tboxPhonenumber = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.GridViewCustomer = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tboxName
            // 
            this.tboxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxName.Location = new System.Drawing.Point(179, 119);
            this.tboxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(188, 26);
            this.tboxName.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(51, 280);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(122, 21);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(51, 231);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 21);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(51, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 21);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // tboxPhonenumber
            // 
            this.tboxPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPhonenumber.Location = new System.Drawing.Point(179, 275);
            this.tboxPhonenumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxPhonenumber.Name = "tboxPhonenumber";
            this.tboxPhonenumber.Size = new System.Drawing.Size(188, 26);
            this.tboxPhonenumber.TabIndex = 6;
            // 
            // tboxEmail
            // 
            this.tboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxEmail.Location = new System.Drawing.Point(179, 170);
            this.tboxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(188, 26);
            this.tboxEmail.TabIndex = 7;
            // 
            // tboxAddress
            // 
            this.tboxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxAddress.Location = new System.Drawing.Point(179, 226);
            this.tboxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(188, 26);
            this.tboxAddress.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(55, 420);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRemove.FlatAppearance.BorderSize = 4;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(179, 420);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 45);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxCustomerID.Location = new System.Drawing.Point(179, 64);
            this.tboxCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(188, 26);
            this.tboxCustomerID.TabIndex = 14;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(51, 69);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(107, 21);
            this.lblCustomerID.TabIndex = 13;
            this.lblCustomerID.Text = "Customer_ID";
            // 
            // GridViewCustomer
            // 
            this.GridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCustomer.Location = new System.Drawing.Point(435, 64);
            this.GridViewCustomer.Name = "GridViewCustomer";
            this.GridViewCustomer.RowHeadersWidth = 62;
            this.GridViewCustomer.RowTemplate.Height = 28;
            this.GridViewCustomer.Size = new System.Drawing.Size(981, 401);
            this.GridViewCustomer.TabIndex = 15;
            this.GridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCustomer_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReload.FlatAppearance.BorderSize = 4;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Location = new System.Drawing.Point(179, 352);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(102, 45);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(55, 352);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 513);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.GridViewCustomer);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxPhonenumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCustomers";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tboxPhonenumber;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DataGridView GridViewCustomer;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpdate;
    }
}