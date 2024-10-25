using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session3
    {
        public static void Main1()
        {
            //Ex_01();
            Ex_02();
        }
        /// <summary>
        /// Doi do C thanh K và F
        /// </summary>
        public static void Ex_01()
        {
            Console.Write("Enter a Celsius: ");
            float Celsius = float.Parse(Console.ReadLine());
            float Kelvin = Celsius + 273;
            float Fahrenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {Kelvin}");
            Console.WriteLine($"Fahrenheit = {Fahrenheit}");
        }
        /// <summary>
        /// Tinh the tich va dien tich hinh cau
        /// </summary>
        public static void Ex_02()
        {
            Console.Write("Nhap ban kinh mat cau: ");
            float Radius = float.Parse(Console.ReadLine());
            float PI = 3.14f;
            float surface = 4 * PI * Radius * Radius;
            double volume = (4 / 3) * PI * (Radius * Radius * Radius);
            Console.WriteLine($"Surface = {surface}");
            Console.WriteLine($"Volume = {volume}");
        }
        public static void Ex_03()
        {
            Console.Write("Nhap so a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            float b = float.Parse(Console.ReadLine());
            float sum = a + b;
            float substract = a - b;
            float multi = a * b;
            float divide = a / b;
            float mod = a % b;
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {substract}");
            Console.WriteLine($"a * b = {multi}");
            Console.WriteLine($"a / b = {divide}");
            Console.WriteLine($"a mod b = {mod}");
        }
    }
}
