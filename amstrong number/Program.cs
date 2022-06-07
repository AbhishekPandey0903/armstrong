using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
       {
//            int n, r, sum = 0, temp;
//            Console.WriteLine("Enter the Number= ");
//            n = int.Parse(Console.ReadLine());
//            temp = n;
//            while (n > 0)
//            {
//                r = n % 10;
//                sum = sum + (r * r * r);
//                n = n / 10;
//            }
//            if (temp == sum)
//                Console.WriteLine("Armstrong Number.");
//            else
//                Console.WriteLine("Not Armstrong Number.");
//            Console.ReadLine();
//        }
//    }
//}

           
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                cars[0] = "Opel";
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine(cars[i]);
                }
                Console.ReadLine();
            }
        }
    }