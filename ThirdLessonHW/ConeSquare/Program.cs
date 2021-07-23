using System;

namespace ConeSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            double l, r;

            Console.WriteLine("Введите радиус R: ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите образующую L: ");
            l = double.Parse(Console.ReadLine());

            double coneSquare = GetConeSquare(pi, r, l);

            Console.WriteLine($"Площадь конуса равна {coneSquare}");
        }

        static double GetConeSquare(double pi, double r, double l)
        {
            return pi * r * (r + l); 
        }
    }
}
