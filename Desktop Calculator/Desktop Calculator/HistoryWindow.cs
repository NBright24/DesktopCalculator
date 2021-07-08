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
    public partial class HistoryWindow : Form
    {
       
        public HistoryWindow()
        {
            InitializeComponent();
        }

        

        private void MemoryDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            MemoryDisplay.Text = "There's no history yet.";
        }
    }
}
