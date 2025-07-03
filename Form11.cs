using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASOLINA
{
    public partial class Form11 : System.Windows.Forms.Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dsvfadgvToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 ekle = new Form10();

            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 ekle = new Form12();

            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ac = new Form8();

            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ekle = new Form4();

            ekle.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet46.istasyondakiakaryakit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyondakiakaryakitTableAdapter.Fill(this.gASOLINADataSet46.istasyondakiakaryakit);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ilkForm ekle = new ilkForm();

            ekle.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into istasyondakiakaryakit where Fiyat", baglanti);
            komut.Parameters.AddWithValue("@Fiyat", textBox3.Text);
            komut.ExecuteNonQuery();

            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from istasyondakiakaryakit", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            

            while (read.Read())
            {
                if(komut.Parameters.AddWithValue["Otogaz"].ToString() == ["Fiyat"].textBox3.Text.ToString())
                {
                    textBox3.Items.Add(read["Fiyat"].ToString());
                }

            }

            baglanti.Close();
            */
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            Form26 acc = new Form26();
            acc.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            Form27 acc = new Form27();
            acc.ShowDialog();
        }
    }
}
