using System;
using System.Windows.Forms;

namespace calc
{
    public partial class Calculator : Form
    {
        double FirstNum;
        string Operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "0";
            }
            else
            {
                nholder.Text = nholder.Text + "0";
            }
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "1";
            }
            else
            {
                nholder.Text = nholder.Text + "1";
            }
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "2";
            }
            else
            {
                nholder.Text = nholder.Text + "2";
            }
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "3";
            }
            else
            {
                nholder.Text = nholder.Text + "3";
            }
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "4";
            }
            else
            {
                nholder.Text = nholder.Text + "4";
            }
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "5";
            }
            else
            {
                nholder.Text = nholder.Text + "5";
            }
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "6";
            }
            else
            {
                nholder.Text = nholder.Text + "6";
            }
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "7";
            }
            else
            {
                nholder.Text = nholder.Text + "7";
            }
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "8";
            }
            else
            {
                nholder.Text = nholder.Text + "8";
            }
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (nholder.Text == "0" && nholder.Text != null)
            {
                nholder.Text = "9";
            }
            else
            {
                nholder.Text = nholder.Text + "9";
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(nholder.Text);
            nholder.Text = "";
            Operation = "+";
            dotBtn.Enabled = true;
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(nholder.Text);
            nholder.Text = "";
            Operation = "-";
            dotBtn.Enabled = true;
        }

        private void multiplicationBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(nholder.Text);
            nholder.Text = "";
            Operation = "*";
            dotBtn.Enabled = true;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(nholder.Text);
            nholder.Text = "";
            Operation = "/";
            dotBtn.Enabled = true;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            nholder.Text = nholder.Text + ".";
            dotBtn.Enabled = false;

        }

        private void equalstoBtn_Click(object sender, EventArgs e)
        {
            double SecondNum;
            double Result;

            SecondNum = Convert.ToDouble(nholder.Text);

            if (Operation == "+")
            {
                Result = (FirstNum + SecondNum);
                nholder.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNum - SecondNum);
                nholder.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "/")
            {
                Result = (FirstNum / SecondNum);
                nholder.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNum * SecondNum);
                nholder.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nholder.Clear();
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            string test = nholder.Text;
            nholder.Text = test.Remove(test.Length - 1, 1);
        }
    }
}
