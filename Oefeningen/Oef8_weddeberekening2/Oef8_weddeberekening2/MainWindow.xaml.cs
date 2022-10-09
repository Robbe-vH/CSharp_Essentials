using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oef8_weddeberekening2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            double uurloon;
            double aantalUren;

            bool isAantalUrenEengetal = double.TryParse(TxtAantalUren.Text, out aantalUren);
            bool isUurLoonEenGetal = double.TryParse(TxtUurloon.Text, out uurloon);

            if (isAantalUrenEengetal && isUurLoonEenGetal)
            {
                double brutoloon = aantalUren * uurloon;
                double nettoloon

                switch (brutoloon)
                {
                    case > 50000:
                        nettoloon = brutoloon * 0.5;
                        break;
                    case > 25000 and <= 50000:
                        nettoloon = brutoloon * 0.6;
                        break;
                    case > 15000 and <= 25000:
                        nettoloon = brutoloon * 0.7;
                        break;
                    case > 10000 and <= 15000:
                        nettoloon = brutoloon * 0.8;
                        break;
                    default:
                        nettoloon = brutoloon;
                        break;
                }

                 

                string output = $"Naam: {TxtNaam.Text}\n" +
                                $"Brutoloon: {brutoloon}\n" +
                                $"Nettoloon: {nettoloon}";
                TxtResultaat.Text = output;
            }
        }

        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtAantalUren.Clear();
            TxtNaam.Clear();
            TxtResultaat.Clear();
            TxtUurloon.Clear();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
