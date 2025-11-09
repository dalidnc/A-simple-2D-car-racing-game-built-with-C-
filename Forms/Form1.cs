namespace CarRacingGame
{
    public partial class CarRacing : Form
    {

        public Size MevcutBoyut;

        public CarRacing()
        {
            InitializeComponent();
            MevcutBoyut = this.ClientSize;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move_line(5);
        }

        void move_line(int speed)
        {


            if (pictureBox1.Top >= MevcutBoyut.Height)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;

            }

            if (pictureBox2.Top >= MevcutBoyut.Height)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;

            }

            if (pictureBox3.Top >= MevcutBoyut.Height)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;

            }

            if (pictureBox4.Top >= MevcutBoyut.Height)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;

            }

        }

        private void CarRacing_KeyDown(object sender, KeyEventArgs e)
        {
            int movepx = 55;
            Point CurrentLoc = pbCar.Location;
            pbCar.Location = CurrentLoc;


            if (e.KeyCode == Keys.Right)
            {
                pbCar.Location = new Point(CurrentLoc.X + movepx, CurrentLoc.Y);


            }
            else if (e.KeyCode == Keys.Left)
            {
                pbCar.Location = new Point(CurrentLoc.X - movepx, CurrentLoc.Y);

            }

            //Bariyerler Belirlendi

            if (pbCar.Location.X <= -10)
            {
                pbCar.Location = new Point(12, 554);
            }
            if (pbCar.Location.X >= +490)
            {
                pbCar.Location = new Point(490, 554);
            }






        }

        private void CarRacing_Load(object sender, EventArgs e)
        {
            pbCar.Location = new Point(246, 554);
        }

        private void pbRock_Click(object sender, EventArgs e)
        {

        }
    }
}
