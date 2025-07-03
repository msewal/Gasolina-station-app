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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        string resimPath;

        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");

        bool durum;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Resim aç";
            openFileDialog2.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası(*.tif)|*.tif";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                resimPath = openFileDialog2.FileName.ToString();
            }
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL;Initial Catalog = GASOLINA; User ID = sa; Password=54321");
            baglanti.Open();

            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            SqlCommand komut = new SqlCommand("insert into istasyon(istasyonadi,istasyonresmi,istasyonadresi) values(@istasyonadi,@istasyonresmi,@istasyonadresi)", baglanti);
            komut.Parameters.Add("@istasyonresmi", SqlDbType.Image, resim.Length).Value = resim;
           
            komut.Parameters.AddWithValue("@istasyonadi", textBox1.Text);

            komut.Parameters.AddWithValue("@istasyonadresi", textBox2.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İstasyon eklendi.");

            }

        }
    }

