namespace WinFormsProject
{
    partial class UserEdit
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
            lbl_userInfo = new Label();
            txb_balance = new TextBox();
            cmb_roles = new ComboBox();
            dt_birthday = new DateTimePicker();
            txb_surname = new TextBox();
            txb_name = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            txt_email = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_userEdit = new Button();
            SuspendLayout();
            // 
            // lbl_userInfo
            // 
            lbl_userInfo.AutoSize = true;
            lbl_userInfo.Location = new Point(59, -5);
            lbl_userInfo.Name = "lbl_userInfo";
            lbl_userInfo.Size = new Size(0, 15);
            lbl_userInfo.TabIndex = 17;
            // 
            // txb_balance
            // 
            txb_balance.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_balance.Location = new Point(487, 368);
            txb_balance.Name = "txb_balance";
            txb_balance.Size = new Size(200, 22);
            txb_balance.TabIndex = 31;
            // 
            // cmb_roles
            // 
            cmb_roles.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_roles.FormattingEnabled = true;
            cmb_roles.Location = new Point(487, 316);
            cmb_roles.Name = "cmb_roles";
            cmb_roles.Size = new Size(121, 21);
            cmb_roles.TabIndex = 30;
            // 
            // dt_birthday
            // 
            dt_birthday.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dt_birthday.Location = new Point(484, 250);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.Size = new Size(200, 22);
            dt_birthday.TabIndex = 29;
            // 
            // txb_surname
            // 
            txb_surname.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_surname.Location = new Point(484, 73);
            txb_surname.Name = "txb_surname";
            txb_surname.Size = new Size(200, 22);
            txb_surname.TabIndex = 28;
            // 
            // txb_name
            // 
            txb_name.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_name.Location = new Point(484, 19);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(200, 22);
            txb_name.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 192, 128);
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(487, 343);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 26;
            label7.Text = "Balance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 128);
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(487, 292);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 25;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 128);
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(484, 226);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 24;
            label5.Text = "Birthday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 128);
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(484, 49);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 23;
            label4.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 128);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(484, -5);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(484, 189);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(147, 22);
            txt_password.TabIndex = 20;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(484, 126);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(147, 22);
            txt_email.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(484, 161);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 18;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(486, 103);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // btn_userEdit
            // 
            btn_userEdit.BackColor = Color.FromArgb(255, 128, 0);
            btn_userEdit.BackgroundImageLayout = ImageLayout.Center;
            btn_userEdit.FlatStyle = FlatStyle.Popup;
            btn_userEdit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_userEdit.Location = new Point(498, 401);
            btn_userEdit.Name = "btn_userEdit";
            btn_userEdit.Size = new Size(94, 41);
            btn_userEdit.TabIndex = 32;
            btn_userEdit.Text = "Edit";
            btn_userEdit.UseVisualStyleBackColor = false;
            btn_userEdit.Click += btn_userEdit_Click;
            // 
            // UserEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_userEdit);
            Controls.Add(lbl_userInfo);
            Controls.Add(txb_balance);
            Controls.Add(cmb_roles);
            Controls.Add(dt_birthday);
            Controls.Add(txb_surname);
            Controls.Add(txb_name);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserEdit";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_userInfo;
        private TextBox txb_balance;
        private ComboBox cmb_roles;
        private DateTimePicker dt_birthday;
        private TextBox txb_surname;
        private TextBox txb_name;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_password;
        private TextBox txt_email;
        private Label label2;
        private Label label1;
        private Button btn_userEdit;
    }
}