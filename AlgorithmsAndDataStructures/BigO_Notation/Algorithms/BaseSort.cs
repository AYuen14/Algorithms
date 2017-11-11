using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    public abstract class BaseSort
    {
        /// <summary>
        /// Swaps arrays index value
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i]; //1
            array[i] = array[j]; //1
            array[j] = temp;  //1
        }

        /// <summary>
        /// Display array values.
        /// </summary>
        /// <param name="array"></param>
        public static void Display(int[] array)
        {
            string tempVariable = string.Empty; //1

            foreach (int x in array) //n
            {
                tempVariable += string.Format("{0},", x.ToString());//n
            }

            Console.WriteLine(string.Format("{0} \n", tempVariable));
        }

        /// <summary>
        /// Creates a new random array
        /// </summary>
        /// <param name="x"></param>
        public static int[] CreateRandomArray(int[] x)
        {
            int[] returnArray = x;
            Random rand = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                returnArray[i] = rand.Next(0, 100);
            }

            return returnArray;
        }

        /// <summary>
        /// Starts the timer.
        /// </summary>
        /// <param name="sw">The sw.</param>
        public static void StartTimer(Stopwatch sw)
        {
            sw.Start();
        }

        /// <summary>
        /// Stops the timer.
        /// </summary>
        /// <param name="sw">The sw.</param>
        public static void StopTimer(Stopwatch sw)
        {
            sw.Stop();
        }

        /// <summary>
        /// Displays the timer.
        /// </summary>
        /// <param name="sw">The sw.</param>
        public static void DisplayTimer(Stopwatch sw)
        {
            Console.WriteLine(string.Format("Time elapsed for Sort: {0}", sw.Elapsed.Milliseconds.ToString()));
        }
    }
}
