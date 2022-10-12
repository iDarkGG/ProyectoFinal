using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class DataBase
    {
        private static List<User> _users = new List<User>();
        public List<User> Users
        {
            get { return _users; }
        }
    }
}
