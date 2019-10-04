using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string BeforeValue = "";
        string AfterValue = "";
        string Operation = "";
        double result = 0;

        private void buttonNUM_Click(object sender, EventArgs e)
        {
            Button buttonNumber = sender as Button;

            if ( buttonNumber.Text == "." )
            {
                textBox1.Text += buttonNumber.Text;
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = buttonNumber.Text;
            }
            else
            {
                textBox1.Text += buttonNumber.Text;
            }

            if ( Operation != "" )
            {
                AfterValue += buttonNumber.Text;
            }
        }

        private void buttonMathematical_Click(object sender, EventArgs e)
        {
            Button Mathematice = sender as Button;

            if ( AfterValue != "" )
            {
                switch (Operation)
                {
                    case "+":
                        result = Convert.ToDouble(BeforeValue) + Convert.ToDouble(AfterValue);
                        break;
                    case "-":
                        result = Convert.ToDouble(BeforeValue) - Convert.ToDouble(AfterValue);
                        break;
                    case "*":
                        result = Convert.ToDouble(BeforeValue) * Convert.ToDouble(AfterValue);
                        break;
                    case "/":
                        result = Convert.ToDouble(BeforeValue) / Convert.ToDouble(AfterValue);
                        break;
                }

                BeforeValue = result.ToString();
                AfterValue = "";
            }
            else
            {
                BeforeValue = textBox1.Text;
            }

            Operation = Mathematice.Text;
            textBox1.Text += Mathematice.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            BeforeValue = "";
            AfterValue = "";
            Operation = "";
            result = 0;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double GetBeforeValue = Convert.ToDouble(BeforeValue);
            double GetAfterValue  = Convert.ToDouble(AfterValue);
            double Result = 0;

            switch (Operation)
            {
                case "+":
                    Result = GetBeforeValue + GetAfterValue;
                    break;
                case "-":
                    Result = GetBeforeValue - GetAfterValue;
                    break;
                case "*":
                    Result = GetBeforeValue * GetAfterValue;
                    break;
                case "/":
                    Result = GetBeforeValue / GetAfterValue;
                    break;
            }
            textBox1.Text = Result.ToString();

            BeforeValue = "";
            AfterValue = "";
            Operation = "";
            result = 0;
        }
    }
}
