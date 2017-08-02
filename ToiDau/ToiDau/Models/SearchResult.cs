using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToiDau.Models
{
    public class SearchResult
    {
        public string Address { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public double Distance { get; set; }
        public bool IsLast { get; set; } = false;
    }
}
