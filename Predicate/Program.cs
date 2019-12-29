using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class Program
    {
        static bool IsHigherThan(int number)
        {
            if (number > 10)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            // predicate take one input parameter only and return bool
            Predicate<int> isHigherThan10 = IsHigherThan;
            Console.WriteLine(isHigherThan10(122));

            // predicate with anon method
            isHigherThan10 = delegate (int x)
            {
                if (x > 121)
                    return true;

                return false;
            };

            Console.WriteLine(isHigherThan10(-23));

            // predicate with lambda
            isHigherThan10 = x => x > 1000;
            Console.WriteLine(isHigherThan10(23435));
        }
    }
}
