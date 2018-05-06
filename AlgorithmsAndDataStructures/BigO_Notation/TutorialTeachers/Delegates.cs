using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    public class Delegates
    {
        internal delegate void print(int value);

        public Delegates()
        {
            print printDeletegate = PrintNumber;
            printDeletegate += PrintNumber;
            printDeletegate += PrintMoney;
            printDeletegate += PrintHexadecimal;

            printDeletegate(10000);
        }

        private static void PrintHelper(print delegateFunc, int number)
        {
            delegateFunc(number);
        }

        private static void PrintNumber(int number)
        {
            Console.WriteLine("Nuber: {0, -12:N0}", number);
        }

        private static void PrintMoney(int number)
        {
            Console.WriteLine("Money: {0:C}", number);
        }

        private static void PrintHexadecimal(int number)
        {
            Console.WriteLine("Money: {0:X}", number);
        }
    }
}
