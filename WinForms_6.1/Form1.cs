

namespace WinForms_6._1
{
    public partial class Form1 : Form
    {
        DateTime voteTime = new DateTime(2024, 1, 1, 1, 0, 0);

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            label1.Text = TimeRemaining.Days + " : " + TimeRemaining.Hours + " : " + TimeRemaining.Minutes + " : " + TimeRemaining.Seconds;
        }
    }
}