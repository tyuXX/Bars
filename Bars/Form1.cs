using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bars.rntm;

namespace Bars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(parame))
            {
                try
                {
                    string[] master = File.ReadAllLines(parame);
                    minimum = Convert.ToInt32(decode(master[0], hs));
                    sub = BigInteger.Parse(decode(master[1], hs));
                    loads = BigInteger.Parse(decode(master[2], hs));
                    banks = BigInteger.Parse(decode(master[3], hs));
                    bars = BigInteger.Parse(decode(master[4], hs));
                    prices[0] = BigInteger.Parse(decode(master[5], hs));
                    prices[1] = BigInteger.Parse(decode(master[6], hs));
                    prices[2] = BigInteger.Parse(decode(master[7], hs));
                    prices[3] = BigInteger.Parse(decode(master[8], hs));
                    for (BigInteger i = bars; i > 0; i++)
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = minimum;
                loads += sub;
            }
            progressBar1.Value++;
            label1.Text = "%" + progressBar1.Value.ToString();
            label2.Text = "Loads:" + loads.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Banks_Tick(object sender, EventArgs e)
        {
            loads += (loads * banks) / 100;
        }

        private void unlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] master = { encode(minimum.ToString(),hs), encode(sub.ToString(),hs), encode(loads.ToString(),hs), encode(bars.ToString(),hs), encode(banks.ToString(), hs), encode(prices[0].ToString(),hs), encode(prices[1].ToString(), hs), encode(prices[2].ToString(), hs), encode(prices[3].ToString(), hs) };
                saveFileDialog1.Filter = "Bars save files (*.brs) | *.brs";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, master);
                    saveloc = saveFileDialog1.FileName;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Bars save files(*.brs) | *.brs";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string[] master = File.ReadAllLines(openFileDialog1.FileName);
                    minimum = Convert.ToInt32(decode(master[0],hs));
                    sub = BigInteger.Parse(decode(master[1],hs));
                    loads = BigInteger.Parse(decode(master[2],hs));
                    banks = BigInteger.Parse(decode(master[3],hs));
                    bars = BigInteger.Parse(decode(master[4],hs));
                    prices[0] = BigInteger.Parse(decode(master[5],hs));
                    prices[1] = BigInteger.Parse(decode(master[6],hs));
                    prices[2] = BigInteger.Parse(decode(master[7],hs));
                    prices[3] = BigInteger.Parse(decode(master[8],hs));
                    for (BigInteger i = bars; i > 0; i++)
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private string encode(string enc,string hash)
        {
            byte[] data = UnicodeEncoding.Unicode.GetBytes(enc);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripdes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return (Convert.ToBase64String(results, 0, results.Length));
                }
            }
        }
        private string decode(string dec,string hash)
        {
            byte[] data = Convert.FromBase64String(dec);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UnicodeEncoding.Unicode.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripdes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripdes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return (UnicodeEncoding.Unicode.GetString(results));
                }
            }
        }
    }
}
