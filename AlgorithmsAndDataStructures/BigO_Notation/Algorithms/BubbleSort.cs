namespace BigO_Notation.Algorithms
{
    using System;
    using System.Diagnostics;

    public class BubbleSort :BaseSort
    {
        /// <summary>
        /// The array
        /// </summary>
        private int[] _array;

        /// <summary>
        /// The stop watch
        /// </summary>
        private Stopwatch _stopWatch;

        public BubbleSort(int[] array, Stopwatch stopWatch)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if(stopWatch == null)
            {
                throw new ArgumentNullException(nameof(stopWatch));
            }

            this._array = CreateRandomArray(array);
            this._stopWatch = stopWatch;
        }

        /// <summary>
        /// Sorts min value to the top.
        /// </summary>
        /// <param name="array"></param>
        public void Sort()//Big O(n^2)
        {
            int n = _array.Length; //1

            for (int i = 1; i < n; i++) //1 + n + n
            {
                for (int j = 0; j < n - i; j++) //n + n^2/2 - n/2 + n^2/2 - n/2 = n + n^2 - n = n^2
                {
                    if (_array[j] > _array[j + 1]) //n^2/2 - n/2
                    {
                        Swap(_array, j, j + 1); //n^2
                    }
                }
            }
        }

        public void SortPractice()
        {
            Display(this._array);
            StartTimer(this._stopWatch);

            for(int i = 1; i < this._array.Length; i++)
            {
                for(int j = 0; j < this._array.Length - i; j++)
                {
                    if(this._array[j] < this._array[j + 1])
                    {
                        swap(this._array, j, j + 1);
                    }
                }
            }

            StopTimer(this._stopWatch);
            Display(this._array);
            DisplayTimer(this._stopWatch);
        }

        public void swap(int[] array, int value1, int value2)
        {
            int temp = array[value1];
            array[value1] = array[value2];
            array[value2] = temp;
        }
    }
}
