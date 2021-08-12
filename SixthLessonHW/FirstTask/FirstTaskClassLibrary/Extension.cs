using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.FirstTaskClassLibrary
{
    public static class Extension
    {
        public static void LargestBookInLibrary(this Library library , Book[] books)
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
            for (int i = 0; i < books.Length; i++)
            {
                if ((books[i].PageNumber > max) && (books[i].LibraryName.ToLower() == libraryName.ToLower()))
                {
                    max = books[i].PageNumber;
                    maxElementIndex = i;
                }
            }

            if (max == 0)
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

