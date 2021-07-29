using System;
using ThirdTaskLibrary;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус конуса :");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту конуса :");
            double high = double.Parse(Console.ReadLine());

            Cone cone = new Cone(radius ,high);

            double baseArea = cone.BaseArea(radius);
            Console.WriteLine($"Площадь поверхности основания конуса : {baseArea}");

            double fullArea = cone.FullArea(radius, high);
            Console.WriteLine($"Полная площадь поверхности конуса : {fullArea}");
        }
    }
}
