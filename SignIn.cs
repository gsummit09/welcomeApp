using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SignIn
    {
        public string Authentication(string username, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "User name and psaaword required";
            }
            else
            {
                if((username == "admin" ) && (password == null))
                {
                    msg = "Authentication Pass";
                }  
                else
                {
                    msg = "Authentication Fail";
                }
            }
            return msg;
        }
    }
}
