using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        private string _id;
        private string _password;
        
        public string id { get { return _id; } private set { _id = value; } }
        public string password { get { return _password; } private set { _password = value; } }


        public User(string nom,string password)
        {
            this._id = nom;
            this._password = password;
        }
    }

}
