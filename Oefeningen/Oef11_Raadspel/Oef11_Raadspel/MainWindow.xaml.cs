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

namespace Oef11_Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gebruikerGetal;
        readonly Random rnd = new ();

        public static class Globals {
            public static int randomGetal = 5;
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEvalueer_Click(object sender, RoutedEventArgs e)
        {
            
            
            bool isGetal = int.TryParse(TxtGetal.Text, out gebruikerGetal);

            if (isGetal)
            {
                if (gebruikerGetal < maakgetal.randomGetal) 
                {

                }
            }
            else
            {
                TxtUitvoer1.Text = "Input is ongeldig";
            }

        }

        private void BtnNieuw_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
