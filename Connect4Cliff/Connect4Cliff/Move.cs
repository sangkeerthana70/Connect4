using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Cliff
{
    public class Move
    {
        public int[] location { get; set; }
        public String player { get; set; }

        public Move(int[] location, string player)
        {
            this.location = location;
            this.player = player;
        }
    }
}
