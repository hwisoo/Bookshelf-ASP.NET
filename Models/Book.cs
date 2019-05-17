using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
