using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
#region Elementusings
using Periodensystem.erste_Hauptgruppe;
using Periodensystem.zweite_Hauptgruppe;

using Periodensystem.dritte_Nebengruppe;

using Periodensystem.Lanthanoide;
using Periodensystem.Actinoide;

using Periodensystem.vierte_Nebengruppe;
using Periodensystem.fünfte_Nebengruppe;
using Periodensystem.sechste_Nebengruppe;
using Periodensystem.siebte_Nebengruppe;
using Periodensystem.achte_Nebengruppe;
using Periodensystem.erste_Nebengruppe;
using Periodensystem.zweite_Nebengruppe;

using Periodensystem.dritte_Hauptgruppe;
using Periodensystem.vierte_Hauptgruppe;
using Periodensystem.fuenfte_Hauptgruppe;
using Periodensystem.sechste_Hauptgruppe;
using Periodensystem.siebte_Hauptgruppe;
using Periodensystem.achte_Hauptgruppe;
using System.Windows.Media;
#endregion

namespace Periodensystem_der_Elemente
{
    /// <summary>
    /// Interaktionslogik für Übung.xaml
    /// </summary>
    public partial class Übung : Page
    {
        public Übung()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
        }

        #region Sondersachen
        void sbir_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzenp();
        }
        void sbis_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzenp();
        }
        void sbiw_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzenp();
        }

        void sbim_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzens();
        }
        void sbirh_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzens();
        }

        void sbid_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzenc();
        }
        void sbig_Checked(object sender, RoutedEventArgs e)
        {
            rücksetzenc();
        }
        public DispatcherTimer dt = new DispatcherTimer()
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        #endregion

        #region Elemente
        #region 1. HG
        Wasserstoff H = new Wasserstoff();
        Lithium Li = new Lithium();
        Natrium Na = new Natrium();
        Kalium K = new Kalium();
        Rubidium Rb = new Rubidium();
        Caesium Cs = new Caesium();
        Francium Fr = new Francium();
        #endregion
        #region 2. HG
        Beryllium Be = new Beryllium();
        Magnesium Mg = new Magnesium();
        Calcium Ca = new Calcium();
        Strontium Sr = new Strontium();
        Barium Ba = new Barium();
        Radium Ra = new Radium();
        #endregion

        #region 3. NG
        Scandium Sc = new Scandium();
        Yttrium Y = new Yttrium();
        Lanthan La = new Lanthan();
        Actinium Ac = new Actinium();
        #endregion

        #region Lanthanoide
        Cer Ce = new Cer();
        Praseodym Pr = new Praseodym();
        Neodym Nd = new Neodym();
        Promethium Pm = new Promethium();
        Samarium Sm = new Samarium();
        Europium Eu = new Europium();
        Gadolinium Gd = new Gadolinium();
        Terbium Tb = new Terbium();
        Dysprosium Dy = new Dysprosium();
        Holmium Ho = new Holmium();
        Erbium Er = new Erbium();
        Thulium Tm = new Thulium();
        Ytterbium Yb = new Ytterbium();
        Lutetium Lu = new Lutetium();
        #endregion
        #region Actinoide
        Thorium Th = new Thorium();
        Protactinium Pa = new Protactinium();
        Uran U = new Uran();
        Neptunium Np = new Neptunium();
        Plutonium Pu = new Plutonium();
        Americium Am = new Americium();
        Curium Cm = new Curium();
        Berkelium Bk = new Berkelium();
        #endregion

        #region 4. NG
        Titan Ti = new Titan();
        Zirconium Zr = new Zirconium();
        Hafnium Hf = new Hafnium();
        #endregion
        #region 5. NG
        Vanadium V = new Vanadium();
        Niob Nb = new Niob();
        Tantal Ta = new Tantal();
        #endregion
        #region 6. NG
        Chrom Cr = new Chrom();
        Molybdän Mo = new Molybdän();
        Wolfram W = new Wolfram();
        #endregion
        #region 7. NG
        Mangan Mn = new Mangan();
        Technetium Tc = new Technetium();
        Rhenium Re = new Rhenium();
        #endregion
        #region 8. NG
        Eisen Fe = new Eisen();
        Ruthenium Ru = new Ruthenium();
        Osmium Os = new Osmium();

        Cobalt Co = new Cobalt();
        Rhodium Rh = new Rhodium();
        Iridium Ir = new Iridium();

        Nickel Ni = new Nickel();
        Palladium Pd = new Palladium();
        Platin Pt = new Platin();
        #endregion
        #region 1. NG
        Kupfer Cu = new Kupfer();
        Silber Ag = new Silber();
        Gold Au = new Gold();
        #endregion
        #region 2. NG
        Zink Zn = new Zink();
        Cadmium Cd = new Cadmium();
        Quecksilber Hg = new Quecksilber();
        #endregion

        #region 3. HG
        Bor B = new Bor();
        Aluminium Al = new Aluminium();
        Gallium Ga = new Gallium();
        Indium In = new Indium();
        Thallium Tl = new Thallium();
        #endregion
        #region 4. HG
        Kohlenstoff C = new Kohlenstoff();
        Silicium Si = new Silicium();
        Germanium Ge = new Germanium();
        Zinn Sn = new Zinn();
        Blei Pb = new Blei();
        #endregion
        #region 5. HG
        Stickstoff N = new Stickstoff();
        Phosphor P = new Phosphor();
        Arsen As = new Arsen();
        Antimon Sb = new Antimon();
        Bismut Bi = new Bismut();
        #endregion
        #region 6. HG
        Sauerstoff O = new Sauerstoff();
        Schwefel S = new Schwefel();
        Selen Se = new Selen();
        Tellur Te = new Tellur();
        Polonium Po = new Polonium();
        #endregion
        #region 7. HG
        Fluor F = new Fluor();
        Chlor Cl = new Chlor();
        Brom Br = new Brom();
        Iod I = new Iod();
        Astat At = new Astat();
        #endregion
        #region 8. HG
        Helium He = new Helium();
        Neon Ne = new Neon();
        Argon Ar = new Argon();
        Krypton Kr = new Krypton();
        Xenon Xe = new Xenon();
        Radon Rn = new Radon();
        #endregion
        #endregion

        #region Booleans
        public static bool fertig;
        public static bool bordnungszahl = false;
        public static bool bmasse = false;
        public static bool bdichte = false;
        public static bool bname = false;
        public static bool bsiedepunkt = false;
        public static bool bschmelzpunkt = false;
        public static bool ok;
        #endregion

        #region Integer
        private static int a = 0;
        private static int richtig = 0;
        #endregion

        #region Strings
        private string sbiversuche = "Bisherige Versuche: ";
        private string sbirichtig = "Bisher richtig: ";
        
        private string tbdichte = "Dichte:\n";
        private string tbschmelzpunkt = "Schmelzpunkt:\n";
        private string tbsiedepunkt = "Siedepunkt:\n";
        private string temperatur = "°C";
        private string grammproqcm = "g/cm³";

        private static string gruppe;
        private static string elem;
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

        #region Überprüfungen
        public void ordnungszahlprüfung(int ord, int x)
        {
            if (ord == x)
            {
                imgordnungszahl.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bordnungszahl = true;
                ordnungzahl.IsReadOnly = true;
                richtig++;
                ordnungszahl.Text = x.ToString();
            }
            else
                imgordnungszahl.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }

        public void masseprüfung(int atommasse, int x)
        {
            if (atommasse == x)
            {
                imgmasse.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bmasse = true;
                masse.IsReadOnly = true;
                richtig++;
                Atommasse.Text = x.ToString();
            }
            else
                imgmasse.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }

        public void dichteprüfung(float dich, float x)
        {
            if (dich == x)
            {
                imgdichte.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bdichte = true;
                dichte.IsReadOnly = true;
                richtig++;
                Dichte.Text = tbdichte + x.ToString() + grammproqcm;
            }
            else
                imgdichte.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }
        public void dichteprüfung(string dich, string x)
        {
            if (dich == x)
            {
                imgdichte.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bdichte = true;
                dichte.IsReadOnly = true;
                richtig++;
                Dichte.Text = tbdichte + x + grammproqcm;
            }
            else
                imgdichte.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }

        public void nameprüfung(string nam, string x)
        {
            if (nam == x)
            {
                imgname.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bname = true;
                ename.IsReadOnly = true;
                richtig++;
                Elementname.Text = x;
            }
            else
                imgname.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }

        public void schmelzpktprüfung(int schmelzpkt, int x)
        {
            if (schmelzpkt == x)
            {
                imgschmelzpunkt.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bschmelzpunkt = true;
                schmelzpunkt.IsReadOnly = true;
                richtig++;
                Schmelzpunkt.Text = tbschmelzpunkt + x.ToString() + temperatur;
            }
            else
                imgschmelzpunkt.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }
        public void schmelzpktprüfung(string schmelzpkt, string x)
        {
            if (schmelzpkt == x)
            {
                imgschmelzpunkt.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bschmelzpunkt = true;
                schmelzpunkt.IsReadOnly = true;
                richtig++;
                Schmelzpunkt.Text = tbschmelzpunkt + x + temperatur;
            }
            else
                imgschmelzpunkt.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }

        public void siedepktprüfung(int siedepkt, int x)
        {
            if (siedepkt == x)
            {
                imgsiedepunkt.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bsiedepunkt = true;
                siedepunkt.IsReadOnly = true;
                richtig++;
                Siedepunkt.Text = tbsiedepunkt + x.ToString() + temperatur;
            }
            else
                imgsiedepunkt.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }
        public void siedepktprüfung(string siedepkt, string x)
        {
            if (siedepkt == x)
            {
                imgsiedepunkt.Source = new BitmapImage(new Uri("Häckchen.png", UriKind.Relative));
                bsiedepunkt = true;
                siedepunkt.IsReadOnly = true;
                richtig++;
                Siedepunkt.Text = tbsiedepunkt + x + temperatur;
            }
            else
                imgsiedepunkt.Source = new BitmapImage(new Uri("Kreuz.png", UriKind.Relative));
        }
        #endregion

        #region Initialisierugen der textBoxes und des Buttons
        #region Zurücksetzen
        public void rücksetzen()
        {
            ordnungzahl.IsReadOnly = false;
            masse.IsReadOnly = false;
            dichte.IsReadOnly = false;
            ename.IsReadOnly = false;
            siedepunkt.IsReadOnly = false;
            schmelzpunkt.IsReadOnly = false;

            bdichte = false;
            bordnungszahl = false;
            bsiedepunkt = false;
            bschmelzpunkt = false;
            bmasse = false;
            bname = false;
            fertig = false;

            btnh.IsEnabled = true;
            SBIversuche.Content = sbiversuche + "0";
            SBIrichtig.Content = sbirichtig + "0";
            a = 0;

            SBIrot.Visibility = Visibility.Collapsed;
            SBIweiß.Visibility = Visibility.Collapsed;
            SBIschwarz.Visibility = Visibility.Collapsed;

            SBIdiamant.Visibility = Visibility.Collapsed;
            SBIgraphit.Visibility = Visibility.Collapsed;

            SBIromb.Visibility = Visibility.Collapsed;
            SBImono.Visibility = Visibility.Collapsed;

            ordnungzahl.Clear();
            masse.Clear();
            ename.Clear();
            dichte.Clear();
            siedepunkt.Clear();
            schmelzpunkt.Clear();

            textBlock1.Visibility = Visibility.Hidden;
            imgordnungszahl.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgmasse.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgdichte.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgschmelzpunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgsiedepunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgname.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));

            Elementname.Text = "";
            elementsymbol.Text = "";
            Dichte.Text = tbdichte;
            Siedepunkt.Text = tbsiedepunkt;
            Schmelzpunkt.Text = tbschmelzpunkt;
            ordnungszahl.Text = "";
            Atommasse.Text = "";
        }
        public void rücksetzenp()
        {
            ordnungzahl.IsReadOnly = false;
            masse.IsReadOnly = false;
            dichte.IsReadOnly = false;
            ename.IsReadOnly = false;
            siedepunkt.IsReadOnly = false;
            schmelzpunkt.IsReadOnly = false;

            bdichte = false;
            bordnungszahl = false;
            bsiedepunkt = false;
            bschmelzpunkt = false;
            bmasse = false;
            bname = false;
            fertig = false;

            btnh.IsEnabled = true;
            SBIversuche.Content = sbiversuche + "0";
            SBIrichtig.Content = sbirichtig + "0";
            a = 0;

            SBIrot.Visibility = Visibility.Visible;
            SBIweiß.Visibility = Visibility.Visible;
            SBIschwarz.Visibility = Visibility.Visible;

            SBIdiamant.Visibility = Visibility.Collapsed;
            SBIgraphit.Visibility = Visibility.Collapsed;

            SBIromb.Visibility = Visibility.Collapsed;
            SBImono.Visibility = Visibility.Collapsed;

            ordnungzahl.Clear();
            masse.Clear();
            ename.Clear();
            dichte.Clear();
            siedepunkt.Clear();
            schmelzpunkt.Clear();

            textBlock1.Visibility = Visibility.Hidden;
            imgordnungszahl.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgmasse.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgdichte.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgschmelzpunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgsiedepunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgname.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));


            Elementname.Text = "";
            elementsymbol.Text = "";
            Dichte.Text = tbdichte;
            Siedepunkt.Text = tbsiedepunkt;
            Schmelzpunkt.Text = tbschmelzpunkt;
            ordnungszahl.Text = "";
            Atommasse.Text = "";
        }
        public void rücksetzens()
        {
            ordnungzahl.IsReadOnly = false;
            masse.IsReadOnly = false;
            dichte.IsReadOnly = false;
            ename.IsReadOnly = false;
            siedepunkt.IsReadOnly = false;
            schmelzpunkt.IsReadOnly = false;

            bdichte = false;
            bordnungszahl = false;
            bsiedepunkt = false;
            bschmelzpunkt = false;
            bmasse = false;
            bname = false;
            fertig = false;

            btnh.IsEnabled = true;
            SBIversuche.Content = sbiversuche + "0";
            SBIrichtig.Content = sbirichtig + "0";
            a = 0;

            SBIrot.Visibility = Visibility.Collapsed;
            SBIweiß.Visibility = Visibility.Collapsed;
            SBIschwarz.Visibility = Visibility.Collapsed;

            SBIdiamant.Visibility = Visibility.Collapsed;
            SBIgraphit.Visibility = Visibility.Collapsed;

            SBIromb.Visibility = Visibility.Visible;
            SBImono.Visibility = Visibility.Visible;

            ordnungzahl.Clear();
            masse.Clear();
            ename.Clear();
            dichte.Clear();
            siedepunkt.Clear();
            schmelzpunkt.Clear();

            textBlock1.Visibility = Visibility.Hidden;
            imgordnungszahl.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgmasse.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgdichte.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgschmelzpunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgsiedepunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgname.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));

            Elementname.Text = "";
            elementsymbol.Text = "";
            Dichte.Text = tbdichte;
            Siedepunkt.Text = tbsiedepunkt;
            Schmelzpunkt.Text = tbschmelzpunkt;
            ordnungszahl.Text = "";
            Atommasse.Text = "";
        }
        public void rücksetzenc()
        {
            ordnungzahl.IsReadOnly = false;
            masse.IsReadOnly = false;
            dichte.IsReadOnly = false;
            ename.IsReadOnly = false;
            siedepunkt.IsReadOnly = false;
            schmelzpunkt.IsReadOnly = false;

            bdichte = false;
            bordnungszahl = false;
            bsiedepunkt = false;
            bschmelzpunkt = false;
            bmasse = false;
            bname = false;
            fertig = false;

            btnh.IsEnabled = true;
            SBIversuche.Content = sbiversuche + "0";
            SBIrichtig.Content = sbirichtig + "0";
            a = 0;

            SBIrot.Visibility = Visibility.Collapsed;
            SBIweiß.Visibility = Visibility.Collapsed;
            SBIschwarz.Visibility = Visibility.Collapsed;

            SBIdiamant.Visibility = Visibility.Visible;
            SBIgraphit.Visibility = Visibility.Visible;

            SBIromb.Visibility = Visibility.Collapsed;
            SBImono.Visibility = Visibility.Collapsed;

            ordnungzahl.Clear();
            masse.Clear();
            ename.Clear();
            dichte.Clear();
            siedepunkt.Clear();
            schmelzpunkt.Clear();

            textBlock1.Visibility = Visibility.Hidden;
            imgordnungszahl.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgmasse.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgdichte.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgschmelzpunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgsiedepunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgname.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));

            Elementname.Text = "";
            elementsymbol.Text = "";
            Dichte.Text = tbdichte;
            Siedepunkt.Text = tbsiedepunkt;
            Schmelzpunkt.Text = tbschmelzpunkt;
            ordnungszahl.Text = "";
            Atommasse.Text = "";
        }
        public void rücksetzensp()
        {
            ordnungzahl.IsReadOnly = true;
            masse.IsReadOnly = true;
            dichte.IsReadOnly = true;
            ename.IsReadOnly = true;
            siedepunkt.IsReadOnly = true;
            schmelzpunkt.IsReadOnly = true;

            btnh.IsEnabled = false;
            SBIversuche.Content = sbiversuche + "0";
            SBIrichtig.Content = sbirichtig + "0";
            a = 0;

            SBIrot.Visibility = Visibility.Collapsed;
            SBIweiß.Visibility = Visibility.Collapsed;
            SBIschwarz.Visibility = Visibility.Collapsed;

            SBIdiamant.Visibility = Visibility.Collapsed;
            SBIgraphit.Visibility = Visibility.Collapsed;

            SBIromb.Visibility = Visibility.Collapsed;
            SBImono.Visibility = Visibility.Collapsed;

            ordnungzahl.Clear();
            masse.Clear();
            ename.Clear();
            dichte.Clear();
            siedepunkt.Clear();
            schmelzpunkt.Clear();

            textBlock1.Visibility = Visibility.Hidden;
            imgordnungszahl.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgmasse.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgdichte.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgschmelzpunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgsiedepunkt.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));
            imgname.Source = new BitmapImage(new Uri("Normal.png", UriKind.Relative));

            Elementname.Text = "";
            elementsymbol.Text = "";
            Dichte.Text = tbdichte;
            Siedepunkt.Text = tbsiedepunkt;
            Schmelzpunkt.Text = tbschmelzpunkt;
            ordnungszahl.Text = "";
            Atommasse.Text = "";
        }
        #endregion
        private void symbolfarbe(string Hintergrund)
        {
            elementsymbol.Text = elem;
            elementsymbolfarbe.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente;component/Bilder/Hintergründe/" + Hintergrund, UriKind.RelativeOrAbsolute));
            if (Hintergrund == "Alkalimetalle.png")
            {
                Elementname.Foreground = new SolidColorBrush(Colors.White);
                elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                Atommasse.Foreground = new SolidColorBrush(Colors.White);
                ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
                Dichte.Foreground = new SolidColorBrush(Colors.White);
                Siedepunkt.Foreground = new SolidColorBrush(Colors.White);
                Schmelzpunkt.Foreground = new SolidColorBrush(Colors.White);
            }
            else
                if (Hintergrund == "Erdalkalimetalle.png")
                {
                    Elementname.Foreground = new SolidColorBrush(Colors.White);
                    elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                    Atommasse.Foreground = new SolidColorBrush(Colors.White);
                    ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
                    Dichte.Foreground = new SolidColorBrush(Colors.White);
                    Siedepunkt.Foreground = new SolidColorBrush(Colors.White);
                    Schmelzpunkt.Foreground = new SolidColorBrush(Colors.White);
                }
                else
                    if (Hintergrund == "Edelgase.png")
                    {
                        Elementname.Foreground = new SolidColorBrush(Colors.White);
                        elementsymbol.Foreground = new SolidColorBrush(Colors.White);
                        Atommasse.Foreground = new SolidColorBrush(Colors.White);
                        ordnungszahl.Foreground = new SolidColorBrush(Colors.White);
                        Dichte.Foreground = new SolidColorBrush(Colors.White);
                        Siedepunkt.Foreground = new SolidColorBrush(Colors.White);
                        Schmelzpunkt.Foreground = new SolidColorBrush(Colors.White);
                    }
                    else
                    {
                        Elementname.Foreground = new SolidColorBrush(Colors.Black);
                        elementsymbol.Foreground = new SolidColorBrush(Colors.Black);
                        Atommasse.Foreground = new SolidColorBrush(Colors.Black);
                        ordnungszahl.Foreground = new SolidColorBrush(Colors.Black);
                        Dichte.Foreground = new SolidColorBrush(Colors.Black);
                        Siedepunkt.Foreground = new SolidColorBrush(Colors.Black);
                        Schmelzpunkt.Foreground = new SolidColorBrush(Colors.Black);
                    }
        }
        #region 1. HG
        private void wasserstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "H";
            gruppe = "HG1";
            symbolfarbe("Gase.png");
        }
        private void lithium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Li";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        private void natrium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Na";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        private void kalium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "K";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        private void rubidium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Rb";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        private void caesium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cs";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        private void francium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Fr";
            gruppe = "HG1";
            symbolfarbe("Alkalimetalle.png");
        }
        #endregion
        #region 2. HG
        private void beryllium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Be";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        private void magnesium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Mg";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        private void calcium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ca";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        private void strontium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Sr";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        private void barium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ba";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        private void radium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ra";
            gruppe = "HG2";
            symbolfarbe("Erdalkalimetalle.png");
        }
        #endregion

        #region 3. NG
        private void scandium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Sc";
            gruppe = "NG3";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void yttrium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Y";
            gruppe = "NG3";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void lanthan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "La";
            gruppe = "NG3";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void actinium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ac";
            gruppe = "NG3";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion

        #region Lanthanoide
        private void cer_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ce";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void praseodym_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pr";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void neodym_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Nd";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void promethium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pm";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void samarium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Sm";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void europium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Eu";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void gadolium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Gd";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void terbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Tb";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void dysprosium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Dy";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void holmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ho";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void erbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Er";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void thulium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Tm";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void ytterbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Yb";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        private void lutetium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Lu";
            gruppe = "LAN";
            symbolfarbe("Lanthanoide.png");
        }
        #endregion
        #region Actinoide
        private void thorium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Th";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void protactinium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pa";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void uran_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "U";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void neptunium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Np";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void plutonium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pu";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void americum_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Am";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void curium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cm";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        private void berkelium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Bk";
            gruppe = "ACT";
            symbolfarbe("Actinoide.png");
        }
        #endregion

        #region 4. NG
        private void titan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ti";
            gruppe = "NG4";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void zirconium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Zr";
            gruppe = "NG4";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void hafnium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Hf";
            gruppe = "NG4";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 5. NG
        private void vanadium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "V";
            gruppe = "NG5";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void niob_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Nb";
            gruppe = "NG5";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void tantal_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ta";
            gruppe = "NG5";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 6. NG
        private void chrom_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cr";
            gruppe = "NG6";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void molybdän_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Mo";
            gruppe = "NG6";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void wolfram_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "W";
            gruppe = "NG6";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 7. NG
        private void mangan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Mn";
            gruppe = "NG7";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void technetium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Tc";
            gruppe = "NG7";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void rhenium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Re";
            gruppe = "NG7";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 8. NG
        private void eisen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Fe";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void ruthenium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ru";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void osmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Os";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }

        private void cobalt_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Co";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void rhodium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Rh";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void iridium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ir";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }

        private void nickel_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ni";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void palladium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pd";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void platin_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pt";
            gruppe = "NG8";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 1. NG
        private void kupfer_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cu";
            gruppe = "NG1";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void silber_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ag";
            gruppe = "NG1";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void gold_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Au";
            gruppe = "NG1";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion
        #region 2. NG
        private void zink_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Zn";
            gruppe = "NG2";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void cadmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cd";
            gruppe = "NG2";
            symbolfarbe("Übergangsmetalle.png");
        }
        private void quecksilber_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Hg";
            gruppe = "NG2";
            symbolfarbe("Übergangsmetalle.png");
        }
        #endregion

        #region 3. HG
        private void bor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "B";
            gruppe = "HG3";
            symbolfarbe("Halbmetalle.png");
        }
        private void aluminium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Al";
            gruppe = "HG3";
            symbolfarbe("Metalle.png");
        }
        private void gallium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ga";
            gruppe = "HG3";
            symbolfarbe("Metalle.png");
        }
        private void indium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "In";
            gruppe = "HG3";
            symbolfarbe("Metalle.png");
        }
        private void thallium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Tl";
            gruppe = "HG3";
            symbolfarbe("Metalle.png");
        }
        #endregion
        #region 4. HG
        private void kohlenstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzenc();
            SBIdiamant.IsChecked = true;
            elem = "C";
            gruppe = "HG4";
            symbolfarbe("Feststoffe.png");
        }
        private void silicium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Si";
            gruppe = "HG4";
            symbolfarbe("Halbmetalle.png");
        }
        private void germanium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ge";
            gruppe = "HG4";
            symbolfarbe("Halbmetalle.png");
        }
        private void zinn_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Sn";
            gruppe = "HG4";
            symbolfarbe("Metalle.png");
        }
        private void blei_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Pb";
            gruppe = "HG4";
            symbolfarbe("Metalle.png");
        }
        #endregion
        #region 5. HG
        private void stickstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "N";
            gruppe = "HG5";
            symbolfarbe("Gase.png");
        }
        private void phosphor_click(object sender, RoutedEventArgs e)
        {
            rücksetzenp();
            SBIweiß.IsChecked = true;
            elem = "P";
            gruppe = "HG5";
            symbolfarbe("Feststoffe.png");
        }
        private void arsen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "As";
            gruppe = "HG5";
            symbolfarbe("Halbmetalle.png");
        }
        private void antimon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Sb";
            gruppe = "HG5";
            symbolfarbe("Halbmetalle.png");
        }
        private void bismut_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Bi";
            gruppe = "HG5";
            symbolfarbe("Metalle.png");
        }
        #endregion
        #region 6. HG
        private void sauerstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "O";
            gruppe = "HG6";
            symbolfarbe("Gase.png");
        }
        private void schwefel_click(object sender, RoutedEventArgs e)
        {
            rücksetzens();
            SBImono.IsChecked = true;
            elem = "S";
            gruppe = "HG6";
            symbolfarbe("Feststoffe.png");
        }
        private void selen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Se";
            gruppe = "HG6";
            symbolfarbe("Halbmetalle.png");
        }
        private void tellur_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Te";
            gruppe = "HG6";
            symbolfarbe("Halbmetalle.png");
        }
        private void polonium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Po";
            gruppe = "HG6";
            symbolfarbe("Halbmetalle.png");
        }
        #endregion
        #region 7. HG
        private void fluor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "F";
            gruppe = "HG7";
            symbolfarbe("Halogene.png");
        }
        private void chlor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Cl";
            gruppe = "HG7";
            symbolfarbe("Halogene.png");
        }
        private void brom_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Br";
            gruppe = "HG7";
            symbolfarbe("Halogene.png");
        }
        private void iod_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "I";
            gruppe = "HG7";
            symbolfarbe("Halogene.png");
        }
        private void astat_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "At";
            gruppe = "HG7";
            symbolfarbe("Halogene.png");
        }
        #endregion
        #region 8. HG
        private void helium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "He";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        private void neon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ne";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        private void argon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Ar";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        private void krypton_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Kr";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        private void xenon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Xe";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        private void radon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen();
            elem = "Rn";
            gruppe = "HG8";
            symbolfarbe("Halogene.png");
        }
        #endregion
        #endregion

        #region überprüfen
        private void überprüfen_Click(object sender, RoutedEventArgs e)
        {
            #region 1. HG
            if (gruppe == "HG1")
            {
                switch (elem)
                {
                    case "H":
                        #region Wasserstoff
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, H.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, H.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, H.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Wasserstoff");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, H.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, H.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig"; ;
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Li":
                        #region Lithium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Li.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Li.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Li.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Lithium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Li.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Li.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Na":
                        #region Natrium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Na.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Na.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Na.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Natrium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Na.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Na.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "K":
                        #region Kalium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, K.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, K.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, K.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Kalium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, K.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, K.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Rb":
                        #region Rubidium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Rb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Rb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Rb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Rubidium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Rb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Rb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Cs":
                        #region Caesium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cs.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cs.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cs.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Caesium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cs.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cs.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Fr":
                        #region Francium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Fr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Fr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strdichte = dichte.Text;
                                dichteprüfung(strdichte, Fr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Francium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Fr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Fr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 2. HG
            if (gruppe == "HG2")
            {
                switch (elem)
                {
                    case "Be":
                        #region Beryllium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Be.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Be.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Be.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Beryllium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Be.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Be.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Mg":
                        #region Magnesium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Mg.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Mg.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Mg.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Magnesium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Mg.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Mg.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ca":
                        #region Calcium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ca.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ca.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ca.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Calcium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ca.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ca.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Sr":
                        #region Strontium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Sr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Sr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Sr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Strontium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Sr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Sr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ba":
                        #region Barium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ba.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ba.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ba.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Barium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ba.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ba.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ra":
                        #region Radium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ra.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ra.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ra.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Radium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ra.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ra.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion

            #region 3. NG
            if (gruppe == "NG3")
            {
                switch (elem)
                {
                    case "Sc":
                        #region Scandium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Sc.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Sc.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Sc.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Scandium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Sc.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Sc.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Y":
                        #region Yttrium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Y.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Y.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Y.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Yttrium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Y.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Y.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "La":
                        #region Lanthan
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, La.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, La.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, La.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Lanthan");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, La.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, La.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ac":
                        #region Actinium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ac.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ac.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ac.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Actinium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ac.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ac.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion

            #region Lanthanoide
            if (gruppe == "LAN")
            {
                switch (elem)
                {
                    case "Ce":
                        #region Cer
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ce.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ce.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ce.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Cer");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ce.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ce.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pr":
                        #region Praseodym
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Praseodym");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Nd":
                        #region Neodym
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Nd.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Nd.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Nd.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Neodym");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Nd.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Nd.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pm":
                        #region Promethium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pm.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pm.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pm.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Promethium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pm.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pm.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Sm":
                        #region Samarium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Sm.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Sm.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Sm.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Samarium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Sm.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Sm.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Eu":
                        #region Europium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Eu.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Eu.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Eu.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Europium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Eu.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Eu.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Gd":
                        #region Gadolinium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Gd.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Gd.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Gd.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Gadolinium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Gd.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Gd.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Tb":
                        #region Terbium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Tb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Tb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Tb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Terbium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Tb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Tb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Dy":
                        #region Dysprosium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Dy.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Dy.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Dy.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Dysprosium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Dy.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Dy.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ho":
                        #region Holmium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ho.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ho.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ho.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Holmium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ho.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ho.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Er":
                        #region Erbium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Er.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Er.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Er.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Erbium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Er.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Er.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Tm":
                        #region Thulium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Tm.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Tm.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Tm.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Thulium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Tm.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Tm.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Yb":
                        #region Ytterbium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Yb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Yb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Yb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Ytterbium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Yb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Yb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Lu":
                        #region Lutetium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Lu.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Lu.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Lu.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Lutetium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Lu.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Lu.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region Actinoide
            if (gruppe == "ACT")
            {
                switch (elem)
                {
                    case "Th":
                        #region Thorium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Th.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Th.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Th.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Thorium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Th.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Th.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pa":
                        #region Protactinium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pa.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pa.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pa.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Protactinium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pa.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pa.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "U":
                        #region Uran
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, U.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, U.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, U.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Uran");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, U.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, U.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Np":
                        #region Neptunium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Np.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Np.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Np.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Neptunium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Np.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Np.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pu":
                        #region Plutonium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pu.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pu.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pu.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Plutonium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pu.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pu.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Am":
                        #region Americium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Am.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Am.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Am.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Americium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Am.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Am.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Cm":
                        #region Curium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cm.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cm.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cm.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Curium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cm.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cm.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Bk":
                        #region Berkelium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Bk.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Bk.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Bk.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Berkelium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Bk.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Bk.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion

            #region 4. NG
            if (gruppe == "NG4")
            {

                switch (elem)
                {
                    case "Ti":
                        #region Titan
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ti.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ti.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ti.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Titan");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ti.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ti.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Zr":
                        #region Zirkonium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Zr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Zr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Zr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Zirkonium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Zr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Zr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Hf":
                        #region Hafnium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Hf.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Hf.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Hf.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Hafnium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Hf.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Hf.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 5. NG
            if (gruppe == "NG5")
            {
                switch (elem)
                {
                    case "V":
                        #region Vanadium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, V.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, V.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, V.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Vanadium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, V.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, V.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Nb":
                        #region Niob
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Nb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Nb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Nb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Niob");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Nb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Nb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ta":
                        #region Tantal
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ta.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ta.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ta.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Tantal");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ta.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ta.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 6. NG
            if (gruppe == "NG6")
            {

                switch (elem)
                {
                    case "Cr":
                        #region Chrom
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Chrom");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Mo":
                        #region Molybdän
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Mo.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Mo.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Mo.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Molybdän");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Mo.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Mo.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "W":
                        #region Wolfram
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, W.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, W.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, W.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Wolfram");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, W.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, W.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 7. NG
            if (gruppe == "NG7")
            {
                switch (elem)
                {
                    case "Mn":
                        #region Mangan
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Mn.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Mn.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Mn.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Mangan");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Mn.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Mn.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Tc":
                        #region Technetium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Tc.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Tc.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Tc.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Technetium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Tc.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Tc.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Re":
                        #region Rhenium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Re.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Re.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Re.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Rhenium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Re.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Re.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 8. NG
            if (gruppe == "NG8")
            {
                switch (elem)
                {
                    case "Fe":
                        #region Eisen
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Fe.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Fe.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Fe.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Eisen");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Fe.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Fe.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ru":
                        #region Ruthenium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ru.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ru.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ru.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Ruthenium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ru.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ru.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Os":
                        #region Osmium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Os.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Os.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Os.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Osmium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Os.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Os.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion

                    case "Co":
                        #region Cobalt
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Co.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Co.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Co.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Cobalt");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Co.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Co.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Rh":
                        #region Rhodium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Rh.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Rh.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Rh.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Rhodium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Rh.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Rh.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ir":
                        #region Iridium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ir.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ir.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ir.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Iridium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ir.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ir.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion

                    case "Ni":
                        #region Nickel
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ni.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ni.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ni.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Nickel");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ni.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ni.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pd":
                        #region Palladium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pd.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pd.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pd.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Palladium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pd.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pd.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pt":
                        #region Platin
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pt.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pt.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pt.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Platin");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pt.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pt.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 1. NG
            if (gruppe == "NG1")
            {
                switch (elem)
                {
                    case "Cu":
                        #region Kupfer
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cu.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cu.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cu.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Kupfer");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cu.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cu.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ag":
                        #region Silber
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ag.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ag.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ag.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Silber");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ag.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ag.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Au":
                        #region Gold
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Au.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Au.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Au.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Gold");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Au.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Au.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 2. NG
            if (gruppe == "NG2")
            {
                switch (elem)
                {
                    case "Zn":
                        #region Zink
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Zn.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Zn.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Zn.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Zink");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Zn.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Zn.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Cd":
                        #region Cadmium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cd.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cd.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cd.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Cadmium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cd.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cd.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Hg":
                        #region Quecksilber
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Hg.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Hg.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Hg.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Quecksilber");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Hg.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Hg.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion

            #region 3. HG
            if (gruppe == "HG3")
            {
                switch (elem)
                {
                    case "B":
                        #region Bor
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, B.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, B.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, B.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Bor");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, B.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, B.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Al":
                        #region Aluminium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Al.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Al.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Al.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Aluminium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Al.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Al.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ga":
                        #region Gallium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ga.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ga.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ga.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Gallium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ga.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ga.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "In":
                        #region Indium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, In.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, In.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, In.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Indium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, In.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, In.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Tl":
                        #region Thallium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Tl.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Tl.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Tl.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Thallium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Tl.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Tl.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 4. HG
            if (gruppe == "HG4")
            {
                switch (elem)
                {
                    case "C":
                        #region Kohlenstoff
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, C.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, C.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            #region Dichte
                            if (SBIgraphit.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, C.DichteG);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIdiamant.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, C.DichteD);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }
                            #endregion

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Kohlenstoff");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, C.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, C.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Si":
                        #region Silicium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Si.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Si.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Si.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Silicium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Si.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Si.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ge":
                        #region Germanium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ge.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ge.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ge.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Germanium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ge.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ge.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Sn":
                        #region Zinn
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Sn.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Sn.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Sn.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Zinn");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Sn.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Sn.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Pb":
                        #region Blei
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Pb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Pb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Pb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Blei");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Pb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Pb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 5. HG
            if (gruppe == "HG5")
            {
                switch (elem)
                {
                    case "N":
                        #region Stickstoff
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, N.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, N.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, N.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Stickstoff");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, N.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, N.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "P":
                        #region Phosphor
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, P.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, P.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Phosphor");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            #region Dichte
                            if (SBIrot.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, P.DichteR);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIweiß.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, P.DichteW);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIschwarz.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, P.DichteS);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }
                            #endregion

                            #region Schmelztemp
                            if (SBIrot.IsChecked == true)
                            {
                                try
                                {
                                    int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                    schmelzpktprüfung(intschmelzpkt, P.SchmelztemperaturR);
                                }
                                catch (FormatException)
                                {
                                    schmelzpunkt.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIweiß.IsChecked == true)
                            {
                                try
                                {
                                    int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                    schmelzpktprüfung(intschmelzpkt, P.SchmelztemperaturW);
                                }
                                catch (FormatException)
                                {
                                    schmelzpunkt.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIschwarz.IsChecked == true)
                            {
                                try
                                {
                                    string strschmelzpkt = schmelzpunkt.Text;
                                    schmelzpktprüfung(strschmelzpkt, P.SchmelztemperaturS);
                                }
                                catch (FormatException)
                                {
                                    schmelzpunkt.Text = "Zahlen eingeben";
                                }
                            }
                            #endregion

                            #region Siedetemp
                            if (SBIweiß.IsChecked == true)
                            {
                                try
                                {
                                    int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                    siedepktprüfung(intsiedepkt, P.SiedetemperaturW);
                                }
                                catch (FormatException)
                                {
                                    siedepunkt.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIrot.IsChecked == true)
                            {
                                try
                                {
                                    int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                    siedepktprüfung(intsiedepkt, P.SiedetemperaturR);
                                }
                                catch (FormatException)
                                {
                                    siedepunkt.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIschwarz.IsChecked == true)
                            {
                                try
                                {
                                    string strsiedepkt = siedepunkt.Text;
                                    siedepktprüfung(strsiedepkt, P.SiedetemperaturS);
                                }
                                catch (FormatException)
                                {
                                    siedepunkt.Text = "Zahlen eingeben";
                                }
                            }
                            #endregion

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "As":
                        #region Arsen
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, As.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, As.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, As.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Arsen");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, As.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, As.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Sb":
                        #region Antimon
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Sb.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Sb.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Sb.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Antimon");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Sb.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Sb.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Bi":
                        #region Bismut
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Bi.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Bi.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Bi.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Bismut");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Bi.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Bi.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 6. HG
            if (gruppe == "HG6")
            {
                switch (elem)
                {
                    case "O":
                        #region Sauerstoff
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, O.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, O.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, O.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Sauerstoff");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, O.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, O.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "S":
                        #region Schwefel
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, S.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, S.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            #region Dichte
                            if (SBImono.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, S.DichteM);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }

                            if (SBIromb.IsChecked == true)
                            {
                                try
                                {
                                    float fltdichte = Convert.ToSingle(dichte.Text);
                                    dichteprüfung(fltdichte, S.DichteR);
                                }
                                catch (FormatException)
                                {
                                    dichte.Text = "Zahlen eingeben";
                                }
                            }
                            #endregion

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Schwefel");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, S.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, S.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Se":
                        #region Selen
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Se.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Se.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Se.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Selen");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Se.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Se.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Te":
                        #region Tellur
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Te.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Te.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Te.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Tellur");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Te.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Te.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Po":
                        #region Polonium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Po.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Po.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Po.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Polonium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Po.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Po.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 7. HG
            if (gruppe == "HG7")
            {
                switch (elem)
                {
                    case "F":
                        #region Fluor
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, F.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, F.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, F.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Fluor");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, F.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, F.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Cl":
                        #region Chlor
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Cl.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Cl.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Cl.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Chlor");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Cl.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Cl.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Br":
                        #region Brom
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Br.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Br.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Br.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Brom");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Br.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Br.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "I":
                        #region Iod
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, I.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, I.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, I.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Iod");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, I.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, I.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "At":
                        #region Astat
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, At.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, At.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strdichte = dichte.Text;
                                dichteprüfung(strdichte, At.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Astat");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, At.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, At.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
            #region 8. HG
            if (gruppe == "HG8")
            {
                switch (elem)
                {
                    case "He":
                        #region Helium
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, He.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, He.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, He.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Helium");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, He.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, He.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }

                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ne":
                        #region Neon
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ne.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ne.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ne.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Neon");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ne.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ne.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Ar":
                        #region Argon
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Ca.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Ar.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Ar.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Argon");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Ar.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Ar.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Kr":
                        #region Krypton
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Kr.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Kr.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Kr.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Krypton");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Kr.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Kr.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Xe":
                        #region Xenon
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;


                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Xe.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Xe.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Xe.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Xenon");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Xe.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Xe.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                    case "Rn":
                        #region Radon
                        do
                        {
                            ok = false;
                            a++;
                            bordnungszahl = false;
                            bmasse = false;
                            bdichte = false;
                            bname = false;
                            bsiedepunkt = false;
                            bschmelzpunkt = false;

                            try
                            {
                                int intordnungszahl = Convert.ToInt32(ordnungzahl.Text);
                                ordnungszahlprüfung(intordnungszahl, Rn.Ordnungszahl);
                            }
                            catch (FormatException)
                            {
                                ordnungzahl.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intmasse = Convert.ToInt32(masse.Text);
                                masseprüfung(intmasse, Rn.Massezahl);
                            }
                            catch (FormatException)
                            {
                                masse.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                float fltdichte = Convert.ToSingle(dichte.Text);
                                dichteprüfung(fltdichte, Rn.Dichte);
                            }
                            catch (FormatException)
                            {
                                dichte.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                string strname = ename.Text;
                                nameprüfung(strname, "Radon");
                            }
                            catch (FormatException)
                            {
                                ename.Text = "Name eingeben";
                            }

                            try
                            {
                                int intschmelzpkt = Convert.ToInt32(schmelzpunkt.Text);
                                schmelzpktprüfung(intschmelzpkt, Rn.Schmelztemperatur);
                            }
                            catch (FormatException)
                            {
                                schmelzpunkt.Text = "Zahlen eingeben";
                            }

                            try
                            {
                                int intsiedepkt = Convert.ToInt32(siedepunkt.Text);
                                siedepktprüfung(intsiedepkt, Rn.Siedetemperatur);
                            }
                            catch (FormatException)
                            {
                                siedepunkt.Text = "Zahlen eingeben";
                            }


                            if (bordnungszahl == true & bmasse == true & bdichte == true & bname == true & bsiedepunkt == true & bschmelzpunkt == true)
                            {
                                fertig = true;
                            }
                            SBIrichtig.Content = sbirichtig + richtig.ToString();
                            SBIversuche.Content = sbiversuche + a.ToString();
                            richtig = 0;
                        } while (ok == true);

                        if (fertig == true)
                        {
                            if (a > 1)
                            {
                                versuche.Text = "Alles richtig mit " + a + " Versuchen";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            if (a == 1)
                            {
                                versuche.Text = "Sehr gut alles beim 1. mal richtig";
                                SBIversuche.Content = "Wählen Sie ein neues Element aus";
                                btnh.IsEnabled = false;
                            }
                            textBlock1.Visibility = Visibility.Visible;
                        }
                        break;
                        #endregion
                }
            }
            #endregion
        }
        #endregion
    }
}