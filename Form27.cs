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
using System.Net;
using System.Net.Mail;
using System.Security;

namespace GASOLINA
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        DataSet daset = new DataSet();
        private void Kayıt_Göster()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void Kayıt_Göster1()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsatis", baglanti);
            adtr.Fill(daset, "akaryakitsatis");
            dataGridView2.DataSource = daset.Tables["akaryakitsatis"];

            baglanti.Close();
        }
        public bool MailGonder(string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("meleksevvalerdogan@ogrenci.beykoz.edu.tr");
            ePosta.To.Add(EPostatxt.Text); //göndereceğimiz mail adresi

            ePosta.Subject = "GASOLINA SİPARİŞ ONAYI"; //mail konusu
            ePosta.Body = "Merhaba  '" + adsoyad + "', siparişiniz onaylanmıştır. ";  //mail içeriği 
            //ePosta.Body = "Şifre:" + sifre;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("meleksevvalerdogan@ogrenci.beykoz.edu.tr", "63.37rMi");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }
        public bool MailGonderme(string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("meleksevvalerdogan@ogrenci.beykoz.edu.tr");
            ePosta.To.Add(EPostatxt.Text); //göndereceğimiz mail adresi

            ePosta.Subject = "GASOLINA SİPARİŞ ONAYLANMAMA DURUMU"; //mail konusu
            ePosta.Body = "Merhaba  '" + adsoyad + "', siparişiniz onaylanamadı. İstasyonumuz geçici bir süre GASOLINA MINIMARKET'te hizmet veremeyecektir. Anlayışınız için teşekkür ederiz. ";  //mail içeriği 
            //ePosta.Body = "Şifre:" + sifre;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("meleksevvalerdogan@ogrenci.beykoz.edu.tr", "63.37rMi");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(ePosta);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }

        string adsoyad;
        private void Form27_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet59.akaryakitsatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.akaryakitsatisTableAdapter.Fill(this.gASOLINADataSet59.akaryakitsatis);
            // TODO: Bu kod satırı 'gASOLINADataSet58.aracahizmet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.aracahizmetTableAdapter.Fill(this.gASOLINADataSet58.aracahizmet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("select * from musteriEkle where eposta='" + EPostatxt.Text + "'");
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    adsoyad = oku["adsoyad"].ToString();

                    label9.Visible = true;
                    label9.ForeColor = Color.Green;
                    label9.Text = "Mail Gönderildi";

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }
                    MailGonder("Adsoyad" + adsoyad);
                    baglanti.Close();
                }

                else
                {
                    label9.Visible = true;
                    label9.ForeColor = Color.Red;
                    label9.Text = "Girmiş Olduğunuz Bilgi Uyuşmuyor";
                }

            }
            catch (Exception)
            {
                label9.Visible = true;
                label9.ForeColor = Color.Red;
                label9.Text = "Mail Gönderme Hatası";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand komut = new SqlCommand("select * from musteriEkle where eposta='" + EPostatxt.Text + "'");
                komut.Connection = baglanti;
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    adsoyad = oku["adsoyad"].ToString();

                    label9.Visible = true;
                    label9.ForeColor = Color.Green;
                    label9.Text = "Mail Gönderildi";

                    progressBar1.Visible = true;
                    progressBar1.Maximum = 900000;
                    progressBar1.Minimum = 90;

                    for (int j = 90; j < 900000; j++)
                    {
                        progressBar1.Value = j;
                    }
                    MailGonderme("Adsoyad" + adsoyad);
                    baglanti.Close();
                }

                else
                {
                    label9.Visible = true;
                    label9.ForeColor = Color.Red;
                    label9.Text = "Girmiş Olduğunuz Bilgi Uyuşmuyor";
                }

            }
            catch (Exception)
            {
                label9.Visible = true;
                label9.ForeColor = Color.Red;
                label9.Text = "Mail Gönderme Hatası";
            }
        }
        private void sepetlistele()
        {
            /*
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsepet", baglanti);
            adtr.Fill(daset, "akaryakitsepet");
         
            baglanti.Close();
            */
        }
        private void hesapla()
        {
            
        }
        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsatis", baglanti);
            adtr.Fill(daset, "akaryakitsatis");
            dataGridView1.DataSource = daset.Tables["akaryakitsatis"];

            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
           
    }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO akaryakitson(plaka,adsoyad,telefon,eposta,kart,kartsifre,uchane,akaryakitno,tur,litre,fiyat,toplamfiyat) values(@plaka,@adsoyad,@telefon,@eposta,@kart,@kartsifre,@uchane,@akaryakitno,@tur,@litre,@fiyat,@toplamfiyat) ", baglanti);
                // SqlCommand komut = new SqlCommand("insert into aracahizmet", baglanti);

                komut.Parameters.AddWithValue("@plaka", dataGridView2.Rows[i].Cells["plaka"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView2.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@telefon", dataGridView2.Rows[i].Cells["telefon"].Value.ToString());
                komut.Parameters.AddWithValue("@eposta", dataGridView2.Rows[i].Cells["eposta"].Value.ToString());
                komut.Parameters.AddWithValue("@kart", dataGridView2.Rows[i].Cells["kart"].Value.ToString());
                komut.Parameters.AddWithValue("@kartsifre", dataGridView2.Rows[i].Cells["kartsifre"].Value.ToString());
                komut.Parameters.AddWithValue("@uchane", dataGridView2.Rows[i].Cells["uchane"].Value.ToString());
                komut.Parameters.AddWithValue("@akaryakitno", dataGridView2.Rows[i].Cells["akaryakitno"].Value.ToString());
                komut.Parameters.AddWithValue("@tur", dataGridView2.Rows[i].Cells["tur"].Value.ToString());

                komut.Parameters.AddWithValue("@litre", double.Parse(dataGridView2.Rows[i].Cells["litre"].Value.ToString()));
                komut.Parameters.AddWithValue("@fiyat", double.Parse(dataGridView2.Rows[i].Cells["fiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView2.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.ExecuteNonQuery();

                //  SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'"+int.Parse(dataGridView1.Rows[1].Cells["miktari"].Value.ToString())+"' where urunkodu='" + dataGridView1.Rows[1].Cells["barkodno"].Value.ToString() + "'", baglanti);

                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from akaryakitsatis", baglanti);
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Tablo yenilendi.", "Bilgilendirme");
            Kayıt_Göster1();
            daset.Tables["akaryakitsatis"].Clear();
            sepetlistele();
            hesapla();
            baglanti.Close();
        }
    }
    }

