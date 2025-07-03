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
    public partial class Form22 : Form
    {
        public Form22()
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

                }
            }
        }
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
        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + " TL ";
                baglanti.Close();
            }
            catch (Exception)
            {


            }


        }

        private void Form22_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet51.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter1.Fill(this.gASOLINADataSet51.sepet);
      
           
            sepetlistele();

            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(tbl);
            dataGridView3.DataSource = tbl;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtÜrünAdı_TextChanged(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            // SqlCommand komut = new SqlCommand("select *from musteriEkle", baglanti);
            SqlCommand komut = new SqlCommand("select *from urun", baglanti); 
            SqlDataReader read = komut.ExecuteReader();
            if (txtÜrünAdı.Text == "@urunadi")
            {
                      
                txtBarkodNo.Text = read["urunkodu"].ToString();
               // txtMiktari.Text = read["miktari"].ToString();
              txtSatışFiyati.Text = read["satisfiyati"].ToString();
                txtToplamFiyati.Text = "";

            }
           while(read.Read())
            {
                txtBarkodNo.Text = read["urunkodu"].ToString();
                // txtMiktari.Text = read["miktari"].ToString();
                txtSatışFiyati.Text = read["satisfiyati"].ToString();
                txtToplamFiyati.Text = "";
            }

            baglanti.Close();
            //daset.Tables["musteriEkle"].Clear();
            sepetlistele();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {

                }
            }
            */
        }
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunadi='" + dataGridView3.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["urunadi"] != null)
                {

                    txtÜrünAdı.Text = dr["urunadi"].ToString();
                    txtBarkodNo.Text = dr["urunkodu"].ToString();

                    txtSatışFiyati.Text = dr["satisfiyati"].ToString();

                }

            }
            SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where urunkodu='" + txtBarkodNo.Text + "'", baglanti);
        
            
            baglanti.Close();
        }
        private void txtToplamFiyati_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
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

                SqlCommand komut3 = new SqlCommand("update sepet set miktari*satisfiyati where urunkodu='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                // urunkodu
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

        private void btnSatışYap_Click(object sender, EventArgs e)
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
            Kayıt_Göster();
            MessageBox.Show("Satış gerçekleşti.","Bilgilendirme");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            baglanti.Close();
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

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyati.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatışFiyati.Text)).ToString();


            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form22 ekle = new Form22();

            ekle.ShowDialog();
        }
    }
}