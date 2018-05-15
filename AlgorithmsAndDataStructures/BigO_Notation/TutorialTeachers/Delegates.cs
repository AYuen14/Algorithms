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

            //func
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);

            //Action
            Action<int> printActionDelegate = ConsolePrint;
            printActionDelegate(10);

            //Predicate
            Predicate<string> isUpper = isUpperCase;
            bool result2 = isUpperCase("hello world!!");

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

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        #region Funcs
        //a delegate that returns a value
        private static void FuncWithAnonymousMethod()
        {
            Func<int> getRandomNumber = delegate ()
            {
                Random rand = new Random();
                return rand.Next(1, 100);
            };
        }

        private static void FuncWithLambdaExpression()
        {
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
        }
        #endregion

        #region Actions
        //a delegate that returns no value
        private static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        #endregion

        #region Predicates
        private static bool isUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        #endregion
    }
}
