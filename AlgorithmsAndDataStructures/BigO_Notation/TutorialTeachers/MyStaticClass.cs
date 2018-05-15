using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal static class MyStaticClass
    {
        public static int myStaticVariable = 0;
        public static int MyStaticProperty { get; set; }

        static MyStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
        }

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
    }

    internal class MyNonStaticClass
    {
        private static int myStaticClasses = 0;
        public int myNoneStaticClass = 2;

        static MyNonStaticClass()
        {
            myStaticClasses = 1;
            //myNoneStaticClass = 1;

            Console.WriteLine("Inside static constructor.");
        }

        public MyNonStaticClass()
        {
            myStaticClasses = 1;
            myNoneStaticClass = 1;
            Console.WriteLine("Inside MyNonStaticClass constructor.");
        }

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is static method.");
        }

        public void MyNonStaticMethod()
        {
            Console.WriteLine("This is non static method.");
        }
    }
}
