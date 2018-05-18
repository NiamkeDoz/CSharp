using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleForm
{
    class LoginController
    {
        Login login;
        string username;
        string password;

        public LoginController(String username, String password)
        {
            this.username = username;
            this.password = password; 
        }

        public void Authenication()
        {
            if(username != "Scootboot")
            {
                login.SetUsernameError("Incorrect Username");
            }
            else if(password != "")
            {
                login.SetPasswordError("Incorrect Password");
            }
        }
    }
}
