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

namespace Oefening_Vulkanen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[] kolommen = new string[6] { "Naam", "Land", "Lengtegraad", "Breedtegraad", "Hoogte", "Type" };
        private string[,] vulkanen = new string[8, 6] 
        { 
            { "Eyjafjallajokull", "Iceland", "63.633", "-19.633", "1651", "Stratovolcano" },
            { "Fujisan", "Japan", "35.361", "138.728", "3776", "Stratovolcano" }, 
            { "Mauna Loa", "United States", "19.475", "-155.608", "4170", "Shield volcano" }, 
            { "Etna", "Italy", "37.748", "14.999", "3320", "Stratovolcano" }, 
            { "Fogo", "Cape Verde", "14.95", "-24.35", "2829", "Stratovolcano" }, 
            { "Pacaya", "Guatemala", "14.382", "-90.601", "2569", "Complex volcano" }, 
            { "Vesuvius", "Italy", "40.821", "14.426", "1281", "Complex volcano" }, 
            { "Villarrica", "Chile", "-39.42", "-71.93", "2847", "Stratovolcano" } 
        };

        public MainWindow()
        {
            InitializeComponent();
            LaadVulkanenNamenInComboBoxItems();
        }

        private void LaadVulkanenNamenInComboBoxItems()
        {
            for (int i = 0; i < vulkanen.GetLength(0); i++)
            {
                ComboBoxItem vulkaanItem = new ComboBoxItem();
                vulkaanItem.Content = vulkanen[i,0];
                CmbxVulkanen.Items.Add(vulkaanItem);
            }
        }

        private void CmbxVulkanen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbxVulkanen.SelectedIndex > -1)
            {
                StringBuilder SBvulkanen = new StringBuilder();
                //stringbuilder vullen met info over vulkanen
                for (int i = 0; i < vulkanen.GetLength(1); i++)
                {
                    SBvulkanen.AppendLine($"{kolommen[i]}: {vulkanen[CmbxVulkanen.SelectedIndex,i]}");
                }
                //output
                TxtVulkanenUitleg.Text = SBvulkanen.ToString();
            }
             
        }
    }
}
