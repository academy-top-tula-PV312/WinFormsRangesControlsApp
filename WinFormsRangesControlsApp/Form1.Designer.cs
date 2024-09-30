namespace WinFormsRangesControlsApp
{
    partial class Form1
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
            timerApp = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            btnTimer = new Button();
            btnTimerControl = new Button();
            trackBar1 = new TrackBar();
            labelTrack = new Label();
            progressBar1 = new ProgressBar();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerApp
            // 
            timerApp.Interval = 1000;
            timerApp.Tick += timerApp_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 14F);
            labelTimer.Location = new Point(28, 18);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(63, 25);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "label1";
            // 
            // btnTimer
            // 
            btnTimer.BackColor = Color.Red;
            btnTimer.Location = new Point(97, 18);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(96, 53);
            btnTimer.TabIndex = 1;
            btnTimer.UseVisualStyleBackColor = false;
            // 
            // btnTimerControl
            // 
            btnTimerControl.Font = new Font("Segoe UI", 14F);
            btnTimerControl.Location = new Point(672, 12);
            btnTimerControl.Name = "btnTimerControl";
            btnTimerControl.Size = new Size(116, 46);
            btnTimerControl.TabIndex = 2;
            btnTimerControl.Text = "Start";
            btnTimerControl.UseVisualStyleBackColor = true;
            btnTimerControl.Click += btnTimerControl_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(44, 99);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(422, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelTrack
            // 
            labelTrack.AutoSize = true;
            labelTrack.Font = new Font("Segoe UI", 14F);
            labelTrack.Location = new Point(496, 99);
            labelTrack.Name = "labelTrack";
            labelTrack.Size = new Size(63, 25);
            labelTrack.TabIndex = 4;
            labelTrack.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(44, 128);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(421, 53);
            progressBar1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(44, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 32);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2024, 9, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.AnnuallyBoldedDates = new DateTime[]
    {
    new DateTime(2024, 9, 2, 0, 0, 0, 0),
    new DateTime(2024, 9, 20, 0, 0, 0, 0),
    new DateTime(2024, 9, 4, 0, 0, 0, 0)
    };
            monthCalendar1.BackColor = SystemColors.InactiveCaption;
            monthCalendar1.BoldedDates = new DateTime[]
    {
    new DateTime(2024, 9, 5, 0, 0, 0, 0)
    };
            monthCalendar1.Font = new Font("Segoe UI", 14F);
            monthCalendar1.ForeColor = SystemColors.MenuHighlight;
            monthCalendar1.Location = new Point(44, 245);
            monthCalendar1.MaxSelectionCount = 15;
            monthCalendar1.MonthlyBoldedDates = new DateTime[]
    {
    new DateTime(2024, 9, 15, 0, 0, 0, 0)
    };
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            monthCalendar1.TitleBackColor = Color.Blue;
            monthCalendar1.TitleForeColor = Color.Red;
            monthCalendar1.TrailingForeColor = Color.FromArgb(0, 192, 0);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            monthCalendar1.DateSelected += monthCalendar1_DateChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(505, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(265, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 490);
            Controls.Add(pictureBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(progressBar1);
            Controls.Add(labelTrack);
            Controls.Add(trackBar1);
            Controls.Add(btnTimerControl);
            Controls.Add(btnTimer);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerApp;
        private Label labelTimer;
        private Button btnTimer;
        private Button btnTimerControl;
        private TrackBar trackBar1;
        private Label labelTrack;
        private ProgressBar progressBar1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
    }
}
