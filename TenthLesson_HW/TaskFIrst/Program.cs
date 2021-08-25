using System;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            MyItem item = new MyItem();
            MyItem item2 = new MyItem();

            MyListUsingArray list = new MyListUsingArray();

            list.Add(item);
            list.Add(item2);
            list.Add(item);
            list.Add(item2);
            foreach (var a in list)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(list.Count);

            list.Remove(item);
            list.RemoveAt(0);

            foreach(var a in list)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine(list.IndexOf(item2));

            Console.WriteLine(list[0]);

        }
    }
}
