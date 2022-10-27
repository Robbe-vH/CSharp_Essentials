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

namespace FunctieDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        // 1. Return types
        // void is leeg, geen return type
        private void Yeye()
        {

        }

        // return type: int
        // moet sowieso een int returnen
        private int GeefGetal()
        {
            return 69;
        }

        // return type kan eignelijk alles zijn, zolang het een datetype is
        private StringBuilder MaakZin()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello there");
            return sb;
        }

        // 2. naming conventions
        int getal =0;
        private void NaamFunctie()
        {
            getal++;
        }

        // 3. accesmodifier
        private void NogEentje()
        {
            int getalltje = GeefGetal();
        }

        public void UwMoeder()
        {
            int publiekGetalletje = GeefGetal();
        }

        // 4. Parameters
        // onderscehiden door komma's, gedeclareerd in de signatuur
        private void SchilderMuur(string kleur)
        {
            // schilder muur in "kleur"
        }

        private int Optelling(int a, int b, int c)
        {
            return a + b + c;
        }

        public MainWindow()
        {
            InitializeComponent();

            int getal1 = 1;
            int getal2 = 2;
            int getal3 = 3;

            int resultaat = Optelling(getal1, getal2, getal3);
        }

        private void YeeHa()
        {
            // static method, de uitkomst gaat nooit anders zijn door een voorgaande methode/functie
            Math.Pow(69, 2);
            // non static functie kan een andere waarde geven door een voorgaande functie
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hoeren");
            sb.AppendLine(" zijn leuk");
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("Maar bier");
            sb2.Append(" zijn leuk");
        }

        // Method overloading, meerdere datatypes kunnen gebruiken
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Plus(float a, float b)
        {
            return Convert.ToInt32( a - b);
        }
    }
}
