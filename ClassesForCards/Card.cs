using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class Card
    {
        public Rank Rank { set; get; }
        public Lear Lear { set; get; }

        public Card(Lear lear, Rank rank)
        {
            this.Lear = lear;
            this.Rank = rank;
        }
    }
}
