using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    // subscriber
    class Number
    {
        private PrintHelper _printHelper;

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
            _printHelper = new PrintHelper();
            
            // subscribe to beforePrintEvent
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            _printHelper.beforePrintEventWithMessage += printHelper_beforePrintEvent;
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(Value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(Value);
        }
    }
}
