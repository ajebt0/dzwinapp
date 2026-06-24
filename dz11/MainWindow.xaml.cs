using System;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "admin" && tbPassword.Password == "1234")
            {
                LoginGrid.Visibility = Visibility.Collapsed;
                CabinetGrid.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            ProfilePanel.Visibility = Visibility.Visible;
            SettingsPanel.Visibility = Visibility.Collapsed;
            OrdersPanel.Visibility = Visibility.Collapsed;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            ProfilePanel.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Visible;
            OrdersPanel.Visibility = Visibility.Collapsed;
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            ProfilePanel.Visibility = Visibility.Collapsed;
            SettingsPanel.Visibility = Visibility.Collapsed;
            OrdersPanel.Visibility = Visibility.Visible;
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(editFio.Text))
                tbFio.Text = editFio.Text;

            if (!string.IsNullOrWhiteSpace(editEmail.Text))
                tbEmail.Text = editEmail.Text;

            MessageBox.Show("Сохранено!");
        }
    }
}