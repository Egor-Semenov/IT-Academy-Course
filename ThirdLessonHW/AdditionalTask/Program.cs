using System;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел для нахождения НОД: ");
            int number = int.Parse(Console.ReadLine());

            double[] arr = new double[number];

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Введите число {i + 1} : ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            int iteration = 1;
            double NOD = arr[0];
            
            while(iteration < number)
            {
                double c = NOD;

                while (NOD == c)
                {
                    if ((NOD > arr[iteration]) && (NOD % arr[iteration]) == 0)
                    {
                        NOD = arr[iteration];
                    }
                    else if(NOD > arr[iteration])
                    {
                        NOD = NOD % arr[iteration];
                    }

                    if ((arr[iteration] >= NOD) && (arr[iteration] % NOD) == 0)
                    {
                        c++;
                    }
                    else if(arr[iteration] > NOD)
                    {
                        NOD = arr[iteration] % NOD;
                    }
                }

                iteration++;

            }

            Console.WriteLine($"НОД : {NOD}");
        }
    }
}
