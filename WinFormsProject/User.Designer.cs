namespace WinFormsProject
{
    partial class User
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
            this.lbl_userInfo = new System.Windows.Forms.Label();
            btn_deposit = new Button();
            btn_shop = new Button();
            SuspendLayout();
            // 
            // lbl_userInfo
            // 
            this.lbl_userInfo.AutoSize = true;
            this.lbl_userInfo.Location = new Point(12, 9);
            this.lbl_userInfo.Name = "lbl_userInfo";
            this.lbl_userInfo.Size = new Size(0, 13);
            this.lbl_userInfo.TabIndex = 0;

            // 
            // btn_deposit
            // 
            btn_deposit.BackColor = Color.FromArgb(128, 128, 255);
            btn_deposit.FlatStyle = FlatStyle.Popup;
            btn_deposit.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deposit.Location = new Point(113, 185);
            btn_deposit.Name = "btn_deposit";
            btn_deposit.Size = new Size(220, 78);
            btn_deposit.TabIndex = 22;
            btn_deposit.Text = "Deposit";
            btn_deposit.UseVisualStyleBackColor = false;
            btn_deposit.Click += btn_deposit_Click;
            // 
            // btn_shop
            // 
            btn_shop.BackColor = Color.FromArgb(255, 128, 255);
            btn_shop.FlatStyle = FlatStyle.Popup;
            btn_shop.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btn_shop.Location = new Point(442, 185);
            btn_shop.Name = "btn_shop";
            btn_shop.Size = new Size(220, 78);
            btn_shop.TabIndex = 23;
            btn_shop.Text = "Go to Shop";
            btn_shop.UseVisualStyleBackColor = false;
            btn_shop.Click += btn_shop_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_shop);
            Controls.Add(btn_deposit);
            Name = "User";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        public Button btn_deposit;
        public Button btn_shop;
    }
}