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

namespace Oefening_Concert_Planner
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

        private void BtnVoegEventToe_Click(object sender, RoutedEventArgs e)
        {
            // input: type, naam, aantal
            ComboBoxItem geselecteerdItem = (ComboBoxItem)CmbType.SelectedItem;

            string type = geselecteerdItem.Content.ToString();
            string naam = TxtEvent.Text;

            int aantalBezoekers = Convert.ToInt32(TxtAantal.Text);

            // bewerking
            string content = $"{type} - {naam}: {aantalBezoekers}";
            ListBoxItem newEvent = new ListBoxItem();
            newEvent.Content = content;

            //output
            LstBxConcerten.Items.Add(newEvent);
        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxConcerten.SelectedIndex > -1)
            {
                LstBxConcerten.Items.Remove(LstBxConcerten.SelectedItem);
            }
        }

        private void MnIVerwijderAlleEvents_Click(object sender, RoutedEventArgs e)
        {
            LstBxConcerten.Items.Clear();
        }

        private void MnIStandaardEvent_Click(object sender, RoutedEventArgs e)
        {
            string content = "orkest - jaarlijks optreden: 500";
            ListBoxItem lstItem = new ListBoxItem();
            lstItem.Content = content;
            LstBxConcerten.Items.Add(lstItem);
        }

        private void MnIClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
