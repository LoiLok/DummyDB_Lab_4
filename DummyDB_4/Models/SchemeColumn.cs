using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_4
{
    public class SchemeColumn
    {
        [JsonProperty("columnName")]
        public string Name { get; set; }
        [JsonProperty("columnType")]
        public string Type { get; set; }
    }
}
