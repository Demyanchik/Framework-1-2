using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Model
{
    class Data
    {
        public string From { get; set; }
        public string To { get; set; }

        public Data(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}
