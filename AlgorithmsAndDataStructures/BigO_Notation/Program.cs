namespace BigO_Notation
{
    using Algorithms;
    using Algorithms.Base;
    using System;
    using System.Diagnostics;

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

            //Display before sort
            //BubbleSort bubbleSort = new BubbleSort(_array, sw);
            //bubbleSort.SortPractice();

            ////////Display after sort
            //SelectionSort selectionSort = new SelectionSort(_array, sw);
            //selectionSort.SortPractice();

            //InsertionSort insertionSort = new InsertionSort(_array, sw);
            //insertionSort.Sort();

            DoubleLinkList doubleLinkList = new DoubleLinkList();
            doubleLinkList.AddFirst(1);
            doubleLinkList.AddFirst(2);
            doubleLinkList.AddFirst(2);
            doubleLinkList.AddFirst(3);
            doubleLinkList.AddFirst(4);
            doubleLinkList.AddFirst(4);
            doubleLinkList.AddFirst(5);
            doubleLinkList.ToArray();
            DoubleLinkList doubleLinkList2 = doubleLinkList.RemoveDuplicates(doubleLinkList);
            doubleLinkList2.ToArray();
            //DoubleLinkList doubleLinkList2 = new DoubleLinkList();
            //doubleLinkList2.AddFirst(6);
            //doubleLinkList2.AddFirst(7);
            //doubleLinkList2.AddFirst(8);
            //doubleLinkList2.AddFirst(9);
            //doubleLinkList2.AddFirst(10);
            //doubleLinkList2.ToArray();

            //DoubleLinkList mergeList = new DoubleLinkList();
            //mergeList = mergeList.Merge(doubleLinkList, doubleLinkList2);
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

            Console.ReadLine();
        }

    }
}
