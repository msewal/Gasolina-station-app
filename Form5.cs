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
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = Data Source=ALABILIŞIM1\\SQL;User ID=sa");
        private void button3_Click(object sender, EventArgs e)
        {
            BilgileriGüncelle fr = new BilgileriGüncelle();
            fr.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ŞifreGüncelle fr = new ŞifreGüncelle();
            fr.Show();
        }
        Kullanıcı_Form klnc = new Kullanıcı_Form();
        private void button1_Click(object sender, EventArgs e)
        {
            klnc.kullanıcı(textBox1, textBox2);
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
