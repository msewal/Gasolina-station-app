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
    public partial class MüşteriEkle : System.Windows.Forms.Form
    {
        public MüşteriEkle()
        {
            InitializeComponent();

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            //SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1;Initial Catalog=GASOLINA;User ID=sa;Password=54321");


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteriEkle(adsoyad,telno,eposta,sifre,banka,kartsifre,uchane) values(@adsoyad,@telno,@eposta,@sifre,@banka,@kartsifre,@uchane)", baglanti);
            komut.Parameters.AddWithValue("@adsoyad",textBox8.Text);
            komut.Parameters.AddWithValue("@telno",textBox2.Text);
            komut.Parameters.AddWithValue("@eposta",textBox3.Text);
            komut.Parameters.AddWithValue("@sifre",textBox4.Text);
            komut.Parameters.AddWithValue("@banka",textBox5.Text);
            komut.Parameters.AddWithValue("@kartsifre",textBox6.Text);
            komut.Parameters.AddWithValue("@uchane",textBox7.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı oluşturuldu.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

            if (textBox1.Text == "")
            {

                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriEkle where adsoyad= '" + textBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                textBox2.Text = read["telno"].ToString();
                textBox3.Text = read["eposta"].ToString();
                textBox4.Text = read["sifre"].ToString();
                textBox5.Text = read["banka"].ToString();
                textBox6.Text = read["kartsifre"].ToString();
                textBox7.Text = read["uchane"].ToString();
                // textBox8.Text = read["alisfiyati"].ToString();
                //      textBox6.Text = read[""].ToString();
                // textBox13.Text = read["tarih"]

            }

            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
