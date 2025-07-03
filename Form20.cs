using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GASOLINA
{
    public partial class MüşteriGirişi : System.Windows.Forms.Form
    {
        public MüşteriGirişi()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgileriGüncelle şifre = new BilgileriGüncelle();
            şifre.ShowDialog();
        }
        Class1 k = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            }

        private void button3_Click(object sender, EventArgs e)
        {
            k.yenikullanıcı(kullanıcıadıtxt, TelefonNumarasıtxt, EPostatxt, Şifretxt, Bankatxt, Kartşifretxt, Üçhanetxt, groupBox2);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ŞifreGüncelle şifre = new ŞifreGüncelle();
            şifre.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ilkForm ekle = new ilkForm();
            ekle.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            k.kullanıcı(kullanıcıadı1txt, Şifre1txt);
        }

        private void kullanıcıadı1txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
