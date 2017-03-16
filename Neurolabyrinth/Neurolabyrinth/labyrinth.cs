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
        const int finish = 3;
        public int Wall
        {
            get { return wall; }
        }

        bool finished = false;
        //Labyrinth array
        private int[,] laby = new int[row, column]
        { { 2, 0, 0, 1, 3 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 1, 0 },
          { 0, 1, 0, 0, 0 }};

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
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (laby[i, j] == player)
                    {
                        return Tuple.Create(i, j);
                    }
                }
            }
            return Tuple.Create(0, 0);
        }
        //Set player position
       // public void SetPlayerPosition(Tuple<int,int> PlyrPosi, char Move,)
       public int[,] SetPosition(Tuple<int,int> posiPlay, Tuple<int,int> newPosi, int[,] labyr)
        {
            int tempPosiPlay = labyr[posiPlay.Item1, posiPlay.Item2];
            int tempNewPosi = labyr[newPosi.Item1, newPosi.Item2];
            if (tempNewPosi == wall)
            {
                return labyr;
            }
            else if (tempNewPosi == finish)
            {
                labyr[posiPlay.Item1, posiPlay.Item2] = 0;
                labyr[newPosi.Item1, newPosi.Item2] = tempPosiPlay;
                finished = true;
                return labyr;
            }
            else
            {
                labyr[posiPlay.Item1, posiPlay.Item2] = tempNewPosi;
                labyr[newPosi.Item1, newPosi.Item2] = tempPosiPlay;
                return labyr;
            }

        }
        public void Update(labyrinth laby)
        {
            Console.Clear();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(laby.Laby[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
