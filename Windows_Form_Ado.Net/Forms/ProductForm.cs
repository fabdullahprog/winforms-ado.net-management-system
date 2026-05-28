using MyProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Forms
{
    public partial class ProductForm : Form
    {
        private int selectedProductId;
        private string selectedImagePath;
        private string originalImagePath;

        public ProductForm()
        {
            InitializeComponent();
            ApplyModernTheme();
            LoadCategories();
            LoadProducts();
            SetupDataGridView();
            CreateImagesFolder();
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProducts.SelectedRows[0];
                selectedProductId = Convert.ToInt32(row.Cells["ProductId"].Value);
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
                txtUnit.Text = row.Cells["Unit"].Value?.ToString() ?? "";
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells["AvailableQuantity"].Value?.ToString() ?? "";
                
                if (row.Cells["ProductCategoryId"].Value != null)
                {
                    cmbCategory.SelectedValue = row.Cells["ProductCategoryId"].Value;
                }

                string imageName = row.Cells["ProductImage"].Value?.ToString();
                originalImagePath = imageName;
                selectedImagePath = "";

                // Dispose previous image to prevent memory leaks
                if (pbProductImage.Image != null)
                {
                    pbProductImage.Image.Dispose();
                    pbProductImage.Image = null;
                }

                if (!string.IsNullOrEmpty(imageName))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", imageName);
                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            pbProductImage.Image = Image.FromFile(imagePath);
                        }
                        catch
                        {
                            pbProductImage.Image = null;
                        }
                    }
                    else
                    {
                        pbProductImage.Image = null;
                    }
                }
                else
                {
                    pbProductImage.Image = null;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {

        }
        private void CreateImagesFolder()
        {
            string imagesFolder = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }
        }

        private void SetupDataGridView()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT ProductCategoryId, ProductCategoryName FROM ProductCategory";
                DataTable dt = DBHelpers.ExecuteDataTable(query);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "ProductCategoryName";
                cmbCategory.ValueMember = "ProductCategoryId";
                cmbCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                string query = @"SELECT p.ProductId, p.ProductName, p.Unit, p.UnitPrice, 
                                p.AvailableQuantity, p.ProductImage, pc.ProductCategoryName,
                                p.ProductCategoryId
                                FROM Product p
                                INNER JOIN ProductCategory pc ON p.ProductCategoryId = pc.ProductCategoryId";
                DataTable dt = DBHelpers.ExecuteDataTable(query);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveImage(string sourcePath)
        {
            if (string.IsNullOrEmpty(sourcePath))
                return null;

            try
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                string destinationPath = Path.Combine(imagesFolder, uniqueFileName);

                File.Copy(sourcePath, destinationPath, true);

                return uniqueFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void DeleteImage(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
                return;

            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", imageName);
                if (File.Exists(imagePath))
                {
                    File.Delete(imagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting image: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please enter unit", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter valid unit price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter valid quantity", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtUnit.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = -1;
            
            // Dispose image to prevent memory leaks
            if (pbProductImage.Image != null)
            {
                pbProductImage.Image.Dispose();
                pbProductImage.Image = null;
            }
            
            selectedProductId = 0;
            selectedImagePath = "";
            originalImagePath = "";
        }



        private void btnBrowseImage_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Select Product Image";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    
                    // Dispose previous image
                    if (pbProductImage.Image != null)
                    {
                        pbProductImage.Image.Dispose();
                    }
                    
                    try
                    {
                        pbProductImage.Image = Image.FromFile(selectedImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbProductImage.Image = null;
                    }
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                string imageName = SaveImage(selectedImagePath);

                string query = @"INSERT INTO Product (ProductName, Unit, UnitPrice, AvailableQuantity, ProductImage, ProductCategoryId) 
                                    VALUES (@Name, @Unit, @Price, @Quantity, @Image, @CategoryId)";

                SqlParameter[] parameters = {
                        new SqlParameter("@Name", txtProductName.Text.Trim()),
                        new SqlParameter("@Unit", txtUnit.Text.Trim()),
                        new SqlParameter("@Price", decimal.Parse(txtUnitPrice.Text)),
                        new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)),
                        new SqlParameter("@Image", (object)imageName ?? DBNull.Value),
                        new SqlParameter("@CategoryId", cmbCategory.SelectedValue)
                    };

                int result = DBHelpers.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                string imageName = originalImagePath;

                if (!string.IsNullOrEmpty(selectedImagePath) && selectedImagePath != originalImagePath)
                {
                    DeleteImage(originalImagePath);
                    imageName = SaveImage(selectedImagePath);
                }

                string query = @"UPDATE Product SET ProductName = @Name, Unit = @Unit, UnitPrice = @Price, 
                                    AvailableQuantity = @Quantity, ProductImage = @Image, ProductCategoryId = @CategoryId 
                                    WHERE ProductId = @Id";

                SqlParameter[] parameters = {
                        new SqlParameter("@Name", txtProductName.Text.Trim()),
                        new SqlParameter("@Unit", txtUnit.Text.Trim()),
                        new SqlParameter("@Price", decimal.Parse(txtUnitPrice.Text)),
                        new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)),
                        new SqlParameter("@Image", (object)imageName ?? DBNull.Value),
                        new SqlParameter("@CategoryId", cmbCategory.SelectedValue),
                        new SqlParameter("@Id", selectedProductId)
                    };

                int result = DBHelpers.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteImage(originalImagePath);

                    string query = "DELETE FROM Product WHERE ProductId = @Id";
                    SqlParameter[] parameters = {
                        new SqlParameter("@Id", selectedProductId)
                    };

                    int rowsAffected = DBHelpers.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadProducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ApplyModernTheme()
        {
            BackColor = Color.FromArgb(13, 20, 38);
            Color surface = Color.FromArgb(24, 32, 54);
            Color inputBackground = Color.FromArgb(15, 23, 42);

            foreach (Label label in new[] { lblProductCategory, lblProductName, lblUnit, lblUnitPrice, lblQuantity })
            {
                label.ForeColor = Color.White;
                label.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            }

            foreach (TextBox input in new[] { txtProductName, txtUnit, txtUnitPrice, txtQuantity })
            {
                input.BackColor = inputBackground;
                input.ForeColor = Color.White;
                input.BorderStyle = BorderStyle.FixedSingle;
            }

            cmbCategory.BackColor = inputBackground;
            cmbCategory.ForeColor = Color.White;
            cmbCategory.FlatStyle = FlatStyle.Flat;

            pbProductImage.BackColor = surface;

            StyleButton(btnSave, Color.FromArgb(16, 185, 129));
            StyleButton(btnUpdate, Color.FromArgb(59, 130, 246));
            StyleButton(btnDelete, Color.FromArgb(239, 68, 68));
            StyleButton(btnClear, Color.FromArgb(15, 118, 110));
            StyleButton(btnBrowseImage, Color.FromArgb(99, 102, 241));

            StyleGrid(dgvProducts);
        }

        private void StyleButton(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.FromArgb(15, 23, 42);
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Color.FromArgb(24, 32, 54);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
