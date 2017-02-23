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
            LinearLayer inputLayer = new LinearLayer(2);
            SigmoidLayer hiddenLayer = new SigmoidLayer(2);
            SigmoidLayer outputLayer = new SigmoidLayer(1);

            //Connectors
            BackpropagationConnector connector = new BackpropagationConnector(inputLayer, hiddenLayer);
            BackpropagationConnector connector2 = new BackpropagationConnector(hiddenLayer, outputLayer);
        }
    }
}
