using System;
using System.Linq;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Женя скоро будет свободен, а у вас все только начинается";

            var result = from x in str.Split(' ')
                         select x.Replace("о", "");

            foreach(var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
