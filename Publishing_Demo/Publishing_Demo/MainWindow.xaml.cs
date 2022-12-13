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

namespace Publishing_Demo
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

        /// <summary>
        /// Deze methode gaat een complexe berekening doen.
        /// <para>
        /// Uw moeder is een complex variabel ding.
        /// </para>
        /// <para>
        /// het resultaat is 6.
        /// </para>
        ///
        /// </summary>
        /// <param name="uwMoeder">is een BBQ sausje</param>
        /// <returns>6 chickennuggets in stringformaat</returns>
        private string ComplexeMethode(double uwMoeder)
        {
            return "Complexe resultaten";
        }

    }
}
