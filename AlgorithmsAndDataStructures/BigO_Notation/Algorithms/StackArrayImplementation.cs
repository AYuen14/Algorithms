using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    public class StackArrayImplementation
    {
    }

    public class MyStack
    {
        private object[] _array;
        private int _top;
        private int _count;

        public MyStack() : this(8)
        {

        }

        public MyStack(int capacity)
        {
            this._array = new object[capacity];
            this._count = 0;
            this._top = -1;
        }

        public int Count { get { return this._count; } }

        public void Push(object item)
        {
            this._top++;

            if (this._count > this._array.Length)
            {
                object[] temp = new object[this._count * 2];

                //Copy array to temp
                for (int i = 0; i < this._count; i++)
                {
                    temp[i] = this._array[i];
                }

                this._array = temp;
                this._array[this._top] = item;
                this._count++;
            }
            else
            {
                this._array[_top] = item;
                this._count++;
            }
           
        }

        public object Pop(object item)
        {
            if (this._count == 0)
            {
                throw new ArgumentException("This Stack is empty");
            }

            object obj = this._array[this._top];
            this._top--;
            this._count--;

            return obj;
        }

        public object Peek()
        {
            if (this._count == 0)
            {
                throw new ArgumentException("This Stack is empty");
            }

            return this._array[this._top];
        }

        public object[] ToArray()
        {
            //Create a new array
            object[] temp = new object[this._count];

            //Copy array to temp
            for (int i = 0; i < this._count; i++)
            {
                temp[i] = this._array[i];
            }

            //reset array to refer to temp
            this._array = temp;

            return this._array;
        }
    }
}
