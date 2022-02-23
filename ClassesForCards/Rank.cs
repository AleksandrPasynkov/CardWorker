using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public sealed class Rank
    {
        public static readonly Rank Ace = new Rank("Туз");
        public static readonly Rank King = new Rank("Король");
        public static readonly Rank Queen = new Rank("Королева");
        public static readonly Rank Jack = new Rank("Валет");
        public static readonly Rank Ten = new Rank("10");
        public static readonly Rank Nine = new Rank("9");
        public static readonly Rank Eight = new Rank("8");
        public static readonly Rank Seven = new Rank("7");
        public static readonly Rank Six = new Rank("6");
        public static readonly Rank Five = new Rank("5");
        public static readonly Rank Four = new Rank("4");
        public static readonly Rank Three = new Rank("3");
        public static readonly Rank Two = new Rank("2");

        public static readonly Rank[] Ranks = new Rank[]{ Ace, King, Queen, Jack, Ten, Nine,
            Eight, Seven, Six, Five, Four, Three, Two };

        public string Value { set; get; }

        private Rank(string rankCard)
        {
            this.Value = rankCard;
        }
    }
}
