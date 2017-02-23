using NeuronDotNet.Core.Backpropagation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurolabyrinth
{
    class Program
    {
        public static BackpropagationNetwork network;

        static void Main(string[] args)
        {
            //Layer
            LinearLayer inputLayer = new LinearLayer(100);
            SigmoidLayer hiddenLayer1 = new SigmoidLayer(1000);
            SigmoidLayer hiddenLayer2 = new SigmoidLayer(1000);
            SigmoidLayer outputLayer = new SigmoidLayer(4);

            //Connectors
            BackpropagationConnector connector = new BackpropagationConnector(inputLayer, hiddenLayer1);
            BackpropagationConnector connector2 = new BackpropagationConnector(hiddenLayer1, hiddenLayer2);
            BackpropagationConnector connector3 = new BackpropagationConnector(hiddenLayer2, outputLayer);

            network = new BackpropagationNetwork(inputLayer, outputLayer);
            network.Initialize();
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
                    synapse.SourceNeuron.SetBias(weights[index++]);

                }
            }
        }
    }

}
