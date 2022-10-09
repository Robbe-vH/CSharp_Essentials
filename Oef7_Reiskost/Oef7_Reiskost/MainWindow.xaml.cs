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

namespace Oef7_Reiskost
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TxtVluchtInfo.Visibility = Visibility.Collapsed;

            TxtBestemming.Clear();
            TxtBasisvluchtprijs.Clear();
            TxtVluchtklassse.Clear();
            TxtBasisDagprijs.Clear();
            TxtAantalDagen.Clear();
            TxtAantalPersonen.Clear();
            TxtKortingspercentage.Clear();
            TxtResultaat.Clear();
        }

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            // vars uit txtboxes
            string bestemming = TxtBestemming.Text;
            float basisVluchtPrijs = Convert.ToSingle(TxtBasisvluchtprijs.Text);
            int vluchtKlasse = Convert.ToInt32(TxtVluchtklassse.Text);
            float basisDagPrijs = Convert.ToSingle(TxtBasisDagprijs.Text);
            int aantalDagen = Convert.ToInt32(TxtAantalDagen.Text);
            int aantalPersonen = Convert.ToInt32(TxtAantalPersonen.Text);
            float kortingsPercentage = 1 - (Convert.ToSingle(TxtKortingspercentage.Text) / 100);

            // prijs berekenen
            float totaalVluchtprijs = basisVluchtPrijs * vluchtKlasse * aantalPersonen;
            float totaalVerblijfprijs = (basisDagPrijs * aantalPersonen * aantalDagen) * kortingsPercentage;



            //output printen
            TxtResultaat.Text = $"Bestemming: {bestemming} \n" +
                                $"Prijs van vluchten: {totaalVluchtprijs} \n" +
                                $"Prijs van verblijf: {totaalVerblijfprijs}\n";
        }

        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtBestemming.Clear();
            TxtBasisvluchtprijs.Clear();
            TxtVluchtklassse.Clear();
            TxtBasisDagprijs.Clear();
            TxtAantalDagen.Clear();
            TxtAantalPersonen.Clear();
            TxtKortingspercentage.Clear();
            TxtResultaat.Clear();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TxtVluchtklassse_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtVluchtInfo.Visibility = Visibility.Visible;
        }

        private void TxtVluchtklassse_LostFocus(object sender, RoutedEventArgs e)
        {
            TxtVluchtInfo.Visibility = Visibility.Collapsed;
        }
    }
}
