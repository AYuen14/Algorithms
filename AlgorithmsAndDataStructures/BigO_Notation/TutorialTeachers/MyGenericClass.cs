using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.TutorialTeachers
{
    internal class MyGenericClass<T>
    {
        private T genericMemberVariable;
        public T genericProperty { get; set; }

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        internal T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(int).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(int).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }
    }

    internal class myGenericDelegate
    {
        public delegate T Add<T>(T param1, T param2);

        public myGenericDelegate()
        {
            Add<int> sum = AddNumber;
            Console.WriteLine(sum(10, 20));

            Add<string> conct = Concate;
            Console.WriteLine(conct("hello", "world"));
        }

        internal static int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        internal static string Concate(string str1, string str2)
        {
            return str1 + str2;
        }
    }

    internal class myGenericConstraint<T> where T: class
    {
        private T genericMemberVariable;
        public T genericProperty { get; set;}

        public myGenericConstraint(T value)
        {
            genericProperty = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericMethod<U>(T genericParameter, U anotherGenericType) where U : struct
        {
            Console.WriteLine("Generic Parameter of type {0}, value {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return value of type {0}, value {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }
    }
}
