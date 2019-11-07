using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silaydir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        int index = 0;
        Random rnd = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            index = rnd.Next(0, imgList.Images.Count);
            pictureBox1.Image = imgList.Images[index];
        }

        private void TrcSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trcSpeed.Value;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            int red = trackBar1.Value;
            int blue = trcblue.Value;
            int green = trcgreen.Value;

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index++;
            if (index == imgList.Images.Count) // bunu yapıyoruz çünkü tuşa bastıkça sayı artacak ve bu sefer maksimum indexi geçeceğinden proje patlayacaktır. O yüzden seriyi tekrardan başa döndürmek gerek
            {
                index = 0;
            }
            pictureBox1.Image = imgList.Images[index];
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index = imgList.Images.Count - 1;
            pictureBox1.Image = imgList.Images[index];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index--;
            if (index == -1)
            {
                index = imgList.Images.Count - 1;
            }
            pictureBox1.Image = imgList.Images[index];
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Image = imgList.Images[0];
        }
    }
}
