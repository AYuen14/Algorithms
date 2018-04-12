using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    public class StackWithTwoQueues
    {
        private Queue<int> _queue1;
        private Queue<int> _queue2;

        public StackWithTwoQueues()
        {
            _queue1 = new Queue<int>();
            _queue2 = new Queue<int>();

            Push(1);
            Push(2);
            Push(3);
            Push(4);
            Push(5);
            DisplayQueue();

            Pop();
            DisplayQueue();

            Pop();
            DisplayQueue();
        }

        private void Push(int n)
        {
            int count = _queue1.Count();
            for (int i = 0; i < count; i++)
            {
                _queue2.Enqueue(_queue1.Dequeue());
            }

            _queue1.Enqueue(n);

            count = _queue2.Count();
            for(int i = 0; i < count; i++)
            {
                _queue1.Enqueue(_queue2.Dequeue());
            }
        }

        private void Pop()
        {
            _queue1.Dequeue();
        }

        private void DisplayQueue()
        {
            string output = string.Empty;

            foreach (int n in _queue1)
            {
                output += string.Format("{0},", n);
            }

            Console.WriteLine(output.TrimEnd(new char[] { ',' }));
        }
    }
}
