namespace BigO_Notation.Algorithms
{
    using System;
    using System.Diagnostics;

    public class SelectionSort : BaseSort
    {
        private int[] _array;

        private Stopwatch _sw;

        public SelectionSort(int[] array, Stopwatch sw)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (sw == null)
            {
                throw new ArgumentNullException(nameof(sw));
            }

            this._array = CreateRandomArray(array);
            this._sw = sw;
        }

        /// <summary>
        /// Run a loop for i=0 to n-1
        /// </summary>
        /// <param name="array"></param>
        public void Sort()
        {
            //find the index of the smallest element(min index) from i to end
            for (int i = 0; i < _array.Length - 1; i++)
            {
                int tempMinIndex = i;
                for (int j = i + 1; j < _array.Length; j++)
                {
                    //Swap i with min index
                    if (_array[j] < tempMinIndex)
                    {
                        tempMinIndex = j;
                    }
                }

                Swap(_array, i, tempMinIndex);
            }
        }

        public void SortPractice()
        {
            Display(this._array);
            StartTimer(this._sw);

            for(int i = 0; i < this._array.Length-1; i ++)
            {
                int minVariable = i;
                for(int j = i; j < _array.Length; j++)
                {
                    if(this._array[j] < this._array[minVariable])
                    {
                        minVariable = j;
                    }
                }

                Swap(this._array, i, minVariable);
            }

            StopTimer(this._sw);
            Display(this._array);
            DisplayTimer(this._sw);
        }
    }
}
