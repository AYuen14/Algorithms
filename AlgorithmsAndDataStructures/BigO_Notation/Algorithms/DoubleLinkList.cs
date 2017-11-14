using BigO_Notation.Algorithms.Base;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    public class DoubleLinkList : BaseLinkList
    {
        public DoubleLinkList(object item = null, Node node = null)
        {
            if (item != null)
            {
                Node MyNode = new Node(item);
                this.First = this.Last = MyNode;
                this.Count = 1;
            }
            else if (node != null)
            {
                this.First = this.Last = node;
            }
            else
            {
                this.First = this.Last = null;
                this.Count = 0;
            }
        }

        /// <summary>
        /// Adds to the last Node.
        /// </summary>
        /// <param name="node">The node.</param>
        public void AddLast(Node node)
        {
            if (this.Count == 0)
            {
                this.First = this.Last = node;
            }
            else
            {
                node.Previous = this.Last;
                this.Last = node;              
                this.Last.Previous.Next = node;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds to item to last node
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddLast(object item)
        {
            Node node = new Node(item);
            AddLast(node);
        }

        /// <summary>
        /// Adds to the first node
        /// </summary>
        /// <param name="node">The node.</param>
        public void AddFirst(Node node)
        {
            if (this.Count == 0)
            {
                this.First = this.Last = node;
            }
            else
            {
                
                node.Next = this.First;
                this.First.Previous = node;
                this.First = node;
            }

            this.Count++;
        }

        /// <summary>
        /// Adds the item to first node
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddFirst(object item)
        {
            Node node = new Node(item);
            AddFirst(node);
        }


        /// <summary>
        /// Removes the first.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">This is empty link list</exception>
        public object RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new ArgumentException("This is empty link list");
            }

            object returnObject = null;

            if (this.Count == 1)
            {
                returnObject = this.First.Value;
                this.First = this.Last = null;
            }
            else
            {
                returnObject = this.First.Value;
                this.First.Previous = null;
                this.First = this.First.Next;
            }

            this.Count--;
            return returnObject;
        }

        /// <summary>
        /// Removes the last.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">This is empty link list</exception>
        public object RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("This is empty link list");
            }

            object returnObject = new object();

            if (this.Count == 1)
            {
                returnObject = this.Last.Value;
                this.First = this.Last = null;
            }
            else
            {
                returnObject = this.Last.Value;
                this.Last = this.Last.Previous;
                this.Last.Next = null;
            }

            this.Count--;
            return returnObject;
        }

        /// <summary>
        /// To the array.
        /// </summary>
        public void ToArray()
        {
            object[] array = new object[this.Count];
            Node temp = this.First;
            int index = 0;

            while(temp != null)
            {
                array[index] = temp.Value;
                temp = temp.Next;
                index++;
            }

            Display(array);
        }

        /// <summary>
        /// Merges the link list alternating.
        /// </summary>
        /// <param name="list1">The list1.</param>
        /// <param name="list2">The list2.</param>
        /// <returns></returns>
        public DoubleLinkList MergeLinkListAlternating(DoubleLinkList list1, DoubleLinkList list2)
        {
            //both lists dont have to be same size
            DoubleLinkList returnList = new DoubleLinkList();
            Node temp1 = list1.First;
            Node temp2 = list2.First;

            while (temp1 != null && temp2 != null)
            {
                returnList.AddLast(temp1.Value);
                returnList.AddLast(temp2.Value);

                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }

            while(temp1 != null)
            {
                returnList.AddLast(temp1.Value);
                temp1 = temp1.Next;
            }

            while (temp2 != null)
            {
                returnList.AddLast(temp2.Value);
                temp2 = temp2.Next;
            }

            return returnList;
        }

        /// <summary>
        /// Removes the duplicates in list.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <returns></returns>
        public DoubleLinkList RemoveDuplicatesInList(DoubleLinkList list)
        {
            //the assumption is that this linklist is sorted min to max
            //if the link list contains: 10,11,11,15,15,15,20 then after running this method
            //the link list should contains : 10,11,15,20

            DoubleLinkList returnList = new DoubleLinkList();
            Node temp1 = list.First;

            while (temp1 != null)
            {
                if(returnList.Count == 0)
                {
                    returnList.AddLast(temp1.Value);
                }
                else
                {
                    Node temp2 = returnList.First;
                    bool isDuplicate = false;

                    while(temp2 != null)
                    {
                        if (temp2.Value.Equals(temp1.Value))
                        {
                            isDuplicate = true;
                        }
                        temp2 = temp2.Next;
                    }
                    if(isDuplicate == false)
                    {
                        returnList.AddLast(temp1.Value);
                    }
                }
               
                temp1 = temp1.Next;
            }

            return returnList;
        }


        /// <summary>
        /// Gets the duplicates from two link list.
        /// </summary>
        /// <param name="list1">The list1.</param>
        /// <param name="list2">The list2.</param>
        /// <returns></returns>
        public DoubleLinkList GetDuplicatesFromTwoLinkList(DoubleLinkList list1, DoubleLinkList list2)
        {
            DoubleLinkList returnList = new DoubleLinkList();
            Node temp1 = list1.First;

            while (temp1 != null)
            {
                Node temp2 = list2.First;
                bool isDuplicate = false;

                while (temp2 != null)
                {
                    if (temp2.Value.Equals(temp1.Value))
                    {
                        isDuplicate = true;
                    }
                    temp2 = temp2.Next;
                }

                //If Duplicate Add value
                if (isDuplicate == true)
                {
                    //Check if Duplicate already exist in current Duplicate list
                    Node duplicateNode = returnList.First;
                    bool isDuplicateNode = false;

                    while (duplicateNode != null)
                    {
                        if (duplicateNode.Value.Equals(temp1.Value))
                        {
                            isDuplicateNode = true;
                        }
                        duplicateNode = duplicateNode.Next;
                    }

                    //If not part of duplicate list then add value
                    if (isDuplicateNode == false)
                    {
                        returnList.AddLast(temp1.Value);
                    }
                }
                
                temp1 = temp1.Next;
            }

            return returnList;
        }

        /// <summary>
        /// Displays the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        private void Display(object[] array)
        {
            StringBuilder returnString = new StringBuilder();
            foreach(var x in array)
            {
                returnString.Append(string.Format("{0},", x));
            }

            if(returnString.Length == 0)
            {
                returnString.Append("This is an empty list");
            }

            Console.WriteLine(returnString);
        }

        //Add get enumerator so that foreach can be used on this collection
        public IEnumerator GetEnumerator()
        {
            //sequence through nodes starting at first\
            Node tempNode = this.First;
            while (tempNode != null)
            {
                yield return tempNode.Value;
                tempNode = tempNode.Next;
            }
        }

        

    }
}
