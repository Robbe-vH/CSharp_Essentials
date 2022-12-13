using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace TafelsOefenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string inhoudAntwoord = "0";

        // TODO: 2D array voor moeilijke vragen en fouten

        private int eersteGetal = 0;
        private int tweedeGetal = 0;

        private int aantalVragenGedaan = 0;
        private int aantalVragenJuist = 0;
        private int aantalVragenFout = 0;

        private enum Modus { normaal, fouten, moeilijk };

        private Random randomGetal;

        public MainWindow()
        {
            InitializeComponent();
            ZetStartWaardes();
            VernieuwLayout();
            Random randomGetal = new Random();
        }

        #region Reset Functies
        private void VernieuwLayout()
        {
            TxtAantalFout.Text = aantalVragenFout.ToString();
            TxtAantalJuist.Text = aantalVragenJuist.ToString();
            TxtVraagNummer.Text = aantalVragenGedaan.ToString();
            TxtTafel.Text = $"{eersteGetal} x {tweedeGetal} = ";
        }
        private void ZetStartWaardes()
        {
            aantalVragenJuist = 0;
            aantalVragenFout = 0;
            aantalVragenGedaan = 0;
            isMoeilijk = false;
            isFoutenAanHetOefenen = false;
        }

        #endregion

        #region Volgende Vraag
        private void BtnVolgende_Click(object sender, RoutedEventArgs e)
        {
            VolgendeVraag();
        }

        private void TxtAntwoord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                VolgendeVraag();
            }
        }

        private void GenereerGetallenVoorVolgendeVraag()
        {
            // TODO: Stel de waardes eersteGetal en tweedeGetal in afhankelijk van de modus (normaal, fouten oefenen, moeilijk).
            //       Gebruik
            switch (Modus)
            {
                default:
                    break;
            }
        }

        private void VolgendeVraag()
        {
            if ()
            {
                TxtAntwoord.Background = Brushes.White;
            }
            if (aantalVragenGedaan == 0)
            {
                // De eerste vraag wordt gegenereerd.
                // Het antwoord moet niet gevalideerd worden.
                GenereerGetallenVoorVolgendeVraag();
            }
            else
            {
                if (IsAntwoordCorrect())
                {
                    aantalVragenJuist++;
                    ToonJuist();
                }
                else
                {
                    // TODO: sla de opgave op die fout beantwoord was in de aangemaakte 2D array
                    aantalVragenFout++;
                    ToonFout();
                }
                // TODO: controleer of :
                //                  Als:    de tiende vraag beantwoord is
                //                          OF de laatste foute opgave beantwoord is
                //                  Dan:    Ronde afgelopen: reset waardes + enable buttons
                //                          Als:    speler fouten is aan het oefenen
                //                          Dan:    verwijder alle opgaves uit de 2D array van fouten
                //                  Anders: GenereerGetallenVoorVolgendeVraag()
            }
            VernieuwLayout();
            TxtAntwoord.Focus();
            TxtAntwoord.SelectAll();
            aantalVragenGedaan++; //!
        }

        #endregion

        #region Juist Fout
        private void ResetJuistEnFout()
        {
            MessageBox.Show(
                $"Je had {aantalVragenFout} vragen fout en {aantalVragenJuist} vragen juist. Blijf verder oefenen en wordt de tafel-koninging.",
                "Doe zo voort");
            aantalVragenFout = 0;
            aantalVragenJuist = 0;
        }

        private bool IsAntwoordCorrect()
        {
            // TODO: controleer het antwoord
            return true;
        }

        private void ToonFout()
        {
            MessageBox.Show(
                $"Het antwoord was niet {TxtAntwoord.Text}." +
                $"\n\n{eersteGetal} x {tweedeGetal} = {eersteGetal * tweedeGetal}" +
                $"\n\nTom gelooft in jou.",
                "Volgende Keer Beter");
        }

        private void ToonJuist()
        {
            MessageBox.Show(
                $"Het antwoord is correct." +
                $"\n\nTom wist dat je het kon.",
                "PERFECT !");
        }

        #endregion

        #region EventHandlers
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(TxtAntwoord.Text, out int getal))
            {
                inhoudAntwoord = TxtAntwoord.Text;
            }
            else if (string.IsNullOrEmpty(TxtAntwoord.Text))
            {
                inhoudAntwoord = "0";
            }
            else
            {
                TxtAntwoord.Text = inhoudAntwoord;
                TxtAntwoord.CaretIndex = inhoudAntwoord.Length;
            }
        }
        private void BtnFoutenOefenen_Click(object sender, RoutedEventArgs e)
        {
            TxtAntwoord.Background = Brushes.Green;
            isFoutenAanHetOefenen = true;
            aantalVragenGedaan = 0;
            VolgendeVraag();
            BtnFoutenOefenen.IsEnabled = false;
        }

        private void BtnMoeilijk_Click(object sender, RoutedEventArgs e)
        {
            TxtAntwoord.Background = Brushes.Orange;
            Modus 
            aantalVragenGedaan = 0;
            VolgendeVraag();
            BtnMoeilijk.IsEnabled = false;
        }

        #endregion

    }


}
