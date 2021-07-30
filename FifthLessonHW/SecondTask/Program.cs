using System;
using First_SecondTaskLibrary;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayWorker arr = new ArrayWorker();
            arr.array = new int[] { 1, 5, 4, 8, 9, 7, 1 };

            Console.WriteLine("Введите значение нового элемента массива :");
            arr.newValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите индекс нового элемента :");
            arr.index = int.Parse(Console.ReadLine());

            arr.array = arr.NewValue(arr.array, arr.newValue, arr.index);

            Console.WriteLine("Изменённый массив :");
            foreach(var a in arr.array)
            {
                Console.Write($"{a} ");
            }
        }
    }
}
