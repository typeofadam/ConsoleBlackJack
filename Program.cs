using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            deck.Shuffle();

            hand.AddCard(deck.Deal());
            hand.AddCard(deck.Deal());

            var cards = hand.GetHand();
            foreach(Card card in cards) {
                Console.WriteLine(card.Rank);
            }
            Console.WriteLine(hand.Score);
            
        }
    }
}
