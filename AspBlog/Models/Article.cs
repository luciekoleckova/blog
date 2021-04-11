using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspBlog.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Obsah { get; set; }
        public string Titul { get; set; }
        public string Popis { get; set; }
    }
}
