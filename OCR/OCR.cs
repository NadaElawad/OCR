using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class OCR
    {
        MultiLayerPerceptron MLP;
        int num_Classes;
        int imageSz;
        double threshold;
        string[] classes = {"G", "L", "R", "Y", "Z"};

        public OCR(int[] layers, int num_Classes, double alpha, double threshold, TransferFunction.Type type)
        {
            imageSz = 30*30;
            this.threshold = threshold;
            this.num_Classes = num_Classes;
            MLP = new MultiLayerPerceptron(layers, alpha, type);
        }

        public double Learn(int num_TrainingPerClass)
        {
            double meanSquareError = 0;
            while (meanSquareError < threshold)
            {
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);

                        double[] output = new double[num_Classes];
                        for (int k = 0; k < num_Classes; k++)
                        {
                            if (k != i) output[k] = 0;
                            else output[k] = 1;
                        }
                        meanSquareError += MLP.BackPropagate(input, output);
                    }
                }
                meanSquareError /= num_Classes;
            }
            return meanSquareError;
        }
        public int recognize(String imgPath)
        {
            string[] lines = System.IO.File.ReadAllLines(imgPath);
            double[] input = HelperFunctions.ToDoubleArray(lines);
            double[] output = MLP.ForwardPropagate(input);
            int classified = 0;
            for (int i = 0; i < num_Classes; i++)
            {
                if (output[i] > output[classified]) classified = i;
            }
            return classified;
        }
    }
}
