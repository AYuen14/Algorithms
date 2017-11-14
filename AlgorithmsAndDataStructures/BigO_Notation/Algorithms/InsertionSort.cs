namespace BigO_Notation
{
    using System;
    using System.Diagnostics;

    using BigO_Notation.Algorithms;

    public class InsertionSort : BaseSort
    {
        private int[] _array;

        private Stopwatch _stopWatch;

        public InsertionSort(int[] array, Stopwatch stopWatch)
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (stopWatch == null)
            {
                throw new ArgumentNullException(nameof(stopWatch));
            }

            this._array = CreateRandomArray(array);
            this._stopWatch = stopWatch;
        }

        /// <summary>
        /// Insertion sort
        /// </summary>
        /// <param name="array"></param>
        public void Sort()
        {
            Display(this._array);
            StartTimer(this._stopWatch);

            for (int i = 1; i < _array.Length -1; i++)
            {
                int j = i;
                while (j > 0 && _array[j] < _array[j - 1])
                {
                    Swap(_array, j, j - 1);
                    j--;
                }
            }

            StopTimer(this._stopWatch);
            Display(this._array);
            DisplayTimer(this._stopWatch);
        }
    }

}
