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

namespace EuroDollarOef
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

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            Double euro = Convert.ToDouble(TxtEuro.Text);
            TxtDollar.Text = Convert.ToString(euro * 1.2);

        }

        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtDollar.Text = "0";
            TxtEuro.Text = "0";
        }
    }
}
