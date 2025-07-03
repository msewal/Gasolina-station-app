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
using System.Data.OleDb;

namespace GASOLINA
{
    public partial class Form10 : System.Windows.Forms.Form
    {
        

        public Form10()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=GASOLINA\\SQLEXPRESS; Initial Catalog=istasyondakiakaryakit; Integrated Security=true");
        DataSet daset = new DataSet();
  
        
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet24.istasyondakiakaryakit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyondakiakaryakitTableAdapter.Fill(this.gASOLINADataSet24.istasyondakiakaryakit);
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            SqlCommand komut = new SqlCommand("select *from istasyondakiakaryakit where sira= '" + textBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                textBox4.Text = read["akaryakitno"].ToString();
                comboBox1.Text = read["tur"].ToString();
                textBox3.Text = read["Litre"].ToString(); 
                label9.Text = read["Fiyat"].ToString();
               // textBox8.Text = read["alisfiyati"].ToString();
          //      textBox6.Text = read[""].ToString();
                // textBox13.Text = read["tarih"]

            }

            baglanti.Close();

        }
    

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
              SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            //SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1;Initial Catalog=GASOLINA;User ID=sa;Password=54321");


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into istasyondakiakaryakit(sira,akaryakitno,tur,Litre,Fiyat,tarih,DolumuBosmu) values(@sira,@akaryakitno,@tur,@Litre,@Fiyat,@tarih,@DolumuBosmu)", baglanti);
            komut.Parameters.AddWithValue("@sira",textBox1.Text);
            komut.Parameters.AddWithValue("@akaryakitno",textBox4.Text);
            komut.Parameters.AddWithValue("@tur",comboBox1.Text);
            komut.Parameters.AddWithValue("@Litre",textBox3.Text);
            komut.Parameters.AddWithValue("@Fiyat",textBox2.Text);
            komut.Parameters.AddWithValue("@tarih",dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@DolumuBosmu",checkBox1.Checked);
            komut.ExecuteNonQuery();
            baglanti.Close();
          
            MessageBox.Show("Kayıt eklendi.");
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

                if (item is CheckBox)
                {
                    item.Text = "";
                }


            }

            /*
            textBox1.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            checkBox1.Text = "";

            string kad = textBox1.Text;
            string ksad = textBox4.Text;
            string ksinif = comboBox1.Text;
            string tc = textBox3.Text;
            string adres = textBox2.Text;
            string ksod = dateTimePicker1.Text;
            string kod = checkBox1.Text;

              string komut = "insert into istasyondakiakaryakit(sira,akaryakitno,tur,Litre,Fiyat,tarih,DolumuBosmu) values ('" + kad + "','" + ksad + "','" + ksinif + "','" + tc + "','" + adres + "','" + ksod + "','" + kod + "')";
            SqlCommand sorgu = new SqlCommand(komut, baglanti);

            try
            {
                baglanti.Open();
                sorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt Eklendi");
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Ekleme işlemi Yapılamadı");

            }
            */
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            /*
                DataTable tablo = new DataTable();


                SqlDataAdapter adtr = new SqlDataAdapter("select * from istasyondakiakaryakit where tur like '%"+textBox6.Text+"%'",baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;

            */
            SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");

            baglanti.Open();

            

            string sorgu = "select * from istasyondakiakaryakit where tur like '%"+textBox6.Text+"%'";

            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds = new DataSet();

            adap.Fill(ds, "tur");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();

            /*

                string aranan = textBox1.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise;
                                break;
                            }
                        }
                    }
                }

            }*/
            /*

            baglanti.Open();
             DataTable tablo = new DataTable();


            SqlDataAdapter adtr = new SqlDataAdapter("select *from istasyondakiakaryakit where tur like '%"+textBox6.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            */
        }

        private void istasyondakiakaryakitBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 ekle = new Form10();

            ekle.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update istasyondakiakaryakit set Fiyat='" + textBox2.Text + "',Litre='" + textBox3.Text + "' where sira='" + textBox1.Text + "'", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
          
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            MessageBox.Show("Akaryakıt bilgilerinde güncelleme yapıldı.");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");


            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from istasyondakiakaryakit where sira='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            //    DataSet daset = new DataSet();
            komut.ExecuteNonQuery();
            baglanti.Close();
         
            MessageBox.Show("Akaryakıt silindi.");

            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from istasyondakiakaryakit where sira='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
        //    DataSet daset = new DataSet();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Akaryakıt silindi.");
        */
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ekle = new Form7();

            ekle.ShowDialog();
        }
    }
}