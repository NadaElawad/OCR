using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class MultiLayerPerceptron
    {
        public TransferFunction.Type transferFunction;
        public Layer[] layers;
        public double alpha = 0.1;

        public MultiLayerPerceptron(int[] layers, double alpha, TransferFunction.Type transferFunction)
        {
            this.alpha = alpha;
            this.transferFunction = transferFunction;

            this.layers = new Layer[layers.Length];

            for (int i = 0; i < layers.Length; i++)
            {
                if (i == 0)
                    this.layers[i] = new Layer(layers[i], 0);
                else
                    this.layers[i] = new Layer(layers[i], layers[i - 1]);
            }
        }

        public double[] ForwardPropagate(double[] input)
        {
            double[] output = new double[layers[layers.Length - 1].length];
            for (int i = 0; i < layers[0].length; i++)
            {
                layers[0].neurons[i].value = input[i];
            }
            for (int i = 1; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].length; j++)
                {
                    double net = layers[i].neurons[j].bias;
                    for (int k = 0; k < layers[i - 1].length; k++)
                    {
                        net += layers[i - 1].neurons[k].value * layers[i].neurons[j].weights[k];
                    }
                    layers[i].neurons[j].value = TransferFunction.evaluate(net);
                }
            }
            for (int i = 0; i < layers[layers.Length - 1].length; i++)
            {
                output[i] = layers[layers.Length - 1].neurons[i].value;
            }
            return output;
        }
        public double BackPropagate(double[] input, double[] desiredOutput)
        {
            double[] output = ForwardPropagate(input);
            double error = 0;
            for (int i = 0; i < layers[layers.Length - 1].length; i++)
            {
                error = desiredOutput[i] - output[i];
                layers[layers.Length - 1].neurons[i].errorSignal = error * TransferFunction.evaluateDerivative(output[i]);
            }
            for (int i = layers.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < layers[i].length; j++)
                {
                    error = 0;
                    for (int k = 0; k < layers[i + 1].length; k++)
                    {
                        error += layers[i + 1].neurons[k].errorSignal * layers[i + 1].neurons[k].weights[j];
                    }
                    layers[i].neurons[j].errorSignal = error * TransferFunction.evaluateDerivative(layers[i].neurons[j].value);
                }
                for (int j = 0; j < layers[i + 1].length; j++)
                {
                    layers[i + 1].neurons[j].bias += alpha * layers[i + 1].neurons[j].errorSignal;
                    for (int k = 0; k < layers[i].length; k++)
                    {
                        layers[i + 1].neurons[j].weights[k] += alpha * layers[i + 1].neurons[j].errorSignal * layers[i].neurons[k].value;
                    }
                }
            }
            error = 0;
            double meanSquareError = 0;
            for (int i = 0; i < desiredOutput.Length; i++)
            {
                error = desiredOutput[i] - output[i];
                meanSquareError += error * error;
            }
            return meanSquareError / (output.Length);
        }
    }
}
