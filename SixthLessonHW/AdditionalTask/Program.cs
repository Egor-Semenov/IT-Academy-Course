using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 9, 6, 4, 2 };

            Console.WriteLine("Как отсортировать массив? 1.От минимального к максимальному. 2.От максимального к минимальному");
            var answer = int.Parse(Console.ReadLine());

            if(answer != 1 && answer !=2)
            {
                while (answer != 1 && answer != 2)
                {
                    Console.WriteLine("Ответьте 1 или 2!");
                    answer = int.Parse(Console.ReadLine());
                }
            }

            switch(answer)
            {
                case 1: arr.PuzSortFromMinToMax();
                    break;
                case 2: arr.PuzSortFromMaxToMin();
                    break;
            }

            Console.WriteLine("Отсортированный массив :");
            
            foreach(var a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
