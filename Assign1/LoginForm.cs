using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void usernameBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {
            if (usernameBox.Text == "Username")
            {
                usernameBox.Text = string.Empty;
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = string.Empty;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool loginSuccess = true;
            //check login
            if (loginSuccess)
            {
                MenuForm menuForm  = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
        }
    }
}
