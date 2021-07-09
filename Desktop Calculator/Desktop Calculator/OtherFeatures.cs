using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Calculator
{
    class OtherFeatures
    {
        CoreFeatures CoreFeatures = new CoreFeatures();
        
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

    }
}
