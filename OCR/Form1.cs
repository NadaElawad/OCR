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
        Output output;
        public double misMatchingSamples;
        public double meanSquareError;
        public double accuracy;
        OCR ocrApp;

        public InputForm()
        {
            InitializeComponent();
            initializeValues();
        }

        private void initializeValues()
        {
            neuronsPerLayerGridView.Rows[0].SetValues(30);
            activationFunctionCmbx.SelectedIndex = 1;
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
                MessageBox.Show("Please Choose an Activation Function!");
                return false;
            }
            if (valATxt.Visible == true && valATxt.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Slope of Sigmoid Function!");
                return false;
            }
            return true;
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            if (IsDataComplete() == false) { return; }

            int num_HiddenLayers = Int32.Parse(hiddenLayerTxt.Text);
            double alpha = Double.Parse(learningRateTxt.Text);
            double threshold = Double.Parse(errorThresholdTxt.Text);
            int[] layers = new int[num_HiddenLayers + 2];
            int num_Classes = 5;
            int num_TrainingPerClass = 44;

            layers[0] = 30 * 30;
            layers[num_HiddenLayers + 1] = num_Classes;

            TransferFunction.Type typeOfTransferFunction = new TransferFunction.Type();

            if (activationFunctionCmbx.SelectedItem.ToString() == "Sigmoid")
            {
                typeOfTransferFunction = TransferFunction.Type.Sigmoid;
                TransferFunction.slope = Double.Parse(valATxt.Text);
            }
            else
            {
                typeOfTransferFunction = TransferFunction.Type.Hyperbolic;
            }

            for (int i = 0; i < num_HiddenLayers; i++)
            {
                if(neuronsPerLayerGridView.Rows[i].Cells[0].Value == null) {
                    MessageBox.Show("Please Enter Number of Neurons Per Each Layer!");
                    return;
                }
                layers[i + 1] = Int32.Parse(neuronsPerLayerGridView.Rows[i].Cells[0].Value.ToString());
            }
            ocrApp = new OCR(layers, num_Classes, alpha, threshold, typeOfTransferFunction);
            meanSquareError = ocrApp.Learn(num_TrainingPerClass);
            EvaluateClassifier();
            output = new Output(this);
            output.Show();
        }

        void EvaluateClassifier()
        {
            string[] classes= {"G", "L", "R", "Y", "Z"};
            int testPatterns = 11;
            double correctSamples = 0;
            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < testPatterns; j++)
                {
                    string path = "img/" + classes[i] + "/Test/" + (j+45) + ".txt";
                    int classifiedPattern = ocrApp.Classify(path);
                    if (classifiedPattern == i) correctSamples++;
                }
            }
            accuracy = correctSamples / (testPatterns*classes.Length);
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
            }
            else
            {
                valALbl.Show();
                valATxt.Show();
            }
        }

        private void inputForm_Load(object sender, EventArgs e)
        {
            valALbl.Hide();
            valATxt.Hide();
        }
    }
}
