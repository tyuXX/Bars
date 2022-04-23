using System;
using System.Numerics;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "ucdm")
            {
                textBox1.Hide();
                button1.Show();
                button2.Show();
                checkBox1.Show();
                label1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
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
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox2.Hide();
            textBox3.Text = mult2.ToString();
            textBox4.Text = mult3.ToString();
            textBox5.Text = mult4.ToString();
            textBox2.Text = mult5.ToString();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "To Rebirt:\n" + loads / (BigInteger.Pow(rebirts + 2, 16) / 100) + "%\nNeed:\n" + BigInteger.Pow(rebirts + 2, 16) + "\nRebirts:\n" + rebirts + "\nTotal Loads:\n" + totalloads;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    mult2 = BigInteger.Parse(textBox2.Text);
                }
            }
            catch (Exception ex)
            {
                textBox2.Text = "Enter a number";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    mult2 = BigInteger.Parse(textBox3.Text);
                }
            }
            catch (Exception ex)
            {
                textBox3.Text = "Enter a number";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    mult2 = BigInteger.Parse(textBox4.Text);
                }
            }
            catch (Exception ex)
            {
                textBox4.Text = "Enter a number";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    mult2 = BigInteger.Parse(textBox5.Text);
                }
            }
            catch (Exception ex)
            {
                textBox5.Text = "Enter a number";
            }
        }
    }
}
