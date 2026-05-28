using MyProject.DataAccess;
using MyProject.Forms;
using MyProject.Report;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject
{
    public partial class MainForm : Form
    {
        private readonly Color[] statAccentColors = new[]
        {
            Color.FromArgb(59, 130, 246),
            Color.FromArgb(16, 185, 129),
            Color.FromArgb(248, 113, 113),
            Color.FromArgb(250, 204, 21)
        };

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyMenuTheme();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                LoadQuickStats();
                LoadTopProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dashboard failed to load: {ex.Message}", "Dashboard",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuickStats()
        {
            int categoryCount = SafeToInt(DBHelpers.ExecuteScalar("SELECT COUNT(*) FROM ProductCategory"));
            int productCount = SafeToInt(DBHelpers.ExecuteScalar("SELECT COUNT(*) FROM Product"));
            int pendingOrders = SafeToInt(DBHelpers.ExecuteScalar("SELECT COUNT(*) FROM Orders"));
            int lowStock = SafeToInt(DBHelpers.ExecuteScalar("SELECT COUNT(*) FROM Product WHERE AvailableQuantity <= 5"));

            var statCards = new (string Title, string Value, string Subtitle)[]
            {
                ("Categories", categoryCount.ToString("N0"), "Active categories"),
                ("Products", productCount.ToString("N0"), "SKUs in catalog"),
                ("Orders", pendingOrders.ToString("N0"), "Orders recorded"),
                ("Low Stock", lowStock.ToString("N0"), "Need attention")
            };

            flpQuickStats.SuspendLayout();
            flpQuickStats.Controls.Clear();

            for (int i = 0; i < statCards.Length; i++)
            {
                var card = CreateStatCard(statCards[i].Title, statCards[i].Value, statCards[i].Subtitle,
                    statAccentColors[i % statAccentColors.Length]);
                flpQuickStats.Controls.Add(card);
            }

            flpQuickStats.ResumeLayout();
        }

        private void LoadTopProducts()
        {
            string query = @"SELECT TOP 6 p.ProductName, pc.ProductCategoryName, p.UnitPrice, 
                             p.AvailableQuantity, p.Unit
                             FROM Product p
                             INNER JOIN ProductCategory pc ON p.ProductCategoryId = pc.ProductCategoryId
                             ORDER BY p.AvailableQuantity DESC";

            DataTable products = DBHelpers.ExecuteDataTable(query);

            //flpTopProducts.SuspendLayout();
            //flpTopProducts.Controls.Clear();

            if (products.Rows.Count == 0)
            {
                //flpTopProducts.Controls.Add(CreateEmptyStateCard());
            }
            else
            {
                foreach (DataRow row in products.Rows)
                {
                    //flpTopProducts.Controls.Add(CreateProductCard(
                        //row["ProductName"].ToString(),
                        //row["ProductCategoryName"].ToString(),
                        //Convert.ToDecimal(row["UnitPrice"]),
                        //Convert.ToInt32(row["AvailableQuantity"]),
                        //row["Unit"].ToString()));
                }
            }

            //flpTopProducts.ResumeLayout();
        }

        private Control CreateStatCard(string title, string value, string subtitle, Color accentColor)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 120,
                BackColor = Color.FromArgb(30, 41, 59),
                Margin = new Padding(10),
                Padding = new Padding(0),
                BorderStyle = BorderStyle.None
            };

            Panel accent = new Panel
            {
                BackColor = accentColor,
                Dock = DockStyle.Left,
                Width = 6
            };

            Panel content = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(18, 14, 14, 14),
                BackColor = Color.Transparent
            };

            Label lblTitle = new Label
            {
                Text = title.ToUpperInvariant(),
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(4, 4)
            };

            Label lblValue = new Label
            {
                Text = value,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(2, 36)
            };

            Label lblSubtitle = new Label
            {
                Text = subtitle,
                ForeColor = Color.FromArgb(186, 197, 216),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(4, 86)
            };

            content.Controls.Add(lblSubtitle);
            content.Controls.Add(lblValue);
            content.Controls.Add(lblTitle);

            card.Controls.Add(content);
            card.Controls.Add(accent);

            return card;
        }

        private Control CreateProductCard(string productName, string category, decimal unitPrice, int availableQty, string unit)
        {
            Panel card = new Panel
            {
                Width = 370,
                Height = 140,
                BackColor = Color.FromArgb(24, 32, 54),
                Margin = new Padding(10),
                Padding = new Padding(16),
                BorderStyle = BorderStyle.None
            };

            Label lblName = new Label
            {
                Text = productName,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(0, 0)
            };

            Label lblCategory = new Label
            {
                Text = category,
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(0, 30)
            };

            Label lblPrice = new Label
            {
                Text = $"BDT {unitPrice:N2}",
                ForeColor = Color.FromArgb(16, 185, 129),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(0, 58)
            };

            Label lblStock = new Label
            {
                Text = $"In stock: {availableQty} {unit}",
                ForeColor = Color.FromArgb(203, 213, 225),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(0, 90)
            };

            bool isLowStock = availableQty <= 5;
            Label lblStatus = new Label
            {
                Text = isLowStock ? "Low Stock" : "Healthy",
                BackColor = isLowStock ? Color.FromArgb(239, 68, 68) : Color.FromArgb(16, 185, 129),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                Size = new Size(100, 26),
                Location = new Point(card.Width - 132, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            card.Controls.Add(lblStatus);
            card.Controls.Add(lblStock);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblCategory);
            card.Controls.Add(lblName);

            return card;
        }

        private Control CreateEmptyStateCard()
        {
            Panel card = new Panel
            {
                //Width = Math.Max(320, flpTopProducts.Width - 60),
                Height = 140,
                BackColor = Color.FromArgb(24, 32, 54),
                Margin = new Padding(10),
                Padding = new Padding(20),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            Label message = new Label
            {
                Text = "No products found. Add products from the Product menu to populate the dashboard.",
                ForeColor = Color.FromArgb(203, 213, 225),
                Font = new Font("Segoe UI", 10F),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            card.Controls.Add(message);
            return card;
        }

        private void ApplyMenuTheme()
        {
            ApplyMenuColors(menuStrip1.Items);
        }

        private void ApplyMenuColors(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                item.ForeColor = Color.White;
                if (item is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                {
                    ApplyMenuColors(menuItem.DropDownItems);
                }
            }
        }

        private static int SafeToInt(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(value);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderManagementForm form = new OrderManagementForm();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void flpQuickStats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpTopProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();

        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
