namespace WinFormsProject
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbl_userInfo;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_userInfo = new Label();
            btn_users = new Button();
            btn_products = new Button();
            SuspendLayout();
            // 
            // lbl_userInfo
            // 
            lbl_userInfo.AutoSize = true;
            lbl_userInfo.Location = new Point(12, 9);
            lbl_userInfo.Name = "lbl_userInfo";
            lbl_userInfo.Size = new Size(0, 13);
            lbl_userInfo.TabIndex = 0;
            // 
            // btn_users
            // 
            btn_users.BackColor = Color.PowderBlue;
            btn_users.FlatStyle = FlatStyle.Popup;
            btn_users.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btn_users.Location = new Point(111, 189);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(220, 78);
            btn_users.TabIndex = 21;
            btn_users.Text = "Users";
            btn_users.UseVisualStyleBackColor = false;
            btn_users.Click += btn_users_Click;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.YellowGreen;
            btn_products.FlatStyle = FlatStyle.Popup;
            btn_products.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btn_products.Location = new Point(365, 189);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(201, 78);
            btn_products.TabIndex = 23;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            btn_products.Click += btn_products_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 475);
            Controls.Add(btn_products);
            Controls.Add(btn_users);
            Name = "Admin";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        public Button btn_users;
        public Button btn_products;
    }
}