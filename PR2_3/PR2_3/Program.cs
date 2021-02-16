using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_3
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
                    case "100":
                    case "A":
                        if (Math.Sin(x) >= 0)
                        {
                            z = Math.Sqrt(Math.Sin(x));
                            Console.WriteLine("z = {0}", z);
                        }
                        else Console.WriteLine("There can be no negative number under the root");
                        break;
                    case "200":
                    case "B":
                        if (Math.Cos(x) != 0)
                        {
                            z = 1 / Math.Cos(x);
                            Console.WriteLine("z = {0}", z);
                        }
                        else Console.WriteLine("The denominator must not be zero");
                        break;
                    case "250":
                    case "C":
                        if (Math.Tan(x) != 0)
                        {
                            z = Math.Log(Math.Abs(Math.Tan(x)));
                            Console.WriteLine("z = {0}", z);
                        }
                        else Console.WriteLine("Logarithm of zero does not exist");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
}


    

