namespace WinFormsProject
{
    partial class ProductAdd
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
            txb_product_name = new TextBox();
            label1 = new Label();
            txb_price = new TextBox();
            cmb_categories = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btn_add_product = new Button();
            SuspendLayout();
            // 
            // txb_product_name
            // 
            txb_product_name.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_product_name.Location = new Point(255, 92);
            txb_product_name.Name = "txb_product_name";
            txb_product_name.Size = new Size(200, 22);
            txb_product_name.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(255, 67);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 12;
            label1.Text = "Product Name";
            // 
            // txb_price
            // 
            txb_price.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_price.Location = new Point(255, 228);
            txb_price.Name = "txb_price";
            txb_price.Size = new Size(200, 22);
            txb_price.TabIndex = 19;
            // 
            // cmb_categories
            // 
            cmb_categories.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_categories.FormattingEnabled = true;
            cmb_categories.Location = new Point(255, 165);
            cmb_categories.Name = "cmb_categories";
            cmb_categories.Size = new Size(121, 21);
            cmb_categories.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 128);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(255, 203);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 17;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 128);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(255, 134);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 16;
            label3.Text = "Category Name";
            // 
            // btn_add_product
            // 
            btn_add_product.BackColor = Color.Lime;
            btn_add_product.FlatStyle = FlatStyle.Popup;
            btn_add_product.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_product.Location = new Point(270, 291);
            btn_add_product.Name = "btn_add_product";
            btn_add_product.Size = new Size(128, 32);
            btn_add_product.TabIndex = 20;
            btn_add_product.Text = "Add Product";
            btn_add_product.UseVisualStyleBackColor = false;
            btn_add_product.Click += btn_add_product_Click;
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_product);
            Controls.Add(txb_price);
            Controls.Add(cmb_categories);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txb_product_name);
            Controls.Add(label1);
            Name = "ProductAdd";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_product_name;
        private Label label1;
        private TextBox txb_price;
        private ComboBox cmb_categories;
        private Label label2;
        private Label label3;
        private Button btn_add_product;
    }
}