
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace BaoNghi._31231020352
{
    internal class Session5
    {
        static void Main(string[] args)
        {
            //sesion05_ex01();
            //session05_ex02();
            session05_ex03();
        }
        static void sesion05_ex01()
        {
            Console.WriteLine("Nhap so x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so z: ");
            int z = int.Parse(Console.ReadLine());
            int max = Max3Num(x, y, z);
            Console.WriteLine($"So lon nhat la {max}");
        }
        static int Max2Num(int a, int b)
        {
            return a > b ? a : b;
        }

        static int Max3Num(int a, int b, int c)
        {
            return Max2Num(a, Max2Num(b, c));
        }

        static void session05_ex01plus()
        {

        }

        static void session05_ex02()
        {
            do
            {
                Console.Write("Nhap so x: ");
                int x = int.Parse(Console.ReadLine());
            
                if (x < 0 || x == 0)
                {
                    Console.WriteLine("Nhap lai so lon hon 0");
                    
                }
                else
                {
                    long result = GiaiThua(x);
                    Console.WriteLine($"Giai thua cua {x} la {result}");
                    break;
                }
            }
            while (true);
        }
        static int GiaiThua(int a)
        {
            if (a == 1 || a == 0)
            {
                return 1;
            }
            else
            {
                return a * GiaiThua(a - 1);
            }

        }
        static void session05_ex03()
        {
            Console.Write("Nhap so x bat ki: ");
            int x = int.Parse(Console.ReadLine());
            do
            {
                if (x < 0)
                {
                    Console.WriteLine("Nhap lai x lon hon 0");
                    continue;
                }
                else
                {
                    Prime(x);
                    break;
                }
            } while (true);
        }
        static void Prime(int a)
        {
            bool Kiemtra = true;
            for (int i = 2;  i <= Math.Sqrt(a); i++)
            {
                int b = a % i;
                if (b == 0)
                {
                    Kiemtra = false;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (Kiemtra)
            {
                Console.WriteLine($"{a} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{a} khong la so nguyen to");
            }
        }
        static void session05_ex04()
        {
            Console.Write($"Nhap so nguyen to n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i==n; i++)
            {
                if (CheckPrime(i)=true)
                {

                }
            }
        }
        static void CheckPrime(int a)
        {
            bool CheckPrime = true;
            for (int i = 2; i<=Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    CheckPrime = false;
                    break;
                }
                else { continue; }
            }
        }




    }
}
