using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPerrona
{
    public class DataBase : User
    {
        private static List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return _users; }
        }
        public void starter()
        {
            _users.Add(new User(UserName = "Admin", Email = "Admin@gmail.com", Password= "Admin123"));
        }

    }
}
