using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO_Notation.Algorithms
{
    public class QueueWithTwoStacks
    {
        private Stack<int> _stack1;
        private Stack<int> _stack2;

        public QueueWithTwoStacks()
        {
            _stack1 = new Stack<int>();
            _stack2 = new Stack<int>();

            Enqueue(14);
            DisplayQueue();
            Enqueue(2);
            DisplayQueue();
            Enqueue(9);
            DisplayQueue();
            Enqueue(7);
            DisplayQueue();

            Dequeue();
            DisplayQueue();
        }

        private void Enqueue(int n)
        {
            for(int i = 0; i < _stack1.Count(); i++)
            {
                _stack2.Push(_stack1.Pop());
            }

            _stack2.Push(n);
            int count = _stack2.Count();
            for(int i= 0; i < count; i++)
            {
                _stack1.Push(_stack2.Pop());
            }
        }

        private void Dequeue()
        {
            if(_stack1.Count <= 0)
            {
                throw new ArgumentNullException("The stack is empty");
            }
            _stack1.Pop();
        }

        private void DisplayQueue()
        {
            string output = string.Empty;

            foreach(int n in _stack1)
            {
                output += string.Format("{0},", n);
            }

            Console.WriteLine(output.TrimEnd(new char[] { ',' }));
        }
    }
}
