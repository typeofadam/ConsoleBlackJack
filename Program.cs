using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card card;

            deck.Shuffle();
            
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");
            card = deck.Deal();
            Console.WriteLine($"{card.Rank}");

        }
    }
}
