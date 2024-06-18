using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class Shop : Form
    {
        private EditUser _currentUser;

        public Shop(EditUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            DisplayAllProducts();
            DisplayUserInfo();
        }

        private void DisplayUserInfo()
        {
            lbl_info.Text = $"User: {_currentUser.Name} {_currentUser.Surname}\n" +
                                $"Email: {_currentUser.Email}\n" +
                                $"Balance: {_currentUser.Balance} AZN\n" +
                                $"Birthday: {_currentUser.Birthday.ToShortDateString()}";
        }

        private void DisplayAllProducts()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"SELECT p.Id, p.Name, c.Name AS CategoryName, p.Price, p.Count
                                        FROM [Product] p 
                                        JOIN [Category] c ON p.CategoryId = c.Id
                                        WHERE p.IsDeleted = 0 AND p.Count != 0";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    shop_data_grid.DataSource = dataTable;
                    shop_data_grid.MultiSelect = false;
                    shop_data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    shop_data_grid.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (shop_data_grid.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)shop_data_grid.SelectedRows[0].Cells["Id"].Value;
                float selectedProductPrice = Convert.ToSingle(shop_data_grid.SelectedRows[0].Cells["Price"].Value);
                double availableCount = Convert.ToDouble(shop_data_grid.SelectedRows[0].Cells["Count"].Value);

                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the quantity you want to buy:", "Purchase Quantity", "1");
                if (int.TryParse(input, out int purchaseCount) && purchaseCount > 0)
                {
                    if (purchaseCount > availableCount)
                    {
                        MessageBox.Show("Not enough stock available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    float totalCost = purchaseCount * selectedProductPrice;

                    if (_currentUser.Balance >= totalCost)
                    {
                        using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                        {
                            connection.Open();

                            using (var transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    _currentUser.Balance -= totalCost;
                                    var updateUserCmd = connection.CreateCommand();
                                    updateUserCmd.Transaction = transaction;
                                    updateUserCmd.CommandText = @"UPDATE [User] SET Balance = @Balance WHERE Id = @UserId";
                                    updateUserCmd.Parameters.AddWithValue("@Balance", _currentUser.Balance);
                                    updateUserCmd.Parameters.AddWithValue("@UserId", _currentUser.Id);
                                    updateUserCmd.ExecuteNonQuery();

                                    var updateProductCmd = connection.CreateCommand();
                                    updateProductCmd.Transaction = transaction;

                                    updateProductCmd.CommandText = @"UPDATE [Product] SET Count = Count - @PurchaseCount WHERE Id = @ProductId";
                                    updateProductCmd.Parameters.AddWithValue("@PurchaseCount", purchaseCount);
                                    updateProductCmd.Parameters.AddWithValue("@ProductId", selectedProductId);
                                    updateProductCmd.ExecuteNonQuery();


                                    transaction.Commit();

                                    MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AddToCart(_currentUser.Id, selectedProductId, purchaseCount);


                                    DisplayAllProducts();
                                    DisplayUserInfo();
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Purchase failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Insufficient balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to buy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToCart(int userId, int productId, int count)
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"INSERT INTO Cart (UserId, ProductId, Count) VALUES (@UserId, @ProductId, @Count)";
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Count", count);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add product to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
