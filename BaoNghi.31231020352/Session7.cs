using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session7
    {
        public static void Main7()
        {
            int[,] a;
            do
            {
                Console.Write("Vui long nhap so dong: "); int rows = int.Parse(Console.ReadLine());
                Console.Write("Vui long nhap so cot: "); int cols = int.Parse(Console.ReadLine());
                if (rows < 0 || cols < 0)
                {
                    Console.WriteLine("Vui long nhap lai");
                }
                else
                {
                    a = new int[rows, cols];
                    break;
                }
            }while (true); 
            NhapMangRandom(a);
            InMang(a);
            /*do
            {
                Console.Write("Nhap so cot muon in: "); int col = int.Parse(Console.ReadLine());
                if (col > a.GetLength(1) - 1 || col <0)
                {
                    Console.WriteLine("Vui long nhap lai");
                }
                else
                {
                    InCotThui(a, col);
                    break;
                }
            }while(true);*/
            
            TimMax(a);
            Console.WriteLine();
            Transpose(a);
        }

        

        private static void TimMax(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max) { max = a[i, j]; }
                    else { continue; }
                }
                
            }
            Console.WriteLine($"So lon nhat la {max}");
        }

        private static void InMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void NhapMangRandom(int[,]a)
        {
            Random random = new Random();
            for (int i = 0; i<a.GetLength(0); i++ )
            {
                for (int j = 0; j<a.GetLength(1); j++ )
                {
                    a[i, j] = random.Next(100);
                }
            }

        }
        private static void InCotThui(int[,] a, int col)
        {
                    for (int i = 0; i < a.GetLength(0); i++)
                    {
                        Console.WriteLine($"{a[i, col]} ");
                    }
        }
        private static void Transpose(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = a[j,i];
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }




    }
}
