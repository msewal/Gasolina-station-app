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
    public partial class ilkForm : System.Windows.Forms.Form
    {
        public ilkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Girişvekayıt ekle = new Girişvekayıt();

            ekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Girişvekayıt ekle = new Girişvekayıt();

            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüşteriGirişi ekle = new MüşteriGirişi();
            ekle.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void ilkForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form23 ekle = new Form23();

            ekle.ShowDialog();
        }
    }
}
