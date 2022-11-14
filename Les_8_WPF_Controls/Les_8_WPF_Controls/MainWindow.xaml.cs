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

namespace Les_8_WPF_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // BtnVerwerk.Visibility = Visibility.Collapsed;
            // Paneel.Background = Brushes.PeachPuff;

            // TxtInput.Text = "regel 1 \n" + "regel 2 \n" + "regel 3";
        }

        private void MnItemFill_Click(object sender, RoutedEventArgs e)
        {
            ImgCornflakes.Stretch = Stretch.Fill;
        }

        private void MnItemStretch_Click(object sender, RoutedEventArgs e)
        {
            ImgCornflakes.Stretch = Stretch.UniformToFill;
        }

        private void MnItemFit_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void BtnVeranderFoto_Click(object sender, RoutedEventArgs e)
        //{
        //    ImgVerandering.Source = new BitmapImage(new Uri("/assets/cornflakes.jpeg", UriKind.Relative));

        //}

        //private void BtnVerwerk_Click(object sender, RoutedEventArgs e)
        //{
        //    // Property IsChecked kan null zijn, daarom "== true/false" check doen
        //    if (CheckVIP.IsChecked == true)
        //    {
        //        MessageBox.Show("Welcome to VIP section");
        //    } else {
        //        MessageBox.Show("Welome to normal section");
        //    }

        //    if (RdbtnMan.IsChecked == true)
        //    {
        //        MessageBox.Show("man");
        //    }
        //    else if (RdbtnVrouw.IsChecked == true)
        //    {
        //        MessageBox.Show("vrouw");
        //    }
        //    else
        //    {
        //        MessageBox.Show("onbekend");
        //    }

        //    Paneel.Background = Brushes.MediumTurquoise;
        //}
    }
}
