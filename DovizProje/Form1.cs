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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;


namespace DovizProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=AhmetLaptop\\SQLEXPRESS;Initial Catalog=Doviz;Integrated Security=True;");

        private static double FiyatDonusum(string fiyat)
        {
            String FiyatT = fiyat.Split('.')[0];
            String FiyatO = fiyat.Split('.')[1];
            //Console.WriteLine("T: " + alisFiyatiT + " O: " + alisFiyatiO);
            double FiyatD = Double.Parse(FiyatT);
            double FiyatDO = Double.Parse(FiyatO);
            FiyatDO = 0.0001 * FiyatDO;
            FiyatD += FiyatDO;
            return FiyatD;
        }

        private void TrToUsdDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
        }

        private void UsdToTrDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='USD']/ForexBuying";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
        }

        private void TrToEurDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
        }

        private void EurToTrDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='EUR']/ForexBuying";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
        }

        private void UsdToEurDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komutUsd = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String komutEur = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kurUsd = kurCekme.KurCek(komutUsd);
            String kurEur = kurCekme.KurCek(komutEur);
            double kurUsdD = FiyatDonusum(kurUsd);
            double kurEurD = FiyatDonusum(kurEur);
            double kurD = kurEurD / kurUsdD;
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();

        }

        private void EurToUsdDonusum()
        {
            KurCekme kurCekme = new KurCekme();
            String komutUsd = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String komutEur = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kurUsd = kurCekme.KurCek(komutUsd);
            String kurEur = kurCekme.KurCek(komutEur);
            double kurUsdD = FiyatDonusum(kurUsd);
            double kurEurD = FiyatDonusum(kurEur);
            double kurD = kurEurD / kurUsdD;
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();

        }

        private void TrToUsdIslemTamamla()
        {
            
            String usd = "USD";
            String tr = "TRY";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);

            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);

            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonTryMiktar = mevcutMiktar - satilanMiktar;

            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonUsdMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                con.Open();

                //USD Hesabı Güncelleme
                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_UsdGuncelleme";

                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = usd;
                cmd2.Parameters["@pMiktar"].Value = sonUsdMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();



            }

            //TRY Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_TryGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = tr;
            cmd.Parameters["@pMiktar"].Value = sonTryMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
            con.Close();
            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            TrToUsdGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, tr, usd, satilanMiktar, alinacakDovizMiktari);

        }

        private void UsdToTrIslemTamamla()
        {
            String usd = "USD";
            String tr = "TRY";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='USD']/ForexBuying";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);

            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);

            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonUsdMiktar = mevcutMiktar - satilanMiktar;


            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonTryMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                // TRY Hesabı Güncelleme
                con.Open();

                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_TryGuncelleme";



                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = tr;
                cmd2.Parameters["@pMiktar"].Value = sonTryMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();

            }

            //USD Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UsdGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = usd;
            cmd.Parameters["@pMiktar"].Value = sonUsdMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            con.Close();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            UsdToTrGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, usd, tr, satilanMiktar, alinacakDovizMiktari);

        }
        private void TrToEurIslemTamamla()
        {

            String eur = "EUR";
            String tr = "TRY";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);

            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);

            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonTryMiktar = mevcutMiktar - satilanMiktar;

            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonEurMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                con.Open();

                //USD Hesabı Güncelleme
                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_DovizGuncelleme";

                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = eur;
                cmd2.Parameters["@pMiktar"].Value = sonEurMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();

            }

            //TRY Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_TryGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = tr;
            cmd.Parameters["@pMiktar"].Value = sonTryMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
            con.Close();
            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            TrToEurGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, tr, eur, satilanMiktar, alinacakDovizMiktari);


        }
        
        private void EurToTrIslemTamamla()
        {
            String eur = "EUR";
            String tr = "TRY";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komut = "Tarih_Date/Currency[@Kod='EUR']/ForexBuying";
            String kur = kurCekme.KurCek(komut);
            double kurD = FiyatDonusum(kur);

            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonEurMiktar = mevcutMiktar - satilanMiktar;


            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonTryMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                // TRY Hesabı Güncelleme
                con.Open();

                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_TryGuncelleme";



                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = tr;
                cmd2.Parameters["@pMiktar"].Value = sonTryMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();

            }

            //USD Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DovizGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = eur;
            cmd.Parameters["@pMiktar"].Value = sonEurMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            con.Close();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            EurToTrGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, eur, tr, satilanMiktar, alinacakDovizMiktari);


        }
        
        private void UsdToEuroIslemTamamla()
        {

            String usd = "USD";
            String eur = "EUR";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komutUsd = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String komutEur = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kurUsd = kurCekme.KurCek(komutUsd);
            String kurEur = kurCekme.KurCek(komutEur);
            double kurUsdD = FiyatDonusum(kurUsd);
            double kurEurD = FiyatDonusum(kurEur);
            double kurD = kurEurD / kurUsdD;



            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);

            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar / kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonUsdMiktar = mevcutMiktar - satilanMiktar;

            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonEurMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                con.Open();

                //EUR Hesabı Güncelleme
                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_DovizGuncelleme";

                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = eur;
                cmd2.Parameters["@pMiktar"].Value = sonEurMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();

            }

            //USD Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UsdGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = usd;
            cmd.Parameters["@pMiktar"].Value = sonUsdMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
            con.Close();
            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            UsdToEurGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, usd, eur, satilanMiktar, alinacakDovizMiktari);


        }

        private void EuroToUsdIslemTamamla()
        {
            String usd = "USD";
            String eur = "EUR";

            //Kur Çekme
            KurCekme kurCekme = new KurCekme();
            String komutUsd = "Tarih_Date/Currency[@Kod='USD']/ForexSelling";
            String komutEur = "Tarih_Date/Currency[@Kod='EUR']/ForexSelling";
            String kurUsd = kurCekme.KurCek(komutUsd);
            String kurEur = kurCekme.KurCek(komutEur);
            double kurUsdD = FiyatDonusum(kurUsd);
            double kurEurD = FiyatDonusum(kurEur);
            double kurD = kurEurD / kurUsdD;

            //Döviz Türlerini Alma
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();

            //Miktarları alma
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            double satilanMiktar = Double.Parse(satilacakDovizMiktar.Text);

            //Dönüşüm
            double alinacakDovizMiktari = satilanMiktar * kurD;
            alacaginizDovizLbl.Text = alinacakDovizMiktari.ToString();
            double sonEurMiktar = mevcutMiktar - satilanMiktar;


            string gonderilenMusteriNo = Interaction.InputBox("Gönderilecek Hesap Numarasını Giriniz", "Gönderilecek Hesap Numarasını Giriniz", "");
            int secilenMusteri = Convert.ToInt32(gonderilenMusteriNo);
            String gelenMiktar;
            int mevcutMusteriNo = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();


            //Gönderilecek hesabı seçip bakiyesini alma
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Miktar FROM Musteriler WHERE MusteriNo=@MusteriNo", con);
            cmd3.Parameters.AddWithValue("MusteriNo", secilenMusteri);
            SqlDataReader reader1;
            reader1 = cmd3.ExecuteReader();


            if (reader1.Read())
            {
                gelenMiktar = reader1["Miktar"].ToString();
                double gMiktar = Double.Parse(gelenMiktar);
                double sonUsdMiktar = gMiktar + alinacakDovizMiktari;
                con.Close();

                // Usd Hesabı Güncelleme
                con.Open();

                cmd2.Connection = con;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "sp_UsdGuncelleme";



                cmd2.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
                cmd2.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
                cmd2.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

                cmd2.Parameters["@pMusteriAdi"].Value = mAdi;
                cmd2.Parameters["@pDovizTuru"].Value = usd;
                cmd2.Parameters["@pMiktar"].Value = sonUsdMiktar;

                cmd2.ExecuteNonQuery();

                MessageBox.Show("İşlem Tamamlandı.");

                this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
                con.Close();

            }

            //EUR Hesabı Güncelleme

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DovizGuncelleme";

            cmd.Parameters.Add("@pMusteriAdi", SqlDbType.VarChar, 60);
            cmd.Parameters.Add("@pDovizTuru", SqlDbType.Char, 5);
            cmd.Parameters.Add("@pMiktar", SqlDbType.VarChar, 60);

            cmd.Parameters["@pMusteriAdi"].Value = mAdi;
            cmd.Parameters["@pDovizTuru"].Value = eur;
            cmd.Parameters["@pMiktar"].Value = sonEurMiktar;

            cmd.ExecuteNonQuery();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            con.Close();

            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            EurToUsdGozlemEkle(mevcutMusteriNo, gonderilenMusteriNo, eur, usd, satilanMiktar, alinacakDovizMiktari);

        }

        private void TrToUsdGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string tr, string usd, double satilanMiktar, double alinacakDovizMiktari)
        {
            //TRY satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", tr);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //USD alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", usd);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void UsdToTrGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string usd, string tr, double satilanMiktar, double alinacakDovizMiktari)
        {
            //USD satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", usd);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //TRY alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", tr);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void TrToEurGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string tr, string eur, double satilanMiktar, double alinacakDovizMiktari)
        {
            //TRY satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", tr);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //EUR alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", eur);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        private void EurToTrGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string eur, string tr, double satilanMiktar, double alinacakDovizMiktari)
        {
            //Eur satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", eur);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //TRY alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", tr);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        private void UsdToEurGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string usd, string eur, double satilanMiktar, double alinacakDovizMiktari)
        {
            //Usd satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", usd);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //EUR alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", eur);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        private void EurToUsdGozlemEkle(int mevcutMusteriNo, string gonderilenMusteriNo, string eur, string usd, double satilanMiktar, double alinacakDovizMiktari)
        {
            //Eur satış gözlemi ekleme
            con.Open();
            String komut = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd = new SqlCommand(komut, con);
            cmd.Parameters.AddWithValue("@MusteriNo", mevcutMusteriNo);
            cmd.Parameters.AddWithValue("@DovizTuru", eur);
            cmd.Parameters.AddWithValue("@IslemTuru", "S");
            cmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
            cmd.ExecuteNonQuery();
            con.Close();

            //usd alış gözlemi ekleme
            con.Open();
            String komut2 = "INSERT INTO GozlemEkrani (MusteriNo, DovizTuru, IslemTuru, Miktar, Tarih) VALUES (@MusteriNo, @DovizTuru, @IslemTuru, @Miktar, GETDATE())";
            SqlCommand cmd2 = new SqlCommand(komut2, con);
            cmd2.Parameters.AddWithValue("@MusteriNo", gonderilenMusteriNo);
            cmd2.Parameters.AddWithValue("@DovizTuru", usd);
            cmd2.Parameters.AddWithValue("@IslemTuru", "A");
            cmd2.Parameters.AddWithValue("@Miktar", alinacakDovizMiktari);
            cmd2.ExecuteNonQuery();
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dovizDataSet3.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);

            //this.musterilerTableAdapter.Fill(this.dovizDataSet.Musteriler);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mNoGelenLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mAdGelenLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dTuruGelenLbl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            miktarGelenLbl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void veriYenile_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Listeleme";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.musterilerTableAdapter.Fill(this.dovizDataSet3.Musteriler);
            con.Close();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            String usd = "USD";
            String tr = "TRY";
            String eur = "EUR";
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();



            if (hesaptakiDovizTuru.Equals(tr) && dovizSecimi.Equals(usd))
            {
                TrToUsdDonusum();                
            }
            if (hesaptakiDovizTuru.Equals(usd) && dovizSecimi.Equals(tr))
            {
                UsdToTrDonusum();
            }
            if (hesaptakiDovizTuru.Equals(tr) && dovizSecimi.Equals(eur)) 
            {
                TrToEurDonusum();
            }
            if (hesaptakiDovizTuru.Equals(eur) && dovizSecimi.Equals(tr))
            {
                EurToTrDonusum();
            }
            if (hesaptakiDovizTuru.Equals(usd) && dovizSecimi.Equals(eur))
            {
                UsdToEurDonusum();
            }
            if (hesaptakiDovizTuru.Equals(eur) && dovizSecimi.Equals(usd))
            {
                EurToUsdDonusum();
            }


        }

        

        private void islemiTamamlaBtn_Click(object sender, EventArgs e)
        {
            String usd = "USD";
            String tr = "TRY";
            String eur = "EUR";
            String dovizSecimi = cBoxDovizTuru.Text;
            dovizSecimi = dovizSecimi.Trim();
            String hesaptakiDovizTuru = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            hesaptakiDovizTuru = hesaptakiDovizTuru.Trim();
            double mevcutMiktar = Double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            String mAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            if (hesaptakiDovizTuru.Equals(tr) && dovizSecimi.Equals(usd))
            {
                TrToUsdIslemTamamla();               
            }

            if (hesaptakiDovizTuru.Equals(usd) && dovizSecimi.Equals(tr))
            {
                UsdToTrIslemTamamla();
            }
            if (hesaptakiDovizTuru.Equals(tr) && dovizSecimi.Equals(eur))
            {
                TrToEurIslemTamamla();
            }
            if (hesaptakiDovizTuru.Equals(eur) && dovizSecimi.Equals(tr))
            {
                EurToTrIslemTamamla();
            }
            if (hesaptakiDovizTuru.Equals(usd) && dovizSecimi.Equals(eur))
            {
                UsdToEuroIslemTamamla();
            }
            if (hesaptakiDovizTuru.Equals(eur) && dovizSecimi.Equals(usd))
            {
                EuroToUsdIslemTamamla();
            }

        }

        private void gozlemEkraniBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
