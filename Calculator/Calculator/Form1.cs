using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculating d = new Calculating();
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e) //button nummers
        {
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        }

        private void buttonFunction_Click(object sender, EventArgs e) //button functions
        {
            Button button = (Button)sender;
            double x = Convert.ToDouble(result.Text);
            d.NumCollection(x, button.Text);
            result.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e) //button leeg
        {
            result.Text = d.clear();
        }

        private void Equals_Click(object sender, EventArgs e) //button resultaat uitvoeren
        {
            d.SecondCollect(Convert.ToDouble(result.Text)); 
            result.Text = Convert.ToString(d.MakeCalculation());
        }

        private void buttonSingFunc_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            double x = Convert.ToDouble(result.Text);
            result.Text = Convert.ToString(d.SingleCalculation(x, button.Text));
        }
    }
}
