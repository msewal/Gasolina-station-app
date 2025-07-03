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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALABILIŞIM1\\SQL;Initial Catalog=GASOLINA;User ID=sa;Password=54321");
        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet48.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter1.Fill(this.gASOLINADataSet48.urun);
         
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun",baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunadi='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (dr["urunadi"]!=null)
                {

                    label2.Text = dr["urunkodu"].ToString();
                    label3.Text = dr["kategori"].ToString();
                   label4.Text = dr["marka"].ToString();
                  label5.Text = dr["satisfiyati"].ToString();
                  label6.Text = dr["tarih"].ToString();
                    label7.Text = dr["urunadi"].ToString();
                }
                if (dr["urunresmi"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["urunresmi"];
                    MemoryStream memoryStream = new MemoryStream(resim);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                   
                }

                if (dr["barkodno"] != null)
                {
                    byte[] resim2 = new byte[0];
                    resim2 = (byte[])dr["barkodno"];
                    MemoryStream memoryStream1 = new MemoryStream(resim2);
                    pictureBox2.Image = Image.FromStream(memoryStream1);
                    dr.Close();
                    komut.Dispose();
                    baglanti.Close();
                }
            }
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
