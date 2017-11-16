using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    /// <summary>
    /// A recursive method is a method that calls itself
    /// </summary>
    public class RecursiveMethods
    {
        public RecursiveMethods()
        {

        }

        /// <summary>
        /// display intergers up to n
        /// </summary>
        /// <param name="n"></param>
        public void DisplayInts(int n)
        {
            StringBuilder display = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                display.Append(string.Format("{0}, ", i));
            }

            Console.WriteLine(display);
        }

        /// <summary>
        /// Recursive display
        /// </summary>
        /// <param name="n"></param>
        public void RecursiveDisplayInts(int n)
        {
            if(n == 0)
            {
                return;
            }

            Console.WriteLine(string.Format("{0}", n));
            RecursiveDisplayInts(n-1);
        }

        /// <summary>
        /// This will get displayed once the return triggers.
        /// </summary>
        /// <param name="n"></param>
        public void RecursiveDisplayIntsConsoleAfterReturn(int n)
        {
            if (n == 0)
            {
                return;
            }
            
            RecursiveDisplayInts(n - 1);
            Console.WriteLine(string.Format("{0}", n));
        }

        /// <summary>
        /// Iterative factorial
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int IterativeFactorial(int n)
        {
            int returnInt = 1;

            for(int i = n; i > 1; i--)
            {
                returnInt *= i;
            }

            Console.WriteLine(string.Format("IterativeFactorial: {0}", returnInt));
            return returnInt;
        }

        /// <summary>
        /// Recursive factorial method
        /// Breaks problem into smaller problems to build the answer
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int RecursiveFactorial(int n)
        {
            //Check for negative values
            if (n < 0)
                throw new ArgumentOutOfRangeException("Negative values are not allowed");

            //Check if n is either 1 or 0
            if (n == 1 || n == 0)
                return 1;

            //Recursive call to get factorial
            int returnInt = n * RecursiveFactorial(n-1);
            
            Console.WriteLine(string.Format("RecursiveFactorial: {0}", returnInt));
            return returnInt;

        }

        public void RecursiveReverseArray(int[] array, int first, int last)
        {
            if(first >= last)
            {
                return;
            }

            int temp = array[first];
            array[first] = array[last];
            array[last] = temp;

            Display(array);
            RecursiveReverseArray(array, first + 1, last - 1);
            Display(array);
        }

        /// <summary>
        /// Display array values.
        /// </summary>
        /// <param name="array"></param>
        private void Display(int[] array)
        {
            StringBuilder tempVariable = new StringBuilder(); //1

            foreach (int x in array) //n
            {
                tempVariable.Append(string.Format("{0},", x.ToString()));//n
            }

            Console.WriteLine(string.Format("{0} \n", tempVariable));
        }
    }
}
