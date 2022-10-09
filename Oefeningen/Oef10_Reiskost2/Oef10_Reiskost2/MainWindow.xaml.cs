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

namespace Oef10_Reiskost2
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
            // vars uit txtboxes halen en kijken of het getallen zijn
            string bestemming = TxtBestemming.Text;

            float basisVluchtPrijs;
            bool isVluchtPrijsGetal = Single.TryParse(TxtBasisvluchtprijs.Text, out basisVluchtPrijs);

            int vluchtKlasse;
            bool isVluchtKlassegetal = int.TryParse(TxtVluchtklassse.Text, out vluchtKlasse);

            float basisDagPrijs;
            bool isDagPrijsGetal= Single.TryParse(TxtBasisDagprijs.Text, out basisDagPrijs);

            int aantalDagen;
            bool isAantalDagenGetal= int.TryParse(TxtAantalDagen.Text, out aantalDagen);

            int aantalPersonen;
            bool isPersonenGetal = int.TryParse(TxtAantalPersonen.Text, out aantalPersonen);

            float kortingsPercentage;
            bool isKortingGetal = float.TryParse(TxtKortingspercentage.Text, out kortingsPercentage);
            float totaalVluchtprijs;
            float totaalVerblijfprijs;
            float totaalDagprijs;

            // kijken of getallen zijn ingevoerd
            if (isVluchtPrijsGetal && isVluchtKlassegetal && isDagPrijsGetal && isAantalDagenGetal && isPersonenGetal)   
            {
                kortingsPercentage = 1 - kortingsPercentage / 100;
                // prijs berekenen van vlucht
                totaalVluchtprijs = basisVluchtPrijs * aantalPersonen;

                switch (vluchtKlasse)
                {
                    case 1:
                        totaalVluchtprijs = totaalVluchtprijs * 1.3f;
                        break;
                    case 3:
                        totaalVluchtprijs = totaalVluchtprijs * 0.8f;
                        break;
                    default:
                        break;
                }

                //verblijfprijs berekenen
                if (aantalPersonen == 3)
                {
                    totaalDagprijs = (basisDagPrijs * 2f) + (basisDagPrijs * 0.5f);
                }
                else if (aantalPersonen > 3)
                {
                    int aantalKinderen = aantalPersonen - 2;
                    totaalDagprijs = (basisDagPrijs * 2f) + (basisDagPrijs * 0.5f * aantalKinderen);
                }
                else
                {
                    totaalDagprijs = aantalPersonen * basisDagPrijs;
                }

                totaalVerblijfprijs = totaalDagprijs * aantalDagen * kortingsPercentage;

                //output printen als de berekening is gelukt
                TxtResultaat.Text = $"Bestemming: {bestemming} \n" +
                                    $"Prijs van vluchten: {totaalVluchtprijs} \n" +
                                    $"Prijs van verblijf: {totaalVerblijfprijs}\n";

            }
            else
            {
                TxtResultaat.Text = "Geen getallen ingevoerd ofzo buh";
            }  
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
    }
}
