using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class ScientificCalculator : Form
    {
        string operation;
        double num1, num2;
        public ScientificCalculator()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNo1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btnNo2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btnNo3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnNo4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btnNo5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btnNo6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btnNo7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btnNo8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btnNo9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnDOT_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btnNo0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void DispBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9': break;
                case '-':
                    if (txtDisplay.Text.Contains('-') || txtDisplay.Text.Contains("-"))
                    {
                        e.Handled = true;
                    }
                    break;
                case '.':
                    if (txtDisplay.Text.Contains('.') || txtDisplay.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }
        
        private void btnAddition_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Text = "0";
        }
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "%";
            txtDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txtDisplay.Clear();
            //DispBox.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    txtDisplay.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (num1 % num2).ToString();
                    break;
            }
        }


        private void btnSIN_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Sin(double.Parse(txtDisplay.Text))).ToString();
        }

        private void btnCOS_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Cos(double.Parse(txtDisplay.Text))).ToString();
        }

        private void btnTAN_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Tan(double.Parse(txtDisplay.Text))).ToString();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Sqrt(double.Parse(txtDisplay.Text))).ToString();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = (Math.Log10(double.Parse(txtDisplay.Text))).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            operation = "^";
            txtDisplay.Text = "0";
        }
    }
}