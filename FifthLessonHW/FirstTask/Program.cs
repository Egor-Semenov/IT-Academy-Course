using System;
using First_SecondTaskLibrary;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWorker arr = new ArrayWorker();
            arr.array = new int[] { 1,5,4,8,};

            arr.array = arr.Invert(arr.array);

            foreach(var a in arr.array)
            {
                Console.Write($"{a} ");
            }


        }
    }
}
