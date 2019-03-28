using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class Book
    {
        public string BookName { get; set; }
        public string BookJenre { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        //public string Author { get; set; } //  ???
        public Author Authors { get; set; }
        public string BookID { get; private set; }

        private static int BookIDcounter = 1;

        public Book()
        {
            BookID = new string('0', 10 - BookIDcounter.ToString().Length) + BookIDcounter++;
        }

        public override string ToString() => BookName;
        
    }
}
