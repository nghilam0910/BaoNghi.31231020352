
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace BaoNghi._31231020352
{
    internal class Session5
    {
        static void Main1(string[] args)
        {
            //sesion05_ex01();
            //session05_ex02();
            //session05_ex03();
            ///session05_ex04();
            ///session05_ex05();
            ///session05_ex052();
            session05_ex06();
        }
        /// <summary>
        /// Tim so lon nhat
        /// </summary>
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
        /// <summary>
        /// Tim giai thua
        /// </summary>
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
        /// <summary>
        /// Xac dinh so nguyen to
        /// </summary>
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
        /// <summary>
        /// Tim cac so nguyen to nho hon N
        /// </summary>
 
        static void session05_ex04()
        {
            Console.Write($"Nhap so n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so nguyen nho hơn {n} la:");
            for (int b = 2; b <= n; b++)
            {

                if (CheckPrime(b))
                {
                    Console.WriteLine($"{b}");
                    continue;
                }
                else
                {
                    continue;
                }
            }
        }

        static bool CheckPrime(int a)
        {
            if (a < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// Xac dinh so hoan hao
        /// </summary>
        static void session05_ex05()
        {
            do
            {
                Console.Write("Vui long nhap so nguyen duong n:");
                int n = int.Parse(Console.ReadLine());
                if (n < 0 || n == 0)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong");

                }
                else
                {
                    if (CheckPerfect(n))
                    {
                        Console.WriteLine($"{n} la so hoan hao");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{n} khong la so hoan hao");
                        break;
                    }

                }
            } while (true);
        }

        static int TimTongUoc(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                }
                else { continue; }
            }
            return sum;
        }
        static bool CheckPerfect(int y)
        {
            int sum = TimTongUoc(y);
            if (sum == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Xac dinh so hoan hao nho hon 1000
        /// </summary>
        static void session05_ex052()
        {
            Console.WriteLine("Cac so hoan hao nho hon 1000 la:");
            int z = 1;
            do
            {
                if (z < 1000)
                {
                    if (CheckPerfect(z))
                    {
                        Console.WriteLine($"{z}");
                        z = z + 1;
                    }
                    else
                    {
                        z = z + 1;
                        continue;
                    }
                }
                else { break; }
            } while (true);
        }
        /// <summary>
        /// Xac dinh Pangram
        /// </summary>
        static void session05_ex06()
        {
            Console.Write("Nhap mot tu hoac mot cau: ");
            string chuoi = Console.ReadLine();
            if (KiemChu(chuoi))
            {
                Console.WriteLine("Chuoi la pangram");
            }
            else
            {
                Console.WriteLine("Chuoi khong la pangram");
            }
        }
        static bool KiemChu(string input)
        {
            input = input.ToLower();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (input.Contains(c))
                {
                    continue;
                }
                else
                {
                    return false;

                }
            }
            return true;
        }

    }
}
