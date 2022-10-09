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

namespace Oef6_Weddeberekening
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            TxtNaam.Text = "Ellen De Cooman";
            TxtUurloon.Text = "17.85";
            TxtaantalUren.Text = "1686";
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            double uurloon = Convert.ToDouble(TxtUurloon.Text);
            double aantal = Convert.ToDouble(TxtaantalUren.Text);
            string naam = TxtNaam.Text;

            double berekendLoon = (uurloon * aantal) * 0.70;

            string resultaat = "Naam: " + naam + "\r\n" + "Jaarloon: " + berekendLoon + " Euro";
            TxtResultaat.Text = resultaat;
        }
    }
}


//  bij load, standaardwaarden invoeren
//  btnBereken: jaarwedde berekenen *0.70
//  Btnwis: standaardwaarden terug instellen
//  TxtResultaat niet bewerkbaar