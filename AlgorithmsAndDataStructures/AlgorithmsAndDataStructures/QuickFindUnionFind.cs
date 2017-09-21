namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Takes N^2 array access to process sequence of N union commands of N objects.
    /// Takes O^n to initialize
    /// Takes O^n to union
    /// Takes O^1 to find value in array
    /// </summary>
    public class QuickFindUnionFind
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int[] id;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickFindUnionFind"/> class.
        /// </summary>
        /// <param name="n">The n.</param>
        public QuickFindUnionFind(int n)
        {
            id = new int[n];
            //Initialize the int array
            for(int i = 0; i < n;i++)
            {
                id[i] = i;
            }
        }

        /// <summary>
        /// Unions the specified pointer a.
        /// </summary>
        /// <param name="pointerA">The pointer a.</param>
        /// <param name="pointerB">The pointer b.</param>
        public void Union(int pointerA, int pointerB)
        {
            int pointAValue = id[pointerA];
            int pointBValue = id[pointerB];

            for(int i = 0; i < ReturnCount(); i++)
            {
                if(id[i] == pointAValue)
                {
                    id[i] = pointBValue;
                }
            }
        }

        /// <summary>
        /// Determines whether the specified pointer a is connected.
        /// </summary>
        /// <param name="pointerA">The pointer a.</param>
        /// <param name="pointerB">The pointer b.</param>
        /// <returns>
        ///   <c>true</c> if the specified pointer a is connected; otherwise, <c>false</c>.
        /// </returns>
        public bool IsConnected(int pointerA, int pointerB)
        {
            bool isConnected = false;

            if(id[pointerA] == id[pointerB])
            {
                isConnected = true;
            }

            return isConnected;
        }

        /// <summary>
        /// Finds the specified pointer.
        /// </summary>
        /// <param name="pointer">The pointer.</param>
        /// <returns></returns>
        public int Find(int pointer)
        {
            int newPointer = 0;

            for(int i = 0; i < ReturnCount(); i++)
            {
                if(pointer == int.Parse(id[i].ToString()))
                {
                    newPointer = id[i];
                }
            }

            return newPointer;
        }

        /// <summary>
        /// Returns the count.
        /// </summary>
        /// <returns></returns>
        public int ReturnCount()
        {
            return id.Length;
        }
    }
}
