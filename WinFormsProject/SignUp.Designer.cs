namespace WinFormsProject
{
    partial class SignUp
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
            components = new System.ComponentModel.Container();
            lbl_userInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_signup = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txb_name = new TextBox();
            txb_surname = new TextBox();
            dt_birthday = new DateTimePicker();
            cmb_roles = new ComboBox();
            txb_balance = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // lbl_userInfo
            // 
            lbl_userInfo.AutoSize = true;
            lbl_userInfo.Location = new Point(12, 9);
            lbl_userInfo.Name = "lbl_userInfo";
            lbl_userInfo.Size = new Size(0, 15);
            lbl_userInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(439, 117);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 255);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 175);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(437, 140);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(147, 22);
            txt_email.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(437, 203);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(147, 22);
            txt_password.TabIndex = 3;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.PowderBlue;
            btn_signup.FlatStyle = FlatStyle.Popup;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.Location = new Point(566, 438);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(128, 32);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "Registration";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 255, 255);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(437, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 255, 255);
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(437, 63);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 7;
            label4.Text = "Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 255, 255);
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(437, 240);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 8;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 255, 255);
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(440, 306);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 9;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 255, 255);
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(440, 357);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 10;
            label7.Text = "Balance";
            // 
            // txb_name
            // 
            txb_name.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_name.Location = new Point(437, 33);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(200, 22);
            txb_name.TabIndex = 11;
            // 
            // txb_surname
            // 
            txb_surname.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_surname.Location = new Point(437, 87);
            txb_surname.Name = "txb_surname";
            txb_surname.Size = new Size(200, 22);
            txb_surname.TabIndex = 12;
            // 
            // dt_birthday
            // 
            dt_birthday.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dt_birthday.Location = new Point(437, 264);
            dt_birthday.Name = "dt_birthday";
            dt_birthday.Size = new Size(200, 22);
            dt_birthday.TabIndex = 13;
            // 
            // cmb_roles
            // 
            cmb_roles.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_roles.FormattingEnabled = true;
            cmb_roles.Location = new Point(440, 330);
            cmb_roles.Name = "cmb_roles";
            cmb_roles.Size = new Size(121, 21);
            cmb_roles.TabIndex = 14;
            // 
            // txb_balance
            // 
            txb_balance.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            txb_balance.Location = new Point(440, 382);
            txb_balance.Name = "txb_balance";
            txb_balance.Size = new Size(200, 22);
            txb_balance.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
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
            Controls.Add(btn_signup);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_password;
        private Button btn_signup;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txb_name;
        private TextBox txb_surname;
        private DateTimePicker dt_birthday;
        private ComboBox cmb_roles;
        private TextBox txb_balance;
        private ContextMenuStrip contextMenuStrip1;
    }
}