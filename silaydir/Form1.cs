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

        Random rnd = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imgList.Images[rnd.Next(0, imgList.Images.Count)];
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
    }
}
