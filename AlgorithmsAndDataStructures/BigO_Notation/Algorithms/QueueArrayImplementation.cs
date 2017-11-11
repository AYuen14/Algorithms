namespace BigO_Notation.Algorithms
{
    using System;

    public class QueueArrayImplementation
    {

    }

    public class MyQueue
    {
        private object[] _array;
        private int _front;
        private int _tail;
        private int _count;

        public MyQueue(): this(8)
        {
        }

        public MyQueue(int capacity)
        {
            this._array = new object[capacity];
            this._count = 0;
            this._front = -1;
            this._tail = -1;
        }

        public int Count { get { return this._count; }}

        /// <summary>
        /// Add to the tail of queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(object item)
        {
            //If queue is empty
            if(this._count == 0)
            {
                this._front = this._tail = 0;
                this._array[this._tail] = item;
            }
            else if(this._count < this._array.Length)
            {
                //there is atleast one space left
                this._tail++;
                //If tail exceeded the last index, it will be set to 0
                this._tail = this._tail % this._array.Length;

                this._array[this._tail] = item;
            }
            else
            {
                //array is full
                //Create a new array with double memory size
                object[] temp = new object[this._count * 2];

                //Copy array to temp
                for(int i = 0; i < this._count; i++)
                {
                    temp[i] = this._array[this._front];
                    this._front = (_front + 1) % this._array.Length;
                }

                //reset array to refer to temp
                this._array = temp;
                this._front = 0; //set new front
                this._tail = this._count; //set new tail
                this._array[this._tail] = item; //adds new item
            }
            this._count++;
        }

        /// <summary>
        /// Removes the first item in queue
        /// </summary>
        /// <param name="item"></param>
        public object Dequeue(object item)
        {
            object returnObject = new object();

            //if empty throws exception throw argument exception
            if(this._count == 0)
            {
                throw new ArgumentException("This is an empty array");
            }
            else if(this._count == 1)
            {     
                returnObject = this._array[this._front];
                this._front = this._tail = -1;
                this._count = 0;
            }
            else
            {
                //return current head
                returnObject = this._array[this._front];

                //Increment front
                this._front++;

                //If front exceeded the last index, it will be set to 0
                this._front = this._front % this._array.Length;

                this._count--;
            }

            //return object that has veen removed
            return returnObject;
        }

        /// <summary>
        /// displays head of the queue.
        /// </summary>
        public object Peek()
        {
            object returnObject = new object();

            if (this._count == 0)
            {
                throw new ArgumentException("This is an empty array");
            }
            else
            {
                returnObject =  this._array[this._front];
            }

            return returnObject;
        }

        /// <summary>
        /// Copes current into new array
        /// </summary>
        /// <returns></returns>
        public object[] ToArray()
        {
            //Create a new array
            object[] temp = new object[this._count];

            //Copy array to temp
            for (int i = 0; i < this._count; i++)
            {
                temp[i] = this._array[this._front];
                this._front = (_front + 1) % this._array.Length;
            }

            //reset array to refer to temp
            this._array = temp;

            return this._array;
        }
    }
}
