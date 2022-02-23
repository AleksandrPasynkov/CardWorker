using System;
using System.Text.Json;

namespace CardWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Worker();

            var s = w.GetNames();
            Console.WriteLine(s);           // Список колод пуст!

            w.Create("first");
            w.Create("first");              // Калода с именем first уже сужествует!
            w.Create("second");             
            w.Create(" ");                  // Имя колоды не задано!
            w.Create(null);                 // Имя колоды не задано!
            w.Create("third");

            var s1 = w.GetNames();
            Console.WriteLine(s1);           // Достыпны следуюшие колоды: first, second, third.

            w.MixDeck(4, "first");
            w.MixDeck(1, "second");
            w.MixDeck(2, "third");
            Deck third = w.Get("third");

            //foreach (var c in third.cards)
            //    Console.WriteLine($"{c.Lear.Value}, {c.Rank.Value}");

            Deck first = w.Get("first");
            Deck second = w.Get("second");
            Deck fore = w.Get("fore");      // Калоды с именем fore не сужествует! 


            w.Delete("first");
            w.Delete("second");
            w.Delete("fore");               // Калоды с именем fore не сужествует! 
            var s2 = w.GetNames();
            Console.WriteLine(s2);          // Достыпны следуюшие колоды: third.

            // для хранения состония колоды в БД можно серриализовать ее в json
            string json = JsonSerializer.Serialize(third);
            int len = json.Length;
            Console.WriteLine(json);
            Deck restoredDeck = JsonSerializer.Deserialize<Deck>(json);
        }
    }
}
