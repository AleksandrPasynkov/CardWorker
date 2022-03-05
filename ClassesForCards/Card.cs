using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class Card
    {
        public Runks Rank { set; get; }
        public Lears Lear { set; get; }

        public Card(Lears lear, Runks rank)
        {
            this.Lear = lear;
            this.Rank = rank;
        }
    }
}
