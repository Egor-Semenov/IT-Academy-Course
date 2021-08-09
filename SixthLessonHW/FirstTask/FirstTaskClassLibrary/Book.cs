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

            set
            {
                bookName = value;
            }
        }

        string libraryName;

        public string LibraryName
        {
            get
            {
                return libraryName;
            }

            set
            {
                libraryName = value;
            }
        }
        int pageNumber;

        public int PageNumber
        {
            get
            {
                return pageNumber;
            }

            set
            {
                pageNumber = value;
            }
        }

        string author;

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public Book(string bookName, string author, string libaryName, int pageNumber)
        {
            BookName = bookName;
            Author = author;
            LibraryName = libaryName;
            PageNumber = pageNumber;
        }


    }

}
