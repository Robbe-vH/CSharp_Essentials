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

namespace Oefening_Centerparks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] aantalDagen = new int[] { 1, 2, 5, 7, 8, 12, 14, 21 };
        private string[,] woningMetPrijs = new string[5, 2]
        {
            {"2 personen","80"},
            {"4 personen","120"},
            { "4 personen lux","140"},
            { "6 personen","180"},
            { "8 personen","200"}
        };

        public MainWindow()
        {
            InitializeComponent();
            LaadTypeWoningenInComboBox();
            LaadAantalDagenInComboBox();
        }

        private void LaadAantalDagenInComboBox()
        {
            for (int i = 0; i < aantalDagen.Length; i++)
            {
                ComboBoxItem dagItem = new ComboBoxItem();
                dagItem.Content = aantalDagen[i];
                CmbxAantalDagen.Items.Add(dagItem);
            }
        }

        private void LaadTypeWoningenInComboBox()
        {
            for (int i = 0; i < woningMetPrijs.GetLength(0); i++)
            {
                ComboBoxItem typeItem = new ComboBoxItem();
                typeItem.Content = woningMetPrijs[i,0];
                CmbxTypeWoning.Items.Add(typeItem);
            }
        }

        private void BerekenPrijs(object sender, SelectionChangedEventArgs e)
        {
            if (CmbxAantalDagen.SelectedIndex > -1 && CmbxTypeWoning.SelectedIndex > -1) TxtPrijsResultaat.Text = Convert.ToString(Convert.ToInt32(woningMetPrijs[CmbxTypeWoning.SelectedIndex, 1]) * Convert.ToInt32(aantalDagen[CmbxAantalDagen.SelectedIndex]));
        }
    }
}
