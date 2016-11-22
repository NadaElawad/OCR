using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class Neuron
    {
        public double value;
        public double[] weights;
        public double bias;
        public double errorSignal;

        public Neuron(int prevLayerSize)
        {
            Random rand = new Random();
            const double RANGE = 1e13;
            weights = new double[prevLayerSize];
            bias = rand.Next() / RANGE;
            errorSignal = rand.Next() / RANGE;
            value = rand.Next() / RANGE;

            for (int i = 0; i < weights.Length; i++)
                weights[i] = rand.Next() / RANGE;
        }
    }
}
