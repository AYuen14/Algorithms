﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers.Events
{
    internal class PrintHelperPublisher
    {
        public delegate void BeforePrint(string message);

        public event BeforePrint beforePrintEvent;

        public PrintHelperPublisher()
        {

        }

        public void PrintNumber(int num)
        {
            //call delegate method before going to print
            if (beforePrintEvent != null)
                beforePrintEvent("PrintNumber");

            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintDecimal");

            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintMoney");

            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemperature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }
        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}
