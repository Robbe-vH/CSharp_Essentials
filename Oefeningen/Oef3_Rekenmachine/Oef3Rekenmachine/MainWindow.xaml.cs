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

namespace Oef3Rekenmachine
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

        //bewerkingknoppen
        public void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

            decimal Getal1 = Convert.ToDecimal(TxtGetal1.Text);
            decimal Getal2 = Convert.ToDecimal(TxtGetal2.Text);


            decimal resultaat = Getal1 + Getal2;
            TxtResultaat.Text = Convert.ToString(resultaat);
        }

        public void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            decimal Getal1 = Convert.ToDecimal(TxtGetal1.Text);
            decimal Getal2 = Convert.ToDecimal(TxtGetal2.Text);

            decimal resultaat = Getal1 - Getal2;
            TxtResultaat.Text = Convert.ToString(resultaat);
        }

        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            decimal Getal1 = Convert.ToDecimal(TxtGetal1.Text);
            decimal Getal2 = Convert.ToDecimal(TxtGetal2.Text);

            if (Getal2 != 0)
            {
                decimal resultaat = Getal1 / Getal2;
                TxtResultaat.Text = Convert.ToString(resultaat);
            }
            else {
                TxtResultaat.Text = "Gedeeld door nul";
            }

            
        }

        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        {
            decimal Getal1 = Convert.ToDecimal(TxtGetal1.Text);
            decimal Getal2 = Convert.ToDecimal(TxtGetal2.Text);

            decimal resultaat = Getal1 * Getal2;
            TxtResultaat.Text = Convert.ToString(resultaat);
        }


        //wisknop
        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtGetal1.Text = "0";
            TxtGetal2.Text = "0";
            TxtResultaat.Text = "0";
        }
    }
}
