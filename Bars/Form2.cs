using System;
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
            if(!(minimum < 40))
            {
                button3.Hide();
            }
            if (!(extrachance < 18))
            {
                button6.Hide();
            }
            if (taxevade)
            {
                button5.Hide();
            }
            label1.Text = "LD:" + loads;
            label2.Text = "Bars:" + bars;
            label3.Text = "+LD:" + (sub - 1);
            label4.Text = "Minimum:" + minimum;
            label5.Text = "Banks:" + banks;
            label6.Text = "Extra Chance:" + extrachance;
            button1.Text = "More Bars:" + prices[0] + "LD";
            button2.Text = "Extra LD:" + prices[1] + "LD";
            button3.Text = "Higher Min:" + prices[2] + "LD";
            button4.Text = "More Banks:" + prices[3] + "LD";
            button6.Text = "Extra Chance:" + prices[4] + "LD";
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
                bars++;
                Form3 form3 = new Form3();
                form3.barid = bars;
                form3.Show();
                loads -= prices[0];
                prices[0] *= 4;
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (loads > 10000000 || bypass)
            {
                loads -= 10000000;
                taxevade = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (extrachance < 18)
            {
                if (loads > prices[4] || bypass)
                {
                    loads -= prices[4];
                    prices[4] *= 10;
                    extrachance++;
                }
            }
        }
    }
}
