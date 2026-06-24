
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private Image originalImage;

        public Form2()
        {
            InitializeComponent();

            
            originalImage = pictureBox1.Image;

            trackBar1.Scroll += trackBar1_Scroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            int scale = trackBar1.Value;

            int newWidth = originalImage.Width * scale / 100;
            int newHeight = originalImage.Height * scale / 100;

            Bitmap resized = new Bitmap(originalImage, new Size(newWidth, newHeight));

            pictureBox1.Image = resized;
        }
    }
}