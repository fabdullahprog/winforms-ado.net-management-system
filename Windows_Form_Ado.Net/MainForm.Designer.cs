namespace MyProject
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuickInsights = new System.Windows.Forms.Label();
            this.flpQuickStats = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTopProducts = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.productToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuItem1.Text = "Category Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
            this.toolStripMenuItem2.Text = "Product Add";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem1,
            this.productToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.categoryToolStripMenuItem1.Text = "Category";
            this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.categoryToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.productToolStripMenuItem1.Text = "Product";
            this.productToolStripMenuItem1.Click += new System.EventHandler(this.productToolStripMenuItem1_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem1});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // orderToolStripMenuItem1
            // 
            this.orderToolStripMenuItem1.Name = "orderToolStripMenuItem1";
            this.orderToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.orderToolStripMenuItem1.Text = "Order Management";
            this.orderToolStripMenuItem1.Click += new System.EventHandler(this.orderToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Location = new System.Drawing.Point(0, 24);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(960, 98);
            this.panelHeader.TabIndex = 6;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(198)))), ((int)(((byte)(231)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 56);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(308, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Monitor categories, stock and orders in real-time";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electronic Management";
            // 
            // lblQuickInsights
            // 
            this.lblQuickInsights.AutoSize = true;
            this.lblQuickInsights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuickInsights.ForeColor = System.Drawing.Color.White;
            this.lblQuickInsights.Location = new System.Drawing.Point(389, 154);
            this.lblQuickInsights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuickInsights.Name = "lblQuickInsights";
            this.lblQuickInsights.Size = new System.Drawing.Size(112, 21);
            this.lblQuickInsights.TabIndex = 7;
            this.lblQuickInsights.Text = "Quick Insights";
            // 
            // flpQuickStats
            // 
            this.flpQuickStats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpQuickStats.Location = new System.Drawing.Point(11, 267);
            this.flpQuickStats.Margin = new System.Windows.Forms.Padding(2);
            this.flpQuickStats.Name = "flpQuickStats";
            this.flpQuickStats.Padding = new System.Windows.Forms.Padding(4);
            this.flpQuickStats.Size = new System.Drawing.Size(913, 163);
            this.flpQuickStats.TabIndex = 8;
            this.flpQuickStats.Paint += new System.Windows.Forms.PaintEventHandler(this.flpQuickStats_Paint);
            // 
            // lblTopProducts
            // 
            this.lblTopProducts.AutoSize = true;
            this.lblTopProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTopProducts.ForeColor = System.Drawing.Color.White;
            this.lblTopProducts.Location = new System.Drawing.Point(26, 207);
            this.lblTopProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopProducts.Name = "lblTopProducts";
            this.lblTopProducts.Size = new System.Drawing.Size(133, 21);
            this.lblTopProducts.TabIndex = 9;
            this.lblTopProducts.Text = "Inventory Health";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.lblTopProducts);
            this.Controls.Add(this.flpQuickStats);
            this.Controls.Add(this.lblQuickInsights);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuickInsights;
        private System.Windows.Forms.FlowLayoutPanel flpQuickStats;
        private System.Windows.Forms.Label lblTopProducts;
    }
}

