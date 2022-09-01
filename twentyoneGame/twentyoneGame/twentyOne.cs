using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class twentyOne : game, IWalkAway
    {
        public override void play()
        {
            throw new NotImplementedException();
        }
        
        //overriding this function from inherited abstract class
        public override void listPlayers()
        {
            Console.WriteLine("21 players: ");
            base.listPlayers();
        }

        public void WalkAway(player player)
        {
            throw new NotImplementedException();
        }
    }
}
