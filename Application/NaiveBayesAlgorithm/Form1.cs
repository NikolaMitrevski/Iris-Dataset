using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaiveBayesAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            NaiveBayesAlg naiveBayesAlg = new NaiveBayesAlg();

            double sepalLength = double.Parse(textBox_sepalLength.Text);
            double sepalWidth = double.Parse(textBox_sepalWidth.Text);
            double petalLength = double.Parse(textBox_petalLength.Text);
            double petalWidth = double.Parse(textBox_petalWidth.Text);

            label_result.Text = naiveBayesAlg.result(sepalLength, sepalWidth, petalLength, petalWidth);
        }
    }
}
