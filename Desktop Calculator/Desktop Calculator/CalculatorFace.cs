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

        double Memory = 0;

        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CoreFeature.ValueBox = ValueBox.Text;
            //CoreFeature.EquationBox = EquationBox.Text;

            //ValueBox.Text = CoreFeature.ValueBox;
            //EquationBox.Text = CoreFeature.EquationBox;
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("0");
            NumDispFix();
        }

        private void OneBTN_Click(object sender, EventArgs e)
        { 
            CoreFeature.NumDisp("1");
            NumDispFix();
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("2");
            NumDispFix();
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("3");
            NumDispFix();
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("4");
            NumDispFix();
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("5");
            NumDispFix();
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("6");
            NumDispFix();
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("7");
            NumDispFix();
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("8");
            NumDispFix();
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp("9");
            NumDispFix();
        }

        private void PointBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.NumDisp(".");
            NumDispFix();
        }

        private void PosNegBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.PosNeg();
            NumDispFix();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(AddBTN.Text);
            NumDispFix();
        }

        private void SubtractBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(SubtractBTN.Text);
            NumDispFix();
        }

        private void MultiplyBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(MultiplyBTN.Text);
            NumDispFix();
        }

        private void DivideBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ArithOp(DivideBTN.Text);
            NumDispFix();
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Compute();
            HistoryAdd();
            NumDispFix();
        }

        private void FractionBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Reciprocal();
            HistoryAdd();
            NumDispFix();
        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Sqr();
            HistoryAdd();
            NumDispFix();
        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Sqrt();
            HistoryAdd();
            NumDispFix();
        }

        private void PercentBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.Percentage();
            NumDispFix();
        }

        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "0";
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.ClearVal();
            NumDispFix();
        }

        private void BackSpaceBTN_Click(object sender, EventArgs e)
        {
            CoreFeature.BackSpace();
            NumDispFix();
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

            HistDisplay.AppendText(CoreFeature.Val1 + " " + CoreFeature.Val2 + " = ");
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

        public void NumDispFix()
        {
            ValueBox.Text = CoreFeature.ValueBox;
            EquationBox.Text = CoreFeature.EquationBox;
        }
    }   
}
