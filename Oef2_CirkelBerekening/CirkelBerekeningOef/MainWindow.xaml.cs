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

namespace CirkelBerekeningOef
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
            Double Straal = Convert.ToDouble(TxtStraal.Text);
            Double Omtrek = Straal*2*Math.PI;
            Double Oppervlakte = Math.Pow(Straal,2) * Math.PI;

            TxtOppervlakte.Text = Oppervlakte.ToString();
            TxtOmtrek.Text = Omtrek.ToString();
        }

        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtOmtrek.Text = "0";
            TxtOppervlakte.Text = "0";
            TxtStraal.Text = "0";
        }
    }
}
