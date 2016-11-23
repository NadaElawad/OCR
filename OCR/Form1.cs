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
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
           
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
