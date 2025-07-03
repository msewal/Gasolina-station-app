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

namespace GASOLINA
{
    public partial class Girişvekayıt : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        SqlCommand komut;
        SqlDataReader read;
        frmYeni kayıt = new frmYeni();

        public SqlDataReader kullanıcı(TextBox adsoyad, TextBox sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.CommandText = "select *from istsahibigirisi where adsoyad='" + adsoyad.Text + "',sifre='" + sifre + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {

                    MessageBox.Show("Giriş Başarılı");

                    frmYeni form = new frmYeni();
                    form.ShowDialog();

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

        
        public void yenikullanıcı(TextBox adsoyad, TextBox telno, TextBox eposta, TextBox istasyonismi, TextBox sifre, TextBox sifretekrar, GroupBox grup)
        {
            if (sifre.Text == sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select *from GASOLINA where istsahibigirisi='" + adsoyad.Text + "','" + telno.Text + "','" + eposta.Text + "','" + istasyonismi.Text + "','" + sifre.Text + "','" + sifre.Text + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye eklendi");

                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata");
            }
        }
        public void sifre(TextBox adsoyad, TextBox telno, TextBox eposta, TextBox istasyonismi, TextBox sifre, TextBox sifretekrar, GroupBox grup)
        {
            if (sifre.Text == sifretekrar.Text) {
                baglanti.Open();
                komut = new SqlCommand("select *from istsahibigirisi where '" + adsoyad.Text + "'", baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    if (adsoyad.Text == read["adsoyad"].ToString() && telno.Text == read["telno"].ToString())

                    {
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update istsahibigirişi set eposta='"+adsoyad.Text+"',sifre='"+sifre.Text+"' where adsoyad='"+adsoyad.Text+"",baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("İşlem başarılı.");
                        foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı hariç diğer bilgilerinizi kontrol ediniz.", "Hata1");
                    }
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata2");

                }
                baglanti.Close();
            }
            
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata3");
            }
            baglanti.Close();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            k.kullanıcı(txtKullanıcıAdı, txtŞifre);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k.yenikullanıcı(kullanıcıadıtxt, TelefonNumarasıtxt, EPostatxt, İstasyonAdıtxt, Şifretxt, Şifretekrartxt, groupBox2);
        }
        public Girişvekayıt()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }
         
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmŞifre şifre = new frmŞifre();
            şifre.ShowDialog();
        }
        Girişvekayıt k = new Girişvekayıt();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

    
