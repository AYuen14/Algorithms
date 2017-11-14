using System;

namespace BigO_Notation.Algorithms.Base
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(object Item)
        {
            if (Item == null)
            {
                throw new ArgumentNullException(nameof(Item));
            }

            this.Value = Item;
            this.Next = this.Previous = null;
        }
    }

    public abstract class BaseLinkList
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public int Count { get; set; }
    }
}
