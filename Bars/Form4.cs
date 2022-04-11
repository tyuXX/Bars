using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form4 : Form
    {
        bool unlock = false;
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "ucdm")
            {
                unlock = true;
                textBox1.Hide();
                button1.Show();
                button2.Show();
                checkBox1.Show();
                label1.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bypass = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loads = BigInteger.Pow(loads,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bars++;
            Form3 form3 = new Form3();
            form3.barid = bars;
            form3.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            checkBox1.Hide();
            label1.Hide();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "To Rebirt:\n" + loads / (BigInteger.Pow(rebirts + 2, 16) / 100) + "%\nNeed:\n" + BigInteger.Pow(rebirts + 2, 16);
        }
    }
}
