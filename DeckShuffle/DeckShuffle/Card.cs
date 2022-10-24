using DeckShuffle.Enums;

namespace DeckShuffle
{
    public struct Card
    {
        public CardValue Value { get; }
        public CardSuit Suit { get; }

        public Card(CardValue value, CardSuit suit)
        {
            Value = value;
            Suit = suit;
        }
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
