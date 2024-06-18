using WinFormsProject.Entities;
using System;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class SignUp : Form
    {
        public event EventHandler RegistrationSuccessful;

        private GetSUser _currentUser;
        public GetSUser RegisteredUser { get; private set; }
        private bool _isRegistrationSuccessful = false;

        public SignUp(GetSUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            PopulateRolesComboBox();
            DisplayUserInfo();
        }

        public bool IsRegistrationSuccessful => _isRegistrationSuccessful;

        private void DisplayUserInfo()
        {
            if (_currentUser != null)
            {
                lbl_userInfo.Text = $"Welcome, {_currentUser.Name} {_currentUser.Surname}!\n" +
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

        private void PopulateRolesComboBox()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name FROM Role";

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        cmb_roles.DataSource = dataTable;
                        cmb_roles.DisplayMember = "Name";
                        cmb_roles.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to populate roles: {ex.Message}");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb_balance.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float balance))
            {
                MessageBox.Show("Please enter a valid numeric balance.");
                return;
            }
            AddUsr(new AddUser()
            {
                Name = txb_name.Text,
                Surname = txb_surname.Text,
                Email = txt_email.Text,
                Password = txt_password.Text,
                Birthday = dt_birthday.Value,
                RoleId = (int)cmb_roles.SelectedValue,
                Balance = balance
            });

            if (_isRegistrationSuccessful)
            {
                RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
                ClearAddInputs();
            }
        }

        private void AddUsr(AddUser model)
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "insert into [User] (Name,Surname,Email,Password,Birthday,RoleId,Balance,IsDeleted) values(@Name,@Surname,@Email,@Password,@Birthday,@RoleId,@Balance,@IsDeleted)";

                    cmd.Parameters.Add(new SqlParameter("@Name", model.Name));
                    cmd.Parameters.Add(new SqlParameter("@Surname", model.Surname));
                    cmd.Parameters.Add(new SqlParameter("@Email", model.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", model.Password));
                    cmd.Parameters.Add(new SqlParameter("@Birthday", model.Birthday));
                    cmd.Parameters.Add(new SqlParameter("@RoleId", model.RoleId));
                    cmd.Parameters.Add(new SqlParameter("@Balance", model.Balance));
                    cmd.Parameters.Add(new SqlParameter("@IsDeleted", false)) ;

                    MessageBox.Show($"User '{model.Name} {model.Surname}' successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isRegistrationSuccessful = true;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAddInputs()
        {
            txb_name.Text = "";
            txb_surname.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            dt_birthday.Value = DateTime.Now;
            cmb_roles.SelectedIndex = 0;
            txb_balance.Text = "";
        }
    }
}