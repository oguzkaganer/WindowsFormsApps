using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClick(sender,e);
        }

        private void buttonClick(object sender,EventArgs e)
        {
            Control groupBox = ((Button)sender).Parent;
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox && item2.Parent == groupBox)
                        {
                            (item2 as TextBox).Clear();
                        }
                    }
                }
            }
        }
    }
}
