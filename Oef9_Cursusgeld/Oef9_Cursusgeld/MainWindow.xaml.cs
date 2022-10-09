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

namespace Oef9_Cursusgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LblNumeriek.Content = "";
            LblSchrikkeljaar.Content = "";
        }




        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            bool isSchrikkeljaar;
            int jaar;
            int aantalLesuren;
            bool isJaarGetal = int.TryParse(TxtJaar.Text, out jaar);
            bool isAantalUrenEenGetal = int.TryParse(TxtAantalLesuren.Text, out aantalLesuren);
            double inschrijvingsgeld;
            

            if (isJaarGetal && isAantalUrenEenGetal)
            {
                // kijken of het een schrikkeljaar is, deelbaar door 4, eeuwen deelbaar door 400
                if (jaar % 4 == 0 && jaar % 100 != 0)
                {
                    isSchrikkeljaar = true;
                    LblSchrikkeljaar.Content = "Het is een schrikkeljaar";
                }
                else if (jaar % 4 == 0 && jaar % 400 == 0)
                {
                    isSchrikkeljaar = true;
                    LblSchrikkeljaar.Content = "Het is een schrikkeljaar";
                }
                else
                {
                    isSchrikkeljaar = false;
                    LblSchrikkeljaar.Content = "";
                }
                // inschrijvingsgeld berekenen 
                // 1.5 euro per lesuur, schrikkeljaar is 1 uur extra
                if (isSchrikkeljaar)
                {
                    aantalLesuren += 1;
                }

                inschrijvingsgeld = aantalLesuren * 1.5;
                // Output printen
                TxtInschrijvingsGeld.Text = Convert.ToString(inschrijvingsgeld);
            }






        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnIsnNumeriek_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TxtJaar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // is het aantal uren een getal of string
            double jaartal;

            if (double.TryParse(TxtJaar.Text, out jaartal))
            {
                LblNumeriek.Content = "";
            }
            else
            {
                LblNumeriek.Content = "Jaartal is niet numeriek!";
            }
        }
    }

}
