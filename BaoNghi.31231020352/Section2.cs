

using System.Diagnostics.Metrics;

namespace BaoNghi._31231020352
{
    internal class Section2
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            Question_06();
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
            Console.WriteLine("Enter the data type: ");
            var a = Console.ReadLine();
            if {

            }
            Console.WriteLine($"The size of data is {x}");
        } 
        /// <summary>
          /// 
          /// </summary>
        public static void Question_07()
        {

        } 
        /// <summary>
          /// Add / Sum Two Numbers
          /// </summary>
        public static void Question_08()
        {

        } /// <summary>
          /// Add / Sum Two Numbers
          /// </summary>
        public static void Question_09()
        {

        } /// <summary>
          /// Add / Sum Two Numbers
          /// </summary>
        public static void Question_10()
        {

        }
    }
}
