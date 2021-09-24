using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            var timer = new Stopwatch();

            for(int i = 0; i < 100000000; i++)
            {
                carList.Add(new Car { age = i });
            }

            timer.Start();
            foreach (var car in carList)
                car.age = (343 * 34 * 2 * 77) / 567;
            Console.WriteLine("Foreach:          {0}", timer.ElapsedTicks);
            timer.Stop();

            timer.Reset();

            timer.Start();
            for (int i = 0; i < carList.Count; i++)
                carList[i].age = (343 * 34 * 2 * 77) / 567;
            Console.WriteLine("For:              {0}", timer.ElapsedTicks);
            timer.Stop();

            timer.Reset();

            timer.Start();
            Parallel.ForEach(carList, car => car.age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine("Parallel.ForEach: {0}", timer.ElapsedTicks);
            timer.Stop();

            timer.Reset();

            timer.Start();
            Parallel.For(0, carList.Count, i => carList[i].age = (343 * 34 * 2 * 77) / 567);
            Console.WriteLine("Parallel.For:     {0}", timer.ElapsedTicks);
            timer.Stop();


        }
    }
}
