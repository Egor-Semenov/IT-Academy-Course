using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.FirstTaskClassLibrary
{
    static class Library
    {

        public static void IndexInformation(Book[] books, int index)
        {
            Console.WriteLine(books[index].BookName);
            Console.WriteLine(books[index].Author);
            Console.WriteLine(books[index].LibraryName);
            Console.WriteLine(books[index].PageNumber);
        }

        public static void BookNameInformation(Book[] books)
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
                if(a.BookName.ToLower().Equals(bookName.ToLower()))
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

        public static void LargestBookInLibrary(this Book[] books)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите название библиотеки, в которой ищете самую толстую книгу.");
            Console.WriteLine("Список библиотек:");
            Console.ResetColor();
            Console.WriteLine("Британская библиотека");
            Console.WriteLine("Библиотека Конгресса США");
            Console.WriteLine("Королевская библиотека Дании");

            string libraryName = Console.ReadLine();

            var max = 0;
            var maxElementIndex = 0;
            for(int i = 0; i < books.Length; i++)
            {
                if((books[i].PageNumber > max) && (books[i].LibraryName.ToLower() == libraryName.ToLower()))
                {
                    max = books[i].PageNumber;
                    maxElementIndex = i;
                }
            }

            if(max == 0)
            {
                Console.WriteLine("В этой библиотеке нету книг, либо вы ввели неправильное название библиотеки.");
                return;
            }
            Console.WriteLine(books[maxElementIndex].BookName);
            Console.WriteLine(books[maxElementIndex].Author);
            Console.WriteLine(books[maxElementIndex].PageNumber);
        }


    }
}
