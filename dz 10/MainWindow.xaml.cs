
using System.IO;
using System.Windows;
using Microsoft.Win32;

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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                textBox.Text = text;
            }
        }
    }
}