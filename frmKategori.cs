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
    public partial class frmKategori : System.Windows.Forms.Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(" Data Source = ALABILIŞIM1\\SQL; Initial Catalog = GASOLINA; User ID = sa; Password = 54321");

        bool durum;

        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text==read["kategori"].ToString() || textBox1.Text=="")
                        {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void frmKategori_Load(object sender, EventArgs e) 
        {
            

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('"+textBox1.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Text = "";
            MessageBox.Show("Kategori eklendi.");

            }
            else
            {
                MessageBox.Show("Böyle bir kategori var!","Uyarı");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKategori_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
