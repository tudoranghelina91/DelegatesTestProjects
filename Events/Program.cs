using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(123456);
            number.PrintMoney();
            number.PrintNumber();
        }
    }
}
