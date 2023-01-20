using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form10 : Form
    {
        internal List<Form3> Form3s;
        internal BigInteger barcid = 0;
        internal BigInteger listlenght = 0;
        public Form10()
        {
            InitializeComponent();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (barcid > barcontainers)
            {
                Close();
            }
            if(barcontainers > listlenght)
            {
                Close();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            for(BigInteger opened = 0; barcontainers > opened; opened++)
            {
                if(opened == 0)
                {
                    Form3 form3t = new Form3();
                    List<Form3> form3s = new List<Form3> { form3t };
                    Form3s = form3s;
                    listlenght++;
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.barid = 0;
                    form3.MdiParent = this;
                    form3.Show();
                    Form3s.Add(form3);
                    listlenght++;
                }
            }
        }

        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form3 form3 in Form3s)
            {
                form3.barid = -1;
                form3.Close();
            }
            if (!(barcid > barcontainers))
            {
                Form10 form10 = new Form10();
                form10.barcid = barcid;
                form10.Show();
            }
        }
    }
}
