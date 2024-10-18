

using System.Diagnostics.Metrics;

namespace BaoNghi._31231020352
{
    internal class Session2
    {
        public static void Main1()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
        }
        /// <summary>
        /// Add / Sum Two Numbers
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter number a = ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b =int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }
        /// <summary>
        /// Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter number a = ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b =int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {a}");
        }
        /// <summary>
        ///  Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter number a = ");
            float a =float.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            float b =float.Parse(Console.ReadLine());
            float multiply = a * b;
            Console.WriteLine($" {a} * {b} = {multiply}");
        } /// <summary>
          /// convert feet to meter
          /// </summary>
        public static void Question_04()
        {
            Console.Write("Enter the length in feet: ");
            float feet =float.Parse(Console.ReadLine());
            double meters = feet * 0.3048;
            Console.WriteLine($"The length in meter is {meters}");
        }
        /// <summary>
        /// convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter the number in Celcius: ");
            float Celcius = float.Parse(Console.ReadLine());
            double Fahrenheit = Celcius * 33.8;
            Console.WriteLine($"The Fahrenheit is {Fahrenheit}");
            Console.Write("Enter the number in Farhenheit: ");
            double F1 = float.Parse(Console.ReadLine());
            double C1 = F1 / 33.8;
            Console.WriteLine($"The Celsius number is {C1}");
        }
        /// <summary>
        /// find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Size of Int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of decimal: " + sizeof(decimal));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of short: " + sizeof(short));
        } 
        /// <summary>
          /// Print ASCII Value
          /// </summary>
        public static void Question_07()
        {
            Console.Write("Input the character: ");
            char Character = char.Parse(Console.ReadLine());
            int ASCII = (int)Character;
            Console.WriteLine($"ASCII value: {ASCII}");
        } 
        /// <summary>
          /// Calculate Area of Circle
          /// </summary>
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh: ");
            int r = int.Parse(Console.ReadLine());
            double PI = 3.14;
            double area = PI * (r ^ 2);
            Console.WriteLine($"The Area of this circle is: {area}");
        } 
        /// <summary>
        /// Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Nhap canh: ");
            float a = float.Parse(Console.ReadLine());
            float area = a * a;
            Console.WriteLine($"The Area of this circle is: {area}");
        } 
        /// <summary>
        /// convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Nhap so ngay: ");
            int Days = int.Parse(Console.ReadLine());
            int year = Days / 365;
            int week = (Days % 365) / 7;
            int day = (Days % 365) % 7;
            Console.WriteLine($"{Days} is converted to {year} year(s), {week} week(s) and {day} day(s)");
        }
    }
}
