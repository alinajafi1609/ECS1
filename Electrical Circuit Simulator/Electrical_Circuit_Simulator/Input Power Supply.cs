using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Electrical_Circuit_Simulator
{
    public partial class Input_Power_Supply : Form
    {
        new bool Enter = false;
        public Input_Power_Supply()
        {
            InitializeComponent();
        }

        private void Input_Power_Supply_Load(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {
                string InputName = textBox1.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter = true;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Enter)
            {
                string EMF = textBox1.Text;
                double SEMF = Convert.ToDouble(EMF);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Enter)
            {
                string SIntertalResistance = textBox1.Text;
                double InternalResistance = Convert.ToDouble(SIntertalResistance);
            }
        }
    }
}
