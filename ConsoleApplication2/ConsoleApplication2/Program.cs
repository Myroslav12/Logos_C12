using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int n1 = int.Parse(Console.ReadLine());
            //   int n2 = int.Parse(Console.ReadLine());
            //  int oper = int.Parse(Console.ReadLine());

            //switch (oper)
            /*    {
                case 1:
                    Console.WriteLine(n1 * n2);
                    break;

                case 2:
                    Console.WriteLine(n1 / n2);
                    break;

                case 3:
                    Console.WriteLine(n1 + n2);
                    break;

                case 4:
                    Console.WriteLine(n1 - n2);
                    break;

            };   */

            //            int a1 = int.Parse(Console.ReadLine());
            //          if (a1 % 4 == 0) { 
            //              Console.WriteLine("Visokosniy");
            //       }







            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            if (y1 + y2 > y3 && y1 + y3 > y2 && y2 + y3 > y1 )
            {
                Console.WriteLine("Good");


            }



        }


    }
}
