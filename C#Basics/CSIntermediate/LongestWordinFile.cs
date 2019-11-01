using System;
using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText(@"C:\VS2019\LoremIpsum.txt");
            var words = text.Split(new[] {' '});

            var longestWord = "";
            int longestWordLength = 0;
            foreach (var wordLength in words)
            {
                if (wordLength.Length > longestWordLength)
                {
                    longestWord = wordLength;
                    longestWordLength = wordLength.Length;
                }
            }

            Console.WriteLine("Longest word in File is: {0}", longestWord);

            Console.ReadLine();
        }
    }
}