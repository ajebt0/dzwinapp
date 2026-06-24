using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();

            rect.Width = rnd.Next(50, 150);
            rect.Height = rnd.Next(50, 150);

            rect.Fill = new SolidColorBrush(Color.FromRgb(
                (byte)rnd.Next(256),
                (byte)rnd.Next(256),
                (byte)rnd.Next(256)
            ));

            // случайная позиция
            double x = rnd.Next(0, (int)(MyCanvas.ActualWidth - rect.Width));
            double y = rnd.Next(0, (int)(MyCanvas.ActualHeight - rect.Height));

            Canvas.SetLeft(rect, x);
            Canvas.SetTop(rect, y);

            MyCanvas.Children.Add(rect);
        }
    }
}