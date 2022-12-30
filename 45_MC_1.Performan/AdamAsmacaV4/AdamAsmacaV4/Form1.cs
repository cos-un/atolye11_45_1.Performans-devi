using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaV4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] kelimeler = { "BEN", "SEN", "VAMPİR", "DİFRANSİYEL", "ARABA", "FORM", };// Bulucağımız kelimeler.
        String kelime;// Değişkenler.
        String secim;

        int hak = 0;
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = String.Empty;
            secim = kelimeler[rnd.Next(0, 6)];
            label2.Text = secim;// Tahmin etmemiz gereken kelimeyi label2'ye yazdırıyorum.
            kelime = "";
            for (int i = 0; i < secim.Length; i++)// Tahmin etmemiz gereken kelimenin harf uzunluğu kadar "_" işaretini yazdırdım.
            {
                kelime += " _ ";
            }
            label1.Text = kelime;
        }

        private void buttonBasla_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = String.Empty;
            secim = kelimeler[rnd.Next(0, 6)];
            label2.Text = secim;// Tahmin etmemiz gereken kelimeyi label2'ye yazdırıyorum.
            kelime = "";
            for (int i = 0; i < secim.Length; i++)// Tahmin etmemiz gereken kelimenin harf uzunluğu kadar "_" işaretini yazdırdım.
            {
                kelime += " _ ";
            }
            label1.Text = kelime;
        }

        private void buttonDene_Click(object sender, EventArgs e)
        {
            //1.Kelime
            if (secim == "BEN")
            {
                string kelime = "BEN";
                textBox1.Text = textBox1.Text.ToUpper();

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Harf Girin");
                }
                if (textBox1.Text == "BEN".ToString())
                {
                    MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                    label3.Text = "_";
                    label4.Text = "_";
                    label5.Text = "_";
                    textBox1.Text = String.Empty;

                }
                else
                {
                    if (textBox1.Text == kelime[0].ToString())
                    {
                        label3.Text = "B";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[1].ToString())
                        {
                            label4.Text = "E";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[2].ToString())
                            {
                                label5.Text = "N";
                            }
                            else
                            {
                                hak++;
                                if (hak == 1)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                }
                                else if (hak == 2)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = true;
                                    MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                }
                                else if (hak == 3)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = true;
                                    MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                }
                                else if (hak == 4)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = true;
                                    MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                }
                                else if (hak == 5)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = false;
                                    pictureBox6.Visible = true;
                                    MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                }
                                else if (hak == 6)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = false;
                                    pictureBox6.Visible = false;
                                    pictureBox7.Visible = true;
                                    buttonBasla.Enabled = true;
                                    textBox1.Enabled = true;
                                    MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                    MessageBox.Show("BEN", "Cevap");
                                    label3.Text = "_";
                                    label4.Text = "_";
                                    label5.Text = "_";

                                    textBox1.Text = String.Empty;
                                }
                            }
                        }
                    }
                }
                if (label3.Text == "B")
                {
                    textBox1.Clear();
                    if (label4.Text == "E")
                    {
                        textBox1.Clear();
                        if (label5.Text == "N")
                        {
                            textBox1.Clear();
                            buttonBasla.Enabled = true;
                            textBox1.Enabled = true;
                            MessageBox.Show("Tebrikler Kazandınız!");
                            label3.Text = "_";
                            label4.Text = "_";
                            label5.Text = "_";
                            textBox1.Text = String.Empty;

                        }
                    }
                }

            }
            //2. Kelime
            if (secim == "SEN")
            {
                string kelime = "SEN";
                textBox1.Text = textBox1.Text.ToUpper();

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Lütfen Harf Girin");
                }
                if (textBox1.Text == "BEN".ToString())
                {
                    MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                    label3.Text = "_";
                    label4.Text = "_";
                    label5.Text = "_";
                    textBox1.Text = String.Empty;

                }
                else
                {
                    if (textBox1.Text == kelime[0].ToString())
                    {
                        label3.Text = "S";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[1].ToString())
                        {
                            label4.Text = "E";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[2].ToString())
                            {
                                label5.Text = "N";
                            }
                            else
                            {
                                hak++;
                                if (hak == 1)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = true;
                                    MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                }
                                else if (hak == 2)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = true;
                                    MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                }
                                else if (hak == 3)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = true;
                                    MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                }
                                else if (hak == 4)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = true;
                                    MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                }
                                else if (hak == 5)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = false;
                                    pictureBox6.Visible = true;
                                    MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                }
                                else if (hak == 6)
                                {
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    pictureBox3.Visible = false;
                                    pictureBox4.Visible = false;
                                    pictureBox5.Visible = false;
                                    pictureBox6.Visible = false;
                                    pictureBox7.Visible = true;
                                    buttonBasla.Enabled = true;
                                    textBox1.Enabled = true;
                                    MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                    MessageBox.Show("SEN", "Cevap");
                                    label3.Text = "_";
                                    label4.Text = "_";
                                    label5.Text = "_";

                                    textBox1.Text = String.Empty;
                                }
                            }
                        }
                    }
                }
                if (label3.Text == "S")
                {
                    textBox1.Clear();
                    if (label4.Text == "E")
                    {
                        textBox1.Clear();
                        if (label5.Text == "N")
                        {
                            textBox1.Clear();
                            buttonBasla.Enabled = true;
                            textBox1.Enabled = true;
                            MessageBox.Show("Tebrikler Kazandınız!");
                            label3.Text = "_";
                            label4.Text = "_";
                            label5.Text = "_";
                            textBox1.Text = String.Empty;

                        }
                    }
                }

            }
            //3. Kelime
            if (secim == "VAMPİR")
            {

                {
                    string kelime1 = "VAMPİR";
                    textBox1.Text = textBox1.Text.ToUpper();
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen Harf Girin");
                    }
                    if (textBox1.Text == "VAMPİR".ToString())
                    {
                        MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                        label3.Text = "_";
                        label4.Text = "_";
                        label5.Text = "_";
                        label6.Text = "_";
                        label7.Text = "_";
                        label8.Text = "_";
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (textBox1.Text == kelime1[0].ToString())
                        {
                            label3.Text = "V";
                        }
                        else
                        {
                            if (textBox1.Text == kelime1[1].ToString())
                            {
                                label4.Text = "A";
                            }
                            else
                            {
                                if (textBox1.Text == kelime1[2].ToString())
                                {
                                    label5.Text = "M";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime1[3].ToString())
                                    {
                                        label6.Text = "P";
                                    }
                                    else
                                    {
                                        if (textBox1.Text == kelime1[4].ToString())
                                        {
                                            label7.Text = "İ";
                                        }
                                        else
                                        {
                                            if (textBox1.Text == kelime1[5].ToString())
                                            {
                                                label8.Text = "R";
                                            }
                                            else
                                            {
                                                hak++;
                                                if (hak == 1)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                                }
                                                else if (hak == 2)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = false;
                                                    pictureBox3.Visible = true;
                                                    MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                                }
                                                else if (hak == 3)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = false;
                                                    pictureBox3.Visible = false;
                                                    pictureBox4.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                                }
                                                else if (hak == 4)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = false;
                                                    pictureBox3.Visible = false;
                                                    pictureBox4.Visible = false;
                                                    pictureBox5.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                                }
                                                else if (hak == 5)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = false;
                                                    pictureBox3.Visible = false;
                                                    pictureBox4.Visible = false;
                                                    pictureBox5.Visible = false;
                                                    pictureBox6.Visible = true;
                                                    MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                                }
                                                else if (hak == 6)
                                                {
                                                    pictureBox1.Visible = false;
                                                    pictureBox2.Visible = false;
                                                    pictureBox3.Visible = false;
                                                    pictureBox4.Visible = false;
                                                    pictureBox5.Visible = false;
                                                    pictureBox6.Visible = false;
                                                    pictureBox7.Visible = true;
                                                    buttonBasla.Enabled = true;
                                                    textBox1.Enabled = true;
                                                    MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                                    MessageBox.Show("VAMPİR", "Cevap");
                                                    label3.Text = "_";
                                                    label4.Text = "_";
                                                    label5.Text = "_";
                                                    label6.Text = "_";
                                                    label7.Text = "_";
                                                    label8.Text = "_";
                                                    textBox1.Text = String.Empty;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (label3.Text == "V")
                    {
                        textBox1.Clear();
                        if (label4.Text == "A")
                        {
                            textBox1.Clear();
                            if (label5.Text == "M")
                            {
                                textBox1.Clear();
                                if (label6.Text == "P")
                                {
                                    textBox1.Clear();
                                    if (label7.Text == "İ")
                                    {
                                        textBox1.Clear();
                                        if (label8.Text == "R")
                                        {
                                            textBox1.Clear();
                                            buttonBasla.Enabled = true;
                                            textBox1.Enabled = true;
                                            MessageBox.Show("Tebrikler Kazandınız!");
                                            label3.Text = "_";
                                            label4.Text = "_";
                                            label5.Text = "_";
                                            label6.Text = "_";
                                            label7.Text = "_";
                                            label8.Text = "_";
                                            textBox1.Text = String.Empty;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //4. kelime 
            if (secim == "DİFRANSİYEL")

            {

                {
                    string kelime1 = "DİFRANSİYEL";
                    textBox1.Text = textBox1.Text.ToUpper();
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen Harf Girin");
                    }
                    if (textBox1.Text == "DİFRANSİYEL".ToString())
                    {
                        MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                        label3.Text = "_";
                        label4.Text = "_";
                        label5.Text = "_";
                        label6.Text = "_";
                        label7.Text = "_";
                        label8.Text = "_";
                        label9.Text = "_";
                        label10.Text = "_";
                        label11.Text = "_";
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (textBox1.Text == kelime1[0].ToString())
                        {
                            label3.Text = "D";
                        }
                        else
                        {
                            if (textBox1.Text == kelime1[1].ToString())
                            {
                                label4.Text = "İ";
                                label10.Text = "İ";
                            }
                            else
                            {
                                if (textBox1.Text == kelime1[2].ToString())
                                {
                                    label5.Text = "F";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime1[3].ToString())
                                    {
                                        label6.Text = "R";
                                    }
                                    else
                                    {
                                        if (textBox1.Text == kelime1[4].ToString())
                                        {
                                            label7.Text = "A";
                                        }
                                        else
                                        {
                                            if (textBox1.Text == kelime1[5].ToString())
                                            {
                                                label8.Text = "N";
                                            }
                                            else
                                            {
                                                if (textBox1.Text == kelime1[6].ToString())
                                                {
                                                    label9.Text = "S";
                                                }
                                                else
                                                {

                                                    if (textBox1.Text == kelime1[8].ToString())
                                                    {
                                                        label11.Text = "Y";
                                                    }
                                                    else
                                                    {
                                                        if (textBox1.Text == kelime1[9].ToString())
                                                        {
                                                            label12.Text = "E";
                                                        }
                                                        else
                                                        {
                                                            if (textBox1.Text == kelime1[10].ToString())
                                                            {
                                                                label13.Text = "L";
                                                            }
                                                            else
                                                            {
                                                                hak++;
                                                                if (hak == 1)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = true;
                                                                    MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                                                }
                                                                else if (hak == 2)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = false;
                                                                    pictureBox3.Visible = true;
                                                                    MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                                                }
                                                                else if (hak == 3)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = false;
                                                                    pictureBox3.Visible = false;
                                                                    pictureBox4.Visible = true;
                                                                    MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                                                }
                                                                else if (hak == 4)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = false;
                                                                    pictureBox3.Visible = false;
                                                                    pictureBox4.Visible = false;
                                                                    pictureBox5.Visible = true;
                                                                    MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                                                }
                                                                else if (hak == 5)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = false;
                                                                    pictureBox3.Visible = false;
                                                                    pictureBox4.Visible = false;
                                                                    pictureBox5.Visible = false;
                                                                    pictureBox6.Visible = true;
                                                                    MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                                                }
                                                                else if (hak == 6)
                                                                {
                                                                    pictureBox1.Visible = false;
                                                                    pictureBox2.Visible = false;
                                                                    pictureBox3.Visible = false;
                                                                    pictureBox4.Visible = false;
                                                                    pictureBox5.Visible = false;
                                                                    pictureBox6.Visible = false;
                                                                    pictureBox7.Visible = true;
                                                                    buttonBasla.Enabled = true;
                                                                    textBox1.Enabled = true;
                                                                    MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                                                    MessageBox.Show("DİFRANSİYEL", "Cevap");
                                                                    label3.Text = "_";
                                                                    label4.Text = "_";
                                                                    label5.Text = "_";
                                                                    label6.Text = "_";
                                                                    label7.Text = "_";
                                                                    label8.Text = "_";
                                                                    label9.Text = "_";
                                                                    label10.Text = "_";
                                                                    label11.Text = "_";
                                                                    label12.Text = "_";
                                                                    label13.Text = "_";
                                                                    textBox1.Text = String.Empty;
                                                                }
                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                                if (label3.Text == "D")
                                {
                                    textBox1.Clear();
                                    if (label4.Text == "İ")
                                    {
                                        textBox1.Clear();
                                        if (label5.Text == "F")
                                        {
                                            textBox1.Clear();
                                            if (label6.Text == "R")
                                            {
                                                textBox1.Clear();
                                                if (label7.Text == "A")
                                                {
                                                    textBox1.Clear();
                                                    if (label8.Text == "N")
                                                    {
                                                        textBox1.Clear();
                                                        if (label9.Text == "S")
                                                        {
                                                            textBox1.Clear();
                                                            if (label10.Text == "İ")
                                                            {
                                                                textBox1.Clear();
                                                                if (label11.Text == "Y")
                                                                {
                                                                    textBox1.Clear();
                                                                    if (label12.Text == "E")
                                                                    {
                                                                        textBox1.Clear();
                                                                        if (label13.Text == "L")
                                                                        {
                                                                            textBox1.Clear();
                                                                            buttonBasla.Enabled = true;
                                                                            textBox1.Enabled = true;
                                                                            MessageBox.Show("Tebrikler Kazandınız!");
                                                                            label3.Text = "_";
                                                                            label4.Text = "_";
                                                                            label5.Text = "_";
                                                                            label6.Text = "_";
                                                                            label7.Text = "_";
                                                                            label8.Text = "_";
                                                                            label9.Text = "_";
                                                                            label10.Text = "_";
                                                                            label11.Text = "_";
                                                                            label12.Text = "_";
                                                                            label13.Text = "_";
                                                                            textBox1.Text = String.Empty;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }

            //5.KELİME
            if (secim == "ARABA")

            {
                {

                    string kelime1 = "ARABA";
                    textBox1.Text = textBox1.Text.ToUpper();
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen Harf Giriniz");
                    }
                    if (textBox1.Text == "ARABA".ToString())
                    {
                        MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                        label3.Text = "_";
                        label4.Text = "_";
                        label5.Text = "_";
                        label6.Text = "_";
                        label7.Text = "_";
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (textBox1.Text == kelime1[0].ToString())
                        {
                            label3.Text = "A";
                            label5.Text = "A";
                            label7.Text = "A";
                        }
                        else
                        {
                            if (textBox1.Text == kelime1[1].ToString())
                            {
                                label4.Text = "R";
                            }
                            else
                            {

                                if (textBox1.Text == kelime1[3].ToString())
                                {
                                    label6.Text = "B";
                                }
                                else
                                {

                                    hak++;
                                    if (hak == 1)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = true;
                                        MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                    }
                                    else if (hak == 2)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = true;
                                        MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                    }
                                    else if (hak == 3)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = true;
                                        MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                    }
                                    else if (hak == 4)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = true;
                                        MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                    }
                                    else if (hak == 5)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = false;
                                        pictureBox6.Visible = true;
                                        MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                    }
                                    else if (hak == 6)
                                    {
                                        pictureBox1.Visible = false;
                                        pictureBox2.Visible = false;
                                        pictureBox3.Visible = false;
                                        pictureBox4.Visible = false;
                                        pictureBox5.Visible = false;
                                        pictureBox6.Visible = false;
                                        pictureBox7.Visible = true;
                                        buttonBasla.Enabled = true;
                                        textBox1.Enabled = true;
                                        MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                        MessageBox.Show("ARABA", "Cevap");
                                        label3.Text = "_";
                                        label4.Text = "_";
                                        label5.Text = "_";
                                        label6.Text = "_";
                                        label7.Text = "_";
                                        textBox1.Text = String.Empty;
                                    }
                                }
                            }

                        }
                    }
                }

                if (label3.Text == "A")
                {
                    textBox1.Clear();
                    if (label4.Text == "R")
                    {
                        textBox1.Clear();
                        if (label5.Text == "A")
                        {
                            textBox1.Clear();
                            if (label6.Text == "B")
                            {
                                textBox1.Clear();
                                if (label7.Text == "A")
                                {

                                    textBox1.Clear();
                                    buttonBasla .Enabled = true;
                                    textBox1.Enabled = true;
                                    MessageBox.Show("Tebrikler Kazandınız!");
                                    label3.Text = "_";
                                    label4.Text = "_";
                                    label5.Text = "_";
                                    label6.Text = "_";
                                    label7.Text = "_";
                                    textBox1.Text = String.Empty;
                                }
                            }
                        }
                    }
                }//6.Kelime
            }
            if (secim == "FORM")

            {
                {

                    string kelime1 = "FORM";
                    textBox1.Text = textBox1.Text.ToUpper();
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen Harf Giriniz");
                    }
                    if (textBox1.Text == "FORM".ToString())
                    {
                        MessageBox.Show("TEBRİKLER DOĞRU BİLDİNİZ");
                        label3.Text = "_";
                        label4.Text = "_";
                        label5.Text = "_";
                        label6.Text = "_";
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (textBox1.Text == kelime1[0].ToString())
                        {
                            label3.Text = "F";
                        }
                        else
                        {
                            if (textBox1.Text == kelime1[1].ToString())
                            {
                                label4.Text = "O";
                            }
                            else
                            {

                                if (textBox1.Text == kelime1[2].ToString())
                                {
                                    label5.Text = "R";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime1[3].ToString())
                                    {
                                        label6.Text = "M";
                                    }
                                    else
                                    {

                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = true;
                                            MessageBox.Show("KALAN HAK : 5", "Yanlış Harf");
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = true;
                                            MessageBox.Show("KALAN HAK :4", "Yanlış Harf");
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            pictureBox4.Visible = true;
                                            MessageBox.Show("KALAN HAK : 3", "Yanlış Harf");
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            pictureBox4.Visible = false;
                                            pictureBox5.Visible = true;
                                            MessageBox.Show("KALAN HAK : 2", "Yanlış Harf");
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            pictureBox4.Visible = false;
                                            pictureBox5.Visible = false;
                                            pictureBox6.Visible = true;
                                            MessageBox.Show("KALAN HAK : 1", "Yanlış Harf");
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.Visible = false;
                                            pictureBox2.Visible = false;
                                            pictureBox3.Visible = false;
                                            pictureBox4.Visible = false;
                                            pictureBox5.Visible = false;
                                            pictureBox6.Visible = false;
                                            pictureBox7.Visible = true;
                                            buttonBasla.Enabled = true;
                                            textBox1.Enabled = true;
                                            MessageBox.Show("KAYBETTİNİZ!", "Kaybettiniz!");
                                            MessageBox.Show("FORM", "Cevap");
                                            label3.Text = "_";
                                            label4.Text = "_";
                                            label5.Text = "_";
                                            label6.Text = "_";
                                            textBox1.Text = String.Empty;
                                        }
                                    }
                                }

                            }
                        }
                    }

                    if (label3.Text == "F")
                    {
                        textBox1.Clear();
                        if (label4.Text == "O")
                        {
                            textBox1.Clear();
                            if (label5.Text == "R")
                            {
                                textBox1.Clear();
                                if (label6.Text == "M")
                                {


                                    textBox1.Clear();
                                    buttonBasla.Enabled = true;
                                    textBox1.Enabled = true;
                                    MessageBox.Show("Tebrikler Kazandınız!");
                                    label3.Text = "_";
                                    label4.Text = "_";
                                    label5.Text = "_";
                                    label6.Text = "_";
                                    textBox1.Text = String.Empty;
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}