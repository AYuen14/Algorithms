using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.AVLTree
{
    internal class BinaryTree
    {
        private TreeNode root;
        private int count;

        public enum TraversalType
        {
            InOrder,
            PreOrder,
            PostOrder
        }

        public BinaryTree(TreeNode node)
        {
            this.root = node == null ? null : node;
            this.count = node == null ? 0 : 1;

            PopulateTree();
            DisplayNodes(TraversalType.InOrder);
        }

        private void PopulateTree()
        {
            Insert(50, "A");
            Insert(40, "B");
            Insert(75, "C");
            Insert(30, "D");
            Insert(45, "E");
            Insert(20, "F");
            Insert(35, "G");
        }

        private void TraversalInOrder(TreeNode node, Queue queue)
        {
            if(node == null)
            {
                return;
            }

            TraversalInOrder(node.leftNode, queue);

            queue.Enqueue(node.entry);

            TraversalInOrder(node.rightNode, queue);
        }

        public void DisplayNodes(TraversalType traversal)
        {
            Queue queue = new Queue();

            switch(traversal)
            {
                case TraversalType.InOrder:
                    TraversalInOrder(this.root, queue);
                    break;
                case TraversalType.PostOrder:
                    break;
                case TraversalType.PreOrder:
                    break;
            }

            Console.WriteLine("Traversal Type {0}", traversal.ToString());
            foreach(DictionaryEntry de in queue)
            {
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

        }

        public void Insert(int key, object value)
        {
            TreeNode newNode = new TreeNode(key, value);

            if(this.root == null)
            {
                this.root = newNode;
                this.count = 1;
            }
            else
            {
                TreeNode parent = null;
                TreeNode tempNode = this.root;

                while(tempNode != null)
                {
                    if(key == (int)tempNode.entry.Key)
                    {
                        throw new ArgumentException("Key must be unique");
                    }

                    parent = tempNode;

                    tempNode = (key > (int)tempNode.entry.Key) ? tempNode.rightNode : tempNode.leftNode;
                }

                if(key > (int)parent.entry.Key)
                {
                    parent.rightNode = newNode;
                }
                else
                {
                    parent.leftNode = newNode;
                }

                this.count++;
            }

        }
    }
}
