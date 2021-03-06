using System;

namespace Blackjack {
    public class Deck {
        private Card[] cards;
        private int dealtCount;

        public Deck() {
            dealtCount = 0;
            cards = new Card[] {
                new Card(1, 'A'),
                new Card(1, 'A'),
                new Card(1, 'A'),
                new Card(1, 'A'),

                new Card(2, '2'),
                new Card(2, '2'),
                new Card(2, '2'),
                new Card(2, '2'),

                new Card(3, '3'),
                new Card(3, '3'),
                new Card(3, '3'),
                new Card(3, '3'),

                new Card(4, '4'),
                new Card(4, '4'),
                new Card(4, '4'),
                new Card(4, '4'),

                new Card(5, '5'),
                new Card(5, '5'),
                new Card(5, '5'),
                new Card(5, '5'),

                new Card(6, '6'),
                new Card(6, '6'),
                new Card(6, '6'),
                new Card(6, '6'),

                new Card(7, '7'),
                new Card(7, '7'),
                new Card(7, '7'),
                new Card(7, '7'),

                new Card(8, '8'),
                new Card(8, '8'),
                new Card(8, '8'),
                new Card(8, '8'),

                new Card(9, '9'),
                new Card(9, '9'),
                new Card(9, '9'),
                new Card(9, '9'),

                new Card(10, 'T'),
                new Card(10, 'T'),
                new Card(10, 'T'),
                new Card(10, 'T'),

                new Card(10, 'J'),
                new Card(10, 'J'),
                new Card(10, 'J'),
                new Card(10, 'J'),

                new Card(10, 'Q'),
                new Card(10, 'Q'),
                new Card(10, 'Q'),
                new Card(10, 'Q'),

                new Card(10, 'K'),
                new Card(10, 'K'),
                new Card(10, 'K'),
                new Card(10, 'K'),
            };
        }

        public void Shuffle() {
            var rand = new Random();
            Card temp = null;

            for(int i = 0; i < 52; i++) {
                int iSwap = rand.Next(52);
                temp = cards[i];
                cards[i] = cards[iSwap];
                cards[iSwap] = temp;
            }
        }

        public Card Deal() {
            return cards[dealtCount++];
        }
    }
}