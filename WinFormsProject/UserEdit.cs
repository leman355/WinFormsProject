using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class UserEdit : Form
    {
        private EditUser _editUser;

        public UserEdit(EditUser editUser)
        {
            InitializeComponent();
            _editUser = editUser;
            PopulateRoles();
            DisplayUserData();
        }

        private void PopulateRoles()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name FROM [Role]";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable rolesTable = new DataTable();
                    adapter.Fill(rolesTable);

                    cmb_roles.DisplayMember = "Name";
                    cmb_roles.ValueMember = "Id";
                    cmb_roles.DataSource = rolesTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayUserData()
        {
            txb_name.Text = _editUser.Name;
            txb_surname.Text = _editUser.Surname;
            txt_email.Text = _editUser.Email;
            txt_password.Text = _editUser.Password;
            dt_birthday.Value = _editUser.Birthday;
            cmb_roles.SelectedValue = _editUser.RoleId;
            txb_balance.Text = _editUser.Balance.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_userEdit_Click(object sender, EventArgs e)
        {
            _editUser.Name = txb_name.Text;
            _editUser.Surname = txb_surname.Text;
            _editUser.Email = txt_email.Text;
            _editUser.Password = txt_password.Text;
            _editUser.Birthday = dt_birthday.Value;
            _editUser.RoleId = (int)cmb_roles.SelectedValue;

            if (float.TryParse(txb_balance.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float balance))
            {
                _editUser.Balance = balance;
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric balance.");
                return;
            }

            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"UPDATE [User] 
                                        SET Name = @Name, 
                                            Surname = @Surname, 
                                            Email = @Email, 
                                            Password = @Password, 
                                            Birthday = @Birthday, 
                                            RoleId = @RoleId, 
                                            Balance = @Balance 
                                        WHERE Id = @UserId";

                    cmd.Parameters.Add(new SqlParameter("@UserId", _editUser.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", _editUser.Name));
                    cmd.Parameters.Add(new SqlParameter("@Surname", _editUser.Surname));
                    cmd.Parameters.Add(new SqlParameter("@Email", _editUser.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", _editUser.Password));
                    cmd.Parameters.Add(new SqlParameter("@Birthday", _editUser.Birthday));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", _editUser.RoleId));
                    cmd.Parameters.Add(new SqlParameter("@Balance", _editUser.Balance));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"User '{_editUser.Name} {_editUser.Surname}' successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
