using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar = Convert.ToInt32(txt_kisaKenar.Text);
            int uzunKenar = Convert.ToInt32(txt_uzunKenar.Text);

            //Button button1 = new Button();
            //button1.Width = kisaKenar*37;
            //button1.Height = uzunKenar*37;
            //button1.Left = 10;
            //button1.Top = 10;


            for (int i = 0; i < uzunKenar; i++)
            {
                this.Width = i * 37;
                this.Height = i * 37;
                System.Threading.Thread.Sleep(100);
            }


            //this.Controls.Add(button1);

        }
    }
}
