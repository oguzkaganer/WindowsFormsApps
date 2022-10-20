using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] CalculateAge(DateTime dateNow, DateTime birthDate)
        {
            int day1, month1, year1;
            int day2, month2, year2;
            int diffYear, diffMonth, diffDay;
            diffYear = 0; diffMonth = 0; diffDay = 0;
            year1 = birthDate.Year;
            month1 = birthDate.Month;
            day1 = birthDate.Day;
            day2 = dateNow.Day;
            month2 = dateNow.Month;
            year2 = dateNow.Year;
            if (day2 < day1)
            {
                day2 += DateTime.DaysInMonth(year2, month2);
                diffDay = day2 - day1;
                month2--;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            else
            {
                diffDay = day2 - day1;
                if (month2 < month1)
                {
                    month2 += 12;
                    year2--;
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
                else
                {
                    diffMonth = month2 - month1;
                    diffYear = year2 - year1;
                }
            }
            int[] sonuc = new int[3];
            sonuc[0] = diffYear;
            sonuc[1] = diffMonth;
            sonuc[2] = diffDay;
            return sonuc;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbl_dogumTarihi.Text = DateTime.Now.ToShortDateString();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int[] result = CalculateAge(DateTime.Now, Convert.ToDateTime(dateTimePicker1.Text));
            lbl_yas.Text = result[0].ToString() + " Yıl " + result[1].ToString() + " Ay " + result[2].ToString() + " Gün ";
        }
    }
}
