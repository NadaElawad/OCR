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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*OCR ocr = new OCR(new int[] { 30 * 30, 30, 5 }, 5, 0.1, 0.1, TransferFunction.Type.Sigmoid);
            double error = ocr.Learn(44);
            for (int i = 45; i <= 55; i++)
            {
                int ans = ocr.Classify("img/G/Test/" + i + ".txt");
                Console.WriteLine("Class: " + ans);
            }*/
        }
    }
}
