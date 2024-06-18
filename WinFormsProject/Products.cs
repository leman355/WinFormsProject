using System.Data;
using System.Data.SqlClient;
using WinFormsProject.Entities;


namespace WinFormsProject
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            DisplayAllProducts();
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
