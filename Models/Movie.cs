using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modul8_1302200040.Models
{
    public class Movie
    {
        public string Title {get; set;}
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }
    }
}
