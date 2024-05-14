using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOccurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Occurance());
            Console.WriteLine();

            Console.WriteLine(createString());
            Console.WriteLine();

            Console.WriteLine(JoinString());
            Console.WriteLine();

            Console.WriteLine(containString());
            Console.WriteLine();

            Console.WriteLine(RemoveCombine());
            Console.WriteLine();

            Console.WriteLine(FirstLastString());

        }


        public static bool Occurance()
        {
            string s = "jaava";

            Console.WriteLine(s);

            Console.WriteLine("first occurance of 'a' is immediatily next");

            int c = 0;

            for(int i = 0; i < s.Length-1; i++)
            {
                if(s.Equals("a"))
                {
                    c++;
                }

                if(s.Substring(i, 2).Equals("aa") && c < 2) 
                {
                    return true;
                }
            }

            return false;
        }


        public static string createString()
        {
            string s = "abcd";

            Console.WriteLine(s);

            Console.WriteLine("After create new string");
            var result = string.Empty;

            for(int i = 0; i < s.Length; i++)
            {
                result += s.Substring(0, i+1);
            }

            return result;
        }


        public static string JoinString()
        {
            string s1 = "hi";
            string s2 = "hello";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("Join string");

            return s1 + s2 + s2 + s1;

        }


        public static string containString()
        {
            string s = "[[]]";
            Console.WriteLine(s);

            string word = "Hello";

            Console.WriteLine(word);

            Console.WriteLine("String middle another string");

            return s.Substring(0, 2) + word + s.Substring(2);

        }


        public static string RemoveCombine()
        {
            string s1 = "hi";
            string s2 = "hello";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("Remove first and combine both");

            return s1.Substring(1) + s2.Substring(1);

        }


        public static string FirstLastString()
        {
            string s1 = "Hello";
            Console.WriteLine(s1);
            string s2 = "Hi";
            Console.WriteLine(s2);

            Console.WriteLine("Combine first and last character of both string");

            string last = string.Empty;

            if(s1.Length > 0)
            {
                last += s1.Substring(0, 1);
            }
            else
            {
                last += "#";
            }


            if(s2.Length > 0)
            {
                last += s2.Substring(s2.Length-1);
            }
            else
            {
                last += "#";
            }

            return last;
        }
    }
}
