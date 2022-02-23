using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class RandomMixer : IMixer
    {
        public void Mix(Deck deck)
        {
            Random rnd = new Random();

            for (int i = 0; i < deck.Cards.Length; i++)
            {
                int j = rnd.Next(0, deck.Cards.Length - 1);
                var t = deck.Cards[i];
                deck.Cards[i] = deck.Cards[j];
                deck.Cards[j] = t;
            }
        }
    }
}
