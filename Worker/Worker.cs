using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardWorker
{
    public class Worker : IWorker
    {
        private List<Deck> deckKonteiner = new List<Deck>();

        public void Create(string deckName)
        {
            var validName = CheckValidName(deckName);
            var repeatname = CheckRepeatName(deckName);

            if (validName && !repeatname)
            {
                var newDeck = new Deck(deckName);
                deckKonteiner.Add(newDeck);
            }
        }

        public void Delete(string deckName)
        {
            var deckToDelete = Get(deckName);
            deckKonteiner.Remove(deckToDelete);
        }

        public Deck Get(string deckName)
        {
            var validName = CheckValidName(deckName);
            var isDeckPresent = CheckPresentName(deckName);

            if (validName && isDeckPresent)
                return deckKonteiner.Where(d => d.Name == deckName).First();

            return null;
        }

        public string GetNames()
        {
            if (deckKonteiner.Count == 0)
                return "Список колод пуст!";

            StringBuilder sb = new StringBuilder("Достыпны следуюшие колоды: ");

            for (int i = 0; i < deckKonteiner.Count; i++)
            {
                if(i == deckKonteiner.Count -1)
                {
                    sb.Append(deckKonteiner[i].Name);
                    sb.Append(".");
                    break;
                }
                
                sb.Append(deckKonteiner[i].Name);
                sb.Append(", ");
            }

            return sb.ToString();
        }

        public Deck MixDeck(int mixRegime, string deckName)
        {
            var deck = Get(deckName);
            var fabrica = new MixersFactory(mixRegime);
            IMixer mixer = fabrica.GetMixer();
            mixer.Mix(deck);

            return deck;
        }

        private bool CheckValidName(string deckName)
        {
            if (deckName == null)
            {
                Console.WriteLine("Имя колоды не задано!");
                return false;
            }

            deckName = deckName.Trim();

            if (deckName == String.Empty)
            {
                Console.WriteLine("Имя колоды не задано!");
                return false;
            }

            return true;
        }

        private bool CheckRepeatName(string deckName)
        {
            var checkRepeatName = deckKonteiner.Where(d => d.Name == deckName).Any();

            if (checkRepeatName)
                Console.WriteLine($"Калода с именем {deckName} уже сужествует!");

            return checkRepeatName;
        }

        private bool CheckPresentName(string deckName)
        {
            var isDeckPresent = deckKonteiner.Where(d => d.Name == deckName).Any();

            if (!isDeckPresent)
                Console.WriteLine($"Калоды с именем {deckName} не сужествует!");

            return isDeckPresent;
        }
    }
}
