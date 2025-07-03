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

    public partial class ŞifreGüncelle : System.Windows.Forms.Form
    {

        public ŞifreGüncelle()
        {
            InitializeComponent();
        }

        //update musteriEkle set sifre='" + Şifretxt.Text + "' ,banka='" + Bankatxt.Text + "',kartsifre='" + Kartşifretxt.Text + "',uchane='" 

        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("meleksevvalerdogan@ogrenci.beykoz.edu.tr");
            ePosta.To.Add(EPostatxt.Text); //göndereceğimiz mail adresi

            ePosta.Subject = "GASOLINA KULLANICI BİLGİLERİ HATIRLATMA"; //mail konusu
            ePosta.Body = "KULLANICI ADINIZ:  '"+adsoyad+"' KULLANICI ŞİFRENİZ: '"+sifre+"'";  //mail içeriği 
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
   


        string sifre;
        string adsoyad;
        private void button2_Click_1(object sender, EventArgs e)
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

                    sifre = oku["sifre"].ToString();
                        


                            label9.Visible = true;
                            label9.ForeColor = Color.Green;
                            label9.Text = "Girmiş Olduğunuz Bilgi Uyuşuyor, Şifreniz Mail Olarak Gönderildi";

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
        /*
      private void button1_Click(object sender, EventArgs e)
      {

          SqlConnection baglantii = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
          baglantii.Open();

          sqlbaglantisi bgln = new sqlbaglantisi();
          SqlCommand komut = new SqlCommand("select * from musteriEkle where adsoyad='" + kullanıcıadıtxt.Text.ToString() + "' and eposta='" + EPostatxt.Text + "'",bgln.baglantii());
          komut.Connection = bgln.baglantii;
          SqlDataReader read = komut.ExecuteReader();
          while (read.Read()) {
              try
              {
                  if (bgln.baglantii.State == ConnectionState.Closed)
                  {
                      bgln.baglantii.Open();
                  }
                  SmtpClient smtpserver = new SmtpClient();
                  MailMessage mail = new MailMessage();
                  string tarih = DateTime.Now.ToLongDateString();
                  string mailadresim = ("meleksevvalerdogan@ogrenci.beykoz.edu.tr");

                  string sifre = "63.37rMi";
                  string smtpsrvr = "smtp.gmail.com";
                  string kime = (read["eposta"].ToString());
                  string konu = ("Şifre Hatırlatma Maili");
                  string yaz = ("SSayın," + read["adsoyad"].ToString() + "\n" + "GASOLINA uygulamasına" + tarih + " tarihinde şifrehatırlatma talebinde bulundunuz." + "\n" + "Parolanız:" + read["sifre"].ToString() + "\nİyi Günler");
                  smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                  smtpserver.Port = 587;
                  smtpserver.Host = smtpsrvr;
                  smtpserver.EnableSsl = true;
                  mail.From = new MailAddress(mailadresim);
                  mail.To.Add(kime);
                  mail.Subject = konu;
                  mail.Body = yaz;
                  smtpserver.Send(mail);
                  DialogResult bilgi = new DialogResult();
                  bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuşuyor. Şifreniz mail adresinize gönderildi.");
                  this.Hide();

              }
              catch (Exception Hata){

                  MessageBox.Show("Mail gönderilemedi!", "Hata");

                      }
              }

      }
             /* public bool MailGonder(string konu, string icerik)
      {
          MailMessage ePosta = new MailMessage();
          ePosta.From = new MailAddress("meleksevvalerdogan@ogrenci.beykoz.edu.tr");
          ePosta.To.Add(EPostatxt.Text); //göndereceğimiz mail adresi

          ePosta.Subject = konu; //mail konusu
          ePosta.Body = icerik; //mail içeriği 

          SmtpClient client = new SmtpClient();
          client.Credentials = new System.Net.NetworkCredential("eposta", "sifre");
          client.Port = 587;
          client.Host = "meleksevvalerdogan@ogrenci.beykoz.edu.tr";
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
    */
        /*
        Class1 klnc = new Class1();
        private void button2_Click(object sender, EventArgs e)
        {   baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriEkle set adsoyad='" + kullanıcıadıtxt.Text + "',sifre='" + Şifretxt.Text + "', telno='" + TelefonNumarasıtxt.Text + "',eposta='"+EPostatxt+"',banka='"+Bankatxt+"', kartsifre='"+Kartşifretxt+"',uchane='"+Üçhanetxt+"' where adsoyad='" + kullanıcıadıtxt.Text + "',sifre='" + Şifretxt.Text + "', telno='" + TelefonNumarasıtxt.Text + "',eposta='" + EPostatxt + "',banka='" + Bankatxt + "', kartsifre='" + Kartşifretxt + "',uchane='" + Üçhanetxt + "'", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            MessageBox.Show("Akaryakıt bilgilerinde güncelleme yapıldı.");


        }

        private void Şifre(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox Şifretxt, TextBox Bankatxt, TextBox Kartşifretxt, TextBox Üçhanetxt, GroupBox groupBox1)
        {

            throw new NotImplementedException();

        }
        */
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void YeniKullanıcıEkle_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EPostatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}


