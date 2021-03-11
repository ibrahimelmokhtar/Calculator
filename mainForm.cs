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

        private void displayNumber(char charNumber)
        {
            if (txtOperation.Text != "")
            {
                txtNumber2.Text += charNumber;
            }
            else
            {
                txtResult.Text += charNumber;
            }
        }

        private void applyOperation()
        {
            if (txtNumber2.Text != "")
            {
                firstNumber = double.Parse(txtResult.Text);
                secondNumber = double.Parse(txtNumber2.Text);
                switch (txtOperation.Text)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                    case "%":
                        result = firstNumber % secondNumber;
                        break;
                }
                txtResult.Text = result.ToString();
                txtNumber2.Clear();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            displayNumber('0');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            displayNumber('1');
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            displayNumber('2');
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            displayNumber('3');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            displayNumber('4');
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            displayNumber('5');
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            displayNumber('6');
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            displayNumber('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            displayNumber('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            displayNumber('9');
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Text = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Text = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Text = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Text = "/";
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Text = "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            applyOperation();
            txtOperation.Clear();
            txtNumber2.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            displayNumber('.');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtOperation.Clear();
            txtNumber2.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text != "" && txtNumber2.Text != "")
            {
                int lastIndex = txtNumber2.Text.Length - 1;
                txtNumber2.Text = txtNumber2.Text.Remove(lastIndex);
            }
            else if (txtNumber2.Text == "")
            {
                txtOperation.Clear();
            }
            else
            {
                int lastIndex = txtResult.Text.Length - 1;
                txtResult.Text = txtResult.Text.Remove(lastIndex);
            }
        }
    }
}
