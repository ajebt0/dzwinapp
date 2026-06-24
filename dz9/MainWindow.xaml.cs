
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
    
            BitmapImage image = new BitmapImage(
                new Uri("pack://application:,,,/img.png"));


            DrawingVisual dv = new DrawingVisual();

            using (DrawingContext dc = dv.RenderOpen())
            {

                dc.DrawImage(image, new Rect(50, 50, 300, 200));
            }

            RenderTargetBitmap bmp = new RenderTargetBitmap(
                800, 450, 96, 96, PixelFormats.Pbgra32);

            bmp.Render(dv);

            imgCanvas.Source = bmp;
        }
    }
}