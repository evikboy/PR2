using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            double x, a;
            string variant;

            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Variant: ");
            variant = Console.ReadLine();

            switch (variant)
            {
                case "1":
                case "alfa":
                    if (a + Math.Sin(x) >= 0)
                    {
                        z = Math.Sqrt(a + Math.Sin(x));
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("There can be no negative number under the root");
                    break;
                case "2":
                case "beta":
                    if (Math.Sin(a * x) >= 0)
                    {
                        z = Math.Sqrt(Math.Sin(a * x));
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("There can be no negative number under the root");
                    break;
                case "3":
                case "gamma":
                    if (a - x > 0)
                    {
                        z = Math.Log(a - x);
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("The expression under the logarithm must be greater than zero");
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
