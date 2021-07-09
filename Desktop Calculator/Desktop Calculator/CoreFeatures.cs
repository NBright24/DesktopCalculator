using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Calculator
{
    class CoreFeatures
    {
        public double Result = 0, Memory = 0;
        public string Operation = "";
        public bool ValEnter = false;
        public string ValBox = "";

        public void NumDisp(string X)
        {

            if ((ValBox == "0") || (ValEnter))
            {
                ValBox = "";
                ValEnter = false;
            }
            if (X == ".")
            {
                if (!ValBox.Contains("."))
                {
                    if (ValBox == "")
                    {
                        ValBox = "0";
                        ValBox += X;
                    }
                    else
                    {
                        ValBox += X;
                    }
                }
            }
            else
            {
                ValBox += X;
            }
        }
    }
}
