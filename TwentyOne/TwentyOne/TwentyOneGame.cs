using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer {get; set;}
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players);
            {
                
            }
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
