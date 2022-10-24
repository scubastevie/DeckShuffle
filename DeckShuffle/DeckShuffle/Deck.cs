using DeckShuffle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckShuffle
{
    public class Deck
    {

        public List<Card> Cards;

        public Deck()
        {
            Cards = GetShuffledDeck();
        }

        //made this private so that we can't access the creation and shuffle of the deck
        private static List<Card> GetShuffledDeck()
        {
            var deck = CreateDeck().ToList();

            List<Card> shuffledDeck = deck;
            shuffledDeck.Shuffle();

            return shuffledDeck;
        }

        private static IEnumerable<Card> CreateDeck()
        {
            var newDeck = new List<Card>();

            foreach (var value in Enum.GetValues(typeof(CardValue)))
            {
                foreach (var suit in Enum.GetValues(typeof(CardSuit)))
                {
                    newDeck.Add(new Card((CardValue)value, (CardSuit)suit));
                }
            }

            return newDeck;
        }
    }
}
