using System;
using System.Collections.Generic;

namespace CardWorker
{
    public class Deck
    {
        public string Name;
        public Card[] Cards;

        public Deck(string nameDeck)
        {
            this.Name = nameDeck;
            CreateDeck();
        }

        private void CreateDeck()
        {
            var deckList = new List<Card>();

            foreach (Lears lear in Enum.GetValues(typeof(Lears)))
                foreach (Runks runk in Enum.GetValues(typeof(Runks)))
                    deckList.Add(new Card(lear, runk));

            Cards = deckList.ToArray();
        }
    }
}
