using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurolabyrinth
{
    class player
    {
        int posX = 0;
        int posY = 0;

        public player()
        {

        }

        public Tuple<int,int> getPlayerPosition()
        {
            return Tuple.Create(posY,posX);
        }

        public void setPlayerPosition(int newPosX, int newPosY)
        {
            posX = newPosX;
            posY = newPosY;
            //Console.WriteLine("POS: " + posX + "|" + posY);
        }

        public Tuple<int,int> move(string dir)
        {
            switch(dir)
            {
                case "U":
                    setPlayerPosition(posX, posY - 1);
                    break;
                case "D":
                    setPlayerPosition(posX, posY + 1);
                    break;
                case "R":
                    setPlayerPosition(posX + 1, posY);
                    break;
                case "L":
                    setPlayerPosition(posX - 1, posY);
                    break;
            }
            return Tuple.Create(posY, posX);
        }
    }
}
