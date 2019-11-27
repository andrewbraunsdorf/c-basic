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

            var index = list.Count - 1;
            var toReturn = list[index];


            list.RemoveAt(index);

            return toReturn;
        }
        public void Clear()
        {
            list.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            var start = -1;
            var max = 99;

            for (var i = start; i <= max; i++)
            {
                stack.Push(i);
            }
            // // to get a no objects in stack exception
            // stack.Clear();

            for (var i = start; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }

        
    }
}
