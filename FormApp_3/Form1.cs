using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kars_Click(object sender, EventArgs e)
        {
            int sonuc = string.Compare(txt_1.Text, txt_2.Text, false);

            if (sonuc==1)
            {
                lbl_sonuc.Text = "1.Büyük";
            }
            else if(sonuc==-1)
            {
                lbl_sonuc.Text = "2.Büyük";
            }
            else
            {
                lbl_sonuc.Text = "İki string eşittir.";
            }
        }

    }
}
