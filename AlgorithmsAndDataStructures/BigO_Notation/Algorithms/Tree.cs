namespace BigO_Notation.Algorithms
{
    using BigO_Notation.Algorithms.Base;
    using System;
    using System.Collections;

    internal class Tree
    {
        BaseTreeNode _root;
        int _count;

        public enum Traversal
        {
            InOrder,
            PreOrder,
            PostOrder
        }

        public Tree(BaseTreeNode node)
        {
            if(node == null)
            {
                this._root = null;
                this._count = 0;
            }
            else
            {
                this._root = node;
                this._count = 1;
            }

            PopulateTree();
        }

        /// <summary>
        /// Populates dummy data
        /// </summary>
        private void PopulateTree()
        {
            InsertIterative(50, "john");
            InsertIterative(40, "stacy");
            InsertIterative(75, "tim");
            InsertIterative(30, "laura");
            InsertIterative(45, "mike");
            InsertIterative(20, "stacy");
            InsertIterative(35, "joe");
        }

        /// <summary>
        /// Move to the left of the node recursively
        /// get/display the node
        /// move the right of the node recursively
        /// </summary>
        /// <param name="node"></param>
        /// <param name="queue"></param>
        private void TraversalInOrder(BaseTreeNode node, Queue queue)
        {
            //When its last left node in the subtree
            if(node == null)
            {
                return;
            }

            TraversalInOrder(node._left, queue);

            queue.Enqueue(node._entry);

            TraversalInOrder(node._right, queue);
        }

        /// <summary>
        /// Node, left, right
        /// this maintains the structure of the tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="queue"></param>
        private void TraversalPreOrder(BaseTreeNode node, Queue queue)
        {
            if (node == null)
            {
                return;
            }

            queue.Enqueue(node._entry);

            TraversalPreOrder(node._left, queue);

            TraversalPreOrder(node._right, queue);
        }

        /// <summary>
        /// Left, right, node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="queue"></param>
        private void TraversalPostOrder(BaseTreeNode node, Queue queue)
        {
            if (node == null)
            {
                return;
            }
            TraversalPostOrder(node._left, queue);
            TraversalPostOrder(node._right, queue);
            queue.Enqueue(node._entry);         
        }

        /// <summary>
        /// Displays the nodes
        /// </summary>
        /// <param name="display"></param>
        public void DisplayNodes(Traversal display)
        {
            
            Queue queue = new Queue();
            string DisplayTraversal = string.Empty;
            switch (display)
            {
                case Traversal.InOrder:
                    TraversalInOrder(this._root, queue);
                    DisplayTraversal = display.ToString();
                    break;
                case Traversal.PreOrder:
                    TraversalPreOrder(this._root, queue);
                    DisplayTraversal = display.ToString();
                    break;
                default:
                    TraversalPostOrder(this._root, queue);
                    DisplayTraversal = display.ToString();
                    break;
            }
            Console.WriteLine(string.Format("{0}", DisplayTraversal));
            foreach (DictionaryEntry de in queue)
            {
                Console.WriteLine(string.Format("Key:{0}, Value:{1}", de.Key, de.Value));
            }
        }

        /// <summary>
        /// Interative insert algorithm
        /// </summary>
        public void InsertIterative(int key, object value)
        {
            //Create a new node
            BaseTreeNode newNode = new BaseTreeNode(key, value);

            if(this._root == null)
            {
                this._root = newNode;
                this._count = 1;
                return;
            }
            //The parent will keep track of parent node of the child
            BaseTreeNode parent = null;
            BaseTreeNode temp = this._root;

            while(temp != null)
            {
                //When the temp reaches null, the parent will be pointing to the node we will be attaching the new node to.
                parent = temp;

                //Compare the key of the new node with the key of temp node
                if(key == (int)temp._entry.Key)
                {
                    throw new ArgumentException("Key must be unique");
                }

                //Compare if key will go left or right
                if(key > (int)temp._entry.Key)
                {
                    temp = temp._right;
                }
                else
                {
                    temp = temp._left;
                }
            }

            if(key > (int)parent._entry.Key)
            {
                parent._right = newNode;
            }
            else
            {
                parent._left = newNode;
            }

            this._count++;
        }

        /// <summary>
        /// Recursive insert algorithm
        /// </summary>
        public void InsertRecursive()
        {

        }
    }
}
