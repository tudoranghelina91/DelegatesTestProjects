using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class PrintHelper
    {
        // delegate
        public delegate void BeforePrint();
        public delegate void BeforePrintWithMessage(string message);
        public event BeforePrint beforePrintEvent;
        public event BeforePrintWithMessage beforePrintEventWithMessage;

        public void PrintNumber(int num)
        {
            // call delegate method before going to print
            if (beforePrintEvent != null)
            {
                beforePrintEvent();
            }
            // sau
            //beforePrintEvent?.Invoke();
            beforePrintEventWithMessage?.Invoke("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            beforePrintEvent?.Invoke();
            beforePrintEventWithMessage?.Invoke("PrintDecimal");
            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            beforePrintEvent?.Invoke();
            beforePrintEventWithMessage?.Invoke("PrintMoney");
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            beforePrintEvent?.Invoke();
            beforePrintEventWithMessage?.Invoke("PrintTemperature");
            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            beforePrintEvent?.Invoke();
            beforePrintEventWithMessage?.Invoke("PrintHexadecimal");
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
