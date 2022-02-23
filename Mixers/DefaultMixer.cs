using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class DefaultMixer : IMixer
    {
        public void Mix(Deck deck)
        {
            int i = 0;

            for (int j = deck.Cards.Length - 1; i < j; i++, j--)
            {
                var t = deck.Cards[i];
                deck.Cards[i] = deck.Cards[j];
                deck.Cards[j] = t;
            }
        }
    }
}
