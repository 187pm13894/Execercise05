using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    char c = Console.ReadKey().KeyChar;
            //    Console.WriteLine(" " + Char2Code(c));
            //}
            Console.WriteLine(ToUpper('A'));
        }
        
        public static void Print_a_2_z_v1()
        {
            char c = 'a';
            for (int i = 0; i < 26; i ++)
            {
                Console.WriteLine(c);
                c++;
            }

        }

        public static void Print_a_2_z_v2()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }

        public static int Char2Code(char c)
        {
            return (int)c;
        }

        public static bool IsUpper(char c)
        {
            bool isupper = false;
            int n = (int)c;
            if(n >= 65 && n <= 90)
            {
                isupper = true;
            }
           return isupper ;
        }

        public static bool IsLower(char c)
        {
            bool islower = false;
            int n = (int)c;
            if(n >= 97 && n <= 122)
            {
                islower = true;
            }
            return islower;
        }

        public static char ToUpper(char c)
        {
            int n;
            if (IsUpper(c) == false) ;
               n = (int)c - 23;
            return (char)n; 
        }

        public static char ToLower(char c)
        {
            int n = (int)c;
            if (IsLower(c) == false) ;
            {
                n = n - 23;
            }
            return (char)n; 
        }
    }
}
