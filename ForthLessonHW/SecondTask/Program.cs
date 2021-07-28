using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "";
            int start = 199;
            int end = 500;
            while(++start <= end)            
            {
                if (start % 17 == 0)
                {
                    str += start + ","; 
                }
            }
            str = str.Remove(str.Length - 1);
            Console.WriteLine(str);
        }
    }
}
