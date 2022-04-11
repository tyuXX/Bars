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
    public partial class Form7 : Form
    {
        BigInteger bstorage = 0;
        BigInteger bstoragep = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    bstorage = BigInteger.Parse(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "Enter a number";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    bstoragep = BigInteger.Parse(textBox2.Text);
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = "Enter a number";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(supoints >= bstorage || bypass)
            {
                smax += bstorage;
                supoints -= bstorage;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Maximum Storage:" + smax;
            label2.Text = "Storage Points:" + supoints;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (loads >= bstoragep * 4 || bypass)
            {
                supoints += bstoragep;
                loads -= bstoragep * 4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            smax += supoints;
            supoints = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            supoints += (loads / 4);
            loads = 0;
        }
    }
}
