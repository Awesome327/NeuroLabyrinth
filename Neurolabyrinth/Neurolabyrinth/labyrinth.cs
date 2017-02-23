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
        const int row = 10;
        const int column = 10;

        //Labyrinth array
        private int[,] laby = new int[row, column];

        //Konstruktor
        public labyrinth() { }

        //Getter Setter Labyrinth
        public int[,] Laby
        {
            get { return laby; }
            set { laby = value; }
        }


    }
}
