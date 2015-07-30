using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Periodensystem_der_Elemente
{
    /// <summary>
    /// Interaktionslogik für Periodensystem.xaml
    /// </summary>
    public partial class Periodensystem : Page
    {
        public Periodensystem()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
        }

        #region zusätze
        public DispatcherTimer dt = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        #endregion
        #region Strings
            private string akelem = "Aktuelles Element: ";
            private string voelem = "Vorheriges Element: ";
            private string akper = "Aktuelle Periode: ";
            private string akaus = "Aktuelle Außenschale: ";
            private string schale = "-Schale";
        #endregion

        #region Statusbaritems.Content änderung
        private void Elementmitozundmz(string name, int oz, int mz, string Hintergrund)
        {
            elementsymbol.Text = name;
            ordnungszahl.Text = oz.ToString();
            atommasse.Text = mz.ToString();
            elementsymbolfarbe.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente;component/Bilder/Hintergründe/" + Hintergrund, UriKind.RelativeOrAbsolute));
            if (Hintergrund == "Alkalimetalle.png")
            {
                elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                atommasse.Foreground = new SolidColorBrush(Colors.White);
                ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
            }
            else
                if (Hintergrund == "Erdalkalimetalle.png")
                {
                    elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                    atommasse.Foreground = new SolidColorBrush(Colors.White);
                    ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
                }
                else
                    if (Hintergrund == "Edelgase.png")
                    {
                        elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                        atommasse.Foreground = new SolidColorBrush(Colors.White);
                        ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
                    }
                    else
                    {
                        elementsymbol.Foreground = new SolidColorBrush(Colors.Black);
                        atommasse.Foreground = new SolidColorBrush(Colors.Black);
                        ordnungszahl.Foreground = new SolidColorBrush(Colors.Black);
                    }
        }

        #region 1. HG
        private void wasserstoff_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Wasserstoff";
            aktuelleperiode.Content = akper + "1";
            aktuelleaußenschale.Content = akaus + "K" + schale;
            Elementmitozundmz("H", 1, 1, "Gase.png");
        }
        private void wasserstoff_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Wasserstoff";
        }

        private void lithium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Lithium";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("Li", 3, 7, "Alkalimetalle.png");
        }
        private void lithium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Lithium";
        }

        private void natrium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Natrium";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Na", 11, 23, "Alkalimetalle.png");
        }
        private void natrium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Natrium";
        }

        private void kalium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Kalium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("K", 19, 39, "Alkalimetalle.png");
        }
        private void kalium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Kalium";
        }

        private void rubidium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Rubidium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Rb", 37, 86, "Alkalimetalle.png");
        }
        private void rubidium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Rubidium";
        }

        private void caesium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Caesium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Cs", 55, 133, "Alkalimetalle.png");
        }
        private void caesium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Caesium";
        }

        private void francium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Francium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Fr", 87, 223, "Alkalimetalle.png");
        }
        private void francium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Francium";
        }
        #endregion
        #region 2. HG
        private void beryllium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Beryllium";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("Be", 4, 9, "Erdalkalimetalle.png");
        }
        private void beryllium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Beryllium";
        }

        private void magnesium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Magnesium";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Mg", 12, 24, "Erdalkalimetalle.png");
        }
        private void magnesium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Magnesium";
        }

        private void calcium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Calcium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Ca", 20, 40, "Erdalkalimetalle.png");
        }
        private void calcium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Calcium";
        }

        private void strontium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Strontium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Sr", 38, 88, "Erdalkalimetalle.png");
        }
        private void strontium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Strontium";
        }

        private void barium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Barium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Ba", 56, 137, "Erdalkalimetalle.png");
        }
        private void barium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Barium";
        }

        private void radium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Radium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Ra", 88, 226, "Erdalkalimetalle.png");
        }
        private void radium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Radium";
        }
        #endregion

        #region 3. NG
        private void scandium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Scandium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Sc", 21, 45, "Übergangsmetalle.png");
        }
        private void scandium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Scandium";
        }

        private void yttrium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Yttrium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Y", 39, 89, "Übergangsmetalle.png");
        }
        private void yttrium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Yttrium";
        }

        private void lanthan_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Lanthan";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("La", 57, 139, "Übergangsmetalle.png");
        }
        private void lanthan_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Lanthan";
        }

        private void actinium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Actinium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Ac", 89, 227, "Übergangsmetalle.png");
        }
        private void actinium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Actinium";
        }
        #endregion

        #region Lanthanoide
        private void cer_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Cer";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Ce", 58, 140, "Lanthanoide.png");
        }
        private void cer_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Cer";
        }

        private void praseodym_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Praseodym";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Pr", 59, 141, "Lanthanoide.png");
        }
        private void praseodym_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Praseodym";
        }

        private void neodym_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Neodym";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Nd", 60, 144, "Lanthanoide.png");
        }
        private void neodym_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Neodym";
        }

        private void promethium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Promethium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Pm", 61, 147, "Lanthanoide.png");
        }
        private void promethium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Promethium";
        }

        private void samarium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Samarium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Sm", 62, 150, "Lanthanoide.png");
        }
        private void samarium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Samarium";
        }
        
        private void europium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Europium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Eu", 63, 152, "Lanthanoide.png");
        }
        private void europium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Europium";
        }

        private void gadolium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Gadolium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Gd", 64, 157, "Lanthanoide.png");
        }
        private void gadolium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Gadolium";
        }

        private void terbium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Terbium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Tb", 65, 159, "Lanthanoide.png");
        }
        private void terbium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Terbium";
        }

        private void dysprosium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Dysprosium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Dy", 66, 163, "Lanthanoide.png");
        }
        private void dysprosium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Dysprosium";
        }

        private void holmium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Holmium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Ho", 67, 165, "Lanthanoide.png");
        }
        private void holmium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Holmium";
        }

        private void erbium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Erbium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Er", 68, 167, "Lanthanoide.png");
        }
        private void erbium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Erbium";
        }

        private void thulium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Thulium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Tm", 69, 169, "Lanthanoide.png");
        }
        private void thulium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Thulium";
        }

        private void ytterbium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Ytterbium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Yb", 70, 173, "Lanthanoide.png");
        }
        private void ytterbium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Ytterbium";
        }

        private void lutethium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Lutethium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Lu", 71, 175, "Lanthanoide.png");
        }
        private void lutethium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Lutethium";
        }
        #endregion
        #region Actinoide
        private void thorium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Thorium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Th", 90, 232, "Actinoide.png");
        }
        private void thorium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Thorium";
        }

        private void protactinium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Protactinium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Pa", 91, 231, "Actinoide.png");
        }
        private void protactinium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Protactinium";
        }

        private void uran_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Uran";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("U", 92, 238, "Actinoide.png");
        }
        private void uran_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Uran";
        }
        
        private void neptunium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Neptunium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Np", 93, 237, "Actinoide.png");
        }
        private void neptunium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Neptunium";
        }

        private void plutonium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Plutonium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Pu", 94, 244, "Actinoide.png");
        }
        private void plutonium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Plutonium";
        }

        private void americum_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Americum";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Am", 95, 243, "Actinoide.png");
        }
        private void americum_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Americum";
        }
        
        private void curium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Curium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Cm", 96, 247, "Actinoide.png");
        }
        private void curium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Curium";
        }

        private void berkelium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Berkelium";
            aktuelleperiode.Content = akper + "7";
            aktuelleaußenschale.Content = akaus + "Q" + schale;
            Elementmitozundmz("Bk", 97, 247, "Actinoide.png");
        }
        private void berkelium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Berkelium";
        }
        #endregion

        #region 4. NG
        private void titan_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Titan";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Ti", 22, 48, "Übergangsmetalle.png");
        }
        private void titan_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Titan";
        }

        private void zirconium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Zirconium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Zr", 40, 91, "Übergangsmetalle.png");
        }
        private void zirconium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Zirconium";
        }

        private void hafnium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Hafnium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Hf", 72, 179, "Übergangsmetalle.png");
        }
        private void hafnium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Hafnium";
        }
        #endregion
        #region 5. NG
        private void vanadium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Vanadium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("V", 23, 51, "Übergangsmetalle.png");
        }
        private void vanadium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Vanadium";
        }

        private void niob_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Niob";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Nb", 41, 93, "Übergangsmetalle.png");
        }
        private void niob_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Niob";
        }

        private void tantal_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Tantal";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Ta", 73, 181, "Übergangsmetalle.png");
        }
        private void tantal_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Tantal";
        }
        #endregion
        #region 6. NG
        private void chrom_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Chrom";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Cr", 24, 52, "Übergangsmetalle.png");
        }
        private void chrom_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Chrom";
        }

        private void molybdän_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Molybdän";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Mo", 42, 96, "Übergangsmetalle.png");
        }
        private void molybdän_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Molybdän";
        }

        private void wolfram_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Wolfram";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("W", 74, 184, "Übergangsmetalle.png");
        }
        private void wolfram_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Wolfram";
        }
        #endregion
        #region 7. NG
        private void mangan_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Mangan";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Mn", 25, 55, "Übergangsmetalle.png");
        }
        private void mangan_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Mangan";
        }

        private void technetium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Technetium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Tc", 43, 99, "Übergangsmetalle.png");
        }
        private void technetium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Niob";
        }

        private void rhenium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Rhenium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Re", 75, 186, "Übergangsmetalle.png");
        }
        private void rhenium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Rhenium";
        }
        #endregion
        #region 8. NG
        //Block 1
        private void eisen_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Eisen";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Fe", 26, 56, "Übergangsmetalle.png");
        }
        private void eisen_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Eisen";
        }

        private void ruthenium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Ruthenium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Ru", 44, 101, "Übergangsmetalle.png");
        }
        private void ruthenium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Ruthenium";
        }

        private void osmium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Osmium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Os", 76, 190, "Übergangsmetalle.png");
        }
        private void osmium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Osmium";
        }
        //Block 2
        private void cobalt_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Cobalt";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Co", 27, 59, "Übergangsmetalle.png");
        }
        private void cobalt_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Cobalt";
        }

        private void rhodium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Rhodium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Rh", 45, 103, "Übergangsmetalle.png");
        }
        private void rhodium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Rhodium";
        }

        private void iridium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Iridium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Ir", 77, 192, "Übergangsmetalle.png");
        }
        private void iridium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Iridium";
        }
        //Block 3
        private void nickel_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Nickel";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Ni", 28, 59, "Übergangsmetalle.png");
        }
        private void nickel_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Nickel";
        }

        private void palladium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Palladium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Pd", 46, 106, "Übergangsmetalle.png");
        }
        private void palladium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Palladium";
        }

        private void platin_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Platin";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Pt", 78, 195, "Übergangsmetalle.png");
        }
        private void platin_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Platin";
        }
        #endregion
        #region 1. NG
        private void kupfer_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Kupfer";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Cu", 29, 64, "Übergangsmetalle.png");
        }
        private void kupfer_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Kupfer";
        }

        private void silber_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Silber";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Ag", 47, 108, "Übergangsmetalle.png");
        }
        private void silber_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Silber";
        }

        private void gold_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Gold";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Au", 79, 197, "Übergangsmetalle.png");
        }
        private void gold_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Gold";
        }
        #endregion
        #region 2. NG
        private void zink_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Zink";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Zn", 30, 65, "Übergangsmetalle.png");
        }
        private void zink_ToolTipClosing(object sender, ToolTipEventArgs e)
        {

            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Zink";
        }

        private void cadmium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Cadmium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Cd", 48, 112, "Übergangsmetalle.png");
        }
        private void cadmium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Cadmium";
        }

        private void quecksilber_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Quecksilber";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Hg", 80, 201, "Übergangsmetalle.png");
        }
        private void quecksilber_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Quecksilber";
        }
        #endregion

        #region 3. HG
        private void bor_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Bor";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("B", 5, 11, "Halbmetalle.png");
        }
        private void bor_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Bor";
        }

        private void aluminium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Aluminium";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Al", 13, 27, "Metalle.png");
        }
        private void aluminium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Aluminium";
        }

        private void gallium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Gallium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Ga", 31, 70, "Metalle.png");
        }
        private void gallium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Gallium";
        }

        private void indium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Indium";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("In", 49, 115, "Metalle.png");
        }
        private void indium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Indium";
        }

        private void thallium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Thallium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Tl", 81, 204, "Metalle.png");
        }
        private void thallium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Thallium";
        }
        #endregion
        #region 4. HG
        private void kohlenstoff_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Kohlenstoff";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("C", 6, 12, "Feststoffe.png");
        }
        private void kohlenstoff_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Kohlenstoff";
        }

        private void silicium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Silicium";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Si", 14, 28, "Halbmetalle.png");
        }
        private void silicium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Silicium";
        }

        private void germanium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Germanium";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Ge", 32, 73, "Halbmetalle.png");
        }
        private void germanium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Germanium";
        }

        private void zinn_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Zinn";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Sn", 50, 119, "Metalle.png");
        }
        private void zinn_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Zinn";
        }

        private void blei_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Blei";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Pb", 82, 207, "Metalle.png");
        }
        private void blei_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Blei";
        }
        #endregion
        #region 5. HG
        private void stickstoff_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Stickstoff";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("N", 7, 14, "Gase.png");
        }
        private void stickstoff_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Stickstoff";
        }

        private void phosphor_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Phosphor";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("P", 15, 31, "Feststoffe.png");
        }
        private void phosphor_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Phosphor";
        }

        private void arsen_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Arsen";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("As", 33, 75, "Halbmetalle.png");
        }
        private void arsen_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Arsen";
        }

        private void antimon_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Antimon";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Sb", 51, 122, "Halbmetalle.png");
        }
        private void antimon_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Antimon";
        }

        private void bismut_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Bismut";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Bi", 83, 209, "Metalle.png");
        }
        private void bismut_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Bismut";
        }
        #endregion
        #region 6. HG
        private void sauerstoff_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Sauerstoff";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("O", 8, 16, "Gase.png");
        }
        private void sauerstoff_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Sauerstoff";
        }

        private void schwefel_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Schwefel";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("S", 16, 32, "Feststoffe.png");
        }
        private void schwefel_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Schwefel";
        }

        private void selen_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Selen";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Se", 34, 79, "Halbmetalle.png");
        }
        private void selen_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Selen";
        }

        private void tellur_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Tellur";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Te", 52, 128, "Halbmetalle.png");
        }
        private void tellur_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Tellur";
        }

        private void polonium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Polonium";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Po", 84, 210, "Halbmetalle.png");
        }
        private void polonium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Polonium";
        }
        #endregion
        #region 7. HG
        private void flour_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Flour";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("F", 9, 19, "Halogene.png");
        }
        private void flour_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Flour";
        }

        private void chlor_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Chlor";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Cl", 17, 35, "Halogene.png");
        }
        private void chlor_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Chlor";
        }

        private void brom_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Brom";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Br", 35, 80, "Halogene.png");
        }
        private void brom_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Brom";
        }

        private void iod_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Iod";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("I", 53, 127, "Halogene.png");
        }
        private void iod_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Iod";
        }

        private void astat_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Astat";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("At", 85, 210, "Halogene.png");
        }
        private void astat_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Astat";
        }
        #endregion
        #region 8. HG
        private void helium_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Helium";
            aktuelleperiode.Content = akper + "1";
            aktuelleaußenschale.Content = akaus + "K" + schale;
            Elementmitozundmz("He", 2, 4, "Edelgase.png");
        }
        private void helium_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Helium";
        }

        private void neon_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Neon";
            aktuelleperiode.Content = akper + "2";
            aktuelleaußenschale.Content = akaus + "L" + schale;
            Elementmitozundmz("Ne", 10, 20, "Edelgase.png");
        }
        private void neon_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Neon";
        }

        private void argon_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Argon";
            aktuelleperiode.Content = akper + "3";
            aktuelleaußenschale.Content = akaus + "M" + schale;
            Elementmitozundmz("Ar", 18, 40, "Edelgase.png");
        }
        private void argon_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Argon";
        }

        private void krypton_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Krypton";
            aktuelleperiode.Content = akper + "4";
            aktuelleaußenschale.Content = akaus + "N" + schale;
            Elementmitozundmz("Kr", 36, 84, "Edelgase.png");
        }
        private void krypton_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Krypton";
        }

        private void xenon_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Xenon";
            aktuelleperiode.Content = akper + "5";
            aktuelleaußenschale.Content = akaus + "O" + schale;
            Elementmitozundmz("Xe", 54, 131, "Edelgase.png");
        }
        private void xenon_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Xenon";
        }

        private void radon_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem + "Radon";
            aktuelleperiode.Content = akper + "6";
            aktuelleaußenschale.Content = akaus + "P" + schale;
            Elementmitozundmz("Rn", 86, 222, "Edelgase.png");
        }
        private void radon_ToolTipClosing(object sender, ToolTipEventArgs e)
        {
            aktuelleselement.Content = akelem;
            aktuelleperiode.Content = akper;
            aktuelleaußenschale.Content = akaus;
            vorherigeselement.Content = voelem + "Radon";
        }
        #endregion
        #region Uhrzeit
        void dt_Tick(object sender, EventArgs e)
        {
            zeit.Content = string.Format("{0:HH:mm}Uhr", DateTime.Now, DateTime.Now);
            dt.Start();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            zeit.Content = string.Format("{0:HH:mm}Uhr", DateTime.Now, DateTime.Now);
            dt.Start();
        }
        #endregion

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            aktuelleselement.Content = akelem + "-";
            aktuelleperiode.Content = akper + "-";
            aktuelleaußenschale.Content = akaus + schale;
        }
        #endregion
    }
}
