using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GASOLINA
{
    class Kullanıcı_Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        SqlCommand komut;
        SqlDataReader read;
        
        Form11 kayıt = new Form11();

        public SqlDataReader kullanıcı(TextBox kullanıcıadı1txt, TextBox Şifre1txt)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from istsahibigirisi where adsoyad='" + kullanıcıadı1txt.Text + "'";
            read = komut.ExecuteReader();


            if (read.Read() == true)
            {
                if (Şifre1txt.Text == read["sifre"].ToString())
                {

                    MessageBox.Show("Giriş Başarılı");
                 

                    kayıt.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Hata1");
                }

            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata2");
            }


            baglanti.Close();
            return read;

        }
        public void yenikullanıcı(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox İstasyonAdıtxt, TextBox Şifretxt, TextBox Şifretekrartxt, GroupBox grup)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO istsahibigirisi values('" + kullanıcıadıtxt.Text + "','" + TelefonNumarasıtxt.Text + "','" + EPostatxt.Text + "','" + İstasyonAdıtxt.Text + "','" + Şifretxt.Text + "','" + Şifretekrartxt.Text + "')";

            komut.ExecuteNonQuery();
            baglanti.Close();
            /*
            if (Şifretxt.Text == read["sifre"].ToString() && Şifretekrartxt.Text == read["sifretekrar"].ToString())
            {

                
                MessageBox.Show("Üye eklendi");
               // foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

            }
            else if (Şifretxt.Text != Şifretekrartxt.Text)
            {
                
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata");
               // foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                
                MessageBox.Show("Üye eklenemedi!");
               // foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            */
           
        }
        /*
        public void yenikullanıcı(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox Şifretxt, TextBox Bankatxt, TextBox Kartşifretxt, TextBox Üçhanetxt, GroupBox grup)
        {


            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "INSERT INTO musteriEkle values('" + kullanıcıadıtxt.Text + "','" + TelefonNumarasıtxt.Text + "','" + EPostatxt.Text + "','" + Şifretxt.Text + "','" + Bankatxt.Text + "','" + Kartşifretxt + "','" + Üçhanetxt + "')";

            komut.ExecuteNonQuery();


            baglanti.Close();
            MessageBox.Show("Üye eklendi");
            foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";


            
        }
        */
           
        /*
        public void şifre(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox İstasyonAdıtxt, TextBox Şifretxt, TextBox Şifretekrartxt, GroupBox grup)
        {


            baglanti.Open();
            komut = new SqlCommand("select *from istsahibigirisi", baglanti);
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (kullanıcıadıtxt.Text == read["adsoyad"].ToString() && TelefonNumarasıtxt.Text == read["telno"].ToString())
                {
                    if (EPostatxt.Text == read["eposta"].ToString() && İstasyonAdıtxt.Text == read["istasyonismi"].ToString())
                    {


                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update istsahibigirisi  set adsoyad='" + kullanıcıadıtxt.Text + "',telno='" + TelefonNumarasıtxt.Text + "',eposta='" + EPostatxt.Text + "'istasyonismi='" + İstasyonAdıtxt.Text + "' where sifre='" + Şifretxt.Text + "',sifretekrar='" + Şifretekrartxt.Text + "'", baglanti);
                        komut.ExecuteNonQuery();

                        baglanti.Close();

                        MessageBox.Show("İşlem başarılı.");
                        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = " ";
                    }
                    else
                    {
                        MessageBox.Show("E-posta adresi ya da istasyon ismi yanlış.", "Hata1");
                        baglanti.Close();
                    }


                }

                else
                {
                    MessageBox.Show("Kullanıcı adı ya da telefon numarası yanlış.", "Hata2");
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Üye eklenemedi.");
               
            }
            baglanti.Close();
        }
        */
    }
}
    

