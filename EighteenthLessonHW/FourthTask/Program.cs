using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };
            Person rui = new Person { FirstName = "Rui", LastName = "Raposo" };

            Pet barley = new Pet { Name = "Barley", Owner = terry, Age = 10 };
            Pet boots = new Pet { Name = "Boots", Owner = terry, Age = 9 };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte, Age = 10 };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = rui, Age = 4 };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus, Age = 7 };

            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene, rui };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var result = (from person in people
                         join pet in pets on person equals pet.Owner
                         where pet.Age > 5
                         select new { OwnerName = person.FirstName, PetName = pet.Name, PetAge = pet.Age }).Skip(people.Count / 2).Take(3);

            foreach(var item in result)
            {
                Console.WriteLine($"{item.PetName} age is {item.PetAge} is owned by {item.OwnerName}");
            }


        }
    }
}
