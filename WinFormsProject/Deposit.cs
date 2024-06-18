using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class Deposit : Form
    {
        private EditUser _editUser;

        public Deposit(EditUser editUser)
        {
            InitializeComponent();
            _editUser = editUser;
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            lbl_userInfo.Text = $"User: {_editUser.Name} {_editUser.Surname}\n" +
                                $"Email: {_editUser.Email}\n" +
                                $"Balance: {_editUser.Balance} AZN\n" +
                                $"Birthday: {_editUser.Birthday.ToShortDateString()}";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txb_add_balance.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float depositAmount) && depositAmount > 0)
            {
                _editUser.Balance += depositAmount;

                DisplayUserInfo();

                UpdateUserBalanceInDatabase(_editUser.Id, _editUser.Balance);

                MessageBox.Show($"Deposit of {depositAmount} AZN added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric deposit amount greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateUserBalanceInDatabase(int userId, float balance)
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"UPDATE [User] 
                                SET Balance = @Balance 
                                WHERE Id = @UserId";

                    cmd.Parameters.Add(new SqlParameter("@UserId", userId));
                    cmd.Parameters.Add(new SqlParameter("@Balance", balance));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
