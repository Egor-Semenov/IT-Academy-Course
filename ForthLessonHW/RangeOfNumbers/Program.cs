using System;

namespace RangeOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "да";

            while (answer.Equals("да"))
            {
                Console.WriteLine("Введите число : ");
                double number = double.Parse(Console.ReadLine());

                if ((number >= 0) && (number <= 30))
                {
                    Console.WriteLine("Введённое число входит в промежуток от 0 до 30");
                }
                else if ((number >= 31) && (number <= 60))
                {
                    Console.WriteLine("Введённое число входит в промежуток от 31 до 60");
                }
                else if ((number >= 61) && (number <= 100))
                {
                    Console.WriteLine("Введённое число входит в промежуток от 61 до 100");
                }
                else
                {
                    Console.WriteLine("Я такого числа не знаю.");
                }

                Console.WriteLine("Хотите продолжить? Ответьте да или нет.");
                answer = Console.ReadLine().ToLower();
                while (!answer.Equals("да") && !answer.Equals("нет"))
                {
                    Console.WriteLine("Ответьте да или нет!");
                    answer = Console.ReadLine().ToLower();
                    if(answer.Equals("да") || answer.Equals("нет"))
                    {
                        break;
                    }
                }
            }
        }
    }
}
