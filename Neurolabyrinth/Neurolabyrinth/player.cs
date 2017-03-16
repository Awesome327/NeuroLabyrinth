using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurolabyrinth
{
    class player
    {
        int[,] pos = { { 0 }, { 0 } };

        public player()
        {

        }

        public int[,] getPlayerPosition()
        {
            return pos;
        }

        public void setPlayerPosition(int[,] newPos)
        {
            pos = newPos;
        }

        public void move(string dir)
        {
            switch(dir)
            {
                case "up":
                    //pos = pos[i, j + 1];
                    break;
                case "down":
                    break;
                case "right":
                    break;
                case "left":
                    break;
            }
        }
    }
}
