using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Controls_Lijsten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // nooit gewoon een stuk tekst toevoegen, altijd een listboxitem met een content
            // anders kunnen er mismatchende datatypes komen
            //LbxNamen.Items.Add("Lorem Ipsum");
            
            ListBoxItem item = new ListBoxItem();
            item.Content = "Yeyeyeyeye";
            LbxNamen.Items.Add(item);
        }

        private void BtnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = TxtNaam.Text;
            LbxNamen.Items.Add(item);

            TxtNaam.Text = string.Empty;
        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            //ListBoxItem[] geselecteerdItems = (ListBoxItem[])LbxNamen.SelectedItems;
            //StringBuilder rmItems = new StringBuilder();
            //foreach (ListBoxItem item in geselecteerdItems)
            //{
            //    rmItems.AppendLine(item.Content.ToString());
            //}
            //LbxNamen.Items.Remove(geselecteerdItems);
            //MessageBox.Show($"U heeft { rmItems } verwijderd");
            
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListBoxItem item in LbxNamen.Items)
            {
                sb.AppendLine(item.Content.ToString());
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
