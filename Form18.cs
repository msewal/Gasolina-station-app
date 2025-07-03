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
    public partial class BilgileriGüncelle : System.Windows.Forms.Form
    {
        public BilgileriGüncelle()
        {
            InitializeComponent();
        }
      //  Kullanıcı_Form k = new Kullanıcı_Form();

    
        private void button2_Click(object sender, EventArgs e)
        {
           
                try
                {
                    SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    SqlCommand komut = new SqlCommand("select * from istsahibigirisi where eposta='" + EPostatxt.Text + "'");
                    komut.Connection = baglanti;
                    SqlDataReader oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        adsoyad = oku["adsoyad"].ToString();

                        sifre = oku["sifre"].ToString();



                        label1.Visible = true;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Girmiş Olduğunuz Bilgi Uyuşuyor, Şifreniz Mail Olarak Gönderildi";

                        progressBar1.Visible = true;
                        progressBar1.Maximum = 900000;
                        progressBar1.Minimum = 90;

                        for (int j = 90; j < 900000; j++)
                        {
                            progressBar1.Value = j;
                        }

                        MailGonder("Şifreniz: " + sifre, "Adsoyad" + adsoyad);
                        baglanti.Close();
                    }

                    else
                    {
                        label1.Visible = true;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Girmiş Olduğunuz Bilgi Uyuşmuyor";
                    }

                }
                catch (Exception)
                {
                    label1.Visible = true;
                    label1.ForeColor = Color.Red;
                    label1.Text = "Mail Gönderme Hatası";
                }
            }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form18_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BilgileriGüncelle_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TelefonNumarasıtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EPostatxt_TextChanged(object sender, EventArgs e)
        {



        }

        string sifre;
        string adsoyad;
        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("meleksevvalerdogan@ogrenci.beykoz.edu.tr");
            ePosta.To.Add(EPostatxt.Text); //göndereceğimiz mail adresi

            ePosta.Subject = "GASOLINA KULLANICI BİLGİLERİ HATIRLATMA"; //mail konusu
            ePosta.Body = "KULLANICI ADINIZ:  '" + adsoyad + "' KULLANICI ŞİFRENİZ: '" + sifre + "'";  //mail içeriği 
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
    }
   
    
        }
    
  
