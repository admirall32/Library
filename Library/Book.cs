using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string author;
        private string name;

        public string Author { get { return author; } }
        public string Name { get { return name; } }

        public Book(string BookName, string BookAuthor)
        {
            name = BookName;
            author = BookAuthor;
        }
    }
}
