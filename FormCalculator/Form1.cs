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
        List<string> recentOperations = new List<string>();
        double firstNumber, secondNumber;
        string operationType;
        bool isInputedNumberZero = false;
        int inputedDotCount = 0;
        int labelPositionX = 320;
        int labelPositionY = 60;

        public Form1() {
            InitializeComponent();
        }
        private void numberClick(object sender, EventArgs e) {
            Button button = (Button)sender;

            isInputedNumberZero = false;
            string s = textBox1.Text;

            if (s[0] != '0') {
                textBox1.Text = textBox1.Text + button.Text;
            }
            else {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void Button_0_Click(object sender, EventArgs e) {
            if ((isInputedNumberZero != true) && (textBox1.Text != "0")) {
                textBox1.Text = textBox1.Text + "0";
            }

            else {
                isInputedNumberZero = true;
            }
        }

        private void Button_dot_Click(object sender, EventArgs e) {
            inputedDotCount++;
            if (inputedDotCount == 1) {
                textBox1.Text += ".";
            }
        }

        private void Button_c_Click(object sender, EventArgs e) {
            textBox1.Text = "0";
            inputedDotCount = 0;
            secondNumber = 0;
        }

        private void Button_ce_Click(object sender, EventArgs e) {
            textBox1.Text = "0";
            inputedDotCount = 0;
            secondNumber = 0;
            firstNumber = 0;
            operationType = "";
        }

        private void Button_delete_Click(object sender, EventArgs e) {
            int textBoxLength = textBox1.Text.Length;
            textBox1.Text = textBox1.Text.Remove(textBoxLength - 1, 1);
            textBoxLength = textBox1.Text.Length;
            if (textBoxLength == 0) {
                textBox1.Text = "0";
            }
        }

        private void Button_x_square_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "^";
            double answer = Math.Pow(firstNumber, 2);
            textBox1.Text = Convert.ToString(answer);

            recentOperations.Add(firstNumber + operationType + "2" + "=" + answer);

            Label label = new Label();

            for (int i = 0; i < recentOperations.Count(); i++) {
                label.Text = recentOperations.ElementAt(i);
                label.Location = new Point(labelPositionX, labelPositionY);
                label.AutoSize = true;
                label.Font = new Font("Calibri", 20);
                label.ForeColor = Color.LightSlateGray;
                this.Controls.Add(label);
                labelPositionY += 20;
            }
        }

        private void Button_1_devide_x_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "1/x";
            double answer = 1 / firstNumber;
            textBox1.Text = Convert.ToString(answer);

            recentOperations.Add("1 / " + firstNumber + "=" + answer);

            Label label = new Label();

            for (int i = 0; i < recentOperations.Count(); i++) {
                label.Text = recentOperations.ElementAt(i);
                label.Location = new Point(labelPositionX, labelPositionY);
                label.AutoSize = true;
                label.Font = new Font("Calibri", 20);
                label.ForeColor = Color.LightSlateGray;
                this.Controls.Add(label);
                labelPositionY += 20;
            }
        }

        private void Button_sqrt_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "sqrt";
            double answer = Math.Sqrt(firstNumber);
            textBox1.Text = Convert.ToString(answer);

            recentOperations.Add(operationType + " " + firstNumber + "=" + answer);

            Label label = new Label();
            
            for (int i = 0; i < recentOperations.Count(); i++) {
                label.Text = recentOperations.ElementAt(i);
                label.Location = new Point(labelPositionX, labelPositionY);
                label.AutoSize = true;
                label.Font = new Font("Calibri", 20);
                label.ForeColor = Color.LightSlateGray;
                this.Controls.Add(label);
                labelPositionY += 20;
            }
        }

        private void Button_percent_Click(object sender, EventArgs e) {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = "%";
            textBox1.Text = "0";
        }

        private void Button_plusMinus_Click(object sender, EventArgs e) {
            textBox1.Text = Convert.ToString(-1 * Convert.ToDouble(textBox1.Text));
            operationType = "±";
        }

        private void arithmeticOperationOnClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            firstNumber = Convert.ToDouble(textBox1.Text);
            operationType = button.Text;
            textBox1.Text = "0";
        }

        private void Button1_Click(object sender, EventArgs e) {
            recentOperations.Clear();
            foreach (var tb in Controls.OfType<Label>()) {
                tb.Text = null;
            }
        }

        private void Button_equal_Click(object sender, EventArgs e) {
            secondNumber = Convert.ToDouble(textBox1.Text);
            double answer = 0;
            switch(operationType) {
                case "+":
                    answer = firstNumber + secondNumber;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case "-":
                    answer = firstNumber - secondNumber;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case "÷":
                    answer = firstNumber / secondNumber;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case "×":
                    answer = firstNumber * secondNumber;
                    textBox1.Text = Convert.ToString(answer);
                    break;
                case "x²":
                    textBox1.Text = "";
                    break;
                case "1/x":
                    textBox1.Text = "";
                    break;
                case "√":
                    textBox1.Text = "";
                    break;
                case "%":
                    answer = (firstNumber * secondNumber) / 100;
                    textBox1.Text = Convert.ToString(answer);
                    break;
            }
            recentOperations.Add(firstNumber + " " + operationType + " " + secondNumber + "=" + answer);

            Label label = new Label();
            for (int i = 0; i < recentOperations.Count(); i++) {
                label.Text = recentOperations.ElementAt(i);
                label.Location = new Point(labelPositionX, labelPositionY);
                label.AutoSize = true;
                label.Font = new Font("Calibri", 20);
                label.ForeColor = Color.LightSlateGray;
                this.Controls.Add(label);
                labelPositionY += 20;
            }
        }
    }
}
