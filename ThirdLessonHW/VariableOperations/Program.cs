using System;

namespace VariableOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine($"Значение x после (x += y - x++ * z) : {x}");
            z = --x - y * 5;
            Console.WriteLine($"Значение z после (z = --x - y * 5) : {z}");
            y /= x + 5 % z;
            Console.WriteLine($"Значение y после (y /= x + 5 % z) : {y}");
            z = x++ + y * 5;
            Console.WriteLine($"Значение z после (z = x++ + y * 5) : {z}");
            x = y - x++ * z;
            Console.WriteLine($"Значение x после (x = y - x++ * z) : {x}");

        }
    }
}
