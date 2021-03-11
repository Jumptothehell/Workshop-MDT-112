using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ModeOfProgram = Console.ReadLine();
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float graph = (float)Math.Pow((x - 1), 2);

            switch (ModeOfProgram)
            {
                case "time":
                    if (x < 0)
                    { Console.WriteLine("Invalid mouse position"); }
                    else if (x >= 0)
                    { Console.WriteLine("({0} , {1:f2})", x, (float)(Math.Pow((x - 1), 2)));}
                    break;

                case "price":
                    if (x < 0)
                    { Console.WriteLine("Invalid mouse position"); }
                    if (y <= 0)
                    { Console.ReadLine(); }
                    if (x == 1 && y <= 1)
                    { Console.WriteLine("({0:f2} , {1}) and ({2:f2} , {3})", -(float)Math.Sqrt(y) + 1, y, (float)Math.Sqrt(y) + 1, y); }
                    if (x < 1 && y < 1)
                    { Console.WriteLine("{0:f2} , {1}", -(float)Math.Sqrt(y) + 1, y); }
                    if (x >= 0 && y > 1)
                    { Console.WriteLine("{0:f2} , {1}", (float)Math.Sqrt(y) + 1, y);  }
                    break;

                default:
                    Console.WriteLine("Invalid mode.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
