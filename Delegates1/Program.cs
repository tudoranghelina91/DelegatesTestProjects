using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    class Program
    {
        public delegate void Print(int value);

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

        static void Main(string[] args)
        {
            Print printDel = PrintNumber;
            // sau
            //Print printDel = new Print(PrintNumber);

            printDel(1000000);
            printDel(200);
            
            Console.WriteLine();
            
            printDel = PrintMoney;

            printDel(1000000);
            printDel(200);
            
            Console.WriteLine();

            // invoke method assigned to delegate
            printDel.Invoke(4000);
            
            Console.WriteLine();

            printDel = PrintNumber;
            // invoke method assigned to delegate
            printDel.Invoke(4000);
            
            Console.WriteLine();

            // Delegate as parameter to a method allows to pass method name as parameter to another method
            PrintHelper(PrintNumber, 2000);
            PrintHelper(PrintMoney, 2000);
            
            Console.WriteLine();

            // Multicast delegate allows lets you assign multiple methods to same delegate

            // add methods to delegate
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(2500);

            Console.WriteLine();

            // remove PrintNumber method from delegate
            printDel -= PrintNumber;

            printDel(2100);
        }
    }
}
