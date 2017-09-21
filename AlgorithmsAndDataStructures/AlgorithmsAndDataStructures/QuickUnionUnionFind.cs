namespace AlgorithmsAndDataStructures
{
    /// <summary>
    /// Quick Union can be slow because Trees can get tall and the find is too expensive.
    /// Takes O^n to initialize
    /// Takes O^n to union and includes finding root
    /// Takes O^n to find value in array worst case scenario
    /// </summary>
    public class QuickUnionUnionFind
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int[] id;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuickUnionUnionFind"/> class.
        /// </summary>
        /// <param name="n">The n.</param>
        public QuickUnionUnionFind(int n)
        {
            id = new int[n];

            for(int i = 0; i< n; i++)
            {
                id[i] = i;
            }
        }

        /// <summary>
        /// Finds the root.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        private int FindRoot(int i)
        {
            while(i != id[i])
            {
                i = id[i];
            }

            return i;
        }

        /// <summary>
        /// Unions the specified pointer a.
        /// </summary>
        /// <param name="pointerA">The pointer a.</param>
        /// <param name="pointerB">The pointer b.</param>
        public void Union(int pointerA, int pointerB)
        {
            int pointerAId = FindRoot(pointerA);
            int pointerBId = FindRoot(pointerB);

            id[pointerA] = pointerBId;
        }

        /// <summary>
        /// Determines whether the specified pointer a is connected to pointer b.
        /// </summary>
        /// <param name="pointerA">The pointer a.</param>
        /// <param name="pointerB">The pointer b.</param>
        /// <returns>
        ///   <c>true</c> if the specified pointer a is connected; otherwise, <c>false</c>.
        /// </returns>
        public bool IsConnected(int pointerA, int pointerB)
        {
            bool connected = false;

            if(id[pointerA] == id[pointerB])
            {
                connected = true;
            }

            return connected;
        }


    }
}
