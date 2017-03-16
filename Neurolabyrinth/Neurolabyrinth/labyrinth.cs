using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurolabyrinth
{
    class labyrinth
    {
        //Größe und Breite des Labyrinths
        const int row = 5;
        const int column = 5;
        //
        const int player = 2;
        const int weg = 0;
        const int wall = 1;
        //Labyrinth array
        private int[,] laby = new int[row, column]
        { { 0, 0, 0, 1, 3 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 1, 2 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 0, 0 }, };

        //Konstruktor
        public labyrinth()
        {

        }

        //Getter Setter Labyrinth
        public int[,] Laby
        {
            get { return laby; }
            set { laby = value; }
        }

        // get player position
        public Tuple<int, int> GetPlayerPosition(int[,] laby)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (laby[i, j] == player)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return Tuple.Create(0, 0);
        }
    }
}
