using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWorker
{
    public class MixersFactory
    {
        private int mixRegime;

        public MixersFactory(int Regime)
        {
            mixRegime = Regime;
        }

        public IMixer GetMixer()
        {
            switch (mixRegime)
            {
                case 1:
                    return new RandomMixer();
                case 2:
                    return new HandMixer();
                default:
                    return new DefaultMixer();
            }
        }
    }
}
