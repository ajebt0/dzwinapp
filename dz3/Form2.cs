namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private bool isDead = false;

        public Form2()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isDead) return;

            progressBar1.Value = Math.Max(0, progressBar1.Value - 2); 
            progressBar2.Value = Math.Max(0, progressBar2.Value - 2); 
            progressBar3.Value = Math.Max(0, progressBar3.Value - 1); 

            CheckDeath();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (isDead) return;

            progressBar1.Value = Math.Min(100, progressBar1.Value + 15);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (isDead) return;

            progressBar2.Value = Math.Min(100, progressBar2.Value + 15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isDead) return;

            progressBar3.Value = Math.Min(100, progressBar3.Value + 15);
        }

        private void CheckDeath()
        {
            if (progressBar1.Value == 0 ||
                progressBar2.Value == 0 ||
                progressBar3.Value == 0)
            {
                isDead = true;
                timer1.Stop();

                label1.Text = "Питомец умер 💀";

                MessageBox.Show("Ваш питомец умер!", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e) { }
        private void progressBar3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}