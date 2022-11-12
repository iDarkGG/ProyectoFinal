using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPerrona
{

  

    public class InicioDeSesion
    {
        User user = new User();
        DataBase db = new DataBase();


         public bool PasswordAnUserQuerying(string user, string password)
        {
            for (int i = 0; i < db.Users.Count; i++)
            {
                if (db.Users[i].UserName == user ^ db.Users[i].Email == user)
                {
                    if (db.Users[i].Password.Equals(password))
                    {
                        return true;
                        
                    }
                }
            }

            return false;
        }



    }
}
