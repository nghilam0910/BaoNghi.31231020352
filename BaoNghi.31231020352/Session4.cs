using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session4
    {
        public static void Main()
        {
            Ex_01();
            Console.ReadKey();
        }
        /// <summary>
        /// x = y2 + 2y + 1
        /// </summary>
        public static void Ex_01()
        {
            do
            {
                Console.Write("Input value y = ");
            int y = int.Parse(Console.ReadLine());

           
                if (y >= -5 && y <= 5)
                {
                    double z = Math.Pow(y, 2);
                    ///int x = y * y + 2 * y + 1;
                    double x = z + 2 * y + 1;
                    Console.WriteLine($"x = {x}");
                    break;
                }
                else
                {
                    Console.WriteLine("Vui long nhap lai");
                    continue;
                }
            } while (true);
            
        }
        /// <summary>
        /// tinh van toc
        /// </summary>
        public static void Ex_02()
        {
            
        }
    }
}

