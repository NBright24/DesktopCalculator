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
        public Window()
        {
            InitializeComponent();
        }

        float UserVal = 0;
        float UserVal2 = 0;
        Boolean IsAdd = false;
        Boolean IsMin = false;
        Boolean IsMul = false;
        Boolean IsDiv = false;
        short count = 1;
        float result = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private static void NumType(int X)
        {
            //TextBox ValueBox = ValueBox.Text += "X";
        }

        private void OneBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 1;
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 2;
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 3;
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 4;
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 5;
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 6;
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 7;
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 8;
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 9;
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text += 0;
        }

        private void PlusBTN_Click(object sender, EventArgs e)
        {
            UserVal = float.Parse(ValueBox.Text);
            IsAdd = true;
            ValueBox.Text = "";
        }

        private void MinusBTN_Click(object sender, EventArgs e)
        {
            UserVal = float.Parse(ValueBox.Text);
            IsMin = true;
            ValueBox.Text = "";
        }

        private void MultiplyBTN_Click(object sender, EventArgs e)
        {
            UserVal = float.Parse(ValueBox.Text);
            IsMul = true;
            ValueBox.Text = "";
        }

        private void DivideBTN_Click(object sender, EventArgs e)
        {
            UserVal = float.Parse(ValueBox.Text);
            IsDiv = true;
            ValueBox.Text = "";
        }

        private void PointBTN_Click(object sender, EventArgs e)
        {

        }

        private void PosNegBTN_Click(object sender, EventArgs e)
        {

        }

        private void SqrtBTN_Click(object sender, EventArgs e)
        {

        }

        private void SquareBTN_Click(object sender, EventArgs e)
        {

        }

        private void FractionBTN_Click(object sender, EventArgs e)
        {

        }

        private void PercentBTN_Click(object sender, EventArgs e)
        {

        }

        private void BackSpaceBTN_Click(object sender, EventArgs e)
        {

        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {

        }

        private void ClearAllBTN_Click(object sender, EventArgs e)
        {

        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {
            UserVal2 = float.Parse(ValueBox.Text);

            if (IsAdd == true)
            {
               result = UserVal + UserVal2;
            }
            if(IsMin == true)
            {
                result = UserVal - UserVal2;
            }

            ValueBox.Text = "";
            ValueBox.Text = Convert.ToString(result);
            count = 1;
        }


        //MODIFY THIS PART!!!
        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
