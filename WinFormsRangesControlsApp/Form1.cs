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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTrack.Text = trackBar1.Value.ToString();
        }
    }
}
