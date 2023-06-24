using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_2_sp
{
    public class Book
    {
        private int Id;
        private string _name;
        private string _author;
        private DateTime _day_Pr;


        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public DateTime Day_Pr
        {
            get { return _day_Pr; }
            set
            {
                _day_Pr = value;
            }
        }
    }
}
