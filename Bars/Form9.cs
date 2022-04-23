using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void dowload(string link, string name)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, name);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label2.Text = "Version:" + update + "\nTo\nVersion:" + nupdate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dowload("https://raw.githubusercontent.com/tyuXX/Bars/master/BarsUpdate/bin/Debug/BarsUpdate.exe", "BarsUpdate.exe");
            Process.Start("BarsUpdate.exe",Application.ExecutablePath);
            Application.Exit();
        }
    }
}
