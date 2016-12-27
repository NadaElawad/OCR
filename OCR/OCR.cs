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
        PrinicpleComponentAnalysis PCA;
        int num_Epochs;
        int num_Classes;
        double threshold;
        string[] classes = { "G", "L", "R", "Y", "Z" };

        public OCR(int[] layers, int num_Classes, double alpha, double threshold, TransferFunction transferFunction)
        {
            this.threshold = threshold;
            this.num_Classes = num_Classes;
            MLP = new MultiLayerPerceptron(layers, alpha, transferFunction);
        }
        public void SetPCA(PrinicpleComponentAnalysis PCA, int num_Epochs)
        {
            this.PCA = PCA;
            this.num_Epochs = num_Epochs;
        }
        public void ReduceData(int num_TrainingPerClass)
        {
            for(int epoch = 0; epoch < num_Epochs; epoch++)
            {
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/Training/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);
                        PCA.ReduceData(input);
                    }
                }
            }
        }
        public double LearnOnReducedData(int num_TrainingPerClass)
        {
            double meanSquareError = threshold + 1;
            while (meanSquareError > threshold)
            {
                meanSquareError = 0;
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/Training/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);

                        double[] output = new double[num_Classes];
                        for (int k = 0; k < num_Classes; k++)
                        {
                            if (k != i) output[k] = 0;
                            else output[k] = 1;
                        }
                        MLP.BackPropagate(PCA.ForwardPropagate(input), output);
                    }
                }
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/Training/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);

                        double[] output = MLP.ForwardPropagate(input);
                        double[] desiredOutput = new double[num_Classes];
                        double error = 0;
                        for (int k = 0; k < num_Classes; k++)
                        {
                            if (k != i) desiredOutput[k] = 0;
                            else desiredOutput[k] = 1;
                            error = desiredOutput[k] - output[k];
                            meanSquareError += error * error;
                        }
                    }
                }
                meanSquareError /= num_TrainingPerClass * num_Classes*2;
                Console.WriteLine(meanSquareError);
            }
            return meanSquareError;
        }
        public double Learn(int num_TrainingPerClass)
        {
            double meanSquareError = threshold + 1;
            while (meanSquareError > threshold)
            {
                meanSquareError = 0;
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/Training/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);

                        double[] output = new double[num_Classes];
                        for (int k = 0; k < num_Classes; k++)
                        {
                            if (k != i) output[k] = 0;
                            else output[k] = 1;
                        }
                        MLP.BackPropagate(input, output);
                    }
                }
                for (int i = 0; i < num_Classes; i++)
                {
                    for (int j = 1; j <= num_TrainingPerClass; j++)
                    {
                        String pattern = "img/" + classes[i] + "/Training/" + j + ".txt";
                        string[] lines = System.IO.File.ReadAllLines(pattern);
                        double[] input = HelperFunctions.ToDoubleArray(lines);
                        HelperFunctions.Normalize(ref input);

                        double[] output = MLP.ForwardPropagate(input);
                        double[] desiredOutput = new double[num_Classes];
                        double error = 0;
                        for (int k = 0; k < num_Classes; k++)
                        {
                            if (k != i) desiredOutput[k] = 0;
                            else desiredOutput[k] = 1;
                            error = desiredOutput[k] - output[k];
                            meanSquareError += error * error;
                        }
                    }
                }
                meanSquareError /= num_TrainingPerClass*num_Classes*2;
            }
            return meanSquareError;
        }
        public int Classify(String imgPath)
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
        public int ClassifyReducedData(String imgPath)
        {
            string[] lines = System.IO.File.ReadAllLines(imgPath);
            double[] input = HelperFunctions.ToDoubleArray(lines);
            HelperFunctions.Normalize(ref input);

            double[] output = MLP.ForwardPropagate(PCA.ForwardPropagate(input));
            int classified = 0;
            for (int i = 0; i < num_Classes; i++)
            {
                if (output[i] > output[classified]) classified = i;
            }
            return classified;
        }
    }
}
