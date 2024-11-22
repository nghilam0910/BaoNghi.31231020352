using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoNghi._31231020352
{
    internal class Session8
    {
        public static void Main()
        {
            string s1 = "Hello Future by NCT Dream in 2022";
            string s2 = "Hello from the other sideeeeee";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //Console.WriteLine("Length of string: " + len(s1));
            //Seppprint(s1);
            //Reverse(s1);
            //Console.WriteLine("Number of words: " +words(s1));
            //Check(s1);
            //VorC(s1);
            Console.WriteLine(Comp(s1,s2));
            Console.WriteLine("Nhap substring: ");
            string sub = Console.ReadLine();
            Kiemtra(s1, sub);


        }

        private static void Kiemtra(string s1, string? sub)
        {
            s1 = s1.ToLower();
            sub = sub.ToLower();
            if (s1.Contains(sub))
            {
                Console.WriteLine("Substring co trong string");
            }
            else
            {
                Console.WriteLine("Substring khong co trong string");
            }
        }

        static int len(string s)
        {
            int l = 0;
            foreach (char c in s) l++;
            return l;
        }
        static void Seppprint(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]} \t");
            }
        }
        static void Reverse(string s)
        {
            for (int i = s.Length-1; i>=0; i--)
            {
                Console.Write($"{s[i]} \t");
            }
        }
        static int words(string s)
        {
            s=s.Trim();
            string[] w = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return w.Length;
        }
        static void Check(string s)
        {
            int NumCount = 0;
            int CharCount = 0;
            int SpecCount = 0;
            foreach(char c in s)
            {
                if (Char.IsLetter(c))
                {
                    CharCount++;
                }
                else if (Char.IsDigit(c))
                {
                    NumCount++;
                }
                else if (Char.IsSymbol(c) || Char.IsWhiteSpace(c) || Char.IsPunctuation(c))
                {
                    SpecCount++;
                }
            }
            Console.WriteLine("Number of number: " + NumCount);
            Console.WriteLine("Number of digits: " + CharCount);
            Console.WriteLine("Number of special characters: " + SpecCount);
        }
        static void VorC(string s)
        {
            int VowCount = 0;
            int ConCount = 0;
            s = s.ToLower();
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                {
                    continue;
                }
                else if (c=='a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    VowCount++;
                }
                else { ConCount++; }
            }
            Console.WriteLine($"Number of vowels: {VowCount}");
            Console.WriteLine($"Number of consonents: {ConCount}");
        }
        static int Comp (string s1, string s2)
        {
            
            int min = s1.Length < s2.Length ? s1.Length : s2.Length;
            int i = 0;
            while ( i < min )
            {
                if (s1[i] > s2[i]) { return 1; }
                else if (s1[i] < s2[i]) { return -1; }
                i++;
            }
            if (s1.Length > s2.Length) { return 1; } else if (s1.Length < s2.Length) { return -1; }
            return 0;
        }

    }
}
