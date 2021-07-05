﻿using System;
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

        //float UserVal = 0;
        //float UserVal2 = 0;
        //Boolean IsAdd = false;
        //Boolean IsMin = false;
        //Boolean IsMul = false;
        //Boolean IsDiv = false;
        //short count = 1;
        //float result = 0;

        string UserVal = string.Empty;
        string OpValue1 = string.Empty;
        string OpValue2 = string.Empty;
        string Operation;
        double Result = 0;

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
            DisplayNum("3");
        }

        private void FourBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("4");
        }

        private void FiveBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("5");
        }

        private void SixBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("6");
        }

        private void SevenBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("7");
        }

        private void EightBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("8");
        }

        private void NineBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("9");
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            DisplayNum("0");
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

        private void PointBTN_Click(object sender, EventArgs e)
        {
            DisplayNum(".");
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
            ClearAll();
        }

        private void EqualBTN_Click(object sender, EventArgs e)
        {

        }

        private void ValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CharCheckKey(sender, e);
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

        private void DisplayNum(string X)
        {
            ValueBox.Text += X;
            UserVal += X;
        }

        private void Operations(string Y)
        {
            OpValue1 = UserVal;
            Operation = Y;
            UserVal = string.Empty;
        }

        private void ClearAll()
        {
            ValueBox.Text = "";
            UserVal = string.Empty;
            OpValue1 = string.Empty;
            OpValue2 = string.Empty;
        }
    }
}
