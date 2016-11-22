using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class Neuron
    {
        public double Value;
        public double[] Weights;
        public double Bias;
        public double Delta;

        public Neuron(int prevLayerSize)
        {
            Random rand = new Random();
            Weights = new double[prevLayerSize];
            Bias = rand.Next() / 10000000000000.0;
            Delta = rand.Next() / 10000000000000.0;
            Value = rand.Next() / 10000000000000.0;

            for (int i = 0; i < Weights.Length; i++)
                Weights[i] = rand.Next() / 10000000000000.0;
        }
    }
}
