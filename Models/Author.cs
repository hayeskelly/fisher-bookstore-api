using System;
using Fisher.Bookstore.Api.Models;
using System.Collections.Generic;

namespace Fisher.Bookstore.Api.Models
{
    public class Author
    {
        public int Id {get; set;}

        public string name {get; set;}

        public string bio {get; set;}

        public List<Book> Titles {get; set;}
    }
}