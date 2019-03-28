using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public static class AuthorList
    {
        public static List<Author> Authors { get; private set; }

        static AuthorList()
        {
            Authors = new List<Author>();

            Authors.Add(new Author("John Sharp"));
            Authors.Add(new Author("Katy Wong"));
            Authors.Add(new Author("Alicyn Night"));
            Authors.Add(new Author("Jessica Pham"));
        }

        public static void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public static Author GetAuthorByID( string authorID)
        {
            foreach(Author author in Authors)
            {
                if (author.AuthorID == authorID)
                {
                    return author;
                }
            }

            return null;
        }

        public static bool ContainsAuthorName(string authorName)
        {
            foreach(Author author in AuthorList.Authors)
            {
                if(author.AuthorName.ToUpper()== authorName.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }



    }
}
