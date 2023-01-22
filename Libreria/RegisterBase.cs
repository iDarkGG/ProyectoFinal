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
            Regex EmailPattern = new Regex("^(?<User>[\w]{6,30})@(?<Host>[a-zA-Z0-9]+)\.(?<TLD>[a-zA-Z0-9]{2,5})$");

            DataBase dataBase = new DataBase();

            User user = new User();

            bool UserNameAvailable(string input)
            {
                for (int i = 0; i < dataBase.Users.Count; i++)
                {

                    if (username.Equals(dataBase.Users[i].UserName) ^ username.Equals(dataBase.Users[i].Email))
                    {
                        return true;
                    }

                return false;
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
