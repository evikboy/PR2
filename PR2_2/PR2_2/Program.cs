using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            double x;
            string variant;

            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Variant: ");
            variant = Console.ReadLine();

            switch (variant)
            {
                case "A":
                case "a":
                    if (Math.Tan(x) >= 0)
                    {
                        z = Math.Sqrt(Math.Tan(x));
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("There can be no negative number under the root");
                    break;
                case "B":
                case "b":
                    if (Math.Tan(x) != 0)
                    {
                        z = 1 / Math.Tan(x);
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("The denominator must not be zero");
                    break;
                case "C":
                case "c":
                    if (Math.Tan(x) > 0)
                    {
                        z = Math.Log(Math.Tan(x));
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
