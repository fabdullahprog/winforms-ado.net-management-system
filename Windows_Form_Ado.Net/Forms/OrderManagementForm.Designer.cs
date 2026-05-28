namespace MyProject.Forms
{
    partial class OrderManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblAvailableQty = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAllOrders = new System.Windows.Forms.GroupBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.grpOrderItems.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpAllOrders.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.Location = new System.Drawing.Point(20, 23);
            this.dgvAllOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.RowHeadersWidth = 51;
            this.dgvAllOrders.Size = new System.Drawing.Size(1560, 154);
            this.dgvAllOrders.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(185)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnClear.Location = new System.Drawing.Point(493, 478);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 49);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDeleteOrder.Location = new System.Drawing.Point(273, 478);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(200, 49);
            this.btnDeleteOrder.TabIndex = 15;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(252)))), ((int)(((byte)(201)))));
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnPlaceOrder.Location = new System.Drawing.Point(53, 478);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(200, 49);
            this.btnPlaceOrder.TabIndex = 14;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(1413, 476);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(199, 26);
            this.txtTotalAmount.TabIndex = 13;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label10.Location = new System.Drawing.Point(1253, 479);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total Amount:";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(20, 27);
            this.dgvOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.Size = new System.Drawing.Size(1560, 178);
            this.dgvOrderItems.TabIndex = 0;
            // 
            // grpOrderItems
            // 
            this.grpOrderItems.Controls.Add(this.dgvOrderItems);
            this.grpOrderItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.grpOrderItems.Location = new System.Drawing.Point(33, 262);
            this.grpOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrderItems.Size = new System.Drawing.Size(1600, 213);
            this.grpOrderItems.TabIndex = 11;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Order Items";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(1227, 70);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(160, 37);
            this.btnRemoveItem.TabIndex = 14;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAddToOrder.Location = new System.Drawing.Point(1040, 70);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(160, 37);
            this.btnAddToOrder.TabIndex = 13;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            // 
            // lblAvailableQty
            // 
            this.lblAvailableQty.AutoSize = true;
            this.lblAvailableQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblAvailableQty.Location = new System.Drawing.Point(1040, 37);
            this.lblAvailableQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableQty.Name = "lblAvailableQty";
            this.lblAvailableQty.Size = new System.Drawing.Size(93, 17);
            this.lblAvailableQty.TabIndex = 12;
            this.lblAvailableQty.Text = "Available: 0";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(853, 76);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(145, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(773, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Amount:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(600, 76);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(132, 22);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(507, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Unit Price:";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(360, 76);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(105, 22);
            this.txtUnit.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(293, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Unit:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(133, 76);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(27, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(600, 33);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(399, 24);
            this.cmbProduct.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(507, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(133, 33);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(332, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category:";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.btnRemoveItem);
            this.grpProduct.Controls.Add(this.btnAddToOrder);
            this.grpProduct.Controls.Add(this.lblAvailableQty);
            this.grpProduct.Controls.Add(this.txtAmount);
            this.grpProduct.Controls.Add(this.label9);
            this.grpProduct.Controls.Add(this.txtUnitPrice);
            this.grpProduct.Controls.Add(this.label8);
            this.grpProduct.Controls.Add(this.txtUnit);
            this.grpProduct.Controls.Add(this.label7);
            this.grpProduct.Controls.Add(this.txtQuantity);
            this.grpProduct.Controls.Add(this.label6);
            this.grpProduct.Controls.Add(this.cmbProduct);
            this.grpProduct.Controls.Add(this.label5);
            this.grpProduct.Controls.Add(this.cmbCategory);
            this.grpProduct.Controls.Add(this.label4);
            this.grpProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.grpProduct.Location = new System.Drawing.Point(33, 131);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(4);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Padding = new System.Windows.Forms.Padding(4);
            this.grpProduct.Size = new System.Drawing.Size(1600, 123);
            this.grpProduct.TabIndex = 10;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Selection";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1168, 25);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(411, 45);
            this.txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(1021, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Address:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(707, 33);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(265, 22);
            this.txtContactNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(560, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(173, 33);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(332, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // grpAllOrders
            // 
            this.grpAllOrders.Controls.Add(this.dgvAllOrders);
            this.grpAllOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.grpAllOrders.Location = new System.Drawing.Point(33, 540);
            this.grpAllOrders.Margin = new System.Windows.Forms.Padding(4);
            this.grpAllOrders.Name = "grpAllOrders";
            this.grpAllOrders.Padding = new System.Windows.Forms.Padding(4);
            this.grpAllOrders.Size = new System.Drawing.Size(1600, 185);
            this.grpAllOrders.TabIndex = 17;
            this.grpAllOrders.TabStop = false;
            this.grpAllOrders.Text = "All Orders List (Click to Edit/Delete)";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.label3);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.label2);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.label1);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.grpCustomer.Location = new System.Drawing.Point(33, 38);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomer.Size = new System.Drawing.Size(1600, 85);
            this.grpCustomer.TabIndex = 9;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1667, 762);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpOrderItems);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpAllOrders);
            this.Controls.Add(this.grpCustomer);
            this.Name = "OrderManagementForm";
            this.Text = "OrderManagementForm";
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.grpOrderItems.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpAllOrders.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrders;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.GroupBox grpOrderItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblAvailableQty;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAllOrders;
        private System.Windows.Forms.GroupBox grpCustomer;
    }
}