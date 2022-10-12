using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
using System.Text.RegularExpressions;
namespace Libreria
{
    public class RegisterBase : User
    {

        public static void Main()
        {
            Regex EmailPattern = new Regex("(?<user>[^@]+)@(?<host>.+)");

            DataBase dataBase = new DataBase();

            User user = new User();

            bool UserNameChecker(string username)
            {
                for (int i = 0; i < dataBase.Users.Count; i++)
                {
                    if (username.Equals(dataBase.Users.ElementAt(i).UserName))
                    {
                        user.UsernameValid = false;
                    }
                    else
                    {
                        user.UsernameValid = true;
                    }
                }
                return user.UsernameValid;
            }

            bool PasswordChecker(string password, string confpassword)
            {
                if (password.Equals(confpassword))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool EmailChecker(string email)
            {
                Match m = EmailPattern.Match(email);
                if (m.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        }




    }
}