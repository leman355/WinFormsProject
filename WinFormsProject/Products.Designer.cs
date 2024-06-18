namespace WinFormsProject
{
    partial class Products
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btn_add_product = new Button();
            all_products_data_grid = new DataGridView();
            btn_product_edit = new Button();
            btn_product_soft_delete = new Button();
            btn_product_hard_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)all_products_data_grid).BeginInit();
            SuspendLayout();
            // 
            // btn_add_product
            // 
            btn_add_product.BackColor = Color.YellowGreen;
            btn_add_product.FlatStyle = FlatStyle.Popup;
            btn_add_product.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_product.Location = new Point(275, 22);
            btn_add_product.Name = "btn_add_product";
            btn_add_product.Size = new Size(142, 32);
            btn_add_product.TabIndex = 12;
            btn_add_product.Text = "Add Product";
            btn_add_product.UseVisualStyleBackColor = false;
            btn_add_product.Click += btn_add_product_Click;
            // 
            // all_products_data_grid
            // 
            all_products_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_products_data_grid.Location = new Point(78, 80);
            all_products_data_grid.Name = "all_products_data_grid";
            all_products_data_grid.RowTemplate.Height = 25;
            all_products_data_grid.Size = new Size(542, 355);
            all_products_data_grid.TabIndex = 14;
            // 
            // btn_product_edit
            // 
            btn_product_edit.BackColor = Color.FromArgb(128, 255, 128);
            btn_product_edit.FlatStyle = FlatStyle.Popup;
            btn_product_edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_edit.Location = new Point(83, 459);
            btn_product_edit.Name = "btn_product_edit";
            btn_product_edit.Size = new Size(128, 32);
            btn_product_edit.TabIndex = 18;
            btn_product_edit.Text = "Edit Product";
            btn_product_edit.UseVisualStyleBackColor = false;
            btn_product_edit.Click += btn_product_edit_Click;
            // 
            // btn_product_soft_delete
            // 
            btn_product_soft_delete.BackColor = Color.FromArgb(255, 192, 192);
            btn_product_soft_delete.FlatStyle = FlatStyle.Popup;
            btn_product_soft_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_soft_delete.Location = new Point(254, 459);
            btn_product_soft_delete.Name = "btn_product_soft_delete";
            btn_product_soft_delete.Size = new Size(172, 32);
            btn_product_soft_delete.TabIndex = 19;
            btn_product_soft_delete.Text = "Soft Delete Product";
            btn_product_soft_delete.UseVisualStyleBackColor = false;
            btn_product_soft_delete.Click += btn_product_soft_delete_Click;
            // 
            // btn_product_hard_delete
            // 
            btn_product_hard_delete.BackColor = Color.Red;
            btn_product_hard_delete.FlatStyle = FlatStyle.Popup;
            btn_product_hard_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_product_hard_delete.Location = new Point(433, 459);
            btn_product_hard_delete.Name = "btn_product_hard_delete";
            btn_product_hard_delete.Size = new Size(179, 32);
            btn_product_hard_delete.TabIndex = 20;
            btn_product_hard_delete.Text = "Hard Delete Product";
            btn_product_hard_delete.UseVisualStyleBackColor = false;
            btn_product_hard_delete.Click += btn_product_hard_delete_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 529);
            Controls.Add(btn_product_hard_delete);
            Controls.Add(btn_product_soft_delete);
            Controls.Add(btn_product_edit);
            Controls.Add(all_products_data_grid);
            Controls.Add(btn_add_product);
            Name = "Products";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)all_products_data_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_add_product;
        private DataGridView all_products_data_grid;
        private Button btn_product_edit;
        private Button btn_product_soft_delete;
        private Button btn_product_hard_delete;
    }
}