namespace WinFormsProject
{
    partial class SignIn
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
            btn_login = new Button();
            txt_password = new TextBox();
            txt_email = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_signup = new Button();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightSteelBlue;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(341, 270);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(96, 36);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.Location = new Point(326, 206);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(147, 25);
            txt_password.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(326, 115);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(147, 25);
            txt_email.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 128, 255);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 163);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 77);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.PowderBlue;
            btn_signup.FlatStyle = FlatStyle.Popup;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.Location = new Point(673, 1);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(128, 32);
            btn_signup.TabIndex = 10;
            btn_signup.Text = "Registration";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_signup);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Name = "SignIn";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_password;
        private TextBox txt_email;
        private Label label2;
        private Label label1;
        private Button btn_signup;
    }
}