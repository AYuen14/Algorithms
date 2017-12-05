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

            PopulateTree(true);
        }

        #region HelperMethod

        /// <summary>
        /// Populates dummy data
        /// </summary>
        private void PopulateTree(bool isRecursive = false)
        {
            if (isRecursive)
            {
                InsertRecursive(50, "john");
                InsertRecursive(40, "stacy");
                InsertRecursive(75, "tim");
                InsertRecursive(30, "laura");
                InsertRecursive(45, "mike");
                InsertRecursive(20, "stacy");
                InsertRecursive(35, "joe");
            }
            else
            {
                InsertIterative(50, "john");
                InsertIterative(40, "stacy");
                InsertIterative(75, "tim");
                InsertIterative(30, "laura");
                InsertIterative(45, "mike");
                InsertIterative(20, "stacy");
                InsertIterative(35, "joe");
            }
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
        /// Computes the height of the tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int CalculateHeight(BaseTreeNode node)
        {
            if(node == null)
            {
                return -1;
            }
            else
            {
                return node._height;
            }
        }

        /// <summary>
        /// Finds the AVL balance factor
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int BalanceFactor(BaseTreeNode node)
        {
            if(node == null)
            {
                return 0;
            }

            return CalculateHeight(node._left) - CalculateHeight(node._right);
        }

        /// <summary>
        /// Checks if the tree is balanced
        /// </summary>
        /// <returns></returns>
        public bool IsBalanced()
        {
            return IsBalanced(_root);
        }

        private bool IsBalanced(BaseTreeNode node)
        {
            if(node == null)
            {
                return true;
            }

            if(Math.Abs(BalanceFactor(node)) <= 1 && IsBalanced(node._left) && IsBalanced(node._right))
            {
                return true;
            }
            else
            {
                return false;
            }      
        }

        /// <summary>
        /// checks the min of the tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BaseTreeNode Min(BaseTreeNode node)
        {
            if(node == null)
            {
                return null;
            }

            BaseTreeNode tempnode = node;

            while(tempnode._left != null)
            {
                tempnode = tempnode._left;
            }

            return tempnode;
        }

        /// <summary>
        /// Checks for the max of the tree
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BaseTreeNode Max(BaseTreeNode node)
        {
            if (node == null)
            {
                return null;
            }

            BaseTreeNode tempnode = node;

            while (tempnode._right != null)
            {
                tempnode = tempnode._right;
            }

            return tempnode;
        }
        #endregion

        #region Rotation Algorithms

        /// <summary>
        /// Left rotation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BaseTreeNode LeftRotation(BaseTreeNode node)
        {
            BaseTreeNode previousNode = node._right;
            BaseTreeNode tempNode = previousNode._left;

            previousNode._left = node;
            node._right = tempNode;

            node._height = Math.Max(CalculateHeight(node._left), CalculateHeight(node._right)) + 1;
            previousNode._height = Math.Max(CalculateHeight(previousNode._left), CalculateHeight(previousNode._right)) + 1;

            return previousNode;      
        }

        /// <summary>
        /// Right rotation
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private BaseTreeNode RightRotation(BaseTreeNode node)
        {
            BaseTreeNode previousNode = node._left;
            BaseTreeNode tempNode = previousNode._right;

            previousNode._right = node;
            node._left = tempNode;

            node._height = Math.Max(CalculateHeight(node._left), CalculateHeight(node._right)) + 1;
            previousNode._height = Math.Max(CalculateHeight(previousNode._left), CalculateHeight(previousNode._right)) + 1;

            return previousNode;
        }
        #endregion

        #region Traversal Algorithms
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
            if (node == null)
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
        #endregion

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
        public void InsertRecursive(int key, object value)
        {
            BaseTreeNode newNode = new BaseTreeNode(key, value);

            //Call Recursive Method
            this._root = InsertRecursive(this._root, newNode);
        }

        /// <summary>
        /// Insert recursive method call
        /// </summary>
        /// <param name="currentNode"></param>
        /// <param name="newNode"></param>
        /// <returns></returns>
        private BaseTreeNode InsertRecursive(BaseTreeNode currentNode, BaseTreeNode newNode)
        {
            //If root is null
            if(currentNode == null)
            {
                return newNode;
            }

            if((int)newNode._entry.Key > (int)currentNode._entry.Key)
            {
                currentNode._right = InsertRecursive(currentNode._right, newNode);
            }
            else if((int)newNode._entry.Key < (int)currentNode._entry.Key)
            {
                currentNode._left = InsertRecursive(currentNode._left, newNode);
            }

            //Computer the height for all the nodes on the call path
            currentNode._height = 1 + Math.Max(CalculateHeight(currentNode._left), CalculateHeight(currentNode._right));

            //Check the balance factor of computed heights
            int balanceFactor = BalanceFactor(currentNode);
            int bfLeftchild = BalanceFactor(currentNode._left);
            int bfRightchild = BalanceFactor(currentNode._right);

            //Check if rotation is needed
            if (balanceFactor > 1 && bfLeftchild > 0)
            {
                currentNode = RightRotation(currentNode);
            }
            else if (balanceFactor < -1 && bfRightchild < 0)
            {
                currentNode = LeftRotation(currentNode);
            }
            else if (balanceFactor > 1 && bfLeftchild < 0)
            {
                currentNode._left = LeftRotation(currentNode._left);
                currentNode = RightRotation(currentNode);
            }
            else if (balanceFactor < -1 && bfRightchild > 0)
            {
                currentNode._right = LeftRotation(currentNode._right);
                currentNode = RightRotation(currentNode);
            }

            return currentNode;
        }

        public void Delete(int key)
        {
            this._root = Delete(_root, key);
        }
        public BaseTreeNode Delete(BaseTreeNode currentnode, int key)
        {
            if (currentnode == null)
                return null;

            if (key < (int)currentnode._entry.Key)
            {
                currentnode._left = Delete(currentnode._left, key);
            }

            else if (key > (int)currentnode._entry.Key)
            {
                currentnode._right = Delete(currentnode._right, key);
            }

            else //node to delete is found
            {
                //node with only one child or no child
                if (currentnode._left == null || currentnode._right == null)
                {
                    BaseTreeNode temp = null;
                    //if the left is null then set temp to the right node
                    if (temp == currentnode._left)
                        temp = currentnode._right;
                    else
                        temp = currentnode._left; //otherwise set temp to the left node

                    //no child case: temp was assigned either current.left or current.right
                    //but if temp is still null then currentnode has no children
                    if (temp == null)
                    {
                        temp = currentnode;
                        currentnode = null; //delete the currentnode which is now pointing to node to delete
                    }
                    else //one child case: if temp is not null then temp is referencing either
                        //the left child or the right child
                        currentnode = temp;//connect the parent left or right (which is currentnod to temp which is the child of currentnode
                }
                else //two child case
                {
                    //get successor of current node
                    BaseTreeNode successor = Min(currentnode._right);
                    //copy the successor's data to this node
                    currentnode._entry = successor._entry;
                    //delete the successor
                    currentnode._right = Delete(currentnode._right, (int)successor._entry.Key);
                }
            }
            //
            //1. update its height
            if (currentnode == null)
                return currentnode;

            currentnode._height = Math.Max(CalculateHeight(currentnode._left), CalculateHeight(currentnode._right)) + 1;


            int bf = BalanceFactor(currentnode);

            int bfLeftchild = BalanceFactor(currentnode._left);
            int bfRightchild = BalanceFactor(currentnode._right);

            if (bf > 1 && bfLeftchild > 0)
            {
                currentnode = RightRotation(currentnode);

            }
            else if (bf < -1 && bfRightchild < 0)
            {
                currentnode = LeftRotation(currentnode);

            }
            else if (bf > 1 && bfLeftchild < 0)
            {
                currentnode._left = LeftRotation(currentnode._left);
                currentnode = RightRotation(currentnode);
            }
            else if (bf < -1 && bfRightchild > 0)
            {
                currentnode._right = RightRotation(currentnode._right);
                currentnode = LeftRotation(currentnode);
            }

            return currentnode;
        }

    }
}
