using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace TiendaPerrona
{
    public class RegisterBase : User
    {

        Regex EmailPattern = new Regex("(?<user>[^@]+)@(?<host>[^\\s+]{5,20}[^\\s])");

        DataBase dataBase = new DataBase();
        

        User user = new User();

        public bool UserNameChecker(string username)
        {
            if(dataBase.Users.Count == 0)
            {
                if (username.Equals(dataBase.Users[0].UserName))
                {
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < dataBase.Users.Count; i++)
                {
                    if (username.Equals(dataBase.Users[i].UserName) )
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public bool PasswordChecker(string password, string confpassword)
        {
            if (password.Equals(confpassword))
            {
                return true;
            }
            return false;
        }
        public bool EmailChecker(string email)
        {
            if (dataBase.Users.Count == 0)
            {
                if (email.Equals(dataBase.Users[0].Email))
                {
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < dataBase.Users.Count; i++)
                {
                    if (email.Equals(dataBase.Users[i].Email))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public bool EmailVerifier(string email)
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