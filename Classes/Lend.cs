using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Lend
    {
        private int _id = 0;
        private int _book_id = 0;
        private int _people_id = 0;

        public int id { get { return _id; } set { _id = value; } }
        public int book_id { get { return _book_id; } set { _book_id = value; } }

        public int people_id
        {
            get { return _people_id; }
            set
            {
                _people_id = value;
            }
        }
    }
}
