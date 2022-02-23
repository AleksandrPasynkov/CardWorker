using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class HandMixer : IMixer
    {
        public void Mix(Deck deck)
        {
            var tempDeck = new List<Card>();
            Random rnd = new Random();
            int repit = rnd.Next(50, 100);

            foreach (var card in deck.Cards)
                tempDeck.Add(card);

            for (int i = 0; i < repit; i++)
            {
                int delta = rnd.Next(-12, 12);
                int deckPart = delta + tempDeck.Count / 2 - 1;

                var firstPartOfDeck = new List<Card>();

                for (int j = 0; j < deckPart; j++)
                    firstPartOfDeck.Add(tempDeck[j]);

                tempDeck.RemoveRange(0, deckPart);

                foreach (var card in firstPartOfDeck)
                    tempDeck.Add(card);
            }

            for (int i = 0; i < deck.Cards.Length; i++)
                deck.Cards[i] = tempDeck[i];
        }
    }
}
