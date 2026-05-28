namespace MyProject.Forms
{
    partial class ProductForm
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblQuantity.Location = new System.Drawing.Point(17, 240);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 20);
            this.lblQuantity.TabIndex = 33;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(17, 181);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(83, 20);
            this.lblUnitPrice.TabIndex = 32;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblUnit.Location = new System.Drawing.Point(17, 134);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(39, 20);
            this.lblUnit.TabIndex = 31;
            this.lblUnit.Text = "Unit";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblProductName.Location = new System.Drawing.Point(17, 91);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(116, 20);
            this.lblProductName.TabIndex = 30;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblProductCategory.Location = new System.Drawing.Point(17, 43);
            this.lblProductCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(139, 20);
            this.lblProductCategory.TabIndex = 29;
            this.lblProductCategory.Text = "Product Category";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(185)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnClear.Location = new System.Drawing.Point(16, 497);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 48);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDelete.Location = new System.Drawing.Point(269, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 48);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnUpdate.Location = new System.Drawing.Point(140, 443);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 47);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(252)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnSave.Location = new System.Drawing.Point(16, 443);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 47);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(216)))), ((int)(((byte)(242)))));
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(45, 318);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(116, 58);
            this.btnBrowseImage.TabIndex = 24;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(169, 225);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(215, 43);
            this.txtQuantity.TabIndex = 23;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(169, 177);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(215, 40);
            this.txtUnitPrice.TabIndex = 22;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(169, 130);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(215, 38);
            this.txtUnit.TabIndex = 21;
            this.txtUnit.TextChanged += new System.EventHandler(this.txtUnit_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(169, 87);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(215, 35);
            this.txtProductName.TabIndex = 20;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(169, 43);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(215, 24);
            this.cmbCategory.TabIndex = 18;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(440, 31);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(801, 555);
            this.dgvProducts.TabIndex = 17;
            // 
            // pbProductImage
            // 
            this.pbProductImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pbProductImage.Location = new System.Drawing.Point(169, 277);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(216, 124);
            this.pbProductImage.TabIndex = 19;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1257, 617);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}