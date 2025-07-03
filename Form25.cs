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
    public partial class Form25 : Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;
        public Form25()
        {

            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        DataSet daset = new DataSet();


        private void Kayıt_Göster()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsepet", baglanti);
            adtr.Fill(daset, "akaryakitsepet");
            dataGridView1.DataSource = daset.Tables["akaryakitsepet"];

            baglanti.Close();

        }
        private void Form25_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet61.istasyon' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyonTableAdapter1.Fill(this.gASOLINADataSet61.istasyon);
            /*
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select (istasyonadi) from istasyon",baglanti);
                SqlDataReader read;
                read = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("istasyonadi", typeof(string));
                dt.Load(read);
                comboBox2.ValueMember = "istasyonadi";
                comboBox2.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception) { }
            */
            // TODO: Bu kod satırı 'gASOLINADataSet60.akaryakitsepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.akaryakitsepetTableAdapter.Fill(this.gASOLINADataSet60.akaryakitsepet);
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;

            sepetlistele();

            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from istasyondakiakaryakit", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from istasyon", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

           
            while (dr.Read())
            {
                if (dr["istasyonadi"] != null)
                 {
                     textBox6.Text = dr["istasyonadresi"].ToString();

               
                 }
                 if (dr["istasyonresmi"] != null)
                 {
                     byte[] resim = new byte[0];
                     resim = (byte[])dr["istasyonresmi"];
                     MemoryStream memoryStream = new MemoryStream(resim);
                     pictureBox1.Image = Image.FromStream(memoryStream);

                 }

            }
            baglanti.Close();
        }
        private void Form25_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
        }
        private void cam_NewCam(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = ((Bitmap)eventArgs.Frame.Clone());
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
                txtAdSoyad.Text = read["adsoayad"].ToString();
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
            /*
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsepet", baglanti);
            adtr.Fill(daset, "akaryakitsepet");
         
            baglanti.Close();
            */
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from akaryakitsepet", baglanti);
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
            SqlDataAdapter adtr = new SqlDataAdapter("select *from akaryakitsatis", baglanti);
            adtr.Fill(daset, "akaryakitsatis");
            dataGridView1.DataSource = daset.Tables["akaryakitsatis"];

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
          
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update akaryakitsepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void barkodkontrol()
        {
            /*
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from akaryakitsepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (label2.Text == read["akaryakitno"].ToString())
                {

                    durum = false;
                }

            }
            baglanti.Close();
            */
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {

                label26.Text = (double.Parse(textBox5.Text) * double.Parse(label5.Text)).ToString();


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
          
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO akaryakitsepet(plaka,adsoyad,telefon,eposta,kart,kartsifre,uchane,akaryakitno,tur,litre,fiyat,toplamfiyat) values(@plaka,@adsoyad,@telefon,@eposta,@kart,@kartsifre,@uchane,@akaryakitno,@tur,@litre,@fiyat,@toplamfiyat) ", baglanti);

                komut.Parameters.AddWithValue("@plaka", textBox4.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@eposta", txtEPosta.Text);
                komut.Parameters.AddWithValue("@kart", textBox1.Text);
                komut.Parameters.AddWithValue("@kartsifre", textBox2.Text);
                komut.Parameters.AddWithValue("@uchane", textBox3.Text);
                komut.Parameters.AddWithValue("@akaryakitno", label2.Text);
                komut.Parameters.AddWithValue("@tur", label7.Text);
                komut.Parameters.AddWithValue("@litre", int.Parse(textBox5.Text));
                komut.Parameters.AddWithValue("@fiyat", double.Parse(label5.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(label26.Text));
                // komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
                komut.ExecuteNonQuery();

           //    SqlCommand komut3 = new SqlCommand("update istasyondakiakaryakit set Litre*Fiyat where akaryakitno='" + label2.Text + "'", baglanti);
             //   komut3.ExecuteNonQuery();
                // urunkodu
                baglanti.Close();
                Kayıt_Göster();
                /*
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                */

            }
            //  textBox5.Text = "1";
      //   daset.Tables["akaryakitsepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form25 yenile = new Form25();
            yenile.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from istasyondakiakaryakit where tur='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["tur"] != null)
                {

                    label2.Text = dr["akaryakitno"].ToString();
                    label7.Text = dr["tur"].ToString();
                  //  textBox5.Text = dr["litre"].ToString();
                    label5.Text = dr["fiyat"].ToString();
              //      label26.Text = dr["toplamfiyat"].ToString();



                }


            }
            baglanti.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewCam);
            cam.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form13 ekle = new Form13();
            cam.Stop();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                label26.Text = (double.Parse(textBox5.Text) * double.Parse(label5.Text)).ToString();


            }
            catch (Exception)
            {


            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form23 acc = new Form23();
            acc.ShowDialog();
        }

        private void btnSatışİptal_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from akaryakitsepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Göster();
            MessageBox.Show("Satın alma işlemi iptal edildi.");
            daset.Tables["akaryakitsepet"].Clear();

            sepetlistele();
            hesapla();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from akaryakitsepet where akaryakitno='" + dataGridView2.CurrentRow.Cells[7].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Göster();
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["akaryakitsepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışYap_Click_1(object sender, EventArgs e)
        {
            barkodkontrol();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO akaryakitsatis(plaka,adsoyad,telefon,eposta,kart,kartsifre,uchane,akaryakitno,tur,litre,fiyat,toplamfiyat) values(@plaka,@adsoyad,@telefon,@eposta,@kart,@kartsifre,@uchane,@akaryakitno,@tur,@litre,@fiyat,@toplamfiyat) ", baglanti);
                // SqlCommand komut = new SqlCommand("insert into aracahizmet", baglanti);

                komut.Parameters.AddWithValue("@plaka", dataGridView2.Rows[i].Cells["plaka"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView2.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@telefon", dataGridView2.Rows[i].Cells["telefon"].Value.ToString());
                komut.Parameters.AddWithValue("@eposta", dataGridView2.Rows[i].Cells["eposta"].Value.ToString());
                komut.Parameters.AddWithValue("@kart", dataGridView2.Rows[i].Cells["kart"].Value.ToString());
                komut.Parameters.AddWithValue("@kartsifre", dataGridView2.Rows[i].Cells["kartsifre"].Value.ToString());
                komut.Parameters.AddWithValue("@uchane", dataGridView2.Rows[i].Cells["uchane"].Value.ToString());
                komut.Parameters.AddWithValue("@akaryakitno", dataGridView2.Rows[i].Cells["akaryakitno"].Value.ToString());
                komut.Parameters.AddWithValue("@tur", dataGridView2.Rows[i].Cells["tur"].Value.ToString());

                komut.Parameters.AddWithValue("@litre", double.Parse(dataGridView2.Rows[i].Cells["litre"].Value.ToString()));
                komut.Parameters.AddWithValue("@fiyat", double.Parse(dataGridView2.Rows[i].Cells["fiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView2.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.ExecuteNonQuery();

                //  SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'"+int.Parse(dataGridView1.Rows[1].Cells["miktari"].Value.ToString())+"' where urunkodu='" + dataGridView1.Rows[1].Cells["barkodno"].Value.ToString() + "'", baglanti);
                SqlCommand komut2 = new SqlCommand("update istasyondakiakaryakit set Litre=Litre-'" + double.Parse(dataGridView2.Rows[i].Cells["litre"].Value.ToString()) + "' where akaryakitno='" + dataGridView2.Rows[i].Cells["akaryakitno"].Value.ToString() + "'", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from akaryakitsepet", baglanti);
            komut3.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Siparişiniz başarıyla gönderildi, pompacı tarafından onay bekleniyor. Sipariş onaylandığında e-mail yoluyla bilgilendirme yapılır.", "Bilgilendirme");
            this.Hide();
            Form23 message = new Form23();
            message.ShowDialog();
            daset.Tables["akaryakitsepet"].Clear();
            sepetlistele();
            hesapla();
            baglanti.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
