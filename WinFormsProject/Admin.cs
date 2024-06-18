using System.Data;
using System.Data.SqlClient;
using WinFormsProject.Entities;


namespace WinFormsProject
{
    public partial class Admin : Form
    {
        private GetSUser _currentUser;

        public Admin()
        {
            InitializeComponent();
            DisplayAllUsers();
        }

        public Admin(GetSUser currentUser) : this()
        {
            _currentUser = currentUser;
            DisplayUserInfo();
            DisplayAllUsers();
        }

        private void DisplayUserInfo()
        {
            if (_currentUser != null)
            {
                lbl_userInfo.Text = $"Welcome, Admin {_currentUser.Name} {_currentUser.Surname}!\n" +
                                    $"Role: {_currentUser.RoleName}\n" +
                                    $"Email: {_currentUser.Email}\n" +
                                    $"Balance: {_currentUser.Balance}AZN\n" +
                                    $"Birthday: {_currentUser.Birthday.ToShortDateString()}";
            }
            else
            {
                lbl_userInfo.Text = "Welcome, Guest!";
            }
        }

        private void DisplayAllUsers()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT u.Name, u.Surname, u.Email, u.Birthday, r.Name AS RoleName, u.Balance, u.IsDeleted 
                                        FROM [User] u 
                                        JOIN [Role] r ON u.RoleId = r.Id";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    all_users_data_grid.DataSource = dataTable;
                    all_users_data_grid.MultiSelect = false;
                    all_users_data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    all_users_data_grid.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (SignUp signUpForm = new SignUp(_currentUser))
            {
                signUpForm.RegistrationSuccessful += SignUpForm_RegistrationSuccessful;
                signUpForm.ShowDialog();
                signUpForm.RegistrationSuccessful -= SignUpForm_RegistrationSuccessful;
                this.Show();
            }
        }

        private void SignUpForm_RegistrationSuccessful(object sender, EventArgs e)
        {
            DisplayAllUsers();
        }

        private void all_users_data_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_SoftDelete.Visible = true;
            btn_HardDelete.Visible = true;
            btn_Edit.Visible = true;
        }
        private void btn_SoftDelete_Click(object sender, EventArgs e)
        {

        }

        private void btn_HardDelete_Click(object sender, EventArgs e)
        {
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
