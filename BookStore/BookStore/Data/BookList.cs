using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Forms;

namespace BookStore.Data
{
    public static class BookList
    {
        // kitablarin yiqilacaqi List massivi
        public static List<Book> Books { get; private set; }

        // proqram acilanda ilk bu kitablarin cixsin
        static BookList()
        {
            Books = new List<Book>();

            Books.Add(new Book {
                BookName = "C# Step by step",
                BookJenre = "Programmig",
                Price = "45 $",
                Description = "There descripted all about C# programming language",
                Authors = AuthorList.GetAuthorByID("00001"),
            });
            Books.Add(new Book
            {
                BookName = "Arranged",
                BookJenre = "Romance",
                Price = "45 $",
                Description = "Jason Cohen was like the guy from typical books; rich, popular",
                Authors = AuthorList.GetAuthorByID("00002"),
            });
            Books.Add(new Book
            {
                BookName = "Obsessed",
                BookJenre = "Triller",
                Price = "25 $",
                Description = "When a girl shows him the only love he's had in his life, an obsession begins.",
                Authors = AuthorList.GetAuthorByID("00003"),
            });
            Books.Add(new Book
            {
                BookName = "Bloody Mary",
                BookJenre = "Triller",
                Price = "51 $",
                Description = "Kimberly, also known as, Kim, was just playing a harmless game of 'Bloody Mary', right? Nah. It isn't harmless at all. She had to find that out the hard way.",
                Authors = AuthorList.GetAuthorByID("00004"),
            });
            Books.Add(new Book
            {
                BookName = "Halloween Night",
                BookJenre = "Triller",
                Price = "23 $",
                Description = "A bouns story of when Damien came to evelyn's house when Caden got sick and couldn't go trick or treating with Evelyn. ",
                Authors = AuthorList.GetAuthorByID("00003"),
            });
        }


        // bu adda kitabin olub olmamasini yoxlanmasi
        // ve ilk herfin boyuk herfe cevirilmesi
        public static bool ContainsBookName(string bookName)
        {
            foreach (Book book in BookList.Books)
            {
                if (book.BookName.ToUpper() == bookName.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
               
        // sonradan kitab elave etmek ucun metod
        public static void AddBook(Book book)
        {
            Books.Add(book);
        }

        public static Book GetBookById(string bookID)   //
        {                                               //
            //possible with LINQ in the future          //
            foreach (Book book in Books)                //
            {                                           //
                if (book.BookID == bookID)              //
                {                                       //
                    return book;                        //
                }                                       //
            }                                           //                                           //
            return null;                                //
        }

        // daxil edilen kitablarin bir masive yiqan metod (Author tipinde bir author veririk)
        public static List<Book> GetBookByGroup(Author author)
        {
            List<Book> authorBooks = new List<Book>();

            foreach(var thisbook in Books)
            {
                if (thisbook.Authors == author)
                {
                    authorBooks.Add(thisbook);
                }
            }
            return authorBooks;
        }
    }
}
