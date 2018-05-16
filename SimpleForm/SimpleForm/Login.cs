using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleForm
{
    public partial class Login : Form
    {
        string username;
        string password;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            username = Username.Text;
            password = pwd.Text;

            LoginController login = new LoginController(username, password);
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Username")
            {
                Username.Text = "";
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if(Username.Text == "")
            {
                Username.Text = "Username";
            }
        }
        
        private void Password_Enter(object sender, EventArgs e)
        {
            if(pwd.Text == "Password")
            {
                pwd.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(pwd.Text == "")
            {
                pwd.Text = "Password";
            }
        }
    }
}
