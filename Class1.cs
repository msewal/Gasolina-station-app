using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GASOLINA
{
    internal class Class1
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        SqlCommand komut;
        SqlDataReader read;
        Form23 kayıt = new Form23();

        public SqlDataReader kullanıcı(TextBox kullanıcıadı1txt, TextBox Şifre1txt)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from musteriEkle where adsoyad='" + kullanıcıadı1txt.Text + "'";
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
        public void yenikullanıcı(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox Şifretxt, TextBox Bankatxt, TextBox Kartşifretxt, TextBox Üçhanetxt, GroupBox grup)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");

            baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO musteriEkle values('" + kullanıcıadıtxt.Text + "','" + TelefonNumarasıtxt.Text + "','" + EPostatxt.Text + "','" + Şifretxt.Text + "','" + Bankatxt.Text + "','" + Kartşifretxt + "','" + Üçhanetxt + "')";

                komut.ExecuteNonQuery();


                baglanti.Close();
                MessageBox.Show("Üye eklendi");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

       
            baglanti.Close();

        }
        public void Şifre(TextBox kullanıcıadıtxt, TextBox TelefonNumarasıtxt, TextBox EPostatxt, TextBox Şifretxt, TextBox Bankatxt, TextBox Kartşifretxt, TextBox Üçhanetxt, GroupBox grup)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");

            komut = new SqlCommand("select *from musteriEkle", baglanti);
            read = komut.ExecuteReader();
           
                    baglanti.Open();
                    komut = new SqlCommand("update musteriEkle set sifre='" + Şifretxt.Text + "' ,banka='" + Bankatxt.Text + "',kartsifre='" + Kartşifretxt.Text + "',uchane='" + Üçhanetxt.Text + "' where adsoyad='" + kullanıcıadıtxt.Text + "',telno='" + TelefonNumarasıtxt.Text + "',eposta='" + EPostatxt.Text + "'",baglanti);
                    komut.ExecuteNonQuery();

                    baglanti.Close();

                    MessageBox.Show("İşlem başarılı.");
                    foreach (Control item in grup.Controls) if (item is TextBox) item.Text = " ";

              
            
            baglanti.Close();

        }
       /*
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
        baglanti.Open();
            return.baglanti;
       */

        }
}



