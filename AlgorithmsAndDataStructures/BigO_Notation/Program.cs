namespace BigO_Notation
{
    using Algorithms;
    using Algorithms.Base;
    using Interview_Questions;
    using BigO_Notation.CodeWars;
    using BigO_Notation.LeetCode;
    using LeetCode;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        /// <summary>
        /// Array 1
        /// </summary>
        private static int[] _array = new int[10];

        static void Main(string[] args)
        {
            ////Initialize stop watch
            Stopwatch sw = new Stopwatch();

            //Groupon groupon = new Groupon();

            //QueueWithTwoStacks q = new QueueWithTwoStacks();

            //StackWithTwoQueues q = new StackWithTwoQueues();

            //CodeWars.Easy easy = new CodeWars.Easy();
            LeetCode.Easy easy = new LeetCode.Easy();


            //Display before sort
            //BubbleSort bubbleSort = new BubbleSort(_array, sw);
            //bubbleSort.SortPractice();

            ////////Display after sort
            //SelectionSort selectionSort = new SelectionSort(_array, sw);
            //selectionSort.SortPractice();

            //InsertionSort insertionSort = new InsertionSort(_array, sw);
            //insertionSort.Sort();

            //DoubleLinkList doubleLinkList = new DoubleLinkList();
            //doubleLinkList.AddLast(1);
            //doubleLinkList.AddLast(2);
            //doubleLinkList.AddLast(2);
            //doubleLinkList.AddLast(3);
            //doubleLinkList.AddLast(4);
            //doubleLinkList.AddLast(4);
            //doubleLinkList.AddLast(5);
            //doubleLinkList.ToArray();

            //DoubleLinkList doubleLinkList2 = new DoubleLinkList();
            //doubleLinkList2.AddFirst(2);
            //doubleLinkList2.AddFirst(6);
            //doubleLinkList2.AddFirst(7);
            //doubleLinkList2.AddFirst(8);
            //doubleLinkList2.AddFirst(4);
            //doubleLinkList2.AddFirst(10);
            //doubleLinkList2.ToArray();

            //DoubleLinkList DuplicateList = doubleLinkList.GetDuplicatesFromTwoLinkList(doubleLinkList, doubleLinkList2);
            //Console.WriteLine("Find Duplicates in two link list");
            //DuplicateList.ToArray();

            //DoubleLinkList RemoveDuplicateList = doubleLinkList.RemoveDuplicatesInList(doubleLinkList);
            //Console.WriteLine("Removing Duplicates in link list");
            //RemoveDuplicateList.ToArray();

            //DoubleLinkList mergeList = new DoubleLinkList();
            //mergeList = mergeList.Merge(doubleLinkList, doubleLinkList2);
            //Console.WriteLine("Merging two link list");
            //mergeList.ToArray();

            //object obj = doubleLinkList.RemoveFirst();
            //Console.WriteLine(string.Format("Removing Node Obj: {0}", obj));
            //doubleLinkList.ToArray();

            //object obj2 = doubleLinkList.RemoveLast();
            //Console.WriteLine(string.Format("Removing Node Obj: {0}", obj2));
            //doubleLinkList.ToArray();

            //MyQueue queue = new MyQueue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);

            //Console.WriteLine(string.Format("First In line: {0} \n", queue.Peek()));

            //int x = (int)queue.Dequeue(1);
            //Console.WriteLine(string.Format("Remove first In line: {0} and Count:{1} \n", x, queue.Count));

            //object[] array = queue.ToArray();
            //Console.WriteLine(string.Format("Displaying ToArray"));

            //foreach(object obj in array)
            //{
            //    Console.WriteLine(string.Format("{0} \n",obj));
            //}

            //MyStack stack = new MyStack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);

            //Console.WriteLine(string.Format("First In line: {0} \n", stack.Peek()));

            //int y = (int)stack.Pop(1);
            //Console.WriteLine(string.Format("Remove first In line: {0} and Count:{1} \n", y, stack.Count));

            //object[] arrayStack = stack.ToArray();
            //Console.WriteLine(string.Format("Displaying ToArray"));

            //foreach (object obj in arrayStack)
            //{
            //    Console.WriteLine(string.Format("{0} \n", obj));
            //}

            //int[] arraytemp = { 20,3,15,8,25,12,6,19,33,23 };
            //int[] arraytemp2 = { 3, 7, 15, 19, 22, 27 };
            //MergeSort mergeSort = new MergeSort();
            //Console.WriteLine("merge sort started");
            //mergeSort.MergeSortRecursive(arraytemp, 0, arraytemp.Length-1);

            //RecursiveMethods recursive = new RecursiveMethods();
            //recursive.DisplayInts(10);
            //recursive.RecursiveDisplayInts(10);
            //int x = recursive.IterativeFactorial(5);

            //recursive.RecursiveReverseArray(arraytemp, 0, arraytemp.Length - 1);

            //BinarySearch binarySearch = new BinarySearch(arraytemp);
            //int searchValue = binarySearch.RecursiveBinarySearch(3,0, arraytemp.Length-1);
            //Console.WriteLine("Binary Search value index: {0}", searchValue);

            //QuickSort quickSort = new QuickSort();
            //quickSort.Sort(arraytemp, 0, arraytemp.Length - 1);

            //Hashing hash = new Hashing();

            //HashTable hashTable = new HashTable(17);
            //hashTable.Add(37, "John");
            //hashTable.Add(55, "Michelle");
            //hashTable.Add(23, "Karen");
            //hashTable.Add(66, "Steve");
            //hashTable.Add(15, "Tim");
            //hashTable.Display();

            //HashTableDictionaryExample hashTableExample = new HashTableDictionaryExample();
            ////hashTableExample.Get();
            //hashTableExample.Remove();

            //Tree tree = new Tree(null);
            //tree.DisplayNodes(Tree.Traversal.InOrder);
            //tree.DisplayNodes(Tree.Traversal.PreOrder);
            //tree.DisplayNodes(Tree.Traversal.PostOrder);
            //bool isBalance = tree.IsBalanced();
            //Console.WriteLine(string.Format("Tree is balance: {0}", isBalance));
            //Console.WriteLine("Deleting key 40");
            //tree.Delete(40);
            //tree.DisplayNodes(Tree.Traversal.PreOrder);
            //isBalance = tree.IsBalanced();
            //Console.WriteLine(string.Format("Tree is balance: {0}", isBalance));

            //dictionary to SortedDictionary<int,book>
            Console.ReadLine();
        }

    }
}
