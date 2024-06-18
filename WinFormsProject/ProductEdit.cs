using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using WinFormsProject.Entities;

namespace WinFormsProject
{
    public partial class ProductEdit : Form
    {
        private EditProduct _editProduct;

        public ProductEdit(EditProduct editProduct)
        {
            InitializeComponent();
            _editProduct = editProduct;
            PopulateCategories();
            DisplayProductData();
        }

        private void PopulateCategories()
        {
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT Id, Name FROM Category";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable categoriesTable = new DataTable();
                    adapter.Fill(categoriesTable);

                    cmb_categories.DisplayMember = "Name";
                    cmb_categories.ValueMember = "Id";
                    cmb_categories.DataSource = categoriesTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayProductData()
        {
            txb_product_name.Text = _editProduct.Name;
            cmb_categories.SelectedValue = _editProduct.CategoryId;
            txb_price.Text = _editProduct.Price.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void btn_edit_product_Click(object sender, EventArgs e)
        {
            _editProduct.Name = txb_product_name.Text;
            _editProduct.CategoryId = (int)cmb_categories.SelectedValue;

            if (float.TryParse(txb_price.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float price))
            {
                _editProduct.Price = price; 
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var connection = new SqlConnection("Server=WIN-OO1ICO19G9E;Database=WindowsFormsDb;Trusted_Connection=True;"))
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();
                    cmd.CommandText = @"UPDATE Product 
                                        SET Name = @Name, CategoryId = @CategoryId, Price = @Price WHERE Id = @ProductId";
                    cmd.Parameters.Add(new SqlParameter("@ProductId", _editProduct.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", _editProduct.Name));
                    cmd.Parameters.Add(new SqlParameter("@CategoryId", _editProduct.CategoryId));
                    cmd.Parameters.Add(new SqlParameter("@Price", _editProduct.Price));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Product '{_editProduct.Name}' successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
