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
    public partial class frmUrunlistele : Form
    {
        public frmUrunlistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
        DataSet daset = new DataSet();


        private void Kayıt_Göster()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];

            baglanti.Close();

        }
        /*
        private void kategorigetir()
        {
           // kategorigetir();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        */

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView2.DataSource = daset.Tables["urun"];
            baglanti.Close();

        }

        private void frmUrunlistele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet34.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter5.Fill(this.gASOLINADataSet34.urun);
            
           
          
            ÜrünListele();
    

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            textBox1.Text = dataGridView2.CurrentRow.Cells["urunkodu"].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells["kategori"].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells["marka"].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells["urunadi"].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells["miktari"].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells["alisfiyati"].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells["satisfiyati"].Value.ToString();
            */
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka , urunadi =@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where urunkodu=@urunkodu", baglanti);

       komut.Parameters.AddWithValue("@urunkodu", textBox1.Text);
            komut.Parameters.AddWithValue("@kategori", textBox2.Text);
            komut.Parameters.AddWithValue("@marka", textBox3.Text);
            komut.Parameters.AddWithValue("@urunadi", textBox4.Text);
            komut.Parameters.AddWithValue("@miktari", textBox5.Text);
            komut.Parameters.AddWithValue("@alisfiyati", textBox6.Text);
            komut.Parameters.AddWithValue("@satisfiyati", textBox7.Text);
          //  komut.Parameters.AddWithValue("@tarih", textBox9.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Göster();
        /*    daset.Tables[""].Clear();
            ÜrünListele();
        */
            MessageBox.Show("Güncelleme yapıldı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where urunkodu=@urunkodu", baglanti);

                komut.Parameters.AddWithValue("@urunkodu", textBox8.Text);
                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı.");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Ürün kodu yazılı değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }
        */
        /*
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboBox1 + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (read["kategori"] != null) {
                    comboBox2.Items.Add(read["marka"].ToString());
                }
            }
            baglanti.Close();
        }
*/
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where urunkodu='" + dataGridView2.CurrentRow.Cells["urunkodu"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt silindi.");
            Kayıt_Göster();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

            if (textBox8.Text == "")
            {
               
                foreach (Control item in panel2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunadi= '" + textBox8.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = read["urunkodu"].ToString();
                textBox2.Text = read["kategori"].ToString();
                textBox3.Text = read["marka"].ToString();
                textBox4.Text = read["urunadi"].ToString();
                textBox5.Text = read["miktari"].ToString();
                textBox6.Text = read["alisfiyati"].ToString();
                textBox7.Text = read["satisfiyati"].ToString();
                // textBox13.Text = read["tarih"]

            }

            baglanti.Close();

            /*
    DataTable tablo = new DataTable();
            baglanti.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where urunadi like '" + textBox8.Text + "'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmUrunlistele ekle = new frmUrunlistele();
            ekle.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        
            Form21 ekle = new Form21();
            ekle.ShowDialog();
        }
    }
    }

