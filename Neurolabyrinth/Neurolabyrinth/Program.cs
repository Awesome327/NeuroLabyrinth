﻿using NeuronDotNet.Core.Backpropagation;
using NeuronDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace Neurolabyrinth
{
    class Program
    {
        public static BackpropagationNetwork network;

        static void Main(string[] args)
        {

            Boolean finished = false;

            //Layer
            LinearLayer inputLayer = new LinearLayer(25);
            SigmoidLayer hiddenLayer1 = new SigmoidLayer(100);
            SigmoidLayer outputLayer = new SigmoidLayer(4);

            //Connectors
            BackpropagationConnector connector = new BackpropagationConnector(inputLayer, hiddenLayer1);
            BackpropagationConnector connector3 = new BackpropagationConnector(hiddenLayer1, outputLayer);

            network = new BackpropagationNetwork(inputLayer, outputLayer);
            network.Initialize();

            labyrinth laby = new labyrinth();
            player plyr = new player();

            laby.Update(laby);

            Console.WriteLine(laby.GetPlayerPosition(laby.Laby));

            do
            {
                string pressedKey = Console.ReadKey(true).Key.ToString();

                switch (pressedKey)
                {
                    case "RightArrow":
                        if (laby.Laby[plyr.getPlayerPosition().Item1, plyr.getPlayerPosition().Item2 + 1] != laby.Wall)
                        {
                            laby.Laby = laby.SetPosition(plyr.getPlayerPosition(), plyr.move("R"), laby.Laby);
                            laby.Update(laby);
                        }
                        break;
                    case "LeftArrow":
                        if (laby.Laby[plyr.getPlayerPosition().Item1, plyr.getPlayerPosition().Item2 - 1] != laby.Wall)
                        {
                            laby.Laby = laby.SetPosition(plyr.getPlayerPosition(), plyr.move("L"), laby.Laby);
                            laby.Update(laby);
                        }
                        break;
                    case "UpArrow":
                        if (laby.Laby[plyr.getPlayerPosition().Item1 - 1, plyr.getPlayerPosition().Item2] != laby.Wall)
                        {
                            laby.Laby = laby.SetPosition(plyr.getPlayerPosition(), plyr.move("U"), laby.Laby);
                            laby.Update(laby);
                        }
                        break;
                    case "DownArrow":
                        if (laby.Laby[plyr.getPlayerPosition().Item1 + 1, plyr.getPlayerPosition().Item2] != laby.Wall)
                        {
                            laby.Laby = laby.SetPosition(plyr.getPlayerPosition(), plyr.move("D"), laby.Laby);
                            laby.Update(laby);
                        }
                        break;
                }
            } while (finished != true);

            Console.Read();
        }

        public static void setNetworkWeights(BackpropagationNetwork aNetwork, double[] weights)
        {
            // Setup the network's weights.
            int index = 0;
            foreach (BackpropagationConnector connector in aNetwork.Connectors)
            {
                foreach (BackpropagationSynapse synapse in connector.Synapses)
                {
                    synapse.Weight = weights[index++];
                    // synapse.SourceNeuron.SetBias(weights[index++]);

                }
            }
        }
        public void Update(labyrinth laby)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(laby.Laby[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
