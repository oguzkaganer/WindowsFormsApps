using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        void gridDoldur()
        {
            sqlConnection = new SqlConnection("Data Source=403-08;Initial Catalog=dbLogin;User ID=sa;Password=1234");
            sqlDataAdapter = new SqlDataAdapter("Select * From tblUser", sqlConnection);
            dataSet = new DataSet();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataSet, "tblUser");
            dataGridView1.DataSource = dataSet.Tables["tblUser"];
            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "insert into tblUser(id,usr,pwd,name) values ('" + txt_id.Text + "','" + txt_user.Text + "','" + txt_password.Text + "','" + txt_name.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            gridDoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "update tblUser set usr='" + txt_user.Text + "',pwd='" + txt_password.Text + "',name='" + txt_name.Text + "' where id=" + txt_id.Text + "";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            gridDoldur();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            sqlCommand = new SqlCommand();
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "delete from tblUser where id=" + txt_id.Text;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            gridDoldur();
        }
    }
}
