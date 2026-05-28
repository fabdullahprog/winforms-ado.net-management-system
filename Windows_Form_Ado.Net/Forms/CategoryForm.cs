using MyProject.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Forms
{
    public partial class CategoryForm : Form
    {
        private int selectedCategoryId = 0;

        public CategoryForm()
        {
            InitializeComponent();
            ApplyModernTheme();
            SetupDataGridView();
            LoadCategories();
            dgvCategories.SelectionChanged += DgvCategories_SelectionChanged;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void SetupDataGridView()
        {
            dgvCategories.AutoGenerateColumns = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.MultiSelect = false;
            dgvCategories.AllowUserToAddRows = false;
        }

        private void LoadCategories()
        {
            try
            {
                string query = "SELECT ProductCategoryId, ProductCategoryName, ProductCategoryDescription FROM ProductCategory";
                DataTable dt = DBHelpers.ExecuteDataTable(query);
                dgvCategories.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCategories.SelectedRows[0];
                selectedCategoryId = Convert.ToInt32(row.Cells["ProductCategoryId"].Value);
                txtCategoryName.Text = row.Cells["ProductCategoryName"].Value?.ToString() ?? "";
                txtDuration.Text = row.Cells["ProductCategoryDescription"].Value?.ToString() ?? "";
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter category name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtCategoryName.Clear();
            txtDuration.Clear();
            selectedCategoryId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                string query = @"INSERT INTO ProductCategory (ProductCategoryName, ProductCategoryDescription) 
                                    VALUES (@Name, @Description)";

                SqlParameter[] parameters = {
                    new SqlParameter("@Name", txtCategoryName.Text.Trim()),
                    new SqlParameter("@Description", string.IsNullOrWhiteSpace(txtDuration.Text) ? (object)DBNull.Value : txtDuration.Text.Trim())
                };

                int result = DBHelpers.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Category saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                string query = @"UPDATE ProductCategory SET ProductCategoryName = @Name, 
                                    ProductCategoryDescription = @Description 
                                    WHERE ProductCategoryId = @Id";

                SqlParameter[] parameters = {
                    new SqlParameter("@Name", txtCategoryName.Text.Trim()),
                    new SqlParameter("@Description", string.IsNullOrWhiteSpace(txtDuration.Text) ? (object)DBNull.Value : txtDuration.Text.Trim()),
                    new SqlParameter("@Id", selectedCategoryId)
                };

                int result = DBHelpers.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM ProductCategory WHERE ProductCategoryId = @Id";
                    SqlParameter[] parameters = {
                        new SqlParameter("@Id", selectedCategoryId)
                    };

                    int rowsAffected = DBHelpers.ExecuteNonQuery(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadCategories();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ApplyModernTheme()
        {
            BackColor = Color.FromArgb(13, 20, 38);
            Color inputBackground = Color.FromArgb(15, 23, 42);

            foreach (Label label in new[] { lblCategoryName, lblCategoryDescription })
            {
                label.ForeColor = Color.White;
                label.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            }

            foreach (TextBox input in new[] { txtCategoryName, txtDuration })
            {
                input.BackColor = inputBackground;
                input.ForeColor = Color.White;
                input.BorderStyle = BorderStyle.FixedSingle;
            }

            StyleButton(btnSave, Color.FromArgb(16, 185, 129));
            StyleButton(btnUpdate, Color.FromArgb(59, 130, 246));
            StyleButton(btnDelete, Color.FromArgb(239, 68, 68));

            StyleGrid(dgvCategories);
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
