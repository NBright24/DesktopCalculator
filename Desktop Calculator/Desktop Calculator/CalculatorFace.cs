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
        string Val1, Val2;
        bool HistorySelect = true;

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
            Compute();
            HistoryAdd();
        }

        private void FractionBTN_Click(object sender, EventArgs e)
        {
            //METHOD THIS
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "1 / " + Result.ToString();
            ValueBox.Text = (1 / Result).ToString();
            Result = Double.Parse(ValueBox.Text);

            HistoryAdd();
        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {
            //METHOD THIS
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "sqr(" + Result + ")";
            ValueBox.Text = (Result * Result).ToString();
            Result = Double.Parse(ValueBox.Text);

            HistoryAdd();
        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {
            //METHOD THIS
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "√" + Result;
            ValueBox.Text = (Math.Sqrt(Result)).ToString();
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
            EquationBox.Text = "";
            ValueBox.Text = "0";
            Result = 0;
        }

        private void BackSpaceBTN_Click(object sender, EventArgs e)
        {
            BackSpace();
        }

        private void MenuIcon_Click(object sender, EventArgs e)
        {
            NewFeature();
        }

        private void OnTopBTN_Click(object sender, EventArgs e)
        {
            NewFeature();
        }

        private void HistoryLBL_Click(object sender, EventArgs e)
        {
            HistorySelect = true;

            HighlightHIST.Visible = true;
            HighlightMEM.Visible = false;
            HistDisplay.Visible = true;
            MemDisp.Visible = false;
            ClearMEMBTN.Visible = false;

            if (HistDisplay.Text != "There's no history yet")
            {
                ClearHistBTN.Visible = true;
            }
        }

        private void MemoryLBL_Click(object sender, EventArgs e)
        {
            HistorySelect = false;

            HighlightHIST.Visible = false;
            HighlightMEM.Visible = true;
            HistDisplay.Visible = false;
            MemDisp.Visible = true;
            ClearHistBTN.Visible = false;

            if (MemDisp.Text != "There's no memory yet")
            {
                ClearMEMBTN.Visible = true;
            }
        }

        private void ClearHistBTN_Click(object sender, EventArgs e)
        {
            HistDisplay.Clear();
            if (HistDisplay.Text == "")
            {
                HistDisplay.Text = "There's no history yet";
            }
            ClearHistBTN.Visible = false;
            HistDisplay.ScrollBars = 0;
        }

        private void ClearMEMBTN_Click(object sender, EventArgs e)
        {

        }



        // FUNCTION METHODS SECTION
        // DON'T FORGET TO CLEAN THE CODE BEFORE PRESENTATION
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

        public void Compute()
        {
            Val1 = EquationBox.Text;

            EquationBox.Text = "";

            switch(Operation)
            {
                case "+":
                    ValueBox.Text = ((Result + Double.Parse(ValueBox.Text))).ToString();
                    break;
                case "-":
                    ValueBox.Text = ((Result - Double.Parse(ValueBox.Text))).ToString();
                    break;
                case "×":
                    ValueBox.Text = ((Result * Double.Parse(ValueBox.Text))).ToString();
                    break;
                case "÷":
                    ValueBox.Text = ((Result / Double.Parse(ValueBox.Text))).ToString();
                    break;
                default:
                    break;
            }

            Result = Double.Parse(ValueBox.Text);
            Operation = "";

        }

        private void HistoryAdd()
        {
            Val2 = ValueBox.Text;

            ClearHistBTN.Visible = true;

            if (HistDisplay.Text == "There's no history yet")
            {
                HistDisplay.Text = "";
            }

            HistDisplay.AppendText(Val1 + " " + Val2 + " = " + "\n");
            HistDisplay.AppendText("\n\t" + ValueBox.Text + "\n\n");
        }

        private void BackSpace()
        {
            if (ValueBox.Text.Length > 0)
            {
                ValueBox.Text = ValueBox.Text.Remove(ValueBox.Text.Length - 1, 1);
            }

            if (ValueBox.Text == "")
            {
                ValueBox.Text = "0";
            }
        }

        private void NewFeature()
        {
            MessageBox.Show("Feature coming soon!", "Stay Tuned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
