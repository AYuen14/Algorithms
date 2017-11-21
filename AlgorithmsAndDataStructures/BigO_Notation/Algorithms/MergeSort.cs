namespace BigO_Notation.Algorithms
{
    /// <summary>
    /// N log N
    /// The core of the merge sort is the merge.
    /// </summary>
    public class MergeSort : BaseSort
    {
        public void Merge(int[] array, int first, int mid, int last)
        {
            
            int tempfirst = first;
            int tempMid = mid + 1;
            int returnArrayPointer = 0;
            int[] tempArray = new int[last - first + 1];
            

            while (tempfirst <= mid && tempMid <= last)
            {
                if(array[tempfirst] < array[tempMid])
                {
                    tempArray[returnArrayPointer] = array[tempfirst];
                    tempfirst++;
                    returnArrayPointer++;
                }
                else
                {
                    tempArray[returnArrayPointer] = array[tempMid];
                    tempMid++;
                    returnArrayPointer++;
                }   
            }

            while (tempfirst <= mid)
            {
                tempArray[returnArrayPointer] = array[tempfirst];
                tempfirst++;
                returnArrayPointer++;
            }

            while (tempMid <= last)
            {
                tempArray[returnArrayPointer] = array[tempMid];
                tempMid++;
                returnArrayPointer++;
            }

            tempfirst = first;
            for(int k = 0; k < tempArray.Length; k++)
            {
                array[tempfirst] = tempArray[k];
                tempfirst++;
            }
            
        }

        /// <summary>
        /// Merge sort recursive
        /// </summary>
        /// <param name="array"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        public void MergeSortRecursive(int[] array, int first, int last)
        {
            if(first < last)
            {
                int mid = (first + last) / 2;
                MergeSortRecursive(array, first, mid);
                MergeSortRecursive(array, mid + 1, last);
                Display(array);
                //Merge the left and the right
                Merge(array, first, mid, last);
                Display(array);
            }
        }
    }
}
