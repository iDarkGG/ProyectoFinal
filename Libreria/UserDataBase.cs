using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class UserDataBase
    {
        private string _username;
        private string _password;
        private string _email;
        private static int _counter = 0;
        private int userID;
        private bool usernameValid = false;
        private bool registeredSucces = false;
        private bool logInSucces = false;
        public static List<UserDataBase> _users = new List<UserDataBase>();

        public UserDataBase() { }
        public UserDataBase(string username, string email, string password)
        {
            _username = username;
            _email = email;
            _password = password;
            userID = Counter();
        }


        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool RegisteredSucces
        {
            get { return registeredSucces; }
            set { registeredSucces = value; }
        }

        public bool LogInSucces
        {
            get { return logInSucces; }
            set { logInSucces = value; }
        }

        public bool UsernameValid
        {
            get { return usernameValid; }
            set { usernameValid = value; }
        }


        public static int Counter() => ++_counter;

    }
}
