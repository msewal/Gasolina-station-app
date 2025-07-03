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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace GASOLINA
{
    public partial class Form12 : System.Windows.Forms.Form
    {
        FilterInfoCollection webcam;
        VideoCaptureDevice cam;

        public Form12()
        {
            InitializeComponent();
        }


        private void Form12_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo dev in webcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void cam_NewCam(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = ((Bitmap)eventArgs.Frame.Clone());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame+=new NewFrameEventHandler(cam_NewCam);
            cam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barkod = new BarcodeReader();
            if (pictureBox1.Image != null)
            {
                Result res = barkod.Decode((Bitmap)pictureBox1.Image);
                try
                {
                    string dec = res.ToString().Trim();
                    if(dec!="")
                    {
                        timer1.Stop();
                        textBox1.Text = dec;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cam!=null)
                if (cam.IsRunning == true)
                {
                    cam.Stop();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 ekle = new Form13();
            ekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 ekle = new Form13();
            cam.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 ekle = new Form11();

            ekle.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
