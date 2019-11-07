using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
            Operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnSquareroot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                Operation = "√";
            
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
                Operation = "√";
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "^2";
                Operation = "^2";
            }
            else
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                textBox1.Text = textBox1.Text + "^2";
                Operation = "^2";
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
   

            if (Operation == "^2")
            {
                SecondNumber = 0;
            }
            else {
                SecondNumber = Convert.ToDouble(textBox1.Text);
            }

            if (Operation == "Bin")
            {
                Result = (SecondNumber);
                int value = System.Convert.ToInt32(Result);
                textBox1.Text = Convert.ToString(value, 2);
                FirstNumber = Result;
            }
            if (Operation == "Decimal")
            {
                Result = (SecondNumber);
                string Res = Convert.ToString(Result);
                int value2 = Convert.ToInt32(Res, 2);
              
                textBox1.Text = Convert.ToString(value2);
                FirstNumber = Convert.ToDouble(value2);
            }
           
            if (Operation == "√")
            {
                textBox1.Text = "0";
                Result = Math.Sqrt(SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "^2")
            {
                SecondNumber = 0;
                Result = Math.Pow(FirstNumber, 2);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "&")
            {
                if (FirstNumber == 1 && SecondNumber == 1)
                {
                    Result = 1;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                {
                    Result = 0;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "OR")
            {
                if ((FirstNumber == 1 && SecondNumber == 1) || (FirstNumber == 1 && SecondNumber == 0) || (FirstNumber == 0 && SecondNumber == 1))
                {
                    Result = 1;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                {
                    Result = 0;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
             
            }
            if (Operation == "NOT")
            {
                if (FirstNumber == 0 || SecondNumber == 0)
                {
                    Result = 1;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                else
                {
                    Result = 0;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //to convert to binary
            
                Operation = "Bin";
      
            
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // convert to decimal
            Operation = "Decimal";
        }

        private void BtnAnd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "&";
        }

        private void BtnOr_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "OR";
        }

        private void BtnNot_Click(object sender, EventArgs e)

        {
            textBox1.Text = "0";
            Operation = "NOT";
        }
    }
}
