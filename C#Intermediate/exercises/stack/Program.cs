using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You can not add a null object to stack.");
            }

            list.Add(obj);

        }

        public object Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("There are no objects in the stack yet.");
            }

            var toReturn = list[0];

            var elements = list.Count;

            for (int i = 0; i < elements -1; i++)
            {
                list[i] = (int)list[i + 1];
            }

            list.Remove(elements - 1);

            return toReturn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            var start = 0;
            var max = 5;

            for (var i = start; i <= max; i++)
            {
                _stack.Push(i);
            }

            for (var i = start; i <= max; i++)
            {
                Console.WriteLine(_stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
