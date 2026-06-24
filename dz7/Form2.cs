namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScreamerForm f = new ScreamerForm();

            f.WindowState = FormWindowState.Maximized;
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopMost = true;

            f.Show();
            
            Timer closeTimer = new Timer();
            closeTimer.Interval = 2000;
            closeTimer.Tick += (s, ev) =>
            {
                closeTimer.Stop();
                f.Close();
            };
            closeTimer.Start();
        }

        
    }
}