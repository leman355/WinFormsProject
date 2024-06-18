namespace WinFormsProject
{
    partial class Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_signup = new Button();
            btn_Edit = new Button();
            btn_SoftDelete = new Button();
            btn_HardDelete = new Button();
            all_users_dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)all_users_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.PowderBlue;
            btn_signup.FlatStyle = FlatStyle.Popup;
            btn_signup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.Location = new Point(382, 12);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(128, 32);
            btn_signup.TabIndex = 11;
            btn_signup.Text = "Registration";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(255, 128, 0);
            btn_Edit.FlatStyle = FlatStyle.Popup;
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Location = new Point(32, 397);
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
            btn_SoftDelete.Location = new Point(570, 397);
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
            btn_HardDelete.Location = new Point(724, 397);
            btn_HardDelete.Name = "btn_HardDelete";
            btn_HardDelete.Size = new Size(128, 32);
            btn_HardDelete.TabIndex = 17;
            btn_HardDelete.Text = "Hard Delete";
            btn_HardDelete.UseVisualStyleBackColor = false;
            btn_HardDelete.Click += btn_HardDelete_Click;
            // 
            // all_users_dataGrid
            // 
            all_users_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_users_dataGrid.Location = new Point(22, 72);
            all_users_dataGrid.Name = "all_users_dataGrid";
            all_users_dataGrid.RowTemplate.Height = 25;
            all_users_dataGrid.Size = new Size(874, 301);
            all_users_dataGrid.TabIndex = 18;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 475);
            Controls.Add(all_users_dataGrid);
            Controls.Add(btn_HardDelete);
            Controls.Add(btn_SoftDelete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_signup);
            Name = "Users";
            ((System.ComponentModel.ISupportInitialize)all_users_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.DataGridView all_users_data_grid;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_SoftDelete;
        private System.Windows.Forms.Button btn_HardDelete;
        private DataGridView all_users_dataGrid;
    }
}
