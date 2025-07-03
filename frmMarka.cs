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
    public partial class frmMarka : System.Windows.Forms.Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

        bool durum;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            markaengelle();
            if (durum == true)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(kategori,marka) values('" + comboBox1.Text + "','" + textBox5.Text + "')", baglanti);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Marka eklendi.");
            }

        

            else
            {
                MessageBox.Show("Marka eklenemedi çünkü böyle bir kategori ve marka var.","Uyarı");
            }
            comboBox1.Text = "";
            textBox5.Text = "";
    
           
        }

      
        
        private void kategorigetir() {
            /*  SqlConnection baglanti = new SqlConnection("Data Source=GASOLINA\\SQLEXPRESS; Initial Catalog=markabilgileri Integrated Security = true");
              baglanti.Open();
                  SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
                  SqlDataReader read = komut.ExecuteReader();
                      comboBox1.Items.Add(read["kategori"].ToString());
              komut.ExecuteNonQuery();
              baglanti.Close();
            */
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            
           while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
              
               
            }

            baglanti.Close();

        }
        private void frmMarka_Load(object sender, EventArgs e)
        {

            // 
            kategorigetir();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void markaengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["kategori"].ToString() && textBox5.Text == read["marka"].ToString() || comboBox1.Text=="" || textBox5.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
