using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_sayi1.Text);
            int b = Convert.ToInt32(txt_sayi2.Text);

            int toplam = a + b;

            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_cikart_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_sayi1.Text);
            int b = Convert.ToInt32(txt_sayi2.Text);

            int toplam = a - b;

            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_sayi1.Text);
            int b = Convert.ToInt32(txt_sayi2.Text);

            int toplam = a * b;

            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txt_sayi1.Text);
                int b = Convert.ToInt32(txt_sayi2.Text);

                int toplam = a / b;

                lbl_sonuc.Text = toplam.ToString();
            }
            catch (Exception)
            {
                lbl_sonuc.Text = "İşlem Başarısız";
            }
            
        }

        private void btn_exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
