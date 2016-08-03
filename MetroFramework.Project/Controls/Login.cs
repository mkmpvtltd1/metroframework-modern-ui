using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroFramework.Project
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateForm();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateForm();
        }
        private void ValidateForm()
        {
            btnLogin.Highlight = false;
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            string userName = txtUsername.Text.Trim();
            string passWord = txtPassword.Text.Trim();
            if (userName.Length < 1)
            {
                // txtUsername.Focus();
                lblUsernameError.Text = "Enter Username";
            }
            else if (passWord.Length < 1)
            {
                //    txtPassword.Focus();
                lblPasswordError.Text = "Enter Password";
            }
            else
            {
                btnLogin.Highlight = true;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Service_TMS.TMSClient obj = new Service_TMS.TMSClient();
                bool login = obj.Login(txtUsername.Text, txtPassword.Text);
                if (login)
                {
                    MessageBox.Show("Login Sucessfull");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
