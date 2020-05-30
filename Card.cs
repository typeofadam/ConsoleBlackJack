namespace Blackjack {
    public class Card {
        public int Value {get;}
        public char Rank {get;}

        public Card(int value, char rank) {
            Value = value;
            Rank = rank;
        }
    }
}