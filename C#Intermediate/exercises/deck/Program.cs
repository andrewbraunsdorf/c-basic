using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CreateCards();
            Console.ReadLine();
        }
    }
}
