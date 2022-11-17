using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;
using System.Xml.Linq;

namespace TiendaPerrona
{
    public class DataBase : User
    {
        private static List<User> _users = new List<User>();
        private Regex r = new Regex(@"(?<path1>\w+:\\\w+)(?<path2>\\\w+)+(?<path3>\\ProyectoFinal)");
        private static string path;
        public List<User> Users
        {
            get { return _users; }
        }
        public void starter()
        {
            _users.Add(new User(UserName = "Admin", Email = "Admin@gmail.com", Password = "Admin123"));
        }

        public string UserShower(string input)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                if (_users[i].Email.Equals(input) | _users[i].UserName.Equals(input))
                {
                    return _users[i].UserName;
                }

            }
            return "Usuario Por Defecto.";
        }

        public void generarArchivo()
        {
            path = obtenerPath();

            XDocument doc = new XDocument(new XComment("Lista_de_Usuarios"),
                new XElement("Users",
                from usuario in _users.ToArray()
                select
                new XElement("User", new XAttribute("User_Name", usuario.UserName),
                new XElement("User_ID", usuario.UserID),
                new XElement("Email", usuario.Email),
                new XElement("Password", usuario.Password)

                )));

            path += Path.Combine(path, @"\DataBaseUsers.xml");

            doc.Save(path);

            ocultarArchivo();
        }

        public string obtenerPath()
        {
            MatchCollection m = r.Matches(AppDomain.CurrentDomain.BaseDirectory);
            GroupCollection g = null;
            CaptureCollection c = null;
            foreach (Match item in m)
            {
                c = item.Groups[2].Captures;
                g = item.Groups;
            }

            string pathxd = g["path1"].Value;

            foreach (Capture item in c)
            {
                pathxd += item.Value;
            }

            pathxd += g["path3"].Value;

            return pathxd;
        }

        private void ocultarArchivo()
        {
            FileAttributes atributos = File.GetAttributes(path);
            File.SetAttributes(path, atributos | FileAttributes.Hidden);
        }

        public void añadirElemento(User usuario)
        {
            string s = obtenerPath();
            s += (Path.Combine(s, @"\DataBaseUsers.xml"));
            XDocument doc = XDocument.Load(@"C:\Users\Wilman\source\repos\ProyectoFinal\DataBaseUsers.xml");

            doc.Element("Users").Add(
                    new XElement("User", new XAttribute("User_Name", usuario.UserName),
                new XElement("User_ID", usuario.UserID),
                new XElement("Email", usuario.Email),
                new XElement("Password", usuario.Password)
                ));

            doc.Save(path);
        }
    }
}