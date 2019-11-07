namespace silaydir
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trcSpeed = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trcgreen = new System.Windows.Forms.TrackBar();
            this.trcblue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcblue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "firtina_oncesi_cesme_korfezi.jpg");
            this.imgList.Images.SetKeyName(1, "manzara-fotograflarinda-1-3-kurali-1030x613.jpg");
            this.imgList.Images.SetKeyName(2, "Full-HD-Berrak-Gol-Ve-Harika-1920-X-1080-Manzara-Resmi.jpg");
            this.imgList.Images.SetKeyName(3, "manzara_05_tam35-blogspot-com.jpg");
            this.imgList.Images.SetKeyName(4, "iskele-kuslar-ve-deniz-wallpaper-masaustu-manzara-resmi.jpg");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "|<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(175, 478);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(451, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = ">";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 479);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = ">|";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // trcSpeed
            // 
            this.trcSpeed.Location = new System.Drawing.Point(12, 12);
            this.trcSpeed.Maximum = 1000;
            this.trcSpeed.Minimum = 100;
            this.trcSpeed.Name = "trcSpeed";
            this.trcSpeed.Size = new System.Drawing.Size(776, 45);
            this.trcSpeed.TabIndex = 6;
            this.trcSpeed.Value = 100;
            this.trcSpeed.Scroll += new System.EventHandler(this.TrcSpeed_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 508);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(776, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // trcgreen
            // 
            this.trcgreen.Location = new System.Drawing.Point(12, 610);
            this.trcgreen.Maximum = 255;
            this.trcgreen.Minimum = 1;
            this.trcgreen.Name = "trcgreen";
            this.trcgreen.Size = new System.Drawing.Size(776, 45);
            this.trcgreen.TabIndex = 8;
            this.trcgreen.Value = 1;
            this.trcgreen.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // trcblue
            // 
            this.trcblue.Location = new System.Drawing.Point(12, 559);
            this.trcblue.Maximum = 255;
            this.trcblue.Minimum = 1;
            this.trcblue.Name = "trcblue";
            this.trcblue.Size = new System.Drawing.Size(776, 45);
            this.trcblue.TabIndex = 9;
            this.trcblue.Value = 1;
            this.trcblue.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.trcblue);
            this.Controls.Add(this.trcgreen);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trcSpeed);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcblue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trcSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trcgreen;
        private System.Windows.Forms.TrackBar trcblue;
    }
}

