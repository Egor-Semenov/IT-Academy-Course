using System;
using FirstTask.FirstTaskClassLibrary;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Library library = new Library();

            library.Books = new Book[6];

            Book book1 = new Book("Таинственный остров", "Жюль Верн", "Британская библиотека", 544);
            Book book2 = new Book("Крёстный отец", "Марио Пьюзо", "Библиотека Конгресса США", 576);
            Book book3 = new Book("Властелин колец: Возвращение короля", "Джон Рональд Руэл Толкин", "Королевская библиотека Дании", 352);
            Book book4 = new Book("Зелёная миля", "Стивен Кинг", "Британская библиотека", 368);
            Book book5 = new Book("Побег из Шоушенка", "Стивен Кинг", "Королевская библиотека Дании", 192);
            Book book6 = new Book("Мастер и Маргарита", "Михаил Булгаков", "Библиотека Конгресса США", 528);

            library.Books[0] = book1;
            library.Books[1] = book2;
            library.Books[2] = book3;
            library.Books[3] = book4;
            library.Books[4] = book5;
            library.Books[5] = book6;

            library.IndexInformation(library.Books, 0);

            library.BookNameInformation(library.Books);

            library.LargestBookInLibrary(library.Books);
        }
    }
}
