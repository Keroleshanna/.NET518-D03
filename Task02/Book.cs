using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availablility { get; set; }

        public Book(string title, string author, string iSBN, bool availablility = true)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availablility = availablility;
        }
    }
}