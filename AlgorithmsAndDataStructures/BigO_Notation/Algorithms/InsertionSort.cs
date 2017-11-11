namespace BigO_Notation
{
    using BigO_Notation.Algorithms;
    using System;

    public class InsertionSort : BaseSort
    {
        private int[] _array;

        public InsertionSort(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            this._array = array;
        }

        /// <summary>
        /// Insertion sort
        /// </summary>
        /// <param name="array"></param>
        public void Sort()
        {
            for(int i = 1; i < _array.Length -1; i++)
            {
                int j = i;
                while (j > 0 && _array[j] < _array[j - 1])
                {
                    Swap(_array, j, j - 1);
                    j--;
                }
            }
        }

        public void SortPractice()
        {

        }
    }

}
