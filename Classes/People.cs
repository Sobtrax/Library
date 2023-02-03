using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class People
    {
        private int _id = 0;
        private string _name = "";
        private string _surname = "";

        public string name { get { return _name; } set { _name = value; } }
        public string surname { get { return _surname; } set { _surname = value; } }
        public int id { get { return _id; } set { _id = value; } }
        public string FullName
        {
            get
            {
                if ((_name == null || _name == "") && (_surname == null || _surname == ""))
                {
                    return "Noone";
                }
                else
                {
                    return _name + " " + _surname;
                }
            }
        }
    }
}
