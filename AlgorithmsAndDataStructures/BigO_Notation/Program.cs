namespace BigO_Notation
{
    using System.IO;
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
    using AVLTree;
    using TutorialTeachers;
    using TutorialTeachers.Events;
    using TutorialTeachers.Collections;
    using static TutorialTeachers.Collections.MyHashtable;
    using System.Text;
    using DesignPatterns;

    class Program
    {

        /// <summary>
        /// Array 1
        /// </summary>
        private static int[] _array = new int[10];

        public enum cs
        {
            connecting,
            disconnecting
        }

        static void Main(string[] args)
        {
            ////Initialize stop watch
            Stopwatch sw = new Stopwatch();

            var x = MyFactoryPattern.Create();
            x.GetRandomNumber();

            Console.ReadLine();
        }
    }
}
