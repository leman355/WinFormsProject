using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            if (ValidateUser(email, password))
            {
                //this.Hide();
                GetSUser currentUser = GetCurrentUser(email, password);
                //SignUp mainForm = new SignUp(currentUser);
                //mainForm.ShowDialog();
                //this.Close();
                if (currentUser.RoleName == "Admin")
                {
                    this.Hide();
                    Admin adminForm = new Admin(currentUser);
                    adminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    SignUp mainForm = new SignUp(currentUser);
                    mainForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SignUp signUpForm = new SignUp(null))
            {
                signUpForm.ShowDialog();
                if (signUpForm.IsRegistrationSuccessful)
                {
                    this.Show();
                }
            }
        }

        private bool ValidateUser(string email, string password)
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT COUNT(1) FROM [User] WHERE Email = @Email AND Password = @Password";
                    cmd.Parameters.Add(new SqlParameter("@Email", email));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));

                    int result = (int)cmd.ExecuteScalar();
                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to validate user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private GetSUser GetCurrentUser(string email, string password)
        {
            GetSUser user = null;
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT u.Name, u.Surname, u.Email, u.Birthday, r.Name AS RoleName, u.Balance 
                                        FROM [User] u 
                                        JOIN [Role] r ON u.RoleId = r.Id 
                                        WHERE u.Email = @Email AND u.Password = @Password";
                    cmd.Parameters.Add(new SqlParameter("@Email", email));
                    cmd.Parameters.Add(new SqlParameter("@Password", password));

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new GetSUser()
                            {
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                Email = reader["Email"].ToString(),
                                Birthday = Convert.ToDateTime(reader["Birthday"]),
                                RoleName = reader["RoleName"].ToString(),
                                Balance = Convert.ToSingle(reader["Balance"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        }
    }
}
