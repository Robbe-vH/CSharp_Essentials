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
using System.Xml.XPath;

namespace Oefening_29_Rekenmachine2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal1;
        int getal2;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HaalGetallen(string eersteGetal, string tweedeGetal)
        {
            getal1 = Convert.ToInt32(eersteGetal);
            getal2 = Convert.ToInt32(tweedeGetal);
        }
        private int Berekening(char operatie)
        {
            switch (operatie)
            {
                case '+':
                    return getal1 + getal2;
                    //break;
                case '-':
                    return getal1 - getal2;
                    //break;
                case ':':
                    return getal1 / getal2;
                    //break;
                case '*':
                    return getal1 * getal2;
                    //break;
                default:
                    return 0;
                    // break;
            }
        }
 

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            HaalGetallen(TxtEersteGetal.Text, TxtTweedeGetal.Text);
            TxtResultaat.Text = Convert.ToString(Berekening('+'));
        }
        private void BtnMaal_Click(object sender, RoutedEventArgs e)
        {
            HaalGetallen(TxtEersteGetal.Text, TxtTweedeGetal.Text);
            TxtResultaat.Text = Convert.ToString(Berekening('*'));
        }
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            HaalGetallen(TxtEersteGetal.Text, TxtTweedeGetal.Text);
            TxtResultaat.Text = Convert.ToString(Berekening('-'));
        }
        private void BtnDeel_Click(object sender, RoutedEventArgs e)
        {
            HaalGetallen(TxtEersteGetal.Text, TxtTweedeGetal.Text);
            TxtResultaat.Text = Convert.ToString(Berekening(':'));
        }

        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtEersteGetal.Clear();
            TxtTweedeGetal.Clear();
            TxtResultaat.Clear();
        }

        
    }
}
