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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void imageClassifyButton_Click(object sender, EventArgs e)
        {
            DialogResult result = imageBrowserDialog.ShowDialog();
            if(result == DialogResult.OK) //test result
            {
                //do something with the file
            }
        }
    }
}
