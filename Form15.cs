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
    public partial class Form15 : System.Windows.Forms.Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem)
            {
                this.Opacity += 0.009;

                }
                if (this.Opacity == 1.0)
                {
                    islem = true;
                }
                if (islem)
                {
                    this.Opacity -= 0.009;
                    if (this.Opacity == 0)
                    {

                        ilkForm show = new ilkForm();
                        show.Show();
                        timer1.Enabled = false;
                        
                    }
                }
           
         
    }
        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
