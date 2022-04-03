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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void up_Tick(object sender, EventArgs e)
        {
            label1.Text = "LD:" + loads;
            label2.Text = "Bars:" + bars;
            label3.Text = "+LD:" + (sub - 1);
            label4.Text = "Minimum:" + minimum;
            label5.Text = "Banks:" + banks;
            button1.Text = "More Bars:" + prices[0] + "LD";
            button2.Text = "Extra LD:" + prices[1] + "LD";
            button3.Text = "Higher Min:" + prices[2] + "LD";
            button4.Text = "More Banks:" + prices[3] + "LD";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(loads > prices[1] || bypass)
            {
                loads -= prices[1];
                prices[1] *= 5;
                sub++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loads > prices[0] || bypass)
            {
                Form3 form3 = new Form3();
                form3.Show();
                loads -= prices[0];
                prices[0] *= 4;
                bars++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(minimum < 40)
            {
                if (loads > prices[2] || bypass)
                {
                    loads -= prices[2];
                    prices[2] *= 2;
                    minimum++;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (loads > prices[3] || bypass)
            {
                loads -= prices[3];
                prices[3] *= 10;
                banks += 1;
            }
        }
    }
}
