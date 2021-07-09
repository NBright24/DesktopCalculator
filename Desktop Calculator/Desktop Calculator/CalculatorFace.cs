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

        //double Result = 0, Memory = 0;
        //string Operation = "";
        //bool ValEnter = false;

        //string Val1, Val2;
        //bool HistorySelect = true;

        CoreFeatures CoreFeatures = new CoreFeatures();
        OtherFeatures OtherFeatures = new OtherFeatures();

        int Count1 = 0, Count2 = 1;

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValueBox.Text = CoreFeatures.ValBox;
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("0");
        }

        private void OneBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("1");
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("2");
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("3");
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("4");
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("5");
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("6");
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("7");
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("8");
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp("9");
        }

        private void PointBTN_Click(object sender, EventArgs e)
        {
            CoreFeatures.NumDisp(".");
        }

        private void PosNegBTN_Click(object sender, EventArgs e)
        {
            PosNeg();
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
            Reciprocal();
        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {
            Sqr();
        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {
            Sqrt();
        }

        private void PercentBTN_Click(object sender, EventArgs e)
        {
            Percentage();
        }

        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "0";
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            ClearVal();
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
            HisDispLight();
        }

        private void MemoryLBL_Click(object sender, EventArgs e)
        {
            MemDispLight();
        }

        private void ClearHistBTN_Click(object sender, EventArgs e)
        {
            ClearDisp(HistDisplay, "There's no history yet", ClearHistBTN);
        }

        private void ClearMEMBTN_Click(object sender, EventArgs e)
        {
            ClearDisp(MemDisp, "There's no memory yet", ClearMEMBTN);
            MEMClear();
        }
        private void MEMRecallBTN_Click(object sender, EventArgs e)
        {
            MEMCall();
        }

        private void MEMAddBTN_Click(object sender, EventArgs e)
        {
            MEMAdd();
        }

        private void MEMSubtractBTN_Click(object sender, EventArgs e)
        {
            MEMSub();
        }

        private void MEMClearBTN_Click(object sender, EventArgs e)
        {
            ClearDisp(MemDisp, "There's no memory yet", ClearMEMBTN);
            MEMClear();
        }

        private void MEMSaveBTN_Click(object sender, EventArgs e)
        {
            MEMSave();
        }

        private void MemDisp_TextChanged(object sender, EventArgs e)
        {
            MEMDispChange();
        }



        

        private void ArithOp(String X)
        {
            Count2 = Count1 % 2;

            if (Result != 0)
            {
                Compute();
                if(Count2 == 0)
                {
                    HistoryAdd();
                }
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
            Count1 += 1;
            Val1 = EquationBox.Text;
        }

        private void ClearVal()
        {
            EquationBox.Text = "";
            ValueBox.Text = "0";
            Result = 0;
        }

        public void Compute()
        {
            Val2 = ValueBox.Text;

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
            EquationBox.Text = Val1 + " " + Val2 + " = " ;

        }

        private void HistoryAdd()
        {
            ClearHistBTN.Visible = true;

            if (HistDisplay.Text == "There's no history yet")
            {
                HistDisplay.Text = "";
            }

                HistDisplay.AppendText(Val1 + " " + Val2 + " = ");
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

        private void HisDispLight()
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

        private void MemDispLight()
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

        private void ClearDisp(RichTextBox X, string Y, PictureBox Z)
        {
            X.Clear();
            if (X.Text == "")
            {
                X.Text = Y;
            }
            Z.Visible = false;
            X.ScrollBars = 0;
        }

        private void Percentage()
        {
            if (EquationBox.Text != "")
            {
                Result = Double.Parse(ValueBox.Text);
                ValueBox.Text = (Result / 100).ToString();
            }
            else
            {
                ValueBox.Text = "0";
                Result = Double.Parse(ValueBox.Text);
            }
        }

        private void Reciprocal()
        {
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "1 / " + Result.ToString() + " = ";
            ValueBox.Text = (1 / Result).ToString();
            Result = Double.Parse(ValueBox.Text);

            HistoryAdd();
        }

        private void Sqrt()
        {
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "√" + Result + " = ";
            ValueBox.Text = (Math.Sqrt(Result)).ToString();

            HistoryAdd();
        }

        private void Sqr()
        {
            EquationBox.Text = "";
            Result = double.Parse(ValueBox.Text);
            EquationBox.Text = "sqr(" + Result + ")" + " = ";
            ValueBox.Text = (Result * Result).ToString();
            Result = Double.Parse(ValueBox.Text);

            HistoryAdd();
        }

        private void PosNeg()
        {
            Result = Double.Parse(ValueBox.Text);
            ValueBox.Text = (0 - Result).ToString();
        }

        private void MEMSave()
        {
            MemDisp.Text = "";
            Memory = Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        private void MEMAdd()
        {
            MemDisp.Text = "";
            Memory += Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        private void MEMSub()
        {
            MemDisp.Text = "";
            Memory -= Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        private void MEMCall()
        {
            ValueBox.Text = Memory.ToString();
        }

        private void MEMClear()
        {
            MEMClearBTN.Visible = false;
            MEMRecallBTN.Visible = false;
            ClearMEMBTN.Visible = false;

            Memory = 0;
        }

        private void MEMDispChange()
        {
            if ((MemDisp.Text != "") || (MemDisp.Text != "There's no memory yet"))
            {
                MEMClearBTN.Visible = true;
                MEMRecallBTN.Visible = true;
                ClearMEMBTN.Visible = true;
            }
        }
    }
}
