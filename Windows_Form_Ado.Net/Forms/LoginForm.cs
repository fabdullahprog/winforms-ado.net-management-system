using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyModernTheme();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            if (txtBoxUserName.Text.Trim().ToLower() == "admin" &&
                txtBoxPassword.Text.Trim() == "1234")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ApplyModernTheme()
        {
            BackColor = Color.FromArgb(13, 20, 38);
            panel1.BackColor = Color.FromArgb(15, 23, 42);
            panel2.BackColor = Color.FromArgb(24, 32, 54);

            lbHeader.ForeColor = Color.White;
            lblSignin.ForeColor = Color.White;
            lblUserName.ForeColor = Color.FromArgb(203, 213, 225);
            lblPassword.ForeColor = Color.FromArgb(203, 213, 225);
            lblX.ForeColor = Color.FromArgb(248, 113, 113);

            foreach (TextBox input in new[] { txtBoxUserName, txtBoxPassword })
            {
                input.BackColor = Color.FromArgb(15, 23, 42);
                input.ForeColor = Color.White;
                input.BorderStyle = BorderStyle.FixedSingle;
            }

            StyleButton(btnLogin, Color.FromArgb(16, 185, 129));
        }

        private void StyleButton(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
        }
    }
}
