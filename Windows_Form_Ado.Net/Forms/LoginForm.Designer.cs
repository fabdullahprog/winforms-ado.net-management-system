namespace MyProject.Forms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSignin = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 45);
            this.panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.lbHeader.Location = new System.Drawing.Point(66, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(624, 34);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Electronics Product Management System";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblX.Location = new System.Drawing.Point(759, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(25, 28);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtBoxPassword);
            this.panel2.Controls.Add(this.txtBoxUserName);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblSignin);
            this.panel2.Location = new System.Drawing.Point(206, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 423);
            this.panel2.TabIndex = 1;
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.lblSignin.Location = new System.Drawing.Point(130, 44);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(94, 29);
            this.lblSignin.TabIndex = 0;
            this.lblSignin.Text = "Sign In";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblUserName.Location = new System.Drawing.Point(52, 102);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.lblPassword.Location = new System.Drawing.Point(59, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(119, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserName.Location = new System.Drawing.Point(57, 130);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(263, 30);
            this.txtBoxUserName.TabIndex = 3;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.Location = new System.Drawing.Point(57, 220);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(256, 30);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(252)))), ((int)(((byte)(201)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(238)))), ((int)(((byte)(144)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnLogin.Location = new System.Drawing.Point(57, 298);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 54);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(787, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSignin;
    }
}