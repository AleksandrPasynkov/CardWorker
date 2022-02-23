using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public interface IWorker
    {
        public void Create(string deckName);
        public void Delete(string deckName);
        public Deck Get(string deckName);
        public string GetNames();
        public Deck MixDeck(int mixRegime, string deckName);
    }
}
