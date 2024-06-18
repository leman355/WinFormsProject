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
            btn_signup = new Button();
            btn_products = new Button();
            all_users_data_grid = new DataGridView();
            all_products_data_grid = new DataGridView();
            btn_Edit = new Button();
            btn_SoftDelete = new Button();
            btn_HardDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)all_users_data_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)all_products_data_grid).BeginInit();
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
            // btn_signup
            // 
            btn_signup.BackColor = Color.PowderBlue;
            btn_signup.FlatStyle = FlatStyle.Popup;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.Location = new Point(311, 12);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(128, 32);
            btn_signup.TabIndex = 11;
            btn_signup.Text = "Registration";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_products
            // 
            btn_products.BackColor = Color.YellowGreen;
            btn_products.FlatStyle = FlatStyle.Popup;
            btn_products.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_products.Location = new Point(945, 12);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(128, 32);
            btn_products.TabIndex = 12;
            btn_products.Text = "Products";
            btn_products.UseVisualStyleBackColor = false;
            // 
            // all_users_data_grid
            // 
            all_users_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_users_data_grid.Location = new Point(12, 75);
            all_users_data_grid.Name = "all_users_data_grid";
            all_users_data_grid.RowTemplate.Height = 25;
            all_users_data_grid.Size = new Size(741, 288);
            all_users_data_grid.TabIndex = 13;
            all_users_data_grid.CellClick += all_users_data_grid_CellClick;
            // 
            // all_products_data_grid
            // 
            all_products_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_products_data_grid.Location = new Point(791, 66);
            all_products_data_grid.Name = "all_products_data_grid";
            all_products_data_grid.RowTemplate.Height = 25;
            all_products_data_grid.Size = new Size(448, 363);
            all_products_data_grid.TabIndex = 14;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(255, 128, 0);
            btn_Edit.FlatStyle = FlatStyle.Popup;
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Location = new Point(12, 397);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(128, 32);
            btn_Edit.TabIndex = 15;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Visible = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_SoftDelete
            // 
            btn_SoftDelete.BackColor = Color.FromArgb(255, 192, 192);
            btn_SoftDelete.FlatStyle = FlatStyle.Popup;
            btn_SoftDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SoftDelete.Location = new Point(338, 397);
            btn_SoftDelete.Name = "btn_SoftDelete";
            btn_SoftDelete.Size = new Size(128, 32);
            btn_SoftDelete.TabIndex = 16;
            btn_SoftDelete.Text = "Soft Delete";
            btn_SoftDelete.UseVisualStyleBackColor = false;
            btn_SoftDelete.Visible = false;
            // 
            // btn_HardDelete
            // 
            btn_HardDelete.BackColor = Color.Red;
            btn_HardDelete.FlatStyle = FlatStyle.Popup;
            btn_HardDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_HardDelete.Location = new Point(492, 397);
            btn_HardDelete.Name = "btn_HardDelete";
            btn_HardDelete.Size = new Size(128, 32);
            btn_HardDelete.TabIndex = 17;
            btn_HardDelete.Text = "Hard Delete";
            btn_HardDelete.UseVisualStyleBackColor = false;
            btn_HardDelete.Visible = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 475);
            Controls.Add(btn_HardDelete);
            Controls.Add(btn_SoftDelete);
            Controls.Add(btn_Edit);
            Controls.Add(all_products_data_grid);
            Controls.Add(all_users_data_grid);
            Controls.Add(btn_products);
            Controls.Add(btn_signup);
            Name = "Admin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)all_users_data_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)all_products_data_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_signup;
        private Button btn_products;
        private DataGridView all_users_data_grid;
        private DataGridView all_products_data_grid;
        private Button btn_Edit;
        private Button btn_SoftDelete;
        private Button btn_HardDelete;
    }
}