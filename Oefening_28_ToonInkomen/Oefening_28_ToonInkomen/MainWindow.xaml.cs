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

namespace Oefening_28_ToonInkomen
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

        private string BerekenInkomen(int jaarSalaris, int aantalJaren)
        {
            int totaalSalaris = jaarSalaris * aantalJaren;

            return Convert.ToString(totaalSalaris);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TxtInkomen.Text = BerekenInkomen(Convert.ToInt32(TxtSalaris.Text), Convert.ToInt32(TxtAantaljaren.Text));
        }
    }
}
