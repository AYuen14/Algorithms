namespace BigO_Notation.Algorithms
{
    /// <summary>
    /// The core of the quicksort is the partition method.
    /// The idea is to partition an array(in 2 parts: left and the right) according to a pivot.
    /// At the end of running the partition algorithm, all the elements less than the pivot are
    /// placed on the left part and all the elements greater than the pivot are placed on the right part.
    /// The pivot sits between the 2 parts.
    /// </summary>
    public class QuickSort : BaseSort
    {
        private void Swap(int[] array, int up, int down)
        {
            int temp = array[up];
            array[up] = array[down];
            array[down] = temp;
        }

        private int Partition(int[] array, int first, int last)
        {
            //Choose a pivot(It can be random but will choose first one in this scenario)
            //Partition means divide the array into 2 sub arrays(Left and Right).
            //All the elements in the left subarray should be less or equal than to the pivot.
            //All the elemtsin the right subarray should be greater than the pivot.
            //At the end the pivot is in the right spot.
            //Repeat the partition for the left sub array and right sub array.
            int upCounter = first;
            int downCounter = last;

            if (upCounter < downCounter)
            {
                //Choose a pivot point
                int pivot = array[first];

                while (upCounter < downCounter)
                {
                    //Move the up counter until it reaches element > pivot
                    while (upCounter < last && array[upCounter] <= pivot)
                    {
                        upCounter++;
                    }

                    //Move the down counter until it reaches element < pivot
                    while (downCounter > first && array[downCounter] > pivot)
                    {
                        downCounter--;
                    }

                    //swap only if up and down have not cross
                    if (upCounter < downCounter)
                    {
                        Swap(array, upCounter, downCounter);
                    }
                }
                //Once the up and down have crossed
                //Swap the pivot with the element indicated by the down counter
                Swap(array, first, downCounter);
            }

            //Final position of the pivot
            return downCounter;

        }

        public void Sort(int[] array, int first, int last)
        {
            if(first < last)
            {
                int pivotIndex = Partition(array, first, last);

                //Partition the left side
                Sort(array, first, pivotIndex - 1);

                //Partion the right side
                Sort(array, pivotIndex + 1, last);
            }
            Display(array);
        }
    }
}
