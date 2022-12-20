using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Oefening_Eevee_Catcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> eeveeImages = new Dictionary<string, string>
        {
            { "Eevee", "/images/Eevee.png" },
            { "EeveeGigantamax", "/images/EeveeGigantamax.png" },
            { "Espeon", "/images/Espeon.png" },
            { "Flareon", "/images/Flareon.png" },
            { "Glaceon", "/images/Glaceon.png" },
            { "Jolteon", "/images/Jolteon.png" },
            { "Leafeon", "/images/Leafeon.png" },
            { "Sylveon", "/images/Sylveon.png" },
            { "Umbreon", "/images/Umbreon.png" },
            { "Vaporeon", "/images/Vaporeon.png" }
        };

        private DispatcherTimer eeveeTimer;
        private DispatcherTimer huidigeTijd;
        private DispatcherTimer highscoreTimer;
        private int fotoTeller;
        private BitmapImage eeveeBitmapFoto;
        private Random willekeurigeFoto;
        private DateTime startTijd;
        private DateTime endTijd;
        private int totaaltijd = 0;

        public MainWindow()
        {
            InitializeComponent();
            eeveeTimer = new DispatcherTimer(DispatcherPriority.Normal);
            eeveeTimer.Tick += new EventHandler(eeveeTimer_Tick);
            eeveeTimer.Interval = new TimeSpan(0, 0, 1);

            huidigeTijd = new DispatcherTimer();
            huidigeTijd.Tick += new EventHandler(huidigeTijd_Tick);
            huidigeTijd.Interval = new TimeSpan(0, 0, 1);
            huidigeTijd.Start();

            willekeurigeFoto = new Random();
        }

        // Timers
        public void eeveeTimer_Tick(object? sender, EventArgs e)
        {
            // Namen van de Keys linken aan getallen
            List<string> keys = new List<string>(eeveeImages.Keys);

            // Een willekeurige foto inladen uit de dictionary
            fotoTeller = willekeurigeFoto.Next(1, keys.Count);
            string fotopath = eeveeImages[keys[fotoTeller]];

            // Bitmap foto maken
            eeveeBitmapFoto = new BitmapImage();
            eeveeBitmapFoto.BeginInit();
            eeveeBitmapFoto.UriSource = new Uri(fotopath, UriKind.Relative);
            eeveeBitmapFoto.EndInit();

            // Bitmap foto linken aan xaml
            ImgEevee.Source = eeveeBitmapFoto;

            // start tijd score
            startTijd = DateTime.Now;
        }

        private void huidigeTijd_Tick(object? sender, EventArgs e)
        {
            LblHudigeTijd.Text = DateTime.Now.ToLongTimeString();
        }


        // Knop
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eeveeTimer.Start();
        }

        private void ImgEevee_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (fotoTeller == 1)
            {
                TimeSpan score = TimeSpan.FromMilliseconds(startTijd - DateTime.Now);
                eeveeTimer.Stop();
                MessageBox.Show($"Uw Moederrrrrr {totaaltijd}ms");
            }
            else
            {
                // scoreTijd += 100ms;
            }
        }
    }
}
