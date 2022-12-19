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

namespace Oefening_Digitaal_Woordenboek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> woordenboek;

        public MainWindow()
        {
            InitializeComponent();
            woordenboek = new Dictionary<string, string>() 
            {
                { "Paard", "Mihihihi"},
                {"Uil", "Woesh Woesh" }
            };
            VoegItemsToeAanListBox();
        }

        private void VoegItemsToeAanListBox()
        {
            foreach (var key in woordenboek.Keys)
            {
                ListBoxItem woordItem = new ListBoxItem();
                woordItem.Content = key;
                LbxWoordenLijst.Items.Add(woordItem);
            }
        }

        private void BtnVoegWoordToe_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtWoord.Text) && !string.IsNullOrWhiteSpace(TxtUitleg.Text))
            {
                if (!woordenboek.ContainsKey(TxtWoord.Text))
                {
                    woordenboek.Add(TxtWoord.Text, TxtUitleg.Text);

                    ListBoxItem woordItem = new ListBoxItem();
                    woordItem.Content = TxtWoord.Text;
                    LbxWoordenLijst.Items.Add(woordItem);

                }
                else MessageBox.Show("Dit woord staat al in het woordenboek!", "Fout");
            }
            
            if (string.IsNullOrWhiteSpace(TxtWoord.Text)) TxtWoord.Background = Brushes.Red;
            if (string.IsNullOrWhiteSpace(TxtUitleg.Text)) TxtUitleg.Background = Brushes.Red;
        }

        private void LbxWoordenLijst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem geselcteerdeKey =  (ListBoxItem)LbxWoordenLijst.SelectedItem;
            TxtWoordenBoekUitleg.Text = woordenboek[geselcteerdeKey.Content.ToString()];
        }


        private void TxtUitleg_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtUitleg.Background = Brushes.White;
        }

        private void TxtWoord_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtWoord.Background = Brushes.White;
        }
    }
}
