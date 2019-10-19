using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type
            var a = 10;
            var b = a;
            b++;
            // a = 10; b = 11;
            Console.WriteLine("a: {0}, b: {1}", a, b);

            // reference type
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            // both arrays 0 are 0
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
            Console.ReadLine();
        }
    }
}
