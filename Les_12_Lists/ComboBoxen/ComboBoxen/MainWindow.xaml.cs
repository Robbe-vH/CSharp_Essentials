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

namespace ComboBoxen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxItem comboBoxItem = new ComboBoxItem();
            comboBoxItem.Content = "C#";
            CmbxVakken.Items.Add(comboBoxItem);

            ComboBoxItem comboBoxItem1 = new ComboBoxItem();
            comboBoxItem1.Content = "Web Design";
            CmbxVakken.Items.Add(comboBoxItem1);
        }

        private void CmbxVakken_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CmbxVakken.SelectedIndex > -1)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)CmbxVakken.SelectedItem;
                LblVak.Text = selectedItem.Content.ToString();
            }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
             CmbxVakken.SelectedIndex = -1;
            LblVak.Text = string.Empty;
        }
    }
}
