using System;
using System.Linq;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 8, 0, -1, 6, 4, -1, -3 };

            var positiveNumber = (from x in arr
                       where x > 0
                       select x).Count();
                       

            Console.WriteLine(positiveNumber);

            var average = (from x in arr
                           where x > 0
                           select x).Average();

            Console.WriteLine(average);
        }
    }
}
