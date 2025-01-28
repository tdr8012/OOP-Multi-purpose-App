using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace projectForOOP
{

    public partial class Simple_Calculator : Form
    {

        public class SimpleCalculator
        {
            private double num;
            public double Num
            {
                get { return num; }
                set { num = value; }
            }

            public SimpleCalculator()
            {

            }
            public SimpleCalculator(double num)
            {
                this.num = num;
            }
            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Subtract(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Multiply(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide(double num1, double num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return num1 / num2;
            }
        }
        private SimpleCalculator calculator;
        private double num1;
        private double num2;
        private char operation;
        public Simple_Calculator()
        {
            InitializeComponent();
            calculator = new SimpleCalculator();
        }
        public string FormatOperation(double num1, double num2, char operation, double result)
        {
            return $"{num1} {operation} {num2} = {result}";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum0.Text;
            txtResult.Text += btnNum0.Text;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum1.Text;
            txtResult.Text += btnNum1.Text;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum2.Text;
            txtResult.Text += btnNum2.Text;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum3.Text;
            txtResult.Text += btnNum3.Text;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum4.Text;
            txtResult.Text += btnNum4.Text;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum5.Text;
            txtResult.Text += btnNum5.Text;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum6.Text;
            txtResult.Text += btnNum6.Text;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum7.Text;
            txtResult.Text += btnNum7.Text;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum8.Text;
            txtResult.Text += btnNum8.Text;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNum9.Text;
            txtResult.Text += btnNum9.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnPlus.Text;
            num1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
            GetOperator('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnMinus.Text;
            num1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
            GetOperator('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnMultiply.Text;
            num1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
            GetOperator('*');
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnDiv.Text;
            num1 = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
            GetOperator('/');
        }
        private void GetOperator(char operation)
        {
            this.operation = operation;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEqual.Text;
            num2 = Convert.ToDouble(txtResult.Text);

            double result;
            switch (operation)
            {
                case '+':
                    result = calculator.Add(num1, num2);
                    break;
                case '-':
                    result = calculator.Subtract(num1, num2);
                    break;
                case '*':
                    result = calculator.Multiply(num1, num2);
                    break;
                case '/':
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }

            txtResult.Text = result.ToString();
            txtDisplay.Text += result.ToString();
            btnEqual.Enabled = false;
        }
        
        static string dirPath = @"..\Test\";
        string path = dirPath + "Calculator.txt";
        FileStream fs = null;
        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtDisplay.Text = "";
            num1 = 0;
            num2 = 0;
            btnEqual.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
