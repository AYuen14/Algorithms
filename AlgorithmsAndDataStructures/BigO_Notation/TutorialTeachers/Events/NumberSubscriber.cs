using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers.Events
{
    internal class NumberSubscriber
    {
        private PrintHelperPublisher _printHelper;
        private int _value;

        public NumberSubscriber(int val)
        {
            _value = val;

            _printHelper = new PrintHelperPublisher();
            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }

        private void printHelper_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }
    }
}
