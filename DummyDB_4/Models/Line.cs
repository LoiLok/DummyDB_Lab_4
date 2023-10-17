using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_4
{
    public class Line
    {
        public Dictionary<SchemeColumn, object> Data { get; set; } 
        public Line()
        {
            Data = new Dictionary<SchemeColumn, object>();
        }
    }
}
