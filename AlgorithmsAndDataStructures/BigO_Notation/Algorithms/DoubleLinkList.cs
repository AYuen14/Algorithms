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

        public void AddLast(Node node)
        {
            if (this.Count == 0)
            {
                this.First = this.Last = node;
            }
            else
            {
                this.Last = node;
                node.Previous = this.Last;
                this.Last = node;
            }

            this.Count++;
        }

        public void AddLast(object item)
        {
            Node node = new Node(item);
            AddLast(node);
        }

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

        public void AddFirst(object item)
        {
            Node node = new Node(item);
            AddFirst(node);
        }

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

        //Merge Two linklists by alternating between list1 and list2
        public DoubleLinkList Merge(DoubleLinkList list1, DoubleLinkList list2)
        {
            //both lists dont have to be same size
            DoubleLinkList returnList = new DoubleLinkList();
            Node temp1 = list1.First;
            Node temp2 = list2.First;

            while (temp1 != null && temp2 != null)
            {
                returnList.AddFirst(temp1.Value);
                returnList.AddFirst(temp2.Value);

                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }

            while(temp1 != null)
            {
                returnList.AddFirst(temp1.Value);
                temp1 = temp1.Next;
            }

            while (temp2 != null)
            {
                returnList.AddFirst(temp2.Value);
                temp2 = temp2.Next;
            }

            return returnList;
        }

        public DoubleLinkList RemoveDuplicates(DoubleLinkList list)
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
                    returnList.AddFirst(temp1.Value);
                }
                else
                {
                    foreach (Node x in returnList)
                    {
                        if (x.Value != temp1.Value)
                        {
                            returnList.AddFirst(temp1.Value);
                        }
                    }
                }
               
                temp1 = temp1.Next;
            }

            return returnList;
        }

        //Get Intersection of 2 link list(check for duplicates between 2 link list.)

        private void Display(object[] array)
        {
            StringBuilder returnString = new StringBuilder();
            foreach(var x in array)
            {
                returnString.Append(string.Format("{0},", x));
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
