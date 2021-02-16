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
            double x;
            string variant;

            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Variant: ");
            variant = Console.ReadLine();

            switch(variant)
            {
                case "first":
                case "First":
                case "FIST":
                    z = Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine("z = {0}", z);
                    break;
                case "second":
                case "Second":
                case "SECOND":
                    if (x > 0)
                    {
                        z = Math.Pow(Math.Log(x), 2);
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("The expression under the logarithm must be greater than zero");
                    break;
                case "third":
                case "Third":
                case "THIRD":
                    if (Math.Cos(Math.Pow(x,3)) != 0)
                    {
                        z = 1 / Math.Cos(Math.Pow(x, 3));
                        Console.WriteLine("z = {0}", z);
                    }
                    else Console.WriteLine("The denominator must not be zero");
                    break;
                default: 
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
