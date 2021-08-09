using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,3] { { 5, 1, 2 }, { 7, 9, 3 } ,{ 6 , 1 , 8} };

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            for(int i = 0; i < rows; i++)
            {
                int max = arr[i, 0];
                for(int j = 1; j < columns; j++)
                {
                    if(arr[i,j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine($"Максимальный элемент в ряду №{i + 1} : {max}");
            }
        }
    }
}
