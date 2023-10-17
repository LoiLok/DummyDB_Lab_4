using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_4
{
    public class Table
    {
        public List<Line> Lines { get; set; }
        public Table() 
        {
            Lines = new List<Line>();
        }
    }
}
