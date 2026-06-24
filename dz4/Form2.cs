namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int playerScore = 0;
        private int botScore = 0;
        private Random rnd = new Random();
        private bool gameOver = false;

        public Form2()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            int card = rnd.Next(2, 12);
            playerScore += card;

            label1.Text = "Игрок: " + playerScore;

            if (playerScore > 21)
            {
                gameOver = true;
                label3.Text = "Ты проиграл  (перебор)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameOver) return;

            botScore = rnd.Next(15, 23);

            label2.Text = "Бот: " + botScore;

            if (botScore > 21 && playerScore > 21)
            {
                label3.Text = "Ничья ";
            }
            else if (botScore > 21)
            {
                label3.Text = "Ты победил ";
            }
            else if (playerScore > 21)
            {
                label3.Text = "Ты проиграл ";
            }
            else if (playerScore > botScore)
            {
                label3.Text = "Ты победил ";
            }
            else if (playerScore < botScore)
            {
                label3.Text = "Ты проиграл ";
            }
            else
            {
                label3.Text = "Ничья ";
            }

            gameOver = true;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}