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
    public partial class OrderManagementForm : Form
    {
        private int selectedOrderId = 0;
        private int editingOrderDetailIndex = -1;
        private DataTable orderItemsTable;

        public OrderManagementForm()
        {
            InitializeComponent();
            InitializeOrderItemsTable();
            LoadCategories();
            LoadAllOrders();
            SetupDataGridViews();
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            btnAddToOrder.Click += btnAddToOrder_Click;
            btnRemoveItem.Click += btnRemoveItem_Click;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            btnClear.Click += btnClear_Click;
            dgvAllOrders.CellDoubleClick += DgvAllOrders_CellDoubleClick;
            dgvAllOrders.SelectionChanged += DgvAllOrders_SelectionChanged;
            dgvOrderItems.CellDoubleClick += DgvOrderItems_CellDoubleClick;
            ApplyModernTheme();
        }


        private void InitializeOrderItemsTable()
        {
            orderItemsTable = new DataTable();
            orderItemsTable.Columns.Add("ProductId", typeof(int));
            orderItemsTable.Columns.Add("ProductName", typeof(string));
            orderItemsTable.Columns.Add("OrderQuantity", typeof(int));
            orderItemsTable.Columns.Add("Unit", typeof(string));
            orderItemsTable.Columns.Add("UnitPrice", typeof(decimal));
            orderItemsTable.Columns.Add("Amount", typeof(decimal));
            orderItemsTable.Columns.Add("AvailableQuantity", typeof(int));
            orderItemsTable.Columns.Add("ProductCategoryId", typeof(int));

            dgvOrderItems.DataSource = orderItemsTable;
        }

        private void SetupDataGridViews()
        {
            // Setup Order Items Grid
            dgvOrderItems.AutoGenerateColumns = true;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.ReadOnly = true;

            // Setup All Orders Grid
            dgvAllOrders.AutoGenerateColumns = true;
            dgvAllOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllOrders.MultiSelect = false;
            dgvAllOrders.AllowUserToAddRows = false;
            dgvAllOrders.ReadOnly = true;
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
                MessageBox.Show("Error loading categories: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadProducts(int categoryId)
        {
            try
            {
                string query = @"SELECT ProductId, ProductName, Unit, UnitPrice, AvailableQuantity 
                                FROM Product 
                                WHERE ProductCategoryId = @CategoryId";

                SqlParameter[] parameters = {
                    new SqlParameter("@CategoryId", categoryId)
                };

                DataTable dt = DBHelpers.ExecuteDataTable(query, parameters);

                cmbProduct.DataSource = dt;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductId";
                cmbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CalculateAmount()
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price) &&
                int.TryParse(txtQuantity.Text, out int quantity))
            {
                decimal amount = price * quantity;
                txtAmount.Text = amount.ToString("F2");
            }
            else
            {
                txtAmount.Text = "0.00";
            }
        }


        private void LoadAllOrders()
        {
            try
            {
                string query = @"SELECT o.OrderId, c.CustomerName, c.ContactNumber, 
                                o.OrderDate, o.TotalAmount, c.CustomerId
                                FROM Orders o
                                INNER JOIN Customer c ON o.CustomerId = c.CustomerId
                                ORDER BY o.OrderDate DESC";

                DataTable dt = DBHelpers.ExecuteDataTable(query);
                dgvAllOrders.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int SaveCustomer(SqlConnection conn, SqlTransaction transaction)
        {
            int customerId = 0;

            // Check if customer exists
            string checkQuery = @"SELECT CustomerId FROM Customer 
                                 WHERE ContactNumber = @ContactNumber";

            SqlParameter[] checkParams = {
                new SqlParameter("@ContactNumber", txtContactNumber.Text.Trim())
            };

            using (SqlCommand cmd = new SqlCommand(checkQuery, conn, transaction))
            {
                cmd.Parameters.AddRange(checkParams);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    customerId = Convert.ToInt32(result);

                    // Update customer info
                    string updateQuery = @"UPDATE Customer 
                                          SET CustomerName = @Name, ContactAddress = @Address 
                                          WHERE CustomerId = @Id";

                    SqlParameter[] updateParams = {
                        new SqlParameter("@Name", txtCustomerName.Text.Trim()),
                        new SqlParameter("@Address", txtAddress.Text.Trim()),
                        new SqlParameter("@Id", customerId)
                    };

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                    {
                        updateCmd.Parameters.AddRange(updateParams);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Insert new customer
                    string insertQuery = @"INSERT INTO Customer (CustomerName, ContactNumber, ContactAddress) 
                                          VALUES (@Name, @Contact, @Address); 
                                          SELECT SCOPE_IDENTITY();";

                    SqlParameter[] insertParams = {
                        new SqlParameter("@Name", txtCustomerName.Text.Trim()),
                        new SqlParameter("@Contact", txtContactNumber.Text.Trim()),
                        new SqlParameter("@Address", txtAddress.Text.Trim())
                    };

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                    {
                        insertCmd.Parameters.AddRange(insertParams);
                        customerId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }
                }
            }

            return customerId;
        }



        private int InsertOrder(int customerId, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"INSERT INTO Orders (CustomerId, TotalAmount) 
                            VALUES (@CustomerId, @TotalAmount); 
                            SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId),
                new SqlParameter("@TotalAmount", decimal.Parse(txtTotalAmount.Text))
            };

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddRange(parameters);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }


        private void UpdateOrder(int orderId, int customerId, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"UPDATE Orders 
                            SET CustomerId = @CustomerId, TotalAmount = @TotalAmount 
                            WHERE OrderId = @OrderId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId),
                new SqlParameter("@TotalAmount", decimal.Parse(txtTotalAmount.Text)),
                new SqlParameter("@OrderId", orderId)
            };

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }


        private void InsertOrderDetails(int orderId, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"INSERT INTO OrderDetails (OrderId, ProductId, OrderQuantity, UnitPrice, Amount) 
                            VALUES (@OrderId, @ProductId, @Quantity, @UnitPrice, @Amount)";

            foreach (DataRow row in orderItemsTable.Rows)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@OrderId", orderId),
                    new SqlParameter("@ProductId", row["ProductId"]),
                    new SqlParameter("@Quantity", row["OrderQuantity"]),
                    new SqlParameter("@UnitPrice", row["UnitPrice"]),
                    new SqlParameter("@Amount", row["Amount"])
                };

                using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void DeleteOrderDetails(int orderId, SqlConnection conn, SqlTransaction transaction)
        {
            string query = "DELETE FROM OrderDetails WHERE OrderId = @OrderId";

            SqlParameter[] parameters = {
                new SqlParameter("@OrderId", orderId)
            };

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }


        private void UpdateProductQuantities(SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"UPDATE Product 
                            SET AvailableQuantity = AvailableQuantity - @Quantity 
                            WHERE ProductId = @ProductId";

            foreach (DataRow row in orderItemsTable.Rows)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@Quantity", row["OrderQuantity"]),
                    new SqlParameter("@ProductId", row["ProductId"])
                };

                using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void RestoreProductQuantities(int orderId, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"UPDATE Product 
                            SET AvailableQuantity = AvailableQuantity + od.OrderQuantity
                            FROM Product p
                            INNER JOIN OrderDetails od ON p.ProductId = od.ProductId
                            WHERE od.OrderId = @OrderId";

            SqlParameter[] parameters = {
                new SqlParameter("@OrderId", orderId)
            };

            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadOrderForEdit(int orderId)
        {
            try
            {
                selectedOrderId = orderId;
                // Load Customer Information
                string customerQuery = @"SELECT c.CustomerName, c.ContactNumber, c.ContactAddress, c.CustomerId
                                        FROM Orders o
                                        INNER JOIN Customer c ON o.CustomerId = c.CustomerId
                                        WHERE o.OrderId = @OrderId";

                SqlParameter[] customerParams = {
                    new SqlParameter("@OrderId", orderId)
                };

                DataTable customerDt = DBHelpers.ExecuteDataTable(customerQuery, customerParams);

                if (customerDt.Rows.Count > 0)
                {
                    txtCustomerName.Text = customerDt.Rows[0]["CustomerName"].ToString();
                    txtContactNumber.Text = customerDt.Rows[0]["ContactNumber"].ToString();
                    txtAddress.Text = customerDt.Rows[0]["ContactAddress"].ToString();
                }

                // Load Order Details
                string detailsQuery = @"SELECT od.ProductId, p.ProductName, od.OrderQuantity, 
                                       p.Unit, od.UnitPrice, od.Amount, 
                                       (p.AvailableQuantity + od.OrderQuantity) as AvailableQuantity,
                                       p.ProductCategoryId
                                       FROM OrderDetails od
                                       INNER JOIN Product p ON od.ProductId = p.ProductId
                                       WHERE od.OrderId = @OrderId";

                SqlParameter[] detailsParams = {
                    new SqlParameter("@OrderId", orderId)
                };

                DataTable detailsDt = DBHelpers.ExecuteDataTable(detailsQuery, detailsParams);

                orderItemsTable.Clear();
                foreach (DataRow row in detailsDt.Rows)
                {
                    orderItemsTable.Rows.Add(
                        row["ProductId"],
                        row["ProductName"],
                        row["OrderQuantity"],
                        row["Unit"],
                        row["UnitPrice"],
                        row["Amount"],
                        row["AvailableQuantity"],
                        row["ProductCategoryId"]);
                }

                UpdateTotalAmount();
                btnPlaceOrder.Text = "Update Order";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateOrder()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter customer name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Please enter contact number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product to the order", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private bool ValidateProductInput()
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter valid quantity", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check available quantity
            DataRowView selectedProduct = (DataRowView)cmbProduct.SelectedItem;
            int availableQty = Convert.ToInt32(selectedProduct["AvailableQuantity"]);

            if (quantity > availableQty)
            {
                MessageBox.Show($"Order quantity ({quantity}) exceeds available quantity ({availableQty})!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataRow row in orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["Amount"]);
            }
            txtTotalAmount.Text = total.ToString("F2");
        }


        private void ClearProductFields()
        {
            cmbCategory.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Clear();
            txtUnit.Clear();
            txtUnitPrice.Clear();
            txtAmount.Clear();
            lblAvailableQty.Text = "Available: 0";
            editingOrderDetailIndex = -1;
            btnAddToOrder.Text = "Add to Order";
        }

        private void ClearCustomerFields()
        {
            txtCustomerName.Clear();
            txtContactNumber.Clear();
            txtAddress.Clear();
        }

        private void ClearAll()
        {
            ClearCustomerFields();
            ClearProductFields();
            orderItemsTable.Clear();
            txtTotalAmount.Text = "0.00";
            selectedOrderId = 0;
            btnPlaceOrder.Text = "Place Order";
        }





        private void OrderManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != -1)
            {
                LoadProducts(Convert.ToInt32(cmbCategory.SelectedValue));
            }
            else
            {
                cmbProduct.DataSource = null;
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)cmbProduct.SelectedItem;
                txtUnit.Text = row["Unit"].ToString();
                txtUnitPrice.Text = row["UnitPrice"].ToString();
                lblAvailableQty.Text = "Available: " + row["AvailableQuantity"].ToString();

                // Auto calculate amount when quantity is entered
                CalculateAmount();
            }
            else
            {
                txtUnit.Text = "";
                txtUnitPrice.Text = "";
                lblAvailableQty.Text = "Available: 0";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInput())
                return;

            try
            {
                DataRowView selectedProduct = (DataRowView)cmbProduct.SelectedItem;
                int productId = Convert.ToInt32(selectedProduct["ProductId"]);
                string productName = selectedProduct["ProductName"].ToString();
                int availableQty = Convert.ToInt32(selectedProduct["AvailableQuantity"]);
                int orderQty = int.Parse(txtQuantity.Text);
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                decimal amount = decimal.Parse(txtAmount.Text);
                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                if (editingOrderDetailIndex >= 0)
                {
                    DataRow editingRow = orderItemsTable.Rows[editingOrderDetailIndex];

                    if (orderQty > availableQty)
                    {
                        MessageBox.Show($"Quantity should not exceed available quantity ({availableQty}).",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    editingRow["ProductId"] = productId;
                    editingRow["ProductName"] = productName;
                    editingRow["OrderQuantity"] = orderQty;
                    editingRow["Unit"] = txtUnit.Text;
                    editingRow["UnitPrice"] = unitPrice;
                    editingRow["Amount"] = amount;
                    editingRow["AvailableQuantity"] = availableQty;
                    editingRow["ProductCategoryId"] = categoryId;
                    btnAddToOrder.Text = "Add to Order";
                    editingOrderDetailIndex = -1;
                }
                else
                {
                    // Check if product already exists in order
                    DataRow[] existingRows = orderItemsTable.Select($"ProductId = {productId}");

                    if (existingRows.Length > 0)
                    {
                        // Update existing item
                        int currentQty = Convert.ToInt32(existingRows[0]["OrderQuantity"]);
                        int newQty = currentQty + orderQty;

                        if (newQty > availableQty)
                        {
                            MessageBox.Show($"Total quantity ({newQty}) exceeds available quantity ({availableQty})!",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        existingRows[0]["OrderQuantity"] = newQty;
                        existingRows[0]["Amount"] = newQty * unitPrice;
                        existingRows[0]["ProductCategoryId"] = categoryId;
                        existingRows[0]["AvailableQuantity"] = availableQty;
                    }
                    else
                    {
                        // Add new item
                        DataRow row = orderItemsTable.NewRow();
                        row["ProductId"] = productId;
                        row["ProductName"] = productName;
                        row["OrderQuantity"] = orderQty;
                        row["Unit"] = txtUnit.Text;
                        row["UnitPrice"] = unitPrice;
                        row["Amount"] = amount;
                        row["AvailableQuantity"] = availableQty;
                        row["ProductCategoryId"] = categoryId;
                        orderItemsTable.Rows.Add(row);
                    }
                }

                UpdateTotalAmount();
                ClearProductFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Remove this item from order?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvOrderItems.Rows.RemoveAt(dgvOrderItems.SelectedRows[0].Index);
                    UpdateTotalAmount();
                    editingOrderDetailIndex = -1;
                    btnAddToOrder.Text = "Add to Order";
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(DBHelpers.GetConnectionString()))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Step 1: Insert or Update Customer
                        int customerId = SaveCustomer(conn, transaction);

                        if (selectedOrderId == 0)
                        {
                            // New Order
                            // Step 2: Insert Order
                            int orderId = InsertOrder(customerId, conn, transaction);

                            // Step 3: Insert Order Details
                            InsertOrderDetails(orderId, conn, transaction);

                            // Step 4: Update Product Quantities
                            UpdateProductQuantities(conn, transaction);

                            transaction.Commit();
                            MessageBox.Show("Order placed successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Update Existing Order
                            // Step 1: Restore old quantities
                            RestoreProductQuantities(selectedOrderId, conn, transaction);

                            // Step 2: Delete old order details
                            DeleteOrderDetails(selectedOrderId, conn, transaction);

                            // Step 3: Update order
                            UpdateOrder(selectedOrderId, customerId, conn, transaction);

                            // Step 4: Insert new order details
                            InsertOrderDetails(selectedOrderId, conn, transaction);

                            // Step 5: Update product quantities with new values
                            UpdateProductQuantities(conn, transaction);

                            transaction.Commit();
                            MessageBox.Show("Order updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        ClearAll();
                        LoadAllOrders();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Transaction failed: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            if (selectedOrderId == 0)
            {
                MessageBox.Show("Please select an order to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this order? Product quantities will be restored.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DBHelpers.GetConnectionString()))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Restore product quantities
                            RestoreProductQuantities(selectedOrderId, conn, transaction);

                            // Delete order (OrderDetails will be deleted automatically due to CASCADE)
                            string query = "DELETE FROM Orders WHERE OrderId = @OrderId";

                            SqlParameter[] parameters = {
                                new SqlParameter("@OrderId", selectedOrderId)
                            };

                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                cmd.Parameters.AddRange(parameters);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Order deleted successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearAll();
                            LoadAllOrders();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Transaction failed: " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting order: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvAllOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAllOrders.Rows.Count > e.RowIndex)
            {
                selectedOrderId = Convert.ToInt32(dgvAllOrders.Rows[e.RowIndex].Cells["OrderId"].Value);
                LoadOrderForEdit(selectedOrderId);
            }
        }

        private void DgvAllOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAllOrders.SelectedRows.Count > 0)
            {
                selectedOrderId = Convert.ToInt32(dgvAllOrders.SelectedRows[0].Cells["OrderId"].Value);
            }
        }

        private void DgvOrderItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrderItems.Rows.Count > e.RowIndex)
            {
                DataRowView rowView = dgvOrderItems.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (rowView == null)
                {
                    return;
                }

                DataRow row = rowView.Row;
                editingOrderDetailIndex = e.RowIndex;
                btnAddToOrder.Text = "Update Item";

                int categoryId = Convert.ToInt32(row["ProductCategoryId"]);
                cmbCategory.SelectedValue = categoryId;
                LoadProducts(categoryId);
                cmbProduct.SelectedValue = Convert.ToInt32(row["ProductId"]);

                txtQuantity.Text = row["OrderQuantity"].ToString();
                txtUnit.Text = row["Unit"].ToString();
                txtUnitPrice.Text = row["UnitPrice"].ToString();
                txtAmount.Text = row["Amount"].ToString();
                lblAvailableQty.Text = "Available: " + row["AvailableQuantity"];
            }
        }

        private void ApplyModernTheme()
        {
            BackColor = Color.FromArgb(13, 20, 38);
            Color panelColor = Color.FromArgb(24, 32, 54);
            Color inputBackColor = Color.FromArgb(15, 23, 42);
            Color inputForeColor = Color.White;
            Color labelForeColor = Color.Gainsboro;

            StyleGroupBox(grpCustomer, panelColor);
            StyleGroupBox(grpProduct, panelColor);
            StyleGroupBox(grpOrderItems, panelColor);
            StyleGroupBox(grpAllOrders, panelColor);

            StyleButton(btnPlaceOrder, Color.FromArgb(16, 185, 129));
            StyleButton(btnDeleteOrder, Color.FromArgb(239, 68, 68));
            StyleButton(btnClear, Color.FromArgb(59, 130, 246));
            StyleButton(btnAddToOrder, Color.FromArgb(59, 130, 246));
            StyleButton(btnRemoveItem, Color.FromArgb(248, 113, 113));

            StyleGrid(dgvOrderItems);
            StyleGrid(dgvAllOrders);

            StyleInputsRecursive(this, inputBackColor, inputForeColor, labelForeColor);
            txtTotalAmount.BackColor = inputBackColor;
            txtTotalAmount.ForeColor = inputForeColor;
            label10.ForeColor = inputForeColor;
        }

        private void StyleInputsRecursive(Control parent, Color inputBackColor, Color inputForeColor, Color labelForeColor)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = labelForeColor;
                    lbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor = inputBackColor;
                    tb.ForeColor = inputForeColor;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }
                else if (c is ComboBox cb)
                {
                    cb.BackColor = inputBackColor;
                    cb.ForeColor = inputForeColor;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }

                if (c.HasChildren)
                {
                    StyleInputsRecursive(c, inputBackColor, inputForeColor, labelForeColor);
                }
            }
        }

        private void StyleGroupBox(GroupBox groupBox, Color backgroundColor)
        {
            groupBox.BackColor = backgroundColor;
            groupBox.ForeColor = Color.White;
            groupBox.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
        }

        private void StyleButton(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
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
