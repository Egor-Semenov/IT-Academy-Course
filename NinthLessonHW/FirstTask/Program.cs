using FirstTask.Implementation;
using FirstTask.Interfaces;
using FirstTask.Models;
using System;
using System.Collections.Generic;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<IMovable> collection = new MyCollection<IMovable>();

            collection.myCollection = new List<IMovable>();

            Console.WriteLine(collection.NumberOfItems);

            Car car = new Car();

            collection.AddItem(car);
            Console.WriteLine(collection[0]);

            Boat boat = new Boat();

            collection.AddItem(boat);

            Console.WriteLine(collection[1]);

            Console.WriteLine(collection.NumberOfItems);
        }
    }
}
