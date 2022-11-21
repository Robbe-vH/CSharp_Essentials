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

namespace Oefening_22_Dobbelsteen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;
        private StringBuilder sb;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            sb = new StringBuilder();
        }


        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            int resultaat = random.Next(1, 7);
            int aantalWorpen = 1;

            while (resultaat < 6) {
                resultaat = random.Next(1, 7);
                sb.AppendLine($"Worp {aantalWorpen} is: {resultaat}");
                aantalWorpen++;
            }

            TxtOutput.Text = sb.ToString();
        }

        private void BtnOpnieuw_Click(object sender, RoutedEventArgs e)
        {
            TxtOutput.Clear();
            sb.Clear();
            BtnStart.Focus();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
