using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Calculator
{
    public partial class Window : Form
    {

        double Result = 0;
        string Operation = "";
        bool ValEnter = false;
        char Operator;

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            NumDisp("0");
        }

        private void OneBTN_Click(object sender, EventArgs e)
        {
            NumDisp("1");
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            NumDisp("2");
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            NumDisp("3");
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            NumDisp("4");
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            NumDisp("5");
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            NumDisp("6");
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            NumDisp("7");
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            NumDisp("8");
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            NumDisp("9");
        }

        private void PointBTN_Click(object sender, EventArgs e)
        {
            NumDisp(".");
        }

        private void PosNegBTN_Click(object sender, EventArgs e)
        {

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            ArithOp(AddBTN.Text);
        }

        private void SubtractBTN_Click(object sender, EventArgs e)
        {
            ArithOp(SubtractBTN.Text);
        }

        private void MultiplyBTN_Click(object sender, EventArgs e)
        {
            ArithOp(MultiplyBTN.Text);
        }

        private void DivideBTN_Click(object sender, EventArgs e)
        {
            ArithOp(DivideBTN.Text);
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {

        }

        private void FractionBTN_Click(object sender, EventArgs e)
        {

        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {

        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {

        }

        private void PercentBTN_Click(object sender, EventArgs e)
        {

        }

        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "0";
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "0";
            Result = 0;
        }

        private void BackSpaceBTN_Click(object sender, EventArgs e)
        {

        }

        private void NumDisp(string X)
        {
            if ((ValueBox.Text == "0") || (ValEnter))
            {
                ValueBox.Text = "";
                ValEnter = false;
            }
            if (X == ".")
            {
                if (!ValueBox.Text.Contains("."))
                {
                    if (ValueBox.Text == "")
                    {
                        ValueBox.Text = "0";
                        ValueBox.Text += X;
                    }
                    else
                    {
                        ValueBox.Text += X;
                    }
                }
            }
            else
            {
                ValueBox.Text += X;
            }
        }

        private void ArithOp(String X)
        {
            if (Result != 0)
            {
                EqualBTN.PerformClick();
                ValEnter = true;
                Operation = X;
                EquationBox.Text = Convert.ToString(Result) + " " + Operation;
            }
            else
            {
                Operation = X;
                Result = Double.Parse(ValueBox.Text);
                ValueBox.Text = "";
                EquationBox.Text = Convert.ToString(Result) + " " + Operation;
            }
        }
    }
}
