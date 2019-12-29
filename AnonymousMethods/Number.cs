using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{

    // subscriber
    class Number
    {
        public PrintHelper PrintHelper { get; set; }

        public int Value { get; private set; }

        // beforePrintEvent Handler
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforePrintEventHandler: PrintHelper is going to print a value");
        }

        // beforePrintWithMessage Handler
        void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine($"BeforePrintEvent fires from {message}");
        }

        public Number(int val)
        {
            Value = val;
            PrintHelper = new PrintHelper();

            // subscribe to beforePrintEvent
            PrintHelper.beforePrintEvent += printHelper_beforePrintEvent;
            PrintHelper.beforePrintEventWithMessage += printHelper_beforePrintEvent;
        }

        public void PrintMoney()
        {
            PrintHelper.PrintMoney(Value);
        }

        public void PrintNumber()
        {
            PrintHelper.PrintNumber(Value);
        }
    }
}
