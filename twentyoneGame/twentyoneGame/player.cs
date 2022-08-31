using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class player
    {
        public List<card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
