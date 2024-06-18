namespace WinFormsProject
{
    partial class Shop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label _lbl_info;

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
            lbl_info = new Label();
            shop_data_grid = new DataGridView();
            btn_buy = new Button();
            ((System.ComponentModel.ISupportInitialize)shop_data_grid).BeginInit();
            SuspendLayout();
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Location = new Point(12, 9);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(0, 15);
            lbl_info.TabIndex = 0;
            // 
            // shop_data_grid
            // 
            shop_data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shop_data_grid.Location = new Point(246, 9);
            shop_data_grid.Name = "shop_data_grid";
            shop_data_grid.RowTemplate.Height = 25;
            shop_data_grid.Size = new Size(542, 355);
            shop_data_grid.TabIndex = 15;
            // 
            // btn_buy
            // 
            btn_buy.BackColor = Color.Plum;
            btn_buy.FlatStyle = FlatStyle.Popup;
            btn_buy.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_buy.Location = new Point(484, 395);
            btn_buy.Name = "btn_buy";
            btn_buy.Size = new Size(128, 43);
            btn_buy.TabIndex = 17;
            btn_buy.Text = "Buy";
            btn_buy.UseVisualStyleBackColor = false;
            btn_buy.Click += btn_buy_Click;
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_buy);
            Controls.Add(shop_data_grid);
            Controls.Add(lbl_info);
            Name = "Shop";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)shop_data_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbl_info;
        private DataGridView shop_data_grid;
        private Button btn_buy;
    }
}