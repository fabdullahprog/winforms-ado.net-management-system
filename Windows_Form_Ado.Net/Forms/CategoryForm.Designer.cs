namespace MyProject.Forms
{
    partial class CategoryForm
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
            this.lblCategoryDescription = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryDescription
            // 
            this.lblCategoryDescription.AutoSize = true;
            this.lblCategoryDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblCategoryDescription.Location = new System.Drawing.Point(14, 167);
            this.lblCategoryDescription.Name = "lblCategoryDescription";
            this.lblCategoryDescription.Size = new System.Drawing.Size(60, 13);
            this.lblCategoryDescription.TabIndex = 15;
            this.lblCategoryDescription.Text = "Description";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblCategoryName.Location = new System.Drawing.Point(7, 104);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Category Name";
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(357, 87);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidth = 51;
            this.dgvCategories.Size = new System.Drawing.Size(474, 276);
            this.dgvCategories.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(252)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnSave.Location = new System.Drawing.Point(10, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 47);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnUpdate.Location = new System.Drawing.Point(104, 225);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 47);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDelete.Location = new System.Drawing.Point(212, 225);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(127, 154);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(195, 45);
            this.txtDuration.TabIndex = 9;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(127, 87);
            this.txtCategoryName.Multiline = true;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(195, 44);
            this.txtCategoryName.TabIndex = 8;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.lblCategoryDescription);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtCategoryName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryDescription;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtCategoryName;
    }
}