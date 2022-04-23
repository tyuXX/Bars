using System;
using System.Numerics;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form3 : Form
    {
        internal BigInteger barid = 1;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barid > bars)
            {
                Close();
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar2.Value == progressBar2.Maximum)
            {
                progressBar2.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar3.Value == progressBar3.Maximum)
            {
                progressBar3.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar4.Value == progressBar4.Maximum)
            {
                progressBar4.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar5.Value == progressBar5.Maximum)
            {
                progressBar5.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar6.Value == progressBar6.Maximum)
            {
                progressBar6.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar7.Value == progressBar7.Maximum)
            {
                progressBar7.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar8.Value == progressBar8.Maximum)
            {
                progressBar8.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar9.Value == progressBar9.Maximum)
            {
                progressBar9.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar10.Value == progressBar10.Maximum)
            {
                progressBar10.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar11.Value == progressBar11.Maximum)
            {
                progressBar11.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar12.Value == progressBar12.Maximum)
            {
                progressBar12.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar13.Value == progressBar13.Maximum)
            {
                progressBar13.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar14.Value == progressBar14.Maximum)
            {
                progressBar14.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar15.Value == progressBar15.Maximum)
            {
                progressBar15.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar16.Value == progressBar16.Maximum)
            {
                progressBar16.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar17.Value == progressBar17.Maximum)
            {
                progressBar17.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar18.Value == progressBar18.Maximum)
            {
                progressBar18.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar19.Value == progressBar19.Maximum)
            {
                progressBar19.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar20.Value == progressBar20.Maximum)
            {
                progressBar20.Value = 0;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar21.Value == progressBar21.Maximum)
            {
                progressBar21.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar22.Value == progressBar22.Maximum)
            {
                progressBar22.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar23.Value == progressBar23.Maximum)
            {
                progressBar23.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (progressBar24.Value == progressBar24.Maximum)
            {
                progressBar24.Value = minimum;
                loads += sub * mult * mult2 * mult3 * mult4 * mult5;
				totalloads += sub * mult * mult2 * mult3 * mult4 * mult5;
            }
            if (bars > 0)
            {
                progressBar1.Value++;
            }
            if (bars > 1)
            {
                progressBar2.Value++;
            }
            if (bars > 2)
            {
                progressBar3.Value++;
            }
            if (bars > 3)
            {
                progressBar4.Value++;
            }
            if (bars > 4)
            {
                progressBar5.Value++;
            }
            if (bars > 5)
            {
                progressBar6.Value++;
            }
            if (bars > 6)
            {
                progressBar7.Value++;
            }
            if (bars > 7)
            {
                progressBar8.Value++;
            }
            if (bars > 8)
            {
                progressBar9.Value++;
            }
            if (bars > 9)
            {
                progressBar10.Value++;
            }
            if (bars > 10)
            {
                progressBar11.Value++;
            }
            if (bars > 11)
            {
                progressBar12.Value++;
            }
            if (bars > 12)
            {
                progressBar13.Value++;
            }
            if (bars > 13)
            {
                progressBar14.Value++;
            }
            if (bars > 14)
            {
                progressBar15.Value++;
            }
            if (bars > 15)
            {
                progressBar16.Value++;
            }
            if (bars > 16)
            {
                progressBar17.Value++;
            }
            if (bars > 17)
            {
                progressBar18.Value++;
            }
            if (bars > 18)
            {
                progressBar19.Value++;
            }
            if (bars > 19)
            {
                progressBar20.Value++;
            }
            if (bars > 20)
            {
                progressBar21.Value++;
            }
            if (bars > 21)
            {
                progressBar22.Value++;
            }
            if (bars > 22)
            {
                progressBar23.Value++;
            }
            if (bars > 23)
            {
                progressBar24.Value++;
            }
            label1.Text = "%" + progressBar1.Value;
            label2.Text = "%" + progressBar2.Value;
            label3.Text = "%" + progressBar3.Value;
            label4.Text = "%" + progressBar4.Value;
            label5.Text = "%" + progressBar5.Value;
            label6.Text = "%" + progressBar6.Value;
            label7.Text = "%" + progressBar7.Value;
            label8.Text = "%" + progressBar8.Value;
            label9.Text = "%" + progressBar9.Value;
            label10.Text = "%" + progressBar10.Value;
            label11.Text = "%" + progressBar11.Value;
            label12.Text = "%" + progressBar12.Value;
            label13.Text = "%" + progressBar13.Value;
            label14.Text = "%" + progressBar14.Value;
            label15.Text = "%" + progressBar15.Value;
            label16.Text = "%" + progressBar16.Value;
            label17.Text = "%" + progressBar17.Value;
            label18.Text = "%" + progressBar18.Value;
            label19.Text = "%" + progressBar19.Value;
            label20.Text = "%" + progressBar20.Value;
            label21.Text = "%" + progressBar21.Value;
            label22.Text = "%" + progressBar22.Value;
            label23.Text = "%" + progressBar23.Value;
            label24.Text = "%" + progressBar24.Value;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(barid <= bars)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
