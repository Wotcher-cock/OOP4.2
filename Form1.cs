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
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        public class Model
        {
            private int value;
            public int check;
            public System.EventHandler observers;

            public void setValue(int value, int check)
            {
                this.value = value;
                this.check = check;
                observers.Invoke(this, null);
            }
            public int getValue()
            {
                return value;
            }

            public int getCheck()
            {
                return check;
            }

        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            TrB.Value = model.getValue();
            PB.Value = model.getValue();
            if (model.getCheck() == 0)
            {
                TB.Text = (model.getValue() + 1).ToString();
            }
            else if (model.getCheck() == 1)
            {
                TB.Text = model.getValue().ToString();
                NUP.Text = (model.getValue() - 1).ToString();
            }
            else
            {
                NUP.Text = model.getValue().ToString();
                TB.Text = (model.getValue() + 1).ToString();
            }
        }
    


        private void EnterB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(model.getValue().ToString());
        }

        private void NUP_ValueChanged(object sender, EventArgs e)
        {
            model.setValue(Decimal.ToInt32(NUP.Value), 0);
        }

        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue(Int32.Parse(TB.Text), 1);
            }
        }

        private void TrB_Scroll(object sender, EventArgs e)
        {
            model.setValue(TrB.Value, 2);
        }
    }
}
