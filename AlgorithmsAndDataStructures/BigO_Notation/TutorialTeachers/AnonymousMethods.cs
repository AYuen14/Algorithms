using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal class AnonymousMethods
    {
        public delegate void Print(int value);

        public AnonymousMethods()
        {
            int i = 10;

            Print print = delegate (int value)
            {
                value += i;
                Console.WriteLine("Inside Anonymous method. Value: {0}", value);
            };

            print(1000);

            PrintHelperMethod(delegate (int value) { Console.WriteLine("Anonymous method: {0}", value); }, 100);
        }

        public static void PrintHelperMethod(Print printDelegate, int value)
        {
            value += 10;
            printDelegate(value);
        }
    }
}
