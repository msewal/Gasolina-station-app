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
    public partial class Müşteri_Listele : System.Windows.Forms.Form
    {
        public Müşteri_Listele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        DataSet daset = new DataSet();

       

        private void label8_Click(object sender, EventArgs e)
        {
       
        }

        private void Müşteri_Listele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }
       
        private void Kayıt_Göster()
        {
            
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteriEkle", baglanti);
            adtr.Fill(daset,"musteriEkle");
            dataGridView1.DataSource=daset.Tables["musteriEkle"];
            
            baglanti.Close();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriEkle set adsoyad=@adsoyad,telno=@telno,eposta=@eposta,sifre=@sifre,banka=@banka,kartsifre=@kartsifre,uchane=@uchane where adsoyad=@adsoyad",baglanti);
            komut.Parameters.AddWithValue("@adsoyad", textBox8.Text);
            komut.Parameters.AddWithValue("@telno", textBox2.Text);
            komut.Parameters.AddWithValue("@eposta", textBox3.Text);
            komut.Parameters.AddWithValue("@sifre", textBox4.Text);
            komut.Parameters.AddWithValue("@banka", textBox5.Text);
            komut.Parameters.AddWithValue("@kartsifre", textBox6.Text);
            komut.Parameters.AddWithValue("@uchane", textBox7.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
            //daset.Tables["musteriEkle"].Clear();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriEkle where adsoyad='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["adsoyad"] != null)
                {

                    textBox8.Text = dr["adsoyad"].ToString();
                    textBox2.Text = dr["telno"].ToString();
                    textBox3.Text = dr["eposta"].ToString();
                    textBox4.Text = dr["sifre"].ToString();
                    textBox5.Text = dr["banka"].ToString();
                    textBox6.Text = dr["kartsifre"].ToString();
                    textBox7.Text = dr["uchane"].ToString();
                }

            }
          
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteriEkle set adsoyad=@adsoyad,telno=@telno,eposta=@eposta,sifre=@sifre,banka=@banka,kartsifre=@kartsifre,uchane=@uchane where adsoyad=@adsoyad",baglanti);
            komut.Parameters.AddWithValue("@adsoyad", textBox8.Text);
            komut.Parameters.AddWithValue("@telno", textBox2.Text);
            komut.Parameters.AddWithValue("@eposta", textBox3.Text);
            komut.Parameters.AddWithValue("@sifre", textBox4.Text);
            komut.Parameters.AddWithValue("@banka", textBox5.Text);
            komut.Parameters.AddWithValue("@kartsifre", textBox6.Text);
            komut.Parameters.AddWithValue("@uchane", textBox7.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
            //daset.Tables["musteriEkle"].Clear();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }*/
            baglanti.Open();
             SqlCommand komut = new SqlCommand("delete from musteriEkle where adsoyad like '%"+ textBox8.Text +"%'", baglanti);
         //   SqlCommand komut = new SqlCommand("delete from musteriEkle where adsoyad='" + dataGridView1.CurrentRow.Cells["adsoyad"].Value.ToString() + "'", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            //daset.Tables["musteriEkle"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi.");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            /*
              baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
             */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteriEkle where adsoyad like '%"+textBox1.Text+"%'",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Müşteri_Listele_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet29.musteriEkle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriEkleTableAdapter2.Fill(this.gASOLINADataSet29.musteriEkle);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriEkle where adsoyad= '" + textBox8.Text + "'", baglanti);
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
    }
}
