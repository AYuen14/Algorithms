namespace BigO_Notation.Algorithms
{
    using System;

    public class BinarySearch
    {
        private int[] _array;

        public BinarySearch(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            this._array = array;
        }

        /// <summary>
        /// Iterative binary search, This must be sorted.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public int IterativeBinarySearch(int searchValue)
        {
            int first = 0;
            int last = _array.Length - 1;

            while(first <= last)
            {
                int mid = (first + last) / 2;

                if(_array[mid] == searchValue)
                {
                    return mid;
                }
                else if(_array[mid] < searchValue)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            //Value not found
            return -1;
        }

        /// <summary>
        /// Recursive binary search, this has to be sorted.
        /// </summary>
        /// <param name="searchValue"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        public int RecursiveBinarySearch(int searchValue, int first, int last)
        {
            if(last < first)
            {
                return -1;
            }

            int mid = (first + last) / 2;       

            if (_array[mid] == searchValue)
            {
                return mid;
            }
            else if (_array[mid] < searchValue)
            {
                //search right part of the array
                first = mid + 1;
            }
            else
            {
                //search left part of the array
                last = mid - 1;
            }

            return RecursiveBinarySearch(searchValue, first, last);
        }
    }
}
