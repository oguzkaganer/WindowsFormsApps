using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sayi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lbl_ekran.Text == "0" || durum == true)
            {
                lbl_ekran.Text = btn.Text;
                if (durum == true)
                {
                    durum = false;
                }
            }
            else
            {
                lbl_ekran.Text += btn.Text;
            }
        }
        double sonuc = 0;
        bool durum = false;
        private void btn_islem_Click(object sender, EventArgs e)
        {
            if (durum == false)
            {
                durum = true;
                Button btn = sender as Button;
                switch (btn.Text)
                {
                    case "+":
                        sonuc += Convert.ToDouble(lbl_ekran.Text);
                        lbl_ekran.Text = sonuc.ToString();
                        break;
                    case "-":
                        if (sonuc == 0)
                        {
                            sonuc = Convert.ToDouble(lbl_ekran.Text);
                        }
                        else if (sonuc != 0)
                        {
                            sonuc -= Convert.ToDouble(lbl_ekran.Text);
                            lbl_ekran.Text = sonuc.ToString();
                        }
                        break;
                    case "x":
                        if (sonuc == 0)
                        {
                            sonuc = Convert.ToDouble(lbl_ekran.Text);
                        }
                        else if (sonuc != 0)
                        {
                            sonuc *= Convert.ToDouble(lbl_ekran.Text);
                            lbl_ekran.Text = sonuc.ToString();
                        }
                        break;
                    case "/":
                        if (sonuc == 0)
                        {
                            sonuc = Convert.ToDouble(lbl_ekran.Text);
                        }
                        else if (sonuc != 0)
                        {
                            sonuc /= Convert.ToDouble(lbl_ekran.Text);
                            lbl_ekran.Text = sonuc.ToString();
                        }
                        break;
                }
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            sonuc = 0;
            durum = false;
            if (lbl_ekran.Text != "0")
            {
                lbl_ekran.Text = "0";
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lbl_ekran.Text != "0")
            {
                lbl_ekran.Text = lbl_ekran.Text.Remove(lbl_ekran.Text.Length - 1);
                if (lbl_ekran.Text == string.Empty)
                {
                    lbl_ekran.Text = "0";
                }
            }
        }

        private void btn_virgul_Click(object sender, EventArgs e)
        {
            if (lbl_ekran.Text.Contains(",") == false)
            {
                lbl_ekran.Text += ",";
            }
        }
    }
}
