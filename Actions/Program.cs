using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    class Program
    {
        static void Print(int number)
        {
            Console.WriteLine(number);
        }

        static void PrintSum16(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p)
        {
            Console.WriteLine(a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p);
        }

        static void Main(string[] args)
        {
            // Action delegates don't return values, can take up to 16 input parameters
            Action<int> printAction = Print;
            printAction(1000);
            
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> printSum16 = PrintSum16;
            printSum16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            // Action delegate with new keyword
            printAction = new Action<int>(Print);
            printAction(1234);

            // Action delegate with anonymous method

            printAction = delegate (int x)
            {
                Console.WriteLine($"I am anonymous. My value is {x}");
            };

            printAction(154);

            // Action delegate with lambda expression
            printAction = x => Console.WriteLine($"I am anonymous. My value is {x}");

            printAction(2543);
        }
    }
}
