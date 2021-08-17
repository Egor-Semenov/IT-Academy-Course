using FirstTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.Models
{
    public class Car : IMovable
    {
        public string Name { get; set; }
        public int maxSpeed { get; set; }

        public void GetCollectionInformation()
        {
            Console.WriteLine($"Name : {Name}, Max speed : {maxSpeed}");
        }
    }
}
