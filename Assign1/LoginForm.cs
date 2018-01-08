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
                this.Hide();
                MenuForm menuForm  = new MenuForm();
                menuForm.Show();
                menuForm.Closed += (s, args) => this.Show();
                /*
                 * (s, args) => this.Close(); is a lambda expression. 
                 * It creates a function "in place" that is called when the form2 Closed event is fired. 
                 * (s, args) are just names for the parameters to the lambda.
                 * Which for an event handler are usually something like (object sender, EventArgs e). 
                 * Because the Closed event delegate signature describes their types, the types are not given. 
                 */

            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm rgtForm = new RegisterForm();
            this.Hide();
            rgtForm.Show();
            rgtForm.Closed += (s, args) => this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
