using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyList myList = new MyList();

            MyItem item = new MyItem();

            myList.Add(item);

            Console.WriteLine(myList[0]);

            foreach(var a in myList)
            {
                Console.WriteLine(a);
            }
        }
    }
}
