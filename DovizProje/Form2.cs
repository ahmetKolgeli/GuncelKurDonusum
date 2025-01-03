using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DovizProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=AhmetLaptop\\SQLEXPRESS;Initial Catalog=Doviz;Integrated Security=True;");


        private void islemSorgula_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=AhmetLaptop\\SQLEXPRESS;Initial Catalog=Doviz;Integrated Security=True;");


            if (musteriNoTextBox.Text == ("") && dovizTuruTextBox.Text == ("") && islemTuruTextBox.Text == (""))
            {
                HepsiniGetir();
            }
            else if (dovizTuruTextBox.Text == ("") && islemTuruTextBox.Text == (""))
            {
                int musteriNo = Convert.ToInt32(musteriNoTextBox.Text.ToString());
                MusteriNoyaGoreGetir(musteriNo);
            }
            else if (musteriNoTextBox.Text == ("") && islemTuruTextBox.Text == (""))
            {
                String dovizTuru = dovizTuruTextBox.Text.ToString();
                dovizTuru = dovizTuru.Trim();
                DovizTuruneGoreGetir(dovizTuru);
            }

            else if (dovizTuruTextBox.Text == ("") && musteriNoTextBox.Text == (""))
            {
                String islemTuru = islemTuruTextBox.Text.ToString();
                islemTuru = islemTuru.Trim();
                IslemTuruneGoreGetir(islemTuru);
            }
            else if (islemTuruTextBox.Text == (""))
            {
                int musteriNo = Convert.ToInt32(musteriNoTextBox.Text.ToString());
                String dovizTuru = dovizTuruTextBox.Text.ToString();
                dovizTuru = dovizTuru.Trim();
                MusteriNoVeDovizeGoreGetir(musteriNo, dovizTuru);
            }
            else if (dovizTuruTextBox.Text == (""))
            {
                int musteriNo = Convert.ToInt32(musteriNoTextBox.Text.ToString());
                String islemTuru = islemTuruTextBox.Text.ToString();
                islemTuru = islemTuru.Trim();
                MusteriNoVeIslemTuruneGoreGetir(musteriNo, islemTuru);

            }
            else if (musteriNoTextBox.Text == (""))
            {
                // Döviz Türü ve işlem Türüne göre
                String dovizTuru = dovizTuruTextBox.Text.ToString();
                dovizTuru = dovizTuru.Trim();
                String islemTuru = islemTuruTextBox.Text.ToString();
                islemTuru = islemTuru.Trim();
                DovizTuruVeIslemTuruneGoreGetir(dovizTuru, islemTuru);

            }

            else
            { //Tam Sorgulama
                int musteriNo = Convert.ToInt32(musteriNoTextBox.Text.ToString());
                String dovizTuru = dovizTuruTextBox.Text.ToString();
                dovizTuru = dovizTuru.Trim();
                String islemTuru = islemTuruTextBox.Text.ToString();
                islemTuru = islemTuru.Trim();
                TamSorgulama(musteriNo, dovizTuru, islemTuru);


            }



        }

        private void TamSorgulama(int musteriNo, string dovizTuru, string islemTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_TamSorgulama";
            cmd.Parameters.Add("@pMusteriNo", SqlDbType.Int);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pIslemTuru", SqlDbType.Char, 5);

            cmd.Parameters["@pMusteriNo"].Value = musteriNo;
            cmd.Parameters["@pDovizTuru"].Value = dovizTuru;
            cmd.Parameters["@pIslemTuru"].Value = islemTuru;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void DovizTuruVeIslemTuruneGoreGetir(string dovizTuru, string islemTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DovizTuruVeIslemTuruneGoreGetir";
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pIslemTuru", SqlDbType.Char, 5);

            cmd.Parameters["@pDovizTuru"].Value = dovizTuru;
            cmd.Parameters["@pIslemTuru"].Value = islemTuru;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void MusteriNoVeIslemTuruneGoreGetir(int musteriNo, string islemTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_MusteriNoVeIslemTuruneGoreGetir";
            cmd.Parameters.Add("@pMusteriNo", SqlDbType.Int);
            cmd.Parameters.Add("@pIslemTuru", SqlDbType.Char, 5);

            cmd.Parameters["@pMusteriNo"].Value = musteriNo;
            cmd.Parameters["@pIslemTuru"].Value = islemTuru;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void MusteriNoVeDovizeGoreGetir(int musteriNo, string dovizTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_MusteriNoVeDovizeGoreGetir";
            cmd.Parameters.Add("@pMusteriNo", SqlDbType.Int);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);

            cmd.Parameters["@pMusteriNo"].Value = musteriNo;
            cmd.Parameters["@pDovizTuru"].Value = dovizTuru;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void IslemTuruneGoreGetir(string islemTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_IslemTuruneGoreGetir";
            cmd.Parameters.Add("@pIslemTuru", SqlDbType.Char, 5);
            cmd.Parameters["@pIslemTuru"].Value = islemTuru;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void DovizTuruneGoreGetir(string dovizTuru)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DovizTuruneGoreGetir";
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters["@pDovizTuru"].Value = dovizTuru;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void MusteriNoyaGoreGetir(int musteriNo)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_MusteriNoyaGoregetir";
            cmd.Parameters.Add("@pMusteriNo", SqlDbType.Int);
            cmd.Parameters["@pMusteriNo"].Value = musteriNo;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
            con.Close();
        }

        private void HepsiniGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GozlemEkrani", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gozlemEkraniDataGridView.DataSource = dt;
        }
    }
}
