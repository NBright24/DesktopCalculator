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
        CoreFeatures CoreFeature = new CoreFeatures();
        OtherFeatures OtherFeature = new OtherFeatures();

        double Memory = 0;
        string Val1, Val2 = "";

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoreFeature.ValueBox = ValueBox.Text;
            CoreFeature.EquationBox = EquationBox.Text;
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("0");
        }

        private void OneBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("1");
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("2");
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("3");
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("4");
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("5");
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("6");
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("7");
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("8");
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("9");
        }

        private void PointBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp(".");
        }

        private void PosNegBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.PosNeg();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(AddBTN.Text);
            ArithOPCond();      
        }

        private void SubtractBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(SubtractBTN.Text);
            ArithOPCond();
        }

        private void MultiplyBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(MultiplyBTN.Text);
            ArithOPCond();
        }

        private void DivideBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(DivideBTN.Text);
            ArithOPCond();
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Compute();
            HistoryAdd();
        }

        private void FractionBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Reciprocal();
            HistoryAdd();
        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Sqr();
            HistoryAdd();
        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Sqrt();
            HistoryAdd();
        }

        private void PercentBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Percentage();
        }

        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "0";
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ClearVal();
        }

        private void BackSpaceBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.BackSpace();
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

        //======================== METHODS ========================//

        public void MEMSave()
        {
            MemDisp.Text = "";
            Memory = Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        public void MEMAdd()
        {
            MemDisp.Text = "";
            Memory += Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        public void MEMSub()
        {
            MemDisp.Text = "";
            Memory -= Double.Parse(ValueBox.Text);
            MemDisp.AppendText(Memory.ToString());
        }

        public void MEMCall()
        {
            ValueBox.Text = Memory.ToString();
        }

        public void MEMClear()
        {
            MEMClearBTN.Visible = false;
            MEMRecallBTN.Visible = false;
            ClearMEMBTN.Visible = false;

            Memory = 0;
        }

        public void MEMDispChange()
        {
            if ((MemDisp.Text != "") || (MemDisp.Text != "There's no memory yet"))
            {
                MEMClearBTN.Visible = true;
                MEMRecallBTN.Visible = true;
                ClearMEMBTN.Visible = true;
            }
        }

        public bool HistorySelect = true;

        public void HistoryAdd()
        {
            ClearHistBTN.Visible = true;

            if (HistDisplay.Text == "There's no history yet")
            {
                HistDisplay.Text = "";
            }

            HistDisplay.AppendText(Val1 + " " + Val2 + " = ");
            HistDisplay.AppendText("\n\t" + ValueBox.Text + "\n\n");
        }

        public void NewFeature()
        {
            MessageBox.Show("Feature coming soon!", "Stay Tuned!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HisDispLight()
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

        public void MemDispLight()
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

        public void ClearDisp(RichTextBox X, string Y, PictureBox Z)
        {
            X.Clear();
            if (X.Text == "")
            {
                X.Text = Y;
            }
            Z.Visible = false;
            X.ScrollBars = 0;
        }

        public void ArithOPCond()
        {
            if (CoreFeature.Count2 == 0)
            {
                HistoryAdd();
            }
        }
    }   
}
