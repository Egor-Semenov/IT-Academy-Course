using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Making task with linq";

            var result = (from x in str.Split(' ')
                          where x.EndsWith("g")
                          select x).SingleOrDefault();

            Console.WriteLine(
                String.IsNullOrEmpty(result) ? "null" : result);



        }
    }
}
