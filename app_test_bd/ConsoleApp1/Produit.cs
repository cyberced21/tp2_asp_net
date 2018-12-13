using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produit
    {
        // Fields
        private string _id = "";
        private string _name = "";
        private string _category = "";
        
        // Properties
        public string id { get { return _id; } private set { _id = value; } }
        public string name { get { return _name; } private set { _name = value; } }
        public string category { get { return _category; } private set { _category = value; } }

        public Produit(string p_id,string p_name, string p_category)
        {
            _id = p_id;
            _name = p_name;
            _category = p_category;
        }
    }
}
