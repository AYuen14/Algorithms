using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.CodeWars
{
    public class Easy
    {

        public Easy()
        {
            int output;
            int[] array = new int[]{ 2, 3, 10, 6, 4, 8, 1};
            int[] array2 = new int[] { 7, 9, 5, 6, 3, 2 };
            output = MaximumDifferenceBetweenTwoElementsInArray(array2);
        }

        public int MultiplesThreeOrFive(int value)
        {
            int output = 0;

            for(int i = 0; i <= value -1;i++)
            {
                if(i % 3 == 0)
                {
                    output += i;
                }
                else if(i % 5 == 0)
                {
                    output += i;
                }
            }

            return output;
        }

        public int MaximumDifferenceBetweenTwoElementsInArray(int[] array)
        {
            int output = 0;

            output = array[0] - array[1];

            for(int i = 0; i <= array.Length-1; i++)
            {

                for(int x = i; x < array.Length-1;x++)
                {
                    int diff = array[x] - array[i];

                    if (output < diff)
                    {
                        output = diff;
                    }
                }

            }

            return output;
        }
    }
}
