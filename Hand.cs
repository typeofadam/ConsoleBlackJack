using System.Collections.Generic;

namespace Blackjack {
    public class Hand {
        private List<Card> cards;
        public int score {get; private set;}
        
        public Hand() {
            cards = new List<Card>();
            score = 0;
        }

        public void AddCard(Card card) {
            cards.Add(card);
            CalculateScore();
        }

        public Card[] GetHand() {
            return cards.ToArray();
        }

        private void CalculateScore() {
            var value = 0;
            var hasAce = false;

            foreach(Card card in cards) {
                value += card.Value;
                if(card.Rank == 'A') hasAce = true;
                if(hasAce && value <= 11) value += 10;
            }
            score = value;
        }
    }
}