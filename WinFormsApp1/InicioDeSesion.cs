using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TiendaPerrona
{
    public class InicioDeSesion
    {
        private User user = new User();
        private DataBase db = new DataBase();
        private XDocument usuarios;


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
    
        public void cargarArchivo()
        {
            var xd = db.obtenerPath();
             xd += Path.Combine(xd, @"\DataBaseUsers.xml");

            usuarios = XDocument.Load(xd);

            IEnumerable<XElement> listaTemp = from users in usuarios.Element("Users").
                                              Elements("User") where users.Attribute("User_Name").Value !=
                                              "Admin" select users;


            foreach (var item in listaTemp)
            {
                db.Users.Add(new User(item.Attribute("User_Name").Value, item.Element("Email").Value, item.Element("Password").Value));
            }
            
        }
    }
}
