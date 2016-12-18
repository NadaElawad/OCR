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
    public partial class OutputForm : Form
    {
        InputForm inForm;
        public OutputForm(InputForm inForm)
        {
            this.inForm = inForm;
            InitializeComponent();
            update();
        }
        void update()
        {
            mismatchingSamplesOutLbl.Text = inForm.misMatchingSamples.ToString();
            accuracyRateOutLbl.Text = (Math.Round(inForm.accuracy*100)+"%").ToString();
            mseOutLbl.Text = inForm.meanSquareError.ToString();
        }
        private void imageClassifyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string s = "Image Belongs to Class: " + inForm.ClassifyImage(filePath);
                classifiedPattern.Text = s;
            }
        }
    }
}
