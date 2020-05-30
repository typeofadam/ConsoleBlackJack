namespace Blackjack {
    public class Deck {
        private Card[] cards;

        public Deck() {
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
    }
}