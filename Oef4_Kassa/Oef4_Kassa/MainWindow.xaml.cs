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

namespace Oef4_Kassa
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

        //  1. controleren of het 10 cijfers zijn
        //  2. nummer zonder laatste 2 getallen delen door 97 (integer)
        //  3. 97 aftrekken door quotient
        //  4. 
        private void BtnControleCijfer_Click(object sender, RoutedEventArgs e)
        {
            int ondernemingsNummer = Convert.ToInt32(TxtOndernemingsnummer.Text);
            int controleNummer = 97 - (ondernemingsNummer % 97);
            TxtControleNummer.Text = controleNummer.ToString();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtControleNummer.Clear();
            TxtOndernemingsnummer.Clear();
            TxtAantal.Clear();
            TxtBetalen.Clear();
            TxtPrijs.Clear();
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            //  getallen uit veld halen naar decimaal
            //  prijs maal aantal > txtBetalen.Text

            double teBetalen = Convert.ToDouble(TxtPrijs.Text) * Convert.ToDouble(TxtAantal.Text);
            TxtBetalen.Text = Convert.ToString(Math.Round(teBetalen,2)); 
        }

        //  TODO



        //  Wisknop
        //  TxtVeld.Clear();
    }
}
