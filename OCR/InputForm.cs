using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    public partial class InputForm : Form
    {
        OutputForm output;
        OCR ocrApp;
        TransferFunction mainTransferFunction;
        public double misMatchingSamples;
        public double meanSquareError;
        public double accuracy;

        public InputForm()
        {
            InitializeComponent();
            initializeValues();
        }

        private void initializeValues()
        {
            neuronsPerLayerGridView.Rows[0].SetValues(30);
            numEpochsTxtBox.Text = "30";
            numPCTxtBox.Text = "65";
            activationFunctionCmbx.SelectedIndex = 1;
            numPCTxtBox.Enabled = numEpochsTxtBox.Enabled = pcaAlphaTxtBox.Enabled = false;
            valALbl.Hide();
            valATxt.Hide();
        }

        private bool IsDataComplete()
        {
            if (learningRateTxt.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Learning Rate.");
                return false;
            }
            if (hiddenLayerTxt.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Number Of Hidden Layers.");
                return false;
            }
            if (activationFunctionCmbx.SelectedItem == null)
            {
                MessageBox.Show("Please Choose an Activation Function.");
                return false;
            }
            if (valATxt.Visible == true && valATxt.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Slope of Sigmoid Function.");
                return false;
            }
            if (pcaCheckBox.Checked == true)
            {
                if (numPCTxtBox.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Number of Prinicple Components.");
                    return false;
                }
                if (numEpochsTxtBox.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Number of Epochs.");
                    return false;
                }
                if (pcaAlphaTxtBox.Text.Length == 0)
                {
                    MessageBox.Show("Please Enter Learning Rate for PCA.");
                    return false;
                }
            }
            return true;
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if (IsDataComplete() == false) { return; }

            if (activationFunctionCmbx.SelectedItem.ToString() == "Sigmoid")
                TransferFunction.slope = Double.Parse(valATxt.Text);

            PrinicpleComponentAnalysis PCA = null;
            if (pcaCheckBox.Checked == true)
            {
                int num_Components = Int32.Parse(numPCTxtBox.Text);
                double pcaAlpha = Double.Parse(pcaAlphaTxtBox.Text);
                TransferFunction transferFunction = new TransferFunction(TransferFunction.Type.Linear);
                PCA = new PrinicpleComponentAnalysis(pcaAlpha, transferFunction, num_Components);
            }
            Train(PCA);
            EvaluateClassifier(PCA);
            output = new OutputForm(this);
            output.Show();
        }

        void Train(PrinicpleComponentAnalysis PCA)
        {
            int num_HiddenLayers = Int32.Parse(hiddenLayerTxt.Text);
            double alpha = Double.Parse(learningRateTxt.Text);
            double threshold = Double.Parse(errorThresholdTxt.Text);
            int[] layers = new int[num_HiddenLayers + 2];
            int num_Classes = 5;
            int num_TrainingPerClass = 44;

            if (PCA != null) layers[0] = PCA.num_Components;
            else layers[0] = 30 * 30;
            layers[num_HiddenLayers + 1] = num_Classes;

            for (int i = 0; i < num_HiddenLayers; i++)
            {
                if (neuronsPerLayerGridView.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Please Enter Number of Neurons Per Each Layer!");
                    return;
                }
                layers[i + 1] = Int32.Parse(neuronsPerLayerGridView.Rows[i].Cells[0].Value.ToString());
            }
            ocrApp = new OCR(layers, num_Classes, alpha, threshold, mainTransferFunction);
            if (PCA != null)
            {
                int num_Epochs = Int32.Parse(numEpochsTxtBox.Text);
                ocrApp.SetPCA(PCA, num_Epochs);
                ocrApp.ReduceData(num_TrainingPerClass);
                meanSquareError = ocrApp.LearnOnReducedData(num_TrainingPerClass);
            }
            else
            {
                meanSquareError = ocrApp.Learn(num_TrainingPerClass);
            }
        }

        void EvaluateClassifier(PrinicpleComponentAnalysis PCA)
        {
            string[] classes = { "G", "L", "R", "Y", "Z" };
            int testPatterns = 11;
            double correctSamples = 0;
            int classifiedPattern;
            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < testPatterns; j++)
                {
                    string path = "img/" + classes[i] + "/Test/" + (j + 45) + ".txt";

                    if (PCA != null) classifiedPattern = ocrApp.ClassifyReducedData(path);
                    else classifiedPattern = ocrApp.Classify(path);

                    if (classifiedPattern == i) correctSamples++;
                }
            }
            accuracy = correctSamples / (testPatterns * classes.Length);
            misMatchingSamples = testPatterns * classes.Length - correctSamples;
        }

        public string ClassifyImage(String path)
        {
            string[] classes = { "G", "L", "R", "Y", "Z" };
            return classes[ocrApp.Classify(path)];
        }

        private void activationFunctionCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activationFunctionCmbx.SelectedItem.ToString() == "Tanh")
            {
                valALbl.Hide();
                valATxt.Hide();
                mainTransferFunction = new TransferFunction(TransferFunction.Type.Hyperbolic);
            }
            else
            {
                valALbl.Show();
                valATxt.Show();
                mainTransferFunction = new TransferFunction(TransferFunction.Type.Sigmoid);
            }
        }

        private void pcaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pcaCheckBox.Checked == true)
            {
                numEpochsTxtBox.Enabled = numPCTxtBox.Enabled = pcaAlphaTxtBox.Enabled = true;
            }
            else
            {
                numEpochsTxtBox.Enabled = numPCTxtBox.Enabled = pcaAlphaTxtBox.Enabled = false;
            }
        }
    }
}
