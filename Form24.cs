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
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace GASOLINA
{
    public partial class Form24 : Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;
        public Form24()
        {

            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        DataSet daset = new DataSet();


        private void Kayıt_Göster()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];

            baglanti.Close();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunadi='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["urunadi"] != null)
                {
                    label7.Text = dr["urunadi"].ToString();
                    label2.Text = dr["urunkodu"].ToString();
                    label3.Text = dr["kategori"].ToString();
                    label4.Text = dr["marka"].ToString();
                    label5.Text = dr["satisfiyati"].ToString();


                }
                if (dr["urunresmi"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["urunresmi"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);

                }

            }
            baglanti.Close();

        }
        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet55.gecicisepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gecicisepetTableAdapter2.Fill(this.gASOLINADataSet55.gecicisepet);


            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;

            sepetlistele();

            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barkod = new BarcodeReader();
            if (pictureBox2.Image != null)
            {
                Result res = barkod.Decode((Bitmap)pictureBox2.Image);
                try
                {
                    string dec = res.ToString().Trim();
                    if (dec != "")
                    {
                        timer1.Stop();
                        textBox4.Text = dec;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void cam_NewCam(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = ((Bitmap)eventArgs.Frame.Clone());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewCam);
            cam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 ekle = new Form13();
            cam.Stop();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriEkle", baglanti);


            SqlDataReader read = komut.ExecuteReader();
            if (txtAdSoyad.Text == "@adsoyad")
            {

                txtTelefon.Text = read["telno"].ToString();
                txtEPosta.Text = read["eposta"].ToString();
                //   txtMiktari.Text = read["miktari"].ToString();
                textBox1.Text = read["banka"].ToString();
                textBox2.Text = read["kartsifre"].ToString();
                textBox3.Text = read["uchane"].ToString();

            }

            while (read.Read())
            {

                txtTelefon.Text = read["telno"].ToString();
                txtEPosta.Text = read["eposta"].ToString();
                //   txtMiktari.Text = read["miktari"].ToString();
                textBox1.Text = read["banka"].ToString();
                textBox2.Text = read["kartsifre"].ToString();
                textBox3.Text = read["uchane"].ToString();
            }
            baglanti.Close();
            // daset.Tables["sepet"].Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                }

            }
            */
        }


        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from gecicisepet", baglanti);
            adtr.Fill(daset, "gecicisepet");
            /*
              dataGridView1.Columns[0].Visible= false;
              dataGridView1.Columns[1].Visible = false;
              dataGridView1.Columns[2].Visible = false;
              dataGridView1.Columns[3].Visible = false;
              dataGridView1.Columns[4].Visible = false;
              dataGridView1.Columns[5].Visible = false;
              */
            baglanti.Close();

        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from gecicisepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {


            }


        }
        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from aracahizmet", baglanti);
            adtr.Fill(daset, "aracahizmet");
            dataGridView1.DataSource = daset.Tables["aracahizmet"];

            baglanti.Close();
        }
        /* DataTable yenile()
         {
             baglanti.Open();
             SqlDataAdapter adtr = new SqlDataAdapter("select *from gecicisepet", baglanti);
             DataTable tablo = new DataTable();
             adtr.Fill(tablo);
             baglanti.Close();
             return tablo;
         }
        */
        bool durum;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO gecicisepet(plaka,adsoyad,telefon,eposta,kart,kartsifre,uchane,urunadi,urunkodu,kategori,marka,fiyati,miktari,toplamfiyat) values(@plaka,@adsoyad,@telefon,@eposta,@kart,@kartsifre,@uchane,@urunadi,@urunkodu,@kategori,@marka,@fiyati,@miktari,@toplamfiyat) ", baglanti);

                komut.Parameters.AddWithValue("@plaka", textBox4.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@eposta", txtEPosta.Text);
                komut.Parameters.AddWithValue("@kart", textBox1.Text);
                komut.Parameters.AddWithValue("@kartsifre", textBox2.Text);
                komut.Parameters.AddWithValue("@uchane", textBox3.Text);
                komut.Parameters.AddWithValue("@urunadi", label7.Text);
                komut.Parameters.AddWithValue("@urunkodu", label2.Text);
                komut.Parameters.AddWithValue("@kategori", label3.Text);
                komut.Parameters.AddWithValue("@marka", label4.Text);
                komut.Parameters.AddWithValue("@fiyati", double.Parse(label5.Text));
                komut.Parameters.AddWithValue("@miktari", int.Parse(textBox5.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(label26.Text));
                // komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                baglanti.Close();
                Kayıt_Göster();

            }
            else
            {

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where urunkodu='" + label2.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                // urunkodu
                baglanti.Close();
                Kayıt_Göster();

        
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }


            }
            textBox5.Text = "1";
            daset.Tables["gecicisepet"].Clear();
           
            sepetlistele();
            hesapla();

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO aracahizmet(plaka, adsoyad, telefon, eposta, kart, kartsifre, uchane, urunadi, urunkodu, kategori, marka, fiyati, miktari, toplamfiyat) values(@plaka, @adsoyad, @telefon, @eposta, @kart, @kartsifre, @uchane, @urunadi, @urunkodu, @kategori, @marka, @fiyati, @miktari, @toplamfiyat)", baglanti);
                // SqlCommand komut = new SqlCommand("insert into aracahizmet", baglanti);

                komut.Parameters.AddWithValue("@plaka", dataGridView2.Rows[i].Cells["plaka"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView2.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@telefon", dataGridView2.Rows[i].Cells["telefon"].Value.ToString());
                komut.Parameters.AddWithValue("@eposta", dataGridView2.Rows[i].Cells["eposta"].Value.ToString());
                komut.Parameters.AddWithValue("@kart", dataGridView2.Rows[i].Cells["kart"].Value.ToString());
                komut.Parameters.AddWithValue("@kartsifre", dataGridView2.Rows[i].Cells["kartsifre"].Value.ToString());
                komut.Parameters.AddWithValue("@uchane", dataGridView2.Rows[i].Cells["uchane"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView2.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@urunkodu", dataGridView2.Rows[i].Cells["urunkodu"].Value.ToString());
                komut.Parameters.AddWithValue("@kategori", dataGridView2.Rows[i].Cells["kategori"].Value.ToString());
                komut.Parameters.AddWithValue("@marka", dataGridView2.Rows[i].Cells["marka"].Value.ToString());
                komut.Parameters.AddWithValue("@fiyati", double.Parse(dataGridView2.Rows[i].Cells["fiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView2.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView2.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.ExecuteNonQuery();

                //  SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'"+int.Parse(dataGridView1.Rows[1].Cells["miktari"].Value.ToString())+"' where urunkodu='" + dataGridView1.Rows[1].Cells["barkodno"].Value.ToString() + "'", baglanti);
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView2.Rows[i].Cells["miktari"].Value.ToString()) + "' where urunkodu='" + dataGridView2.Rows[i].Cells["urunkodu"].Value.ToString() + "'", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from gecicisepet", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Siparişiniz başarıyla gönderildi, satıcı tarafından onay bekleniyor. Sipariş onaylandığında e-mail yoluyla bilgilendirme yapılır.", "Bilgilendirme");
                this.Hide();
                Form23 message = new Form23();
                message.ShowDialog();
                daset.Tables["gecicisepet"].Clear();
                sepetlistele();
                hesapla();
            baglanti.Close();
        }

            private void btnSil_Click(object sender, EventArgs e)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from gecicisepet where urunkodu='" + dataGridView2.CurrentRow.Cells[8].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            Kayıt_Göster();
                MessageBox.Show("Ürün sepetten çıkarıldı.");
                daset.Tables["gecicisepet"].Clear();
                sepetlistele();
                hesapla();
            }

            private void btnSatışİptal_Click(object sender, EventArgs e)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from gecicisepet", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            Kayıt_Göster();
                MessageBox.Show("Satın alma işlemi iptal edildi.");
                daset.Tables["gecicisepet"].Clear();

                sepetlistele();
                hesapla();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update gecicisepet", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            Kayıt_Göster();
            }
         
            private void barkodkontrol()
            {
                durum = true;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from gecicisepet", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    if (label2.Text == read["urunkodu"].ToString())
                    {

                        durum = false;
                    }

                }
                baglanti.Close();
            }
            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {
                try
                {

                    label26.Text = (int.Parse(textBox5.Text) * double.Parse(label5.Text)).ToString();


                }
                catch (Exception)
                {


                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form24 yenile = new Form24();
                yenile.ShowDialog();
            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {
                try
                {

                    label26.Text = (int.Parse(textBox5.Text) * double.Parse(label5.Text)).ToString();


                }
                catch (Exception)
                {


                }
            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 yeni = new Form23();
            yeni.ShowDialog();
        }
    } }