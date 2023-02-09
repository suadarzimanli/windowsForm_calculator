using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        double number1;
        double number2;
        double result;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 + number2;
            MessageBox.Show("Result is: " + result);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 - number2;
            MessageBox.Show("Result is: " + result);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 * number2;
            MessageBox.Show("Result is: " + result);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            result = number1 / number2;
            MessageBox.Show("Result is: " + result);
        }

    }
}
