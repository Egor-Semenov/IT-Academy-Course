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

            Car car1 = new Car() { Name = "Audi", maxSpeed = 150 };
            Car car2 = new Car() { Name = "BMW", maxSpeed = 200 };

            Boat boat1 = new Boat() { Name = "Intex", maxSpeed = 70 };
            Boat boat2 = new Boat() { Name = "STREAM", maxSpeed = 65 };

            collection.AddItem(car1);
            collection.AddItem(car2);
            collection.AddItem(boat1);
            collection.AddItem(boat2);

            Console.WriteLine("Collection information:");
            Console.WriteLine($"Number of items in the collection : {collection.NumberOfItems}");
            for(int i = 0; i < collection.NumberOfItems; i++)
            {
                collection[i].GetCollectionInformation();
            }
        }
    }
}
