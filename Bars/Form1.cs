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
            button2.Hide();
            button4.Hide();
            if (!string.IsNullOrEmpty(parame))
            {
                try
                {
                    
                    string[] master = File.ReadAllLines(parame);
                    minimum = Convert.ToInt32(decode(master[0], hs));
                    sub = BigInteger.Parse(decode(master[1], hs));
                    loads = BigInteger.Parse(decode(master[2], hs));
                    BigInteger bart = BigInteger.Parse(decode(master[3], hs));
                    banks = BigInteger.Parse(decode(master[4], hs));
                    prices[0] = BigInteger.Parse(decode(master[5], hs));
                    prices[1] = BigInteger.Parse(decode(master[6], hs));
                    prices[2] = BigInteger.Parse(decode(master[7], hs));
                    prices[3] = BigInteger.Parse(decode(master[8], hs));
                    mult = BigInteger.Parse(decode(master[9], hs));
                    rebirts = BigInteger.Parse(decode(master[10], hs));
                    tax = BigInteger.Parse(decode(master[11], hs));
                    taxevade = Convert.ToBoolean(decode(master[12], hs));
                    prices[4] = BigInteger.Parse(decode(master[13], hs));
                    cincome = BigInteger.Parse(decode(master[14], hs));
                    coutcome = BigInteger.Parse(decode(master[15], hs));
                    cname = decode(master[16], hs);
                    cenflasion = BigInteger.Parse(decode(master[17], hs));
                    csize = BigInteger.Parse(decode(master[18], hs));
                    cpopulation = BigInteger.Parse(decode(master[19], hs));
                    cpopulationrise = BigInteger.Parse(decode(master[20], hs));
                    extrachance = byte.Parse(decode(master[21], hs));
                    for (BigInteger bar = bart; bar > 0; bar--)
                    {
                        bars++;
                        Form3 form3 = new Form3();
                        form3.barid = bars;
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
            if(rebirts >= 7)
            {
                button4.Show();
            }
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = minimum;
                loads += sub * mult;
            }
            progressBar1.Value++;
            label1.Text = "%" + progressBar1.Value;
            label2.Text = "Loads:" + loads + "/" + smax;
            if (loads > BigInteger.Pow(rebirts + 2,16) || bypass)
            {
                button2.Show();
            }
            else
            {
                button2.Hide();
            }
            if(loads > (smax * mult))
            {
                loads = smax * mult;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Banks_Tick(object sender, EventArgs e)
        {
            if(banks > 0)
            {
                loads += (loads * banks) / 100;
            }
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
                string[] master = { encode(minimum.ToString(), hs), encode(sub.ToString(), hs), encode(loads.ToString(), hs), encode(bars.ToString(), hs), encode(banks.ToString(), hs), encode(prices[0].ToString(), hs), encode(prices[1].ToString(), hs), encode(prices[2].ToString(), hs), encode(prices[3].ToString(), hs), encode(mult.ToString(), hs), encode(rebirts.ToString(), hs), encode(tax.ToString(), hs), encode(taxevade.ToString(), hs), encode(prices[4].ToString(), hs), encode(cincome.ToString(), hs), encode(coutcome.ToString(), hs), encode(cname, hs), encode(cenflasion.ToString(), hs), encode(csize.ToString(), hs), encode(cpopulation.ToString(), hs), encode(cpopulationrise.ToString(), hs), encode(extrachance.ToString(), hs), };
                saveFileDialog1.Filter = "Bars save files (*.brs) | *.brs";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog1.FileName, master);
                    parame = saveFileDialog1.FileName;
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
                    string[] master = File.ReadAllLines(parame);
                    minimum = Convert.ToInt32(decode(master[0], hs));
                    sub = BigInteger.Parse(decode(master[1], hs));
                    loads = BigInteger.Parse(decode(master[2], hs));
                    BigInteger bart = BigInteger.Parse(decode(master[3], hs));
                    banks = BigInteger.Parse(decode(master[4], hs));
                    prices[0] = BigInteger.Parse(decode(master[5], hs));
                    prices[1] = BigInteger.Parse(decode(master[6], hs));
                    prices[2] = BigInteger.Parse(decode(master[7], hs));
                    prices[3] = BigInteger.Parse(decode(master[8], hs));
                    mult = BigInteger.Parse(decode(master[9], hs));
                    rebirts = BigInteger.Parse(decode(master[10], hs));
                    tax = BigInteger.Parse(decode(master[11], hs));
                    taxevade = Convert.ToBoolean(decode(master[12], hs));
                    prices[4] = BigInteger.Parse(decode(master[13], hs));
                    cincome = BigInteger.Parse(decode(master[14], hs));
                    coutcome = BigInteger.Parse(decode(master[15], hs));
                    cname = decode(master[16], hs);
                    cenflasion = BigInteger.Parse(decode(master[17], hs));
                    csize = BigInteger.Parse(decode(master[18], hs));
                    cpopulation = BigInteger.Parse(decode(master[19], hs));
                    cpopulationrise = BigInteger.Parse(decode(master[20], hs));
                    extrachance = byte.Parse(decode(master[21], hs));
                    for (BigInteger bar = bart; bar > 0; bar--)
                    {
                        bars++;
                        Form3 form3 = new Form3();
                        form3.barid = bars;
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

        private void button2_Click(object sender, EventArgs e)
        {
            minimum = 0;
            sub = 1;
            loads = 0;
            bars = 0;
            banks = 0;
            coutcome = 0;
            cincome = 0;
            cpopulation = 5;
            cpopulationrise = 0;
            csize = 50;
            extrachance = 0;
            cenflasion = 0;
            mult += 1;
            rebirts += 1;
            prices = new BigInteger[] { 10,100,1000,1000000,100000 };
        }

        private void tax_Tick(object sender, EventArgs e)
        {
            if ((!taxevade) || (!bypass))
            {
                loads -= (loads / tax);
            }
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autosave.Enabled)
            {
                oNToolStripMenuItem.Text = "OFF";
                autosave.Enabled = false;
            }
            else
            {
                oNToolStripMenuItem.Text = "ON";
                autosave.Enabled = true;
            }
        }

        private void autosave_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] master = { encode(minimum.ToString(), hs), encode(sub.ToString(), hs), encode(loads.ToString(), hs), encode(bars.ToString(), hs), encode(banks.ToString(), hs), encode(prices[0].ToString(), hs), encode(prices[1].ToString(), hs), encode(prices[2].ToString(), hs), encode(prices[3].ToString(), hs), encode(mult.ToString(), hs), encode(rebirts.ToString(), hs), encode(tax.ToString(), hs), encode(taxevade.ToString(), hs), encode(prices[4].ToString(), hs), encode(cincome.ToString(), hs), encode(coutcome.ToString(), hs), encode(cname, hs), encode(cenflasion.ToString(), hs), encode(csize.ToString(), hs), encode(cpopulation.ToString(), hs), encode(cpopulationrise.ToString(), hs), encode(extrachance.ToString(), hs), };
                File.WriteAllLines(parame, master);
            }
            catch (Exception ex)
            {

            }
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                oFFToolStripMenuItem.Text = "OFF";
                TopMost = false;
            }
            else
            {
                oFFToolStripMenuItem.Text = "ON";
                TopMost = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void ctick_Tick(object sender, EventArgs e)
        {
            loads += (cincome * mult) - coutcome;
            coutcome = cpopulation / 1000;
            cpopulation += cpopulationrise;
        }

        private void spp_Tick(object sender, EventArgs e)
        {
            spoints += sub * mult;
        }
    }
}
