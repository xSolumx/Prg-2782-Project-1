using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg_2782_Project_1
{
    class LoginDataClass
    {
        private string username;

        protected internal string Username
        {
            get { return username; }
            set { username = value; }
        }


        private string password;

        protected internal string Password
        {
            get { return password; }
            set { password = value; }
        }

        

        



        public LoginDataClass(string Myusername, string MyPassword)
        {
            this.username = Myusername;
            this.password = MyPassword;
            

        }


        public override string ToString()
        {
            return $"Username  |  {Username}\t Passowrd  |  {Password}\t";
        }

    }
}
    
