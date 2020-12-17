using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NUP.Value.ToString());
        }

        private void NUP_ValueChanged(object sender, EventArgs e)
        {
            PB.Value = Decimal.ToInt32(NUP.Value);
            TB.Text = (NUP.Value + 1).ToString();
            TrB.Value = Decimal.ToInt32(NUP.Value);
        }

        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NUP.Value = Int32.Parse(TB.Text) - 1;
                PB.Value = Int32.Parse(TB.Text);
                TrB.Value = Int32.Parse(TB.Text);
            }
        }

        private void TrB_Scroll(object sender, EventArgs e)
        {
            NUP.Value = Decimal.ToInt32(TrB.Value);
            PB.Value = Decimal.ToInt32(TrB.Value);
            TB.Text = (TrB.Value+1).ToString();
        }
    }
}
