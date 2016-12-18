using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class PrinicpleComponentAnalysis
    {
        public int num_Components;
        public Layer[] layers;
        double alpha;
        TransferFunction transferFunction;

        public PrinicpleComponentAnalysis() { }
        public PrinicpleComponentAnalysis(double alpha, TransferFunction transferFunction, int num_Components)
        {
            this.alpha = alpha;
            this.num_Components = num_Components;
            this.transferFunction = transferFunction;
            this.layers = new Layer[2];

            layers[0] = new Layer(30 * 30, 0);
            layers[1] = new Layer(num_Components, 30 * 30);
        }
        public double[] ForwardPropagate(double[] input)
        {
            double[] output = new double[layers[layers.Length - 1].length];
            for (int i = 0; i < layers[0].length; i++)
            {
                layers[0].neurons[i].value = input[i];
            }
            for (int j = 0; j < layers[1].length; j++)
            {
                double net = 0;
                for (int k = 0; k < layers[0].length; k++)
                {
                    net += layers[0].neurons[k].value * layers[1].neurons[j].weights[k];
                }
                layers[1].neurons[j].value = transferFunction.evaluate(net);
            }
            for (int i = 0; i < layers[1].length; i++)
            {
                output[i] = layers[1].neurons[i].value;
            }
            return output;
        }
        public void ReduceData(double[] input)
        {
            for (int i = 0; i < layers[0].length; i++)
            {
                layers[0].neurons[i].value = input[i];
            }
            Parallel.For(0, layers[1].length, j =>
            {
                double net = 0;
                for (int i = 0; i < layers[0].length; i++)
                {
                    net += layers[0].neurons[i].value * layers[1].neurons[j].weights[i];
                }
                layers[1].neurons[j].value = transferFunction.evaluate(net);
            });
            for (int j = 0; j < layers[1].length; j++)
            {
                for (int i = 0; i < layers[0].length; i++)
                {
                    double d_Weight = alpha * layers[1].neurons[j].value * (layers[0].neurons[i].value - getSum(j, i));
                    layers[1].neurons[j].weights[i] += d_Weight;
                }
            };
        }
        double getSum(int j, int i)
        {
            double sum = 0;
            for (int k = 0; k <= j; k++)
                sum += layers[1].neurons[k].value * layers[1].neurons[k].weights[i];
            return sum;
        }
        public double[] GetReducedData()
        {
            double[] reducedData = new double[num_Components];
            for (int i = 0; i < num_Components; i++)
            {
                reducedData[i] = layers[1].neurons[i].value;
            }
            return reducedData;
        }
    }
}