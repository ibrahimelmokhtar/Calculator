using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class mainForm : Form
    {
        public double result;
        public double firstNumber;
        public double secondNumber;
        public char operation;

        public mainForm()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += '0';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += '1';
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += '9';
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtResult.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtResult.Text += '-';
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text += '*';
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text += '/';
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            txtResult.Text += '%';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtResult.Text = result.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtResult.Text += '.';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                int lastIndex = txtResult.Text.Length - 1;
                txtResult.Text = txtResult.Text.Remove(lastIndex);
            }
        }
    }
}
