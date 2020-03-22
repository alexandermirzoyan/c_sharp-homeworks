using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator {
    public partial class Form1 : Form {
        double firstNumber, secondNumber;
        string operationType;

        public Form1() {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, EventArgs e) {
            textBox1.Text += "1";
        }

        private void Button_2_Click(object sender, EventArgs e) {
            textBox1.Text += "2";
        }

        private void Button_3_Click(object sender, EventArgs e) {
            textBox1.Text += "3";
        }

        private void Button_4_Click(object sender, EventArgs e) {
            textBox1.Text += "4";
        }

        private void Button_5_Click(object sender, EventArgs e) {
            textBox1.Text += "5";
        }

        private void Button_6_Click(object sender, EventArgs e) {
            textBox1.Text += "6";
        }

        private void Button_7_Click(object sender, EventArgs e) {
            textBox1.Text += "7";
        }

        private void Button_8_Click(object sender, EventArgs e) {
            textBox1.Text += "8";
        }

        private void Button_9_Click(object sender, EventArgs e) {
            textBox1.Text += "9";
        }

        private void Button_0_Click(object sender, EventArgs e) {
            textBox1.Text += "0";
        }

        private void Button_dot_Click(object sender, EventArgs e) {
            textBox1.Text += ".";
        }

        private void Button_c_Click(object sender, EventArgs e) {
            textBox1.Text = "";
        }

        private void Button_delete_Click(object sender, EventArgs e) {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void Button_plus_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "+";
            textBox1.Text = "";
        }

        private void Button_minus_Click(object sender, EventArgs e) {
            textBox1.Text += "-";
            operationType = "-";
        }

        private void Button_multiply_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "*";
            textBox1.Text = "";
        }

        private void Button_devide_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "/";
            textBox1.Text = "";
        }

        private void Button_x_square_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "^";
            textBox1.Text = Convert.ToString(Math.Pow(firstNumber, 2));
        }

        private void Button_1_devide_x_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "1/x";
            textBox1.Text = Convert.ToString(1/ firstNumber);
        }

        private void Button_sqrt_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "sqrt";
            textBox1.Text = Convert.ToString(Math.Sqrt(firstNumber));
        }

        private void Button_percent_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "%";
            textBox1.Text = "";
        }

        private void Button_plusMinus_Click(object sender, EventArgs e) {
            if (Convert.ToDouble(textBox1.Text) > 0) {
                firstNumber = -Convert.ToDouble(textBox1.Text);
            }
            else {
                firstNumber = Convert.ToDouble(textBox1.Text);
            }
            operationType = "±";
            textBox1.Text = Convert.ToString(firstNumber);
        }

        private void Button_equal_Click(object sender, EventArgs e) {
            secondNumber = Convert.ToDouble(textBox1.Text);
            switch(operationType) {
                case "+":
                    textBox1.Text = Convert.ToString(firstNumber + secondNumber);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(firstNumber - secondNumber);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(firstNumber / secondNumber);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(firstNumber * secondNumber);
                    break;
                case "^":
                    textBox1.Text = "";
                    break;
                case "1/x":
                    textBox1.Text = "";
                    break;
                case "sqrt":
                    textBox1.Text = "";
                    break;
                case "%":
                    textBox1.Text = Convert.ToString(firstNumber % secondNumber);
                    break;
            }
        }
    }
}
