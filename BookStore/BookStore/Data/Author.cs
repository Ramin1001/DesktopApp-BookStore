using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data;

namespace BookStore.Data
{
    public class Author
    {
        public string AuthorName { get; set; }
        public string AuthorID { get; set; }
        //public Book book { get; set; }

        private static int AuthorIDCounter { get; set; } = 1;

        public Author(string author) //Konstruktor
        {
            AuthorName = author;
             // studentin ID-sinin 10 simvolu kecmemek alqoritmi
             AuthorID = new string('0', 5 - AuthorIDCounter.ToString().Length) + AuthorIDCounter++;
        }

        public override string ToString() => AuthorName;
       
    }
}
