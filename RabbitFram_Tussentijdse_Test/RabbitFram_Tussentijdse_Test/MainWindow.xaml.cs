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

namespace RabbitFram_Tussentijdse_Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		//eigen functies
        private int BerekenCapaciteit(int huis, int veld)
        {
            int totaalCapaciteit = huis * 40 + veld * 100;
            return totaalCapaciteit;
        }

        private void WisAlleVelden()
        {
            TxtHuizen.Text = "0";
            TxtVelden.Text = "0";
            TxtSprong.Text = "0";
            TxtMaanden.Text = "0";
            TxtResultaat.Clear();
        }

        public MainWindow()
		{
			InitializeComponent();
		}
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
			WisAlleVelden();
        }

		private void BtnBereken_Click(object sender, RoutedEventArgs e)
		{
			bool huizenIsGetal = int.TryParse(TxtHuizen.Text, out int aantalHuizen);
			bool veldenIsGetal = int.TryParse(TxtVelden.Text, out int aantalVelden);

			int totaalCapaciteit = BerekenCapaciteit(aantalHuizen, aantalVelden);

			if (huizenIsGetal && veldenIsGetal)
			{
				TxtResultaat.Text = $"De totale capactiteit van de boerderij is {totaalCapaciteit} konijnen";
			} else
			{
				MessageBox.Show("Ongeldige input bij aantal huizen of velden", "Ongeldige input",MessageBoxButton.OK,MessageBoxImage.Error);
			}
		}

		private void BtnSimulatie_Click(object sender, RoutedEventArgs e)
		{
			bool huizenIsGetal = int.TryParse(TxtHuizen.Text, out int aantalHuizen);
			bool veldenIsGetal = int.TryParse(TxtVelden.Text, out int aantalVelden);
			bool sprongIsGetal = int.TryParse(TxtSprong.Text, out int aantalSprong);
			bool maandenIsGetal = int.TryParse(TxtMaanden.Text, out int aantalMaanden);
			StringBuilder sb = new StringBuilder();

			// eerst kijken of alles een getal is
			if (huizenIsGetal && veldenIsGetal && sprongIsGetal && maandenIsGetal) {
				int totaalCapaciteit = BerekenCapaciteit(aantalHuizen, aantalVelden);
				double populatie = aantalSprong;

				//iedere maand groei * 1.5
				for (int i = 0; i <= aantalMaanden; i++)
				{
					// pas vanaf de derde maand && als we nog niet aan maximum zitten
					if (i >= 3 && populatie <= totaalCapaciteit)
					{ 
						populatie *= 1.5d;
						populatie = Math.Truncate(populatie);
						
					} else if (populatie > totaalCapaciteit)
					{
						populatie = totaalCapaciteit;
					}

					// toevoegen aan stringbuilder
					sb.AppendLine($"Maand {i}: {populatie}");
					//output resultaat
					TxtResultaat.Text = sb.ToString();
				}
			} else
			{
				MessageBox.Show("Ongeldige input bij aantal huizen, velden, maanden of sprong", "Ongeldige input", MessageBoxButton.OK, MessageBoxImage.Error);			}
		}

		private void BtnWissen_Click(object sender, RoutedEventArgs e)
		{
			WisAlleVelden();
		}

	
	}
}
