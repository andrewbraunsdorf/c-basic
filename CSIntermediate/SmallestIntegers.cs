using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{ 1, 2, 3, 4, 5, 6};
            // return 3 smallest numbers
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", " Count should be between 1 and the number of elements in the list");
            }

            // original list is only used for creating the buffer
            var buffer = new List<int>(list);
            // list to hold smallest numbers
            var smallests = new List<int>();

            //
            while (smallests.Count < count)
            {
                // get smallest number
                var min = GetSmallest(buffer);
                // add to list of smallest number
                smallests.Add(min);
                // remove from original list
                //list.Remove(min);

                // remove from list of identical numbers
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }

            return min;
        }
    }
}
