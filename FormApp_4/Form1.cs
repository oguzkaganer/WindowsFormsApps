using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_mavi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void rb_kirmizi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void rb_yesil_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void rb_mor_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
    }
}
