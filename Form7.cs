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
using System.Windows.Forms.DataVisualization.Charting;
namespace GASOLINA
{
    public partial class Form7 : System.Windows.Forms.Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALABILIŞIM1\\SQL; Initial Catalog = GASOLINA; User ID = sa; Password=54321");


        private void fillchart()
        {
            /*
            DataSet ds=new DataSet();
          baglanti.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select *from istasyondakiakaryakit", baglanti);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["istasyondakiakaryakit"].XValueMember = "@tur";
                chart1.Series["istasyondakiakaryakit"].YValueMembers = "@Litre";
           
            chart1.Titles.Add("Akaryakıt Miktarı");
            baglanti.Close();
            */
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sira, Litre from istasyondakiakaryakit",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read()){
                chart2.Series["istasyondakiakaryakit"].Points.AddXY(read["sira"].ToString(), read["Litre"].ToString());
                chart2.Series["istasyondakiakaryakit"].XValueMember = "@sira";
                chart2.Series["istasyondakiakaryakit"].YValueMembers = "@Litre";
            }
            baglanti.Close();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'gASOLINADataSet36.istasyondakiakaryakit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.istasyondakiakaryakitTableAdapter.Fill(this.gASOLINADataSet36.istasyondakiakaryakit);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            fillchart();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            /*
            DataSet ds = new DataSet();
            baglanti.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select tur,Litre from istasyondakiakaryakit", baglanti);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["istasyondakiakaryakit"].XValueMember = "tur";
            chart1.Series["istasyondakiakaryakit"].YValueMembers = "litre";
            chart1.Titles.Add("Akaryakıt Miktarı");
            baglanti.Close();
        */

            fillchart();
        }
    }
}

    

