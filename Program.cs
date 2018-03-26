using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        private static bool IsPalindrome(string str)
        {
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsAnagramOfPalindrome(string str)
        {
            var charCount = str.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count()
            });

            return charCount.Count(c => c.count % 2 == 1) <= 1;
        }

        static void Main(string[] args)
        {
            var test1 = new string[]
            {
                "single",
                "singlecellecelgnis",
                "oddo",
                "odado"
            };

            foreach (var item in test1)
            {
                Console.WriteLine($"{item}: {IsPalindrome(item)}");
            }

            Console.WriteLine("------------");

            var test2 = new string[]
            {
                "aab",
                "possoff",
                "abc"
            };

            foreach (var item in test2)
            {
                Console.WriteLine($"{item}: {IsAnagramOfPalindrome(item)}");
            }

            Console.ReadLine();
        }
    }
}
