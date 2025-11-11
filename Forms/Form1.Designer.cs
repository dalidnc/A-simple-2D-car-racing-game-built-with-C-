namespace CarRacingGame
{
    partial class CarRacing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarRacing));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pbLeftBarrier = new PictureBox();
            pbRightBarrier = new PictureBox();
            pbCar = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbRock = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftBarrier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRightBarrier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(273, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 142);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(273, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 142);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(273, 330);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 142);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(273, 499);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(17, 142);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pbLeftBarrier
            // 
            pbLeftBarrier.BackColor = Color.White;
            pbLeftBarrier.Location = new Point(1, 1);
            pbLeftBarrier.Name = "pbLeftBarrier";
            pbLeftBarrier.Size = new Size(10, 645);
            pbLeftBarrier.TabIndex = 4;
            pbLeftBarrier.TabStop = false;
            // 
            // pbRightBarrier
            // 
            pbRightBarrier.BackColor = Color.White;
            pbRightBarrier.Location = new Point(565, 2);
            pbRightBarrier.Name = "pbRightBarrier";
            pbRightBarrier.Size = new Size(10, 644);
            pbRightBarrier.TabIndex = 5;
            pbRightBarrier.TabStop = false;
            // 
            // pbCar
            // 
            pbCar.BackColor = Color.Transparent;
            pbCar.Image = (Image)resources.GetObject("pbCar.Image");
            pbCar.Location = new Point(246, 554);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(73, 92);
            pbCar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCar.TabIndex = 6;
            pbCar.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(65, 233);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(74, 58);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(404, 233);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(61, 58);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pbRock
            // 
            pbRock.BackColor = Color.Transparent;
            pbRock.Image = (Image)resources.GetObject("pbRock.Image");
            pbRock.Location = new Point(78, 1);
            pbRock.Name = "pbRock";
            pbRock.Size = new Size(72, 87);
            pbRock.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRock.TabIndex = 9;
            pbRock.TabStop = false;
            pbRock.Click += pbRock_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(404, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 96);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // CarRacing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Gray;
            ClientSize = new Size(575, 646);
            Controls.Add(pictureBox5);
            Controls.Add(pbRock);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pbCar);
            Controls.Add(pbRightBarrier);
            Controls.Add(pbLeftBarrier);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CarRacing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CarRacing_Load;
            KeyDown += CarRacing_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLeftBarrier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRightBarrier).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pbLeftBarrier;
        private PictureBox pbRightBarrier;
        private PictureBox pbCar;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbRock;
        private PictureBox pictureBox5;
    }
}
