using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class Lear
    {
        public static readonly Lear Saders = new Lear("Пики");
        public static readonly Lear Hearts = new Lear("Червы");
        public static readonly Lear Diamonds = new Lear("Буби");
        public static readonly Lear Clubs = new Lear("Крести");

        public static readonly Lear[] Lears = new Lear[] { Saders, Hearts, Diamonds, Clubs };

        public string Value { set; get; }

        private Lear(string learCard)
        {
            this.Value = learCard;
        }
    }
}
