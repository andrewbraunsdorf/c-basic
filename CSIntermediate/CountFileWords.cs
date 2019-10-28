using System;
using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0;
            int length = 0;

            var text = File.ReadAllText(@"C:\VS2019\LoremIpsum.txt");

            while (length <= text.Length - 1)
            {
                if (text[length] == ' ')
                {
                    word++;
                }

                length++;
            }
            

            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Words in text equals: {0}", word);
            Console.ReadLine();
        }
    }
}