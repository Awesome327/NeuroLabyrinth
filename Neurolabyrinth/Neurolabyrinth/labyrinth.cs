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

        //Labyrinth array
        private int[,] laby = new int[row, column] 
        { { 0, 0, 0, 1, 3 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 1, 0 },
          { 2, 1, 0, 0, 0 }, };

        //Konstruktor
        public labyrinth() {

        }

        //Getter Setter Labyrinth
        public int[,] Laby
        {
            get { return laby; }
            set { laby = value; }
        }


    }
}
