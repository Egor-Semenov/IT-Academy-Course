using System;

namespace FirastTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите новое значение элемента № {i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Вывод отсортированного массива:");

            foreach(var a in arr)
            {
                Console.Write($"{a} ");
            }
        }
    }
}
