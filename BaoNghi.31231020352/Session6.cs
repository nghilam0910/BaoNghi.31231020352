using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session6
    {
        public static void Main1()
        {
            Console.Write("Vui long nhap so phan tu mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] x = new int [a];
            ///NhapSoTrongMang(x);
            RandomMang(x);
            InMang(x);
            ///Increase(x,20);
            ///SumMang(x);
            TrungBinhMang(x);
        }
        static void NhapSoTrongMang(int[]x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int sothutu = 1 + i;
                Console.Write($"Vui long nhap phan tu thu #{sothutu}: ");
                x[i] = int.Parse(Console.ReadLine()) ;
                
            }
        }
        static void InMang(int[]x)
        {
            foreach (int i in x)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void RandomMang(int[]x)
        {
            Random random = new Random();
            for (int i = 0;i < x.Length;i++)
            {
                x[i] = random.Next(100);
            }
        }
        static void Increase(int[]x, int Val)
        {
            Console.WriteLine($"Cac phan tu sau khi cong {Val} la:");
            for (int i = 0;i < x.Length;i++)
            {
                x[i] += Val;
                Console.Write($"{x[i]} ");
            }
        }
        static int SumMang(int[]x)
        {
            int sum = 0;
            for (int i = 0; i<x.Length ; i++)
            {
                sum += x[i];
            }
            Console.WriteLine($"Tong cac phan tu la: {sum}");
            return sum;
        }
        static void TrungBinhMang(int[]x)
        {
            float sum = SumMang(x);
            float avg = sum / x.Length;
            Console.WriteLine($"Trung binh cac phan tu la: {avg}");
        }
    }
}
