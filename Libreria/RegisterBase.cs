using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            bool UserNameAvailable(string input)
            {
                for (int i = 0; i < dataBase.Users.Count; i++)
                {
                    if (input.Equals(dataBase.Users[i].UserName) ^ input.Equals(dataBase.Users[i].Email))
                    {
                        return false;
                    }

                }
                return true;
            }

            bool PasswordChecker(string password, string confpassword)
            {
                if (password.Equals(confpassword))
                {
                    return true;
                }
                return false;
            }

            bool EmailChecker(string email)
            {
                Match m = EmailPattern.Match(email);
                if (m.Success)
                {
                    return true;
                }
                return false;
            }
        }




    }
}