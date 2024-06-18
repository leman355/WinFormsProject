namespace WinFormsProject
{
    partial class ProductEdit
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
            btn_edit_product = new Button();
            txb_price = new TextBox();
            cmb_categories = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txb_product_name = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_edit_product
            // 
            btn_edit_product.BackColor = Color.FromArgb(192, 255, 192);
            btn_edit_product.FlatStyle = FlatStyle.Popup;
            btn_edit_product.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit_product.Location = new Point(292, 285);
            btn_edit_product.Name = "btn_edit_product";
            btn_edit_product.Size = new Size(128, 32);
            btn_edit_product.TabIndex = 27;
            btn_edit_product.Text = "Edit Product";
            btn_edit_product.UseVisualStyleBackColor = false;
            btn_edit_product.Click += btn_edit_product_Click;
            // 
            // txb_price
            // 
            txb_price.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_price.Location = new Point(277, 222);
            txb_price.Name = "txb_price";
            txb_price.Size = new Size(200, 22);
            txb_price.TabIndex = 26;
            // 
            // cmb_categories
            // 
            cmb_categories.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_categories.FormattingEnabled = true;
            cmb_categories.Location = new Point(277, 159);
            cmb_categories.Name = "cmb_categories";
            cmb_categories.Size = new Size(121, 21);
            cmb_categories.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 178);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 197);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 24;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 255, 178);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(277, 128);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 23;
            label3.Text = "Category Name";
            // 
            // txb_product_name
            // 
            txb_product_name.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_product_name.Location = new Point(277, 86);
            txb_product_name.Name = "txb_product_name";
            txb_product_name.Size = new Size(200, 22);
            txb_product_name.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 178);
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(277, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 21;
            label1.Text = "Product Name";
            // 
            // ProductEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_edit_product);
            Controls.Add(txb_price);
            Controls.Add(cmb_categories);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txb_product_name);
            Controls.Add(label1);
            Name = "ProductEdit";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_edit_product;
        private TextBox txb_price;
        private ComboBox cmb_categories;
        private Label label2;
        private Label label3;
        private TextBox txb_product_name;
        private Label label1;
    }
}