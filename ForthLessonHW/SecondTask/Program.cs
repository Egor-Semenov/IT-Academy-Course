using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "";
            for(int i = 200; i <= 500; i++ )
            {
                if (i % 17 == 0)
                {
                    str += Convert.ToString(i) + ","; 
                }
            }
            str = str.Remove(str.Length - 1);
            Console.WriteLine(str);
        }
    }
}
