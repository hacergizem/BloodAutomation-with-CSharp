using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodManagment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
        }

        private void loginPswHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginPswHideShow.Text == "Goster")
            {
                loginPswHideShow.Text = "Sakla";
                loginPaswTextbox.PasswordChar = '\0';
            }
            else
            {
                loginPswHideShow.Text = "Goster";
                loginPaswTextbox.PasswordChar = '*';
            }
        }

        private void loginAcceptTermChx_CheckedChanged(object sender, EventArgs e)
        {
            if (loginAcceptTermChx.Checked == true)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginUsernameTextbox.Text == "admin" && loginPaswTextbox.Text == "12345")
            {
                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da parola yanlış!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
