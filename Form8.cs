using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace GASOLINA
{
    public partial class Form8 : System.Windows.Forms.Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;



        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL; Initial Catalog = GASOLINA; User ID = sa; Password=54321");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
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
        private void Kayıt_Göster()
        {

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];

            baglanti.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MüşteriEkle ekle = new MüşteriEkle();
            ekle.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Müşteri_Listele listele = new Müşteri_Listele();
            listele.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {


        }
        private void hesapla()
        {
            try
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", baglanti);
                label9.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {
                /*
                //Sütun değerlerini toplama
                int toplam = 0;//www.yazilimkodlama.com
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[11].Value);
                }
                lblGenelToplam.Text = toplam.ToString();
                */
            }


        }
        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet45.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter6.Fill(this.gASOLINADataSet45.sepet);


        

            //SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1;Initial Catalog=GASOLINA;User ID=sa;Password=54321");

            sepetlistele();
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in webcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUrunlistele listele = new frmUrunlistele();
            listele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ekle = new Form8();
            cam.Stop();
            ekle.ShowDialog();

            
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            // SqlCommand komut = new SqlCommand("select *from musteriEkle", baglanti);
            SqlCommand komut = new SqlCommand("select *from musteriEkle where adsoyad like '%" + txtAdSoyad.Text + "%'", baglanti); ;
            SqlDataReader read = komut.ExecuteReader();
            if (txtAdSoyad.Text == "@adsoyad")
            {

                txtTelefon.Text = read["telno"].ToString();
                txtEPosta.Text = read["eposta"].ToString();
                textBox1.Text = read["banka"].ToString();
                textBox2.Text = read["kartsifre"].ToString();
                textBox3.Text = read["uchane"].ToString();
            }

            while (read.Read())
            {


                txtTelefon.Text = read["telno"].ToString();
                txtEPosta.Text = read["eposta"].ToString();
                textBox1.Text = read["banka"].ToString();
                textBox2.Text = read["kartsifre"].ToString();
                textBox3.Text = read["uchane"].ToString();

            }
            baglanti.Close();
            //daset.Tables["musteriEkle"].Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {

                    /*             
                    textBox4.Text = "";
                  txtÜrünAdı.Text = "@urunadi";
                    txtMiktari.Text = "3";
                    txtSatışFiyati.Text = "@satisfiyati";
                 
                    //txtBarkodNo.Text = "";
                    //txtÜrünAdı.Text = "";
                    //txtMiktari.Text = "1";
                    //txtSatışFiyati.Text = "";
                    txtToplamFiyati.Text = "";
                     */
                }
            }
            /*
             if (txtAdSoyad.Text == "")
            {
                txtTelefon.Text = "";
                txtEPosta.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from musteriEkle where adsoyad like '%" + txtAdSoyad.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) {

                txtTelefon.Text = read["telno"].ToString();
                txtEPosta.Text = read["eposta"].ToString();
                textBox1.Text = read["banka"].ToString();
                textBox2.Text = read["kartsifre"].ToString();
                textBox3.Text = read["uchane"].ToString();


            }
            baglanti.Close();
            foreach (Control item in groupBox1.Controls) {
                if (item is TextBox)
                {
                    txtTelefon.Text = "";
                    txtEPosta.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
            }
            */
        }

        private void cam_NewCam(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        /*
                private void Form8_FormClosing(object sender, FormClosingEventArgs e)
                {
                    if (cam != null)
                        if (cam.IsRunning == true)
                        {
                            cam.Stop();
                        }
                }
        */

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewCam);
            cam.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form8 ekle = new Form8();
            cam.Stop();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();
        }

        private void txtSatışFiyati_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyati.Text)).ToString();


            }
            catch (Exception)
            {

              


            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            BarcodeReader barkod = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result res = barkod.Decode((Bitmap)pictureBox1.Image);
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
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunadi='"+textBox4.Text+"'", baglanti);
            /*SqlCommand komut = new SqlCommand("select *from urun where urunadi like '%" + textBox4.Text + "%'", baglanti)*/
            ;
            SqlDataReader read = komut.ExecuteReader();
            
            if (textBox4.Text == "@urunadi")
            {

                txtBarkodNo.Text = read["urunkodu"].ToString();
                txtÜrünAdı.Text = read["urunadi"].ToString();
                //   txtMiktari.Text = read["miktari"].ToString();
                txtSatışFiyati.Text = read["satisfiyati"].ToString();
                txtToplamFiyati.Text = "";
            }
            
            while (read.Read())
            {
                txtBarkodNo.Text = read["urunkodu"].ToString();
                txtÜrünAdı.Text = read["urunadi"].ToString();
                //   txtMiktari.Text = read["miktari"].ToString();
                txtSatışFiyati.Text = read["satisfiyati"].ToString();
                // txtToplamFiyati.Text = read[""];
            }
          
            baglanti.Close();
            // daset.Tables["sepet"].Clear();
          //  sepetlistele();
         /*   foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                }

            }
         */
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {/*
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
          */
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(adsoyad,eposta,telno,kart,kartsifre,uchane,urunkodu,urunadi,miktari,satisfiyati,toplamfiyat) values(@adsoyad,@eposta,@telno,@kart,@kartsifre,@uchane,@urunkodu,@urunadi,@miktari,@satisfiyati,@toplamfiyat) ", baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@eposta", txtEPosta.Text);
                komut.Parameters.AddWithValue("@telno", txtTelefon.Text);
                komut.Parameters.AddWithValue("@kart", textBox1.Text);
                komut.Parameters.AddWithValue("@kartsifre", textBox2.Text);
                komut.Parameters.AddWithValue("@uchane", textBox3.Text);
                komut.Parameters.AddWithValue("@urunkodu", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyati.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txtToplamFiyati.Text));
                // komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {

                baglanti.Open();

                // SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                // komut3.ExecuteNonQuery();
                //SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(txtMiktari.Text) + "' where urunkodu='" + txtBarkodNo.Text + "'", baglanti);
                //komut2.ExecuteNonQuery();

                /*      SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'" + int.Parse(txtMiktari.Text) + "' where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                     komut2.ExecuteNonQuery();
                */
                /*
              SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where urunkodu='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
             */
                // urunkodu
                SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where urunkodu='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }

                txtMiktari.Text = "1";
                daset.Tables["sepet"].Clear();

                sepetlistele();
                hesapla();
            }
            baglanti.Close();
            Kayıt_Göster();
         
        }
       /*
        private void Form8_KeyDown(object sender, EventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                txtMiktari.Text = txtBarkodNo.Text.Substring(txtBarkodNo.Text.Length - 1);
                txtBarkodNo.Text = "";
            }
        }
        */

        bool durum;
       
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["urunkodu"].ToString())
                {

                    durum = false;
                }

            }
            baglanti.Close();
        }
        
        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (int.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyati.Text)).ToString();


            }
            catch (Exception)
            {
              
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where urunkodu='" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Göster();
           
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSatışİptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Kayıt_Göster();
            
            MessageBox.Show("Ürün sepetten çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }

        private void btnSatışYap_Click_1(object sender, EventArgs e)
        {
            barkodkontrol();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO satis(adsoyad,eposta,telno,kart,kartsifre,uchane,urunkodu,urunadi,miktari,satisfiyati,toplamfiyat) values(@adsoyad,@eposta,@telno,@kart,@kartsifre,@uchane,@urunkodu,@urunadi,@miktari,@satisfiyati,@toplamfiyat)", baglanti);
                //  SqlCommand komut = new SqlCommand("INSERT INTO satis(adsoyad,eposta,telno,urunkodu,urunadi,miktari,satisfiyati,toplamfiyat) values(@adsoyad,@eposta,@telno,@urunkodu,@urunadi,@miktari,@satisfiyati,@toplamfiyat)", baglanti);

                komut.Parameters.AddWithValue("@adsoyad", dataGridView1.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@eposta", dataGridView1.Rows[i].Cells["eposta"].Value.ToString());
                komut.Parameters.AddWithValue("@telno", dataGridView1.Rows[i].Cells["telno"].Value.ToString());
                komut.Parameters.AddWithValue("@kart", dataGridView1.Rows[i].Cells["kart"].Value.ToString());
                komut.Parameters.AddWithValue("@kartsifre", dataGridView1.Rows[i].Cells["kartsifre"].Value.ToString());
                komut.Parameters.AddWithValue("@uchane", dataGridView1.Rows[i].Cells["uchane"].Value.ToString());
                komut.Parameters.AddWithValue("@urunkodu", dataGridView1.Rows[i].Cells["urunkodu"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                //    komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["@toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", txtToplamFiyati.Text);

                //   komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                //  SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'"+int.Parse(dataGridView1.Rows[1].Cells["miktari"].Value.ToString())+"' where urunkodu='" + dataGridView1.Rows[1].Cells["barkodno"].Value.ToString() + "'", baglanti);
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where urunkodu='" + dataGridView1.Rows[i].Cells["urunkodu"].Value.ToString() + "'", baglanti);

                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            baglanti.Close();
            Kayıt_Göster();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatısListele listele = new frmSatısListele();
            listele.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtÜrünAdı_TextChanged(object sender, EventArgs e)
        {
          
        
        }

        private void HIZLI_Click(object sender, EventArgs e)
        {

            Form22 hızzz = new Form22();
            hızzz.ShowDialog();
        }

        private void txtToplamFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
       
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
