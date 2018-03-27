using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        private static bool IsPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

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
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            const int LENGTH = 256;
            int[] count = new int[LENGTH];

            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }

            int nOdd = 0;

            for (int i = 0; i < LENGTH; i++)
            {
                if ((count[i] & 1) != 0)
                {
                    nOdd++;
                }
                    
                if (nOdd > 1)
                {
                    return false;
                }
            }

            return true;
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
