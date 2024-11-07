using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session4
    {
        public static void Main1()
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
        /// <summary>
        /// Xac dinh so chan hay le
        /// </summary>
        static void Ex01_1()
        {
            Console.Write("Vui long nhap mot so: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} la so chan");
            }
            else
            {
                Console.WriteLine($"{x} la so le");
            }
        }
        /// <summary>
        /// Tim max trong 3 so
        /// </summary>
        static void Ex_02_1()
        {
            Console.Write("Vui long nhap so thu nhat: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap so thu hai: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap so thu ba: ");
            int z = int.Parse(Console.ReadLine());
            int max = 0;
            if (x > y && x > z)
            {
                max = x;
            }
            else if (y > x && y > z)
            {
                max = y;
            }
            else
            {
                max = z;
            }
            Console.WriteLine($"So lon nhat la {max}");
        }
        /// <summary>
        /// Xac dinh toa do
        /// </summary>
        static void Ex_03_1()
        {
            Console.Write("Vui long nhap toa do X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap toa do y: ");
            int y = int.Parse(Console.ReadLine());
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Diem nam tren truc toa do");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam tren goc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam tren goc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam tren goc phan tu thu tu");
            }
        }
        /// <summary>
        /// Xac dinh tam giac can, thuong, vuong
        /// </summary>
        static void Ex_01_2()
        {
            int a, b, c;
            do
            {
                Console.Write("Nhap canh a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Nhap canh c: ");
                c = int.Parse(Console.ReadLine());
                if (a + b <= c || a + c <= b || c + b <= a)
                {
                    Console.WriteLine("Vui long dien lai");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            if (a == b && b == c && c == a)
            {
                Console.WriteLine("Tam giac nay la tam giac deu");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Tam giac nay la tam giac can");
            }
            else if (a * a == b * b + c * c || c * c == a * a + b * b || b * b == a * a + c * c)
            {
                Console.WriteLine("Tam giac nay la tam giac vuong");
            }
            else
            {
                Console.WriteLine("Tam giac nay la tam giac thuong");
            }
        }
        /// <summary>
        /// Tim bang cuu chuong cua 1 so
        /// </summary>
        static void Ex_04_2()
        {
            Console.Write("Nhap mot so: ");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                int mul = x * i;
                Console.WriteLine($"{x}*{i}={mul}");
                i = i + 1;
            }
        }
    }
}

