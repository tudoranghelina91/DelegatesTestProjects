using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    public delegate void Print(int val);
    class Program
    {
        static int j = 120;

        // anon method as parameter
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 20;
            printDel(val);
        }

        static void Main(string[] args)
        {
            /* 1. Anonymous methods = method without name
             * 2. Can be defined with delegate keyword and assigned to a variable of delegate type
             */

            Print print = delegate (int val)
            {
                Console.WriteLine($"Inside anonymous method {val}");
            };

            print(1200);

            Console.WriteLine();
            // Anonymous methods can access variables defined in an outer function / scope
            int i = 10;

            Print print2 = delegate (int val)
            {
                val += i;
                Console.WriteLine($"Anonymous method {val}");
                val += j;
                Console.WriteLine($"Anonymous method {val}");
            };

            print2(600);

            // Method with anon function as parameter
            PrintHelperMethod(delegate (int val) 
            { 
                Console.WriteLine($"Anonymous method: {val}"); 
            }, 1500);

            // Anon method as event handlers
            Number number = new Number(15400);
            number.PrintHelper.beforePrintEvent += delegate()
            {
                Console.WriteLine($"Hello from anonymous method! Value of number is {number.Value}");
            };

            number.PrintNumber();
        }
    }
}
