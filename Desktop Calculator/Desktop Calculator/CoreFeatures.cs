using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_Calculator
{
    class CoreFeatures
    {
        OtherFeatures OtherFeatures = new OtherFeatures();

        public double Result = 0, Memory = 0;
        public string Operation = "";
        public bool ValEnter = false;
        public int Count1 = 0, Count2 = 1;
        public string Val1, Val2;

        public string ValueBox, EquationBox, 
            MemDisp,MEMClearBTNVi, MEMRecallBTNVi, ClearMEMBTNVi,
             MemDispAP = "";
    
        public void NumDisp(string X)
        {

            if ((ValueBox == "0") || (ValEnter))
            {
                ValueBox = "";
                ValEnter = false;
            }
            if (X == ".")
            {
                if (!ValueBox.Contains("."))
                {
                    if (ValueBox == "")
                    {
                        ValueBox = "0";
                        ValueBox += X;
                    }
                    else
                    {
                        ValueBox += X;
                    }
                }
            }
            else
            {
                ValueBox += X;
            }
        }

        public void ClearVal()
        {
            EquationBox = "";
            ValueBox = "0";
            Result = 0;
        }

        public void BackSpace()
        {
            if (ValueBox.Length > 0)
            {
                ValueBox = ValueBox.Remove(ValueBox.Length - 1, 1);
            }

            if (ValueBox == "")
            {
                ValueBox = "0";
            }
        }

        public void Compute()
        {
            Val2 = ValueBox;

            EquationBox = "";

            switch (Operation)
            {
                case "+":
                    ValueBox = ((Result + Double.Parse(ValueBox))).ToString();
                    break;
                case "-":
                    ValueBox = ((Result - Double.Parse(ValueBox))).ToString();
                    break;
                case "×":
                    ValueBox = ((Result * Double.Parse(ValueBox))).ToString();
                    break;
                case "÷":
                    ValueBox = ((Result / Double.Parse(ValueBox))).ToString();
                    break;
                default:
                    break;
            }
            Result = Double.Parse(ValueBox);
            Operation = "";
            EquationBox = Val1 + " " + Val2 + " = ";
        }


        public void ArithOp(String X)
        {
            Count2 = Count1 % 2;

            if (Result != 0)
            {
                Compute();
                if (Count2 == 0)
                {
                    HistoryAdd();
                }
                ValEnter = true;
                Operation = X;
                EquationBox = Convert.ToString(Result) + " " + Operation;
            }
            else
            {
                Operation = X;
                Result = Double.Parse(ValueBox);
                ValueBox = "";
                EquationBox = Convert.ToString(Result) + " " + Operation;
            }
            Count1 += 1;
            Val1 = EquationBox;
        }

        public void Percentage()
        {
            if (EquationBox != "")
            {
                Result = Double.Parse(ValueBox);
                ValueBox = (Result / 100).ToString();
            }
            else
            {
                ValueBox = "0";
                Result = Double.Parse(ValueBox);
            }
        }

        public void Reciprocal()
        {
            EquationBox = "";
            Result = double.Parse(ValueBox);
            EquationBox = "1 / " + Result.ToString() + " = ";
            ValueBox = (1 / Result).ToString();
            Result = Double.Parse(ValueBox);

            HistoryAdd();
        }

        public void Sqrt()
        {
            EquationBox = "";
            Result = double.Parse(ValueBox);
            EquationBox = "√" + Result + " = ";
            ValueBox = (Math.Sqrt(Result)).ToString();

            OtherFeatures
        }

        public void Sqr()
        {
            EquationBox = "";
            Result = double.Parse(ValueBox);
            EquationBox = "sqr(" + Result + ")" + " = ";
            ValueBox = (Result * Result).ToString();
            Result = Double.Parse(ValueBox);

            HistoryAdd();
        }

        public void PosNeg()
        {
            Result = Double.Parse(ValueBox.Text);
            ValueBox= (0 - Result).ToString();
        }

        public void MEMSave()
        {
            MemDisp= "";
            Memory = Double.Parse(ValueBox.);
            MemDispAP = Memory.ToString();
        }

        public void MEMAdd()
        {
            MemDisp = "";
            Memory += Double.Parse(ValueBox);
            MemDispAP = Memory.ToString();
        }

        public void MEMSub()
        {
            MemDisp = "";
            Memory -= Double.Parse(ValueBox);
            MemDispAP = Memory.ToString();
        }

        public void MEMCall()
        {
            ValueBox = Memory.ToString();
        }

        public void MEMClear()
        {
            MEMClearBTNVi = false;
            MEMRecallBTNVi = false;
            ClearMEMBTNVi = false;

            Memory = 0;
        }

        public void MEMDispChange()
        {
            if ((MemDisp != "") || (MemDisp != "There's no memory yet"))
            {
                MEMClearBTNVi = true;
                MEMRecallBTNVi = true;
                ClearMEMBTNVi = true;
            }
        }
    }
}
