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
    public partial class RegisterForm : Form
    {
        private bool inputingPass = false;
        private bool inputingUser = false;
        private string userPass = "";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {
            if (!inputingPass)
            {
                passwordBox.Text = string.Empty;
            }
            inputingPass = true;
            
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (!inputingUser)
            {
                usernameBox.Text = string.Empty;
            }
            inputingUser = true;
        }
      
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            /*
            string[][] text = FileIO.split("users.txt");
            foreach (string[] i in text)
            {
                if (i[0] == usernameBox.Text)
                {
                    System.Windows.Forms.MessageBox.Show("Username taken");
                }
                else
                {
                    FileIO.write("users.txt","{\n"+usernameBox.Text+"\n"+passwordBox.Text+"\n"+"}");
                }
            }
            */
        }
       
    }
}

