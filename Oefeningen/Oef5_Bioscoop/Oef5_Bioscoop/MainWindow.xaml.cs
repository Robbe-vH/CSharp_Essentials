using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Oef5_Bioscoop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float normaalTarief = 9.1f;
        float kortingTarief = 8.1f;
        float studentTarief = 6.9f;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            int normaalAantal = Convert.ToInt32(TxtNormaal.Text);
            int kortingAantal = Convert.ToInt32(TxtKorting.Text);
            int studentAantal = Convert.ToInt32(TxtStudent.Text);


            float normaalPrijs = normaalAantal * normaalTarief;
                float kortingPrijs = kortingAantal * kortingTarief;
                float studentPrijs = studentAantal * studentTarief;
                float totaalPrijs = normaalPrijs + kortingPrijs + studentPrijs;

                TxtBetalen.Text = Convert.ToString(Math.Round(totaalPrijs, 2));

            
        }

        private void BtnWis_Click(object sender, RoutedEventArgs e)
        {
            TxtNormaal.Text = "0";
            TxtKorting.Text = "0";
            TxtStudent.Text = "0";
            TxtBetalen.Text = "0";
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int normaalAantal = Convert.ToInt32(TxtNormaal.Text);
                int kortingAantal = Convert.ToInt32(TxtKorting.Text);
                int studentAantal = Convert.ToInt32(TxtStudent.Text);

                float normaalPrijs = normaalAantal * 9.1f;
                float kortingPrijs = kortingAantal * 9.1f;
                float studentPrijs = studentAantal * 9.1f;
                float totaalPrijs = normaalPrijs + kortingPrijs + studentPrijs;

                TxtBetalen.Text = Convert.ToString(Math.Round(totaalPrijs, 2));
            }
        }
    }
}
