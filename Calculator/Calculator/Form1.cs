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
            Calculating.NumCollection(Convert.ToInt32(result.Text), button.Text);
            result.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e) //button leeg
        {
                result.Text = "0";
        }

        private void Equals_Click(object sender, EventArgs e) //button resultaat uitvoeren
        {
            result.Text = Convert.ToString(Calculating.MakeCalculation(Convert.ToInt32(result.Text)));
        }
    }
}
