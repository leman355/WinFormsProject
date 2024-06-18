using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class ProductAdd : Form
    {
        public event EventHandler ProductAdded;

        public ProductAdd()
        {
            InitializeComponent();
            PopulateCategoriesComboBox();
        }

        private void PopulateCategoriesComboBox()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name FROM Category";

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        cmb_categories.DataSource = dataTable;
                        cmb_categories.DisplayMember = "Name";
                        cmb_categories.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to populate categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txb_price.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float price))
            {
                MessageBox.Show("Please enter a valid numeric price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddProduct(new AddProduct
            {
                Name = txb_product_name.Text,
                CategoryId = (int)cmb_categories.SelectedValue,
                Price = price
            });
        }

        private void AddProduct(AddProduct model)
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Product] (Name, CategoryId, Price, IsDeleted) VALUES (@Name, @CategoryId, @Price, @IsDeleted)";
                    cmd.Parameters.AddWithValue("@Name", model.Name);
                    cmd.Parameters.AddWithValue("@CategoryId", model.CategoryId);
                    cmd.Parameters.AddWithValue("@Price", model.Price);
                    cmd.Parameters.AddWithValue("@IsDeleted", false);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Product '{model.Name}' successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ProductAdded?.Invoke(this, EventArgs.Empty);
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product. No rows affected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txb_product_name.Text = "";
            cmb_categories.SelectedIndex = 0;
            txb_price.Text = "";
        }
    }
}
