using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      var sentence = "This is going to be a really, really, really, really, really long text.";
      var summary = StringUtility.SummarizeText(sentence);
      //var summary = SummarizeText(sentence, 25);

      Console.WriteLine(summary);
      Console.ReadLine();

    }

  }
}
