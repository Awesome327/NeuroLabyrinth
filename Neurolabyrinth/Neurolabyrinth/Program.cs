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
            //Player player = new Player();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(laby.Laby[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(laby.GetPlayerPosition(laby.Laby));

            do
            {
                string pressedKey = Console.ReadKey(true).Key.ToString();

                switch (pressedKey)
                {
                    case "RightArrow":
                        Console.WriteLine("Nach rechts");
                        break;
                    case "LeftArrow":
                        Console.WriteLine("Nach links");
                        break;
                    case "UpArrow":
                        Console.WriteLine("Nach oben");
                        break;
                    case "DownArrow":
                        Console.WriteLine("Nach unten");
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
    }

}
