using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Login
    {
        static string message = "Wrong username or password.";
        static string username;
        static string password;
        static string filePath;
        static string Password
        {
            set
            {
                if (value != FileManager.GetUserPassword(username))
                {
                    message = "Wrong password!";
                    //throw new Exception(message);
                    throw new ArgumentException(message);
                }
            }
        }

        static string Username
        {
            set
            {
                username = value;
            }
        }

        public static void Init(string username, string password)
        {

            if (!FileManager.UserExist(username))
            {
                message = "Username does not exist!";
                throw new ArgumentException(message);
            }
            Username = username;
            Password = password;
        }
    }
}
