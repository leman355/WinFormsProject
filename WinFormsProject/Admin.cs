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
            DisplayAllProducts();
        }

        public Admin(GetSUser currentUser) : this()
        {
            _currentUser = currentUser;
            DisplayUserInfo();
            DisplayAllUsers();
            DisplayAllProducts();
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
                    cmd.CommandText = @"SELECT u.Id, u.Name, u.Surname, u.Email, u.Birthday, r.Name AS RoleName, u.Balance, u.IsDeleted 
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

        private void all_users_data_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (all_users_data_grid.SelectedRows.Count > 0)
            {
                btn_SoftDelete.Visible = true;
                btn_HardDelete.Visible = true;
                btn_Edit.Visible = true;
            }
            else
            {
                btn_SoftDelete.Visible = false;
                btn_HardDelete.Visible = false;
                btn_Edit.Visible = false;
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {

            if (all_users_data_grid.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)all_users_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name, Surname, Email, Password, Birthday, RoleId, Balance FROM [User] WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedUserId);

                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();

                                var editUser = new EditUser
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Surname = reader.GetString(2),
                                    Email = reader.GetString(3),
                                    Password = reader.GetString(4),
                                    Birthday = reader.GetDateTime(5),
                                    RoleId = reader.GetInt32(6),
                                    Balance = Convert.ToSingle(reader.GetDouble(7))
                                };

                                using (UserEdit editForm = new UserEdit(editUser))
                                {
                                    if (editForm.ShowDialog() == DialogResult.OK)
                                    {
                                        cmd.CommandText = @"UPDATE [User] SET Name = @Name, Surname = @Surname, Email = @Email, Password = @Password,Birthday = @Birthday, RoleId = @RoleId, Balance = @Balance WHERE Id = @Id";
                                        cmd.Parameters.Clear();
                                        cmd.Parameters.AddWithValue("@Name", editUser.Name);
                                        cmd.Parameters.AddWithValue("@Surname", editUser.Surname);
                                        cmd.Parameters.AddWithValue("@Email", editUser.Email);
                                        cmd.Parameters.AddWithValue("@Password", editUser.Password);
                                        cmd.Parameters.AddWithValue("@Birthday", editUser.Birthday);
                                        cmd.Parameters.AddWithValue("@RoleId", editUser.RoleId);
                                        cmd.Parameters.AddWithValue("@Balance", editUser.Balance);
                                        cmd.Parameters.AddWithValue("@Id", editUser.Id);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                DisplayAllUsers();
                                this.Show();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to retrieve user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SoftDelete_Click(object sender, EventArgs e)
        {
            if (all_users_data_grid.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)all_users_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE [User] SET IsDeleted = 1 WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedUserId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User soft deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check if the user exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DisplayAllUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to soft delete user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to soft delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_HardDelete_Click(object sender, EventArgs e)
        {
            if (all_users_data_grid.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)all_users_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM [User] WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedUserId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User hard deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted. Please check if the user exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DisplayAllUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to hard delete user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to hard delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayAllProducts()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT p.Id, p.Name, c.Name AS CategoryName, p.Price, p.IsDeleted
                                        FROM [Product] p 
                                        JOIN [Category] c ON p.CategoryId = c.Id";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    all_products_data_grid.DataSource = dataTable;
                    all_products_data_grid.MultiSelect = false;
                    all_products_data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    all_products_data_grid.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ProductAdd productAddForm = new ProductAdd())
            {
                productAddForm.ShowDialog();
            }
            DisplayAllProducts();
            this.Show();

        }

        private void all_products_data_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (all_products_data_grid.SelectedRows.Count > 0)
            {
                btn_product_edit.Visible = true;
                btn_product_soft_delete.Visible = true;
                btn_product_hard_delete.Visible = true;
            }
            else
            {
                btn_product_edit.Visible = false;
                btn_product_soft_delete.Visible = false;
                btn_product_hard_delete.Visible = false;
            }
        }

        private void btn_product_edit_Click(object sender, EventArgs e)
        {
            if (all_products_data_grid.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)all_products_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name, CategoryId, Price FROM Product WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedProductId);

                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();

                                var editProduct = new EditProduct
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    CategoryId = reader.GetInt32(2),
                                    Price = Convert.ToSingle(reader.GetDouble(3))
                                };

                                using (ProductEdit editForm = new ProductEdit(editProduct))
                                {
                                    if (editForm.ShowDialog() == DialogResult.OK)
                                    {
                                        cmd.CommandText = @"UPDATE Product SET Name = @Name, CategoryId = @CategoryId, Price = @Price WHERE Id = @Id";
                                        cmd.Parameters.Clear();
                                        cmd.Parameters.AddWithValue("@Name", editProduct.Name);
                                        cmd.Parameters.AddWithValue("@CategoryId", editProduct.CategoryId);
                                        cmd.Parameters.AddWithValue("@Price", editProduct.Price);
                                        cmd.Parameters.AddWithValue("@Id", editProduct.Id);

                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                                DisplayAllProducts();
                                this.Show();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to retrieve product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_product_soft_delete_Click(object sender, EventArgs e)
        {
            if (all_products_data_grid.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)all_products_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE Product SET IsDeleted = 1 WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedProductId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product soft deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check if the product exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DisplayAllProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to soft delete product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to soft delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_product_hard_delete_Click(object sender, EventArgs e)
        {
            if (all_products_data_grid.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)all_products_data_grid.SelectedRows[0].Cells["Id"].Value;

                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM Product WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", selectedProductId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product hard deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were deleted. Please check if the product exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DisplayAllProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to hard delete product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to hard delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
