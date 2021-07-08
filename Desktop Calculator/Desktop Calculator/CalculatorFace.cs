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

        //First Values
        //string UserVal = string.Empty;
        //string OpValue1 = string.Empty;
        //string OpValue2 = string.Empty;
        //string Operation;
        //double Result = 0;
        //ushort Count = 1;

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

        private void OneBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("1");
        }

        private void TwoBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("2");
        }

        private void ThreeBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {

        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {

        }

        private void SixBTN_Click(object sender, EventArgs e)
        {

        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {

        }

        private void EightBTN_Click(object sender, EventArgs e)
        {

        }

        private void NineBTN_Click(object sender, EventArgs e)
        {

        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {

        }

        private void PointBTN_Click(object sender, EventArgs e)
        {
            DisplayNum(".");
        }

        private void PlusBTN_Click(object sender, EventArgs e)
        {
            Operations("+");
        }

        private void MinusBTN_Click(object sender, EventArgs e)
        {
            Operations("-");
        }

        private void MultiplyBTN_Click(object sender, EventArgs e)
        {
            Operations("*");
        }

        private void DivideBTN_Click(object sender, EventArgs e)
        {
            Operations("/");
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
            ClearAll();
        }

        private void ClearEntryBTN_Click(object sender, EventArgs e)
        {
            ValueBox.Text = "";
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {
            Compute();
        }

        //IF SHIT DID NOT WORK, DISABLE KEYBOARD INPUT
        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (ValueBox.Text == "")
            //{
            //    DisplayNum("0");
            //    CharCheckKey(sender, e);
            //}
            //else
            //    CharCheckKey(sender, e);
        }

        private void CharCheckKey(object sender, KeyPressEventArgs e)
        {
            //MODIFY THIS PARTS

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

        private void DisplayNum(string Y)
        {
            //Button Y = (Button)sender;

            //if ((ValueBox.Text == "0") || (ValEnter))
            //{
            //    ValueBox.Text = "";
            //    ValEnter = false;
            //    ValueBox.Text += Y;
            //}
            ValueBox.Text += Y;

            //if (Y == ".")
            //{
            //    if (ValueBox.Text.Contains("."))
            //    {
            //        ValueBox.Text += Y;
            //    }
            //}
            //else
            //{
            //    ValueBox.Text += Y;
            //}
        }

        private void Operations(string Y)
        {
            //OpValue1 = UserVal;
            //Operation = Y;
            //UserVal = string.Empty;
            ////Temporary
            //ValueBox.Text = string.Empty;
        }

        private void ClearAll()
        {
            //ValueBox.Text = "";
            //UserVal = string.Empty;
            //OpValue1 = string.Empty;
            //OpValue2 = string.Empty;
        }

        private void Compute()
        {
            //OpValue2 = UserVal;
            //double Val1, Val2;
            //double.TryParse(OpValue1, out Val1);
            //double.TryParse(OpValue2, out Val2);

            //if (Operation == "*")
            //{
            //    Result = Val1 * Val2;
            //    ValueBox.Text = Result.ToString();
            //}
            //if (Operation == "/")
            //{
            //    if(Val2 != 0)
            //    {
            //        Result = Val1 / Val2;
            //        ValueBox.Text = Result.ToString();
            //    }
            //    else
            //    {
            //        ValueBox.Text = "Math Error";
            //    }
            //}
            //if (Operation == "+")
            //{
            //    Result = Val1 + Val2;
            //    ValueBox.Text = Result.ToString();
            //}
            //if (Operation == "-")
            //{
            //    Result = Val1 - Val2;
            //    ValueBox.Text = Result.ToString();
            //}
        }
    }
}
