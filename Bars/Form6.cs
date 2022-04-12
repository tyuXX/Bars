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
    public partial class Form6 : Form
    {
        BigInteger investment = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "Enflasion:" + cenflasion;
            label2.Text = "Income:" + cincome;
            label3.Text = "Outcome:" + coutcome;
            label4.Text = "Size:" + csize + "m^2";
            label5.Text = "Population:" + cpopulation;
            label6.Text = "Population Rise:" + cpopulationrise;
            cpopulationrise = cincome / 10;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = cname;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cname = textBox1.Text;
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    investment = BigInteger.Parse(textBox2.Text);
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = "Enter a number";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cstarted = true;
            if(investment <= loads)
            {
                loads -= investment;
                cincome += investment / 75;
                csize += investment / 100;
                cenflasion -= investment / 100000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cstarted = true;
            cincome += loads / 75;
            csize += loads / 100;
            cenflasion -= loads / 100000;
            loads = 0;
        }
    }
}
