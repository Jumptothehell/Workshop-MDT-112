using System;

namespace Share_Paying
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sum = 0;
            int n = 0;
            bool ValidPeople = false;
            while (ValidPeople == false)
            {
                Console.WriteLine("Input a number of people who want to share paying: ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                { ValidPeople = true; }
                else
                {Console.WriteLine("Pleqase input again"); }
            }
            bool ValidPrice = false;

            int i = 0;
            double[] StorePrice = new double[999999];
            Console.WriteLine("Input price list what you want to share paying: ");
            Console.WriteLine("Press 0 to finish list.");
            while (ValidPrice == false)
            { 
                StorePrice[i] = double.Parse(Console.ReadLine());
                if (StorePrice[i] > 0)
                { 
                    Sum += StorePrice[i];
                    i++;
                }
                else if (StorePrice[i] == 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine("list [{0}]: {1} ", j+1, StorePrice[j]);
                        ValidPrice = true;
                    }
                }
                else
                { Console.WriteLine("Invalid Price. Please input again"); }
            }
            Console.WriteLine("Sum all of lists is {0}" , Sum);
            double Price = Math.Ceiling(Sum / n);
            Console.WriteLine("If you share {0} people. you must pay {1}", n, Price);
        }
    }
}
