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
            btn_add_product = new Button();
            all_users_data_grid = new DataGridView();
            all_products_data_grid = new DataGridView();
            btn_Edit = new Button();
            btn_SoftDelete = new Button();
            btn_HardDelete = new Button();
            btn_product_edit = new Button();
            btn_product_soft_delete = new Button();
            btn_product_hard_delete = new Button();
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
            // btn_add_product
            // 
            btn_add_product.BackColor = Color.YellowGreen;
            btn_add_product.FlatStyle = FlatStyle.Popup;
            btn_add_product.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_product.Location = new Point(1113, 13);
            btn_add_product.Name = "btn_add_product";
            btn_add_product.Size = new Size(142, 32);
            btn_add_product.TabIndex = 12;
            btn_add_product.Text = "Add Product";
            btn_add_product.UseVisualStyleBackColor = false;
            btn_add_product.Click += btn_add_product_Click;
            // 
            // all_users_data_grid
            // 
            all_users_data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            all_users_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_users_data_grid.Location = new Point(12, 75);
            all_users_data_grid.Name = "all_users_data_grid";
            all_users_data_grid.RowTemplate.Height = 25;
            all_users_data_grid.Size = new Size(810, 288);
            all_users_data_grid.TabIndex = 13;
            all_users_data_grid.SelectionChanged += all_users_data_grid_SelectionChanged;
            // 
            // all_products_data_grid
            // 
            all_products_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_products_data_grid.Location = new Point(870, 66);
            all_products_data_grid.Name = "all_products_data_grid";
            all_products_data_grid.RowTemplate.Height = 25;
            all_products_data_grid.Size = new Size(554, 297);
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
            btn_SoftDelete.Click += btn_SoftDelete_Click;
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
            btn_HardDelete.Click += btn_HardDelete_Click;
            // 
            // btn_product_edit
            // 
            btn_product_edit.BackColor = Color.FromArgb(128, 255, 128);
            btn_product_edit.FlatStyle = FlatStyle.Popup;
            btn_product_edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_edit.Location = new Point(895, 386);
            btn_product_edit.Name = "btn_product_edit";
            btn_product_edit.Size = new Size(128, 32);
            btn_product_edit.TabIndex = 18;
            btn_product_edit.Text = "Edit Product";
            btn_product_edit.UseVisualStyleBackColor = false;
            btn_product_edit.Visible = true;
            btn_product_edit.Click += btn_product_edit_Click;
            // 
            // btn_product_soft_delete
            // 
            btn_product_soft_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_product_soft_delete.FlatStyle = FlatStyle.Popup;
            btn_product_soft_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_soft_delete.Location = new Point(1066, 386);
            btn_product_soft_delete.Name = "btn_product_soft_delete";
            btn_product_soft_delete.Size = new Size(172, 32);
            btn_product_soft_delete.TabIndex = 19;
            btn_product_soft_delete.Text = "Soft Delete Product";
            btn_product_soft_delete.UseVisualStyleBackColor = false;
            btn_product_soft_delete.Visible = true;
            btn_product_soft_delete.Click += btn_product_soft_delete_Click;
            // 
            // btn_product_hard_delete
            // 
            btn_product_hard_delete.BackColor = Color.Red;
            btn_product_hard_delete.FlatStyle = FlatStyle.Popup;
            btn_product_hard_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_hard_delete.Location = new Point(1245, 386);
            btn_product_hard_delete.Name = "btn_product_hard_delete";
            btn_product_hard_delete.Size = new Size(179, 32);
            btn_product_hard_delete.TabIndex = 20;
            btn_product_hard_delete.Text = "Hard Delete Product";
            btn_product_hard_delete.UseVisualStyleBackColor = false;
            btn_product_hard_delete.Visible = true;
            btn_product_hard_delete.Click += btn_product_hard_delete_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 475);
            Controls.Add(btn_product_hard_delete);
            Controls.Add(btn_product_soft_delete);
            Controls.Add(btn_product_edit);
            Controls.Add(btn_HardDelete);
            Controls.Add(btn_SoftDelete);
            Controls.Add(btn_Edit);
            Controls.Add(all_products_data_grid);
            Controls.Add(all_users_data_grid);
            Controls.Add(btn_add_product);
            Controls.Add(btn_signup);
            Name = "Admin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)all_users_data_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)all_products_data_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_signup;
        private Button btn_add_product;
        private DataGridView all_users_data_grid;
        private DataGridView all_products_data_grid;
        private Button btn_Edit;
        private Button btn_SoftDelete;
        private Button btn_HardDelete;
        private Button btn_product_edit;
        private Button btn_product_soft_delete;
        private Button btn_product_hard_delete;
    }
}