using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using System.Data.SqlClient;
using System.IO;

namespace GASOLINA
{
    public partial class Form13 : System.Windows.Forms.Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        QRCodeEncoder code = new QRCodeEncoder();
        Image resim;
        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            resim = code.Encode(textBox1.Text);
            pictureBox2.Image = resim;

           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         /*   SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO urun(barkodno,urunadi) values(@barkodno,@urunadi)", baglanti);
        
            komut.Parameters.Add("@barkodno", SqlDbType.Image, barkodno.Length).Value ="barkodno";
            komut.Parameters.AddWithValue("@urunadi", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("QR Kod ürün adıyla birlikte eklendi.");
            foreach (Control item in this.Controls)
            {


                if (item is PictureBox)
                {
                    item.Tag = "";
                }


                if (item is TextBox)
                {
                    item.Text = "";
                }


            }
         */
        }
    }
}
