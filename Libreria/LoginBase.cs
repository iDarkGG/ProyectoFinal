using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{

  

    public class LoginBase : User
    {
        public static void Main()
        {
            User user = new User();
            DataBase db = new DataBase();

            bool PasswordQuerying(string password)
            {
                for(int i = 0; i < db.Users.Count; i++)
                {
                    if (db.Users[i].Password.Equals(password))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

    }
}
