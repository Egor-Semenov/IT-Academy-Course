using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.FirstTaskClassLibrary
{
    public class Library
    {
        private Book[] books;

        public Book[] Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
            }
        }


        public void IndexInformation(Book[] books, int index)
        {
            Console.WriteLine(books[index].BookName);
            Console.WriteLine(books[index].Author);
            Console.WriteLine(books[index].LibraryName);
            Console.WriteLine(books[index].PageNumber);
        }

        public void BookNameInformation(Book[] books)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Список книг:");
            Console.ResetColor();
            foreach (var a in books)
            {
                Console.WriteLine(a.BookName);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите название книги: ");
            Console.ResetColor();
            string bookName = Console.ReadLine();

            foreach (var a in books)
            {
                if (a.BookName.ToLower().Equals(bookName.ToLower()))
                {
                    Console.WriteLine($"Информация о книге {a.BookName} :");
                    Console.WriteLine($"Автор : {a.Author}");
                    Console.WriteLine($"Библиотека :{a.LibraryName}");
                    Console.WriteLine($"Количество страниц :{a.PageNumber}");
                    return;
                }
            }
            Console.WriteLine("Такой книги нету");
        }

    }   
}
