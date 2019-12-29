using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcs
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Sum16(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o, int p)
        {
            return a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p;
        }

        static int Return5()
        {
            return 5;
        }

        static void Main(string[] args)
        {
            // last int is return type. Func must always have a return type
            Func<int, int, int> add = Sum;

            // can take up to 16 params
            Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> add16 = Sum16;

            int result = add(10, 10);
            Console.WriteLine(result);

            int result16 = add16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            // result is 136
            Console.WriteLine(result16);

            // func with 0 input param
            Func<int> return5 = Return5;
            Console.WriteLine(return5());

            Random rnd = new Random();

            // func with anon method
            Func<int> getRandomNumber = delegate ()
            {
                return rnd.Next();
            };

            Console.WriteLine(getRandomNumber());

            // func with lambda expression

            getRandomNumber = () =>
            {
                return rnd.Next();
            };

            Console.WriteLine(getRandomNumber());
        }
    }
}
