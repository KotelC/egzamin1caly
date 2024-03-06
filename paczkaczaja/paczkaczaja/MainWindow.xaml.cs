using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace paczkaczaja
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SprawdzCeneButton_Click(object sender, RoutedEventArgs e)
        {
            if (PocztowkaRadioButton.IsChecked == true)
            {
                Obraz.Source = new BitmapImage(new Uri("pocztowka.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 1 zł";
            }
            else if (ListRadioButton.IsChecked == true)
            {
                Obraz.Source = new BitmapImage(new Uri("list.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 1,5 zł";
            }
            else if (PaczkaRadioButton.IsChecked == true)
            {
                Obraz.Source = new BitmapImage(new Uri("paczka.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 10 zł";
            }
        }

        private void ZatwierdzButton_Click(object sender, RoutedEventArgs e)
        {
            if (KodPocztowyTextBox.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
            }
            else if (!KodPocztowyTextBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
            }
            else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone");
            }
        }
    }
}