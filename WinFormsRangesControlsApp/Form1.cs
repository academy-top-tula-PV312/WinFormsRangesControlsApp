namespace WinFormsRangesControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //trackBar1.Minimum = -100;
            //trackBar1.Maximum = 100;
            //trackBar1.TickFrequency = 10;
            //trackBar1.TickStyle = TickStyle.BottomRight;
            //trackBar1.Orientation = Orientation.Vertical;
            //trackBar1.Height = 100;
            try
            {
                Image image = Image.FromFile("ada.jpg");

                int scale = 3;
                var width = image.Width / scale;
                var height = image.Height / scale;

                pictureBox1.Width = width;
                pictureBox1.Height = height;

                pictureBox1.Image = image; //Image.FromFile("ada.jpg");
                pictureBox1.ErrorImage = Image.FromFile("error.jpg");
            }
            finally
            {

            }


        }

        private void timerApp_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToLongTimeString();
            btnTimer.Left += 5;
            progressBar1.Value += 5;
        }

        private void btnTimerControl_Click(object sender, EventArgs e)
        {
            if (timerApp.Enabled)
            {
                timerApp.Stop();
                btnTimerControl.Text = "Start";
            }
            else
            {
                timerApp.Start();
                btnTimerControl.Text = "Stop";
            }

            dateTimePicker1.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrack.Text = trackBar1.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelTrack.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string dateRange = e.Start.ToLongDateString() + " " + e.End.ToLongDateString();
            labelTrack.Text = dateRange;


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            string coords = $"X:{e.Location.X} | Y: {e.Location.Y}";
            labelTrack.Text = coords;
        }
    }
}
