
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int index = 0;

        private Color[] colors = new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Orange,
            Color.Purple,
            Color.Pink,
            Color.Cyan,
            Color.Lime,
            Color.Gray
        };

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = colors[index];

            index++;
            if (index >= colors.Length)
                index = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}