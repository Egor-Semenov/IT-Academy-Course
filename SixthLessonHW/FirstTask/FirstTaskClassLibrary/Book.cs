using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.FirstTaskClassLibrary
{
    class Book
    {
        string bookName;

        public string BookName
        {
            get
            {
                return bookName;
            }
        }

        string libraryName;

         public string LibraryName
         {
             get
             {
                 return libraryName;
             }
        }
        int pageNumber;

         public int PageNumber
         {
             get
             {
                 return pageNumber;
             }
         }

        string author;

          public string Author
          {
              get
              {
                  return author;
              }
          }
        
        public Book(string bookName, string author, string libaryName, int pageNumber)
        {
            this.bookName = bookName;
            this.author = author;
            this.libraryName = libaryName;
            this.pageNumber = pageNumber;
        }


    }

}
