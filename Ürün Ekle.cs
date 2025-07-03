using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;
namespace GASOLINA
{
    public partial class frmÜrünEkle : System.Windows.Forms.Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        string resimPath;

        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

        bool durum;
        private void kategorigetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();


            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }

            baglanti.Close();
        }

        
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox6.Text == read["urunkodu"].ToString() || textBox6.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        
        private void ÜrünEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet35.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.gASOLINADataSet35.urun);
            kategorigetir();
            barkodkontrol();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                comboBox2.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            
                SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
                baglanti.Open();

                FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                SqlCommand komut = new SqlCommand("insert into urun(urunresmi, barkodno, urunkodu, kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@urunresmi, @barkodno, @urunkodu, @kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.Add("@urunresmi", SqlDbType.Image, resim.Length).Value = resim;
                komut.Parameters.Add("@barkodno", SqlDbType.Image, resim.Length).Value = resim;

                komut.Parameters.AddWithValue("@urunkodu", textBox1.Text);

                komut.Parameters.AddWithValue("@kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("@marka", comboBox2.Text);
                komut.Parameters.AddWithValue("@urunadi", textBox2.Text);
                komut.Parameters.AddWithValue("@miktari", textBox3.Text);
                komut.Parameters.AddWithValue("@alisfiyati", textBox4.Text);
                komut.Parameters.AddWithValue("@satisfiyati", textBox5.Text);
                komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi.");
            


            comboBox2.Items.Clear();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is PictureBox)
                {
                    item.Text = "";
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ekle = new Form7();

            ekle.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari='" + textBox10.Text + "' where urunkodu='" + textBox6.Text + "'", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }




            MessageBox.Show("Var olan ürün miktarına güncelleme yapıldı.");


        }


        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim aç";
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası(*.tif)|*.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resimPath = openFileDialog1.FileName.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Resim aç";
            openFileDialog2.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası(*.tif)|*.tif";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                resimPath = openFileDialog2.FileName.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

            if (textBox6.Text == "")
            {
                label21.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunkodu= '" + textBox6.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                textBox7.Text = read["kategori"].ToString();
                textBox8.Text = read["marka"].ToString();
                textBox9.Text = read["urunadi"].ToString();
                label21.Text = read["miktari"].ToString();
                textBox11.Text = read["alisfiyati"].ToString();
                textBox12.Text = read["satisfiyati"].ToString();
                // textBox13.Text = read["tarih"]

            }

            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmÜrünEkle ekle = new frmÜrünEkle();

            ekle.ShowDialog();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*
         
         */
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}


