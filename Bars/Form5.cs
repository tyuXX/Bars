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
    public partial class Form5 : Form
    {
        Random random = new Random();
        BigInteger bet = 0;
        byte chance = 80;
        public Form5()
        {
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "LD:" + loads;
            label2.Text = "Chance:" + chance + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(random.Next(1,100) < chance + 1 || bypass)
            {
                loads += bet;
                if (chance > 1)
                {
                    chance--;
                }
            }
            else
            {
                loads -= bet;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    bet = BigInteger.Parse(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "Enter a number";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (random.Next(1, 100) < chance + 1 || bypass)
            {
                loads += loads;
                if(chance > 1)
                {
                    chance--;
                }
            }
            else
            {
                loads = 0;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            chance += extrachance;
        }
    }
}
