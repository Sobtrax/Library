using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes;

namespace Library.Classes
{
    public class Book
    {
        Repo repo = new();
        private string _title = "";
        private string _author = "";
        private string _status = "";
        public int id = 0;
        public string book_title { get { return _title; } set { _title = value; } }
        public string book_author { get { return _author; } set { _author = value; } }
        public string Status { get 
            {
                if(!repo.WasLent(this) || (_status == "" || _status == null))
                {
                    return "Available";
                }
                else
                {
                    return "Lent";
                }

            }
            set { _status = value; } }

    }
}
