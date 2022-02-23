using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace CardWorker
{
    public class Deck
    {
        public string Name { set; get; }
        public Card[] Cards { set; get; }

        public Deck(string nameDeck)
        {
            this.Name = nameDeck;
            CreateDeck();
        }

        public Deck(string nameDeck, Card[] cards)
        {
            this.Name = nameDeck;
            this.Cards = cards;
        }

        private void CreateDeck()
        {
            var deckList = new List<Card>();

            for (int i = 0; i < Lear.Lears.Length; i++)
                for (int j = 0; j < Rank.Ranks.Length; j++)
                    deckList.Add(new Card(Lear.Lears[i], Rank.Ranks[j]));

            Cards = deckList.ToArray();
        }
    }
}
