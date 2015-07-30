using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Periodensystem_2;
using System.Windows.Media;
using System.Windows.Input;

namespace Periodensystem_der_Elemente_2
{
    /// <summary>
    /// Interaktionslogik für Übung.xaml
    /// </summary>
    public partial class Übung_nach_System : Page
    {
        public Übung_nach_System()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBindings.Add(new CommandBinding(Commands.Check, Check_Executed));
            button1.IsEnabled = false;
        }
        
        #region Integer
        private static int versuche = 0;
        private static int richtige = 0;
        #endregion

        #region Strings
        private static string elem;
        #endregion

        #region andere
        Element dummy;
        #endregion

        #region Initialisierugen der textBoxes und des Buttons
        #region Zurücksetzen
        public void rücksetzen(string element)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;

            elem = element;
            versuche = 0;
            richtige = 0;

            tbdichte.Text = "";
            tbdichte.IsReadOnly = false;

            tbelementname.Text = "";
            tbelementname.IsReadOnly = false;

            tbmassezahl.Text = "";
            tbmassezahl.IsReadOnly = false;

            tbordnungszahl.Text = "";
            tbordnungszahl.IsReadOnly = false;

            tbschmelzpkt.Text = "";
            tbschmelzpkt.IsReadOnly = false;

            tbsiedepkt.Text = "";
            tbsiedepkt.IsReadOnly = false;

            einheitdichte.IsEnabled = true;
            einheitdichte.Text = "Einheit der Dichte";

            einheitmassezahl.IsEnabled = true;
            einheitmassezahl.Text = "Einheit der Masse";

            einheitschmelzpkt.IsEnabled = true;
            einheitschmelzpkt.Text = "Einheit des Schmelzpunkts";

            einheitsiedepkt.IsEnabled = true;
            einheitsiedepkt.Text = "Einheit des Siedepunkts";

            imgätzend.Source = null;
            imgdichte.Source = null;
            imgentzündlich.Source = null;
            imggiftig.Source = null;
            imgmassezahl.Source = null;
            imgname.Source = null;
            imgordnungszahl.Source = null;
            imgradioaktiv.Source = null;
            imgreizend.Source = null;
            imgschmelzpkt.Source = null;
            imgsiedepkt.Source = null;
            Allesrichtig.Source = null;

            ätzend.IsEnabled = true;
            ätzend.IsChecked = null;

            entzündlich.IsEnabled = true;
            entzündlich.IsChecked = null;

            giftig.IsEnabled = true;
            giftig.IsChecked = null;

            radioaktiv.IsEnabled = true;
            radioaktiv.IsChecked = null;

            reizend.IsEnabled = true;
            reizend.IsChecked = null;

            SBIRichtig.Content = richtige;
            SBIVersuche.Content = versuche;
        }
        #endregion
        #region 1. HG
        private void wasserstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("H");
        }
        private void lithium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Li");
        }
        private void natrium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Na");
        }
        private void kalium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("K");
        }
        private void rubidium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Rb");
        }
        private void caesium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cs");
        }
        private void francium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Fr");
        }
        #endregion
        #region 2. HG
        private void beryllium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Be");
        }
        private void magnesium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Mg");
        }
        private void calcium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ca");
        }
        private void strontium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Sr");
        }
        private void barium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ba");
        }
        private void radium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ra");
        }
        #endregion

        #region 3. NG
        private void scandium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Sc");
        }
        private void yttrium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Y");
        }
        private void lanthan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("La");
        }
        private void actinium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ac");
        }
        #endregion

        #region Lanthanoide
        private void cer_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ce");
        }
        private void praseodym_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pr");
        }
        private void neodym_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Nd");
        }
        private void promethium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pm");
        }
        private void samarium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Sm");
        }
        private void europium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Eu");
        }
        private void gadolium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Gd");
        }
        private void terbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Tb");
        }
        private void dysprosium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Dy");
        }
        private void holmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ho");
        }
        private void erbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Er");
        }
        private void thulium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Tm");
        }
        private void ytterbium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Yb");
        }
        private void lutetium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Lu");
        }
        #endregion
        #region Actinoide
        private void thorium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Th");
        }
        private void protactinium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pa");
        }
        private void uran_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("U");
        }
        private void neptunium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Np");
        }
        private void plutonium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pu");
        }
        private void americum_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Am");
        }
        private void curium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cm");
        }
        private void berkelium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Bk");
        }
        private void californium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cf");
        }
        #endregion

        #region 4. NG
        private void titan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ti");
        }
        private void zirconium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Zr");
        }
        private void hafnium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Hf");
        }
        #endregion
        #region 5. NG
        private void vanadium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("V");
        }
        private void niob_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Nb");
        }
        private void tantal_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ta");
        }
        #endregion
        #region 6. NG
        private void chrom_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cr");
        }
        private void molybdän_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Mo");
        }
        private void wolfram_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("W");
        }
        #endregion
        #region 7. NG
        private void mangan_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Mn");
        }
        private void technetium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Tc");
        }
        private void rhenium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Re");
        }
        #endregion
        #region 8. NG
        private void eisen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Fe");
        }
        private void ruthenium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ru");
        }
        private void osmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Os");
        }

        private void cobalt_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Co");
        }
        private void rhodium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Rh");
        }
        private void iridium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ir");
        }

        private void nickel_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ni");
        }
        private void palladium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pd");
        }
        private void platin_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pt");
        }
        #endregion
        #region 1. NG
        private void kupfer_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cu");
        }
        private void silber_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ag");
        }
        private void gold_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Au");
        }
        #endregion
        #region 2. NG
        private void zink_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Zn");
        }
        private void cadmium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cd");
        }
        private void quecksilber_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Hg");
        }
        #endregion

        #region 3. HG
        private void bor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("B");
        }
        private void aluminium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Al");
        }
        private void gallium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ga");
        }
        private void indium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("In");
        }
        private void thallium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Tl");
        }
        #endregion
        #region 4. HG
        private void kohlenstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("C");
        }
        private void silicium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Si");
        }
        private void germanium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ge");
        }
        private void zinn_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Sn");
        }
        private void blei_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Pb");
        }
        #endregion
        #region 5. HG
        private void stickstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("N");
        }
        private void phosphor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("P");
        }
        private void arsen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("As");
        }
        private void antimon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Sb");
        }
        private void bismut_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Bi");
        }
        #endregion
        #region 6. HG
        private void sauerstoff_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("O");
        }
        private void schwefel_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("S");
        }
        private void selen_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Se");
        }
        private void tellur_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Te");
        }
        private void polonium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Po");
        }
        #endregion
        #region 7. HG
        private void fluor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("F");
        }
        private void chlor_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Cl");
        }
        private void brom_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Br");
        }
        private void iod_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("I");
        }
        private void astat_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("At");
        }
        #endregion
        #region 8. HG
        private void helium_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("He");
        }
        private void neon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ne");
        }
        private void argon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Ar");
        }
        private void krypton_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Kr");
        }
        private void xenon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Xe");
        }
        private void radon_click(object sender, RoutedEventArgs e)
        {
            rücksetzen("Rn");
        }
        #endregion
        #endregion

        #region Überprüfen
        private void check(Element element)
        {
            dummy = element;
            versuche++;
            richtige = 0;
            //Name
            switch (element.Name.Equals(tbelementname.Text))
            {
                case true: tbelementname.IsReadOnly = true;
                    richtige++;
                    richtig(imgname);
                    break;
                case false: falsch(imgname);
                    break;
            }
            //Ordnungszahl
            switch (element.Ordnungszahl.Equals(tbordnungszahl.Text))
            {
                case true: tbordnungszahl.IsReadOnly = true;
                    richtige++;
                    richtig(imgordnungszahl);
                    break;
                case false: falsch(imgordnungszahl);
                    break;
            }
            //Massezahl
            switch (element.Massezahl.Equals(tbmassezahl.Text))
            {
                case true: tbmassezahl.IsReadOnly = true;
                    richtige++;
                    richtig(imgmassezahl);
                    //Masseeinheit
                    switch (Element.masseein.Equals(einheitmassezahl.Text))
                    {
                        case true: einheitmassezahl.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgmassezahl);
                            break;
                    }
                    break;
                case false: falsch(imgmassezahl);
                    break;
            }
            //Dichte
            switch (element.Dichte.Equals(tbdichte.Text))
            {
                case true: tbdichte.IsReadOnly = true;
                    richtige++;
                    richtig(imgdichte);
                    //Dichteeinheit
                    switch (Element.dichteein.Equals(einheitdichte.Text))
                    {
                        case true: einheitdichte.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgdichte);
                            break;
                    }
                    break;
                case false: falsch(imgdichte);
                    break;
            }
            //Schmelzpkt
            switch (element.Schmelztemperatur.Equals(tbschmelzpkt.Text))
            {
                case true: tbschmelzpkt.IsReadOnly = true;
                    richtige++;
                    richtig(imgschmelzpkt);
                    //Schmelzpkteinheit
                    switch (Element.tempein.Equals(einheitschmelzpkt.Text))
                    {
                        case true: einheitschmelzpkt.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgschmelzpkt);
                            break;
                    }
                    break;
                case false: falsch(imgschmelzpkt);
                    break;
            }
            //Siedepkt
            switch (element.Siedetemperatur.Equals(tbsiedepkt.Text))
            {
                case true: tbsiedepkt.IsReadOnly = true;
                    richtige++;
                    richtig(imgsiedepkt);
                    //Einheitsiedepkt
                    switch (Element.tempein.Equals(einheitsiedepkt.Text))
                    {
                        case true: einheitsiedepkt.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgsiedepkt);
                            break;
                    }
                    break;
                case false: falsch(imgsiedepkt);
                    break;
            }
            //Giftig
            switch (element.Giftig.Equals(giftig.IsChecked))
            {
                case true: giftig.IsEnabled = false;
                    richtige++;
                    richtig(imggiftig);
                    break;
                case false: falsch(imggiftig);
                    break;
            }
            //Radioaktiv
            switch (element.Radioaktiv.Equals(radioaktiv.IsChecked))
            {
                case true: radioaktiv.IsEnabled = false;
                    richtige++;
                    richtig(imgradioaktiv);
                    break;
                case false: falsch(imgradioaktiv);
                    break;
            }
            //Ätzend
            switch (element.Ätzend.Equals(ätzend.IsChecked))
            {
                case true: ätzend.IsEnabled = false;
                    richtige++;
                    richtig(imgätzend);
                    break;
                case false: falsch(imgätzend);
                    break;
            }
            //Entzündlich
            switch (element.Entzündlich.Equals(entzündlich.IsChecked))
            {
                case true: entzündlich.IsEnabled = false;
                    richtige++;
                    richtig(imgentzündlich);
                    break;
                case false: falsch(imgentzündlich);
                    break;
            }
            //Reizend
            switch (element.Reizend.Equals(reizend.IsChecked))
            {
                case true: reizend.IsEnabled = false;
                    richtige++;
                    richtig(imgreizend);
                    break;
                case false: falsch(imgreizend);
                    break;
            }
            if (richtige == 15)
            {
                allesrichtig();
            }
            SBIVersuche.Content = versuche;
            SBIRichtig.Content = richtige;
        }
        private void richtig(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Default_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void falscheeinheit(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Complete_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void falsch(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Error_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void allesrichtig()
        {
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            Allesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/112_Tick_Green_64x64_72.png", UriKind.RelativeOrAbsolute));
        }
        private void info(Image[] bild)
        {
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            for (int i = 0; i < bild.Length; i++)
                bild[i].Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Info_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void Check_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (elem == null)
            {
            }
            else
            {
                switch (elem.ToUpper())
                {
                    //1. Hauptgruppe
                    case "H": check(Elemente.H);
                        break;
                    case "LI": check(Elemente.Li);
                        break;
                    case "NA": check(Elemente.Na);
                        break;
                    case "K": check(Elemente.K);
                        break;
                    case "RB": check(Elemente.Rb);
                        break;
                    case "CS": check(Elemente.Cs);
                        break;
                    case "FR": check(Elemente.Fr);
                        break;
                    //2. Hauptgruppe
                    case "BE": check(Elemente.Be);
                        break;
                    case "MG": check(Elemente.Mg);
                        break;
                    case "CA": check(Elemente.Ca);
                        break;
                    case "SR": check(Elemente.Sr);
                        break;
                    case "BA": check(Elemente.Ba);
                        break;
                    case "RA": check(Elemente.Ra);
                        break;

                    //3. Nebengruppe
                    case "SC": check(Elemente.Sc);
                        break;
                    case "Y": check(Elemente.Y);
                        break;
                    case "LA": check(Elemente.La);
                        break;
                    case "AC": check(Elemente.Ac);
                        break;

                    //Lanthanoide
                    case "CE": check(Elemente.Ce);
                        break;
                    case "PR": check(Elemente.Pr);
                        break;
                    case "ND": check(Elemente.Nd);
                        break;
                    case "PM": check(Elemente.Pm);
                        break;
                    case "SM": check(Elemente.Sm);
                        break;
                    case "EU": check(Elemente.Eu);
                        break;
                    case "GD": check(Elemente.Gd);
                        break;
                    case "TB": check(Elemente.Tb);
                        break;
                    case "DY": check(Elemente.Dy);
                        break;
                    case "HO": check(Elemente.Ho);
                        break;
                    case "ER": check(Elemente.Er);
                        break;
                    case "TM": check(Elemente.Tm);
                        break;
                    case "YB": check(Elemente.Yb);
                        break;
                    case "LU": check(Elemente.Lu);
                        break;

                    //Actinoide
                    case "TH": check(Elemente.Th);
                        break;
                    case "PA": check(Elemente.Pa);
                        break;
                    case "U": check(Elemente.U);
                        break;
                    case "NP": check(Elemente.Np);
                        break;
                    case "PU": check(Elemente.Pu);
                        break;
                    case "AM": check(Elemente.Am);
                        break;
                    case "CM": check(Elemente.Cm);
                        break;
                    case "BK": check(Elemente.Bk);
                        break;
                    case "CF": check(Elemente.Cf);
                        break;

                    //4. Nebengruppe
                    case "TI": check(Elemente.Ti);
                        break;
                    case "ZR": check(Elemente.Zr);
                        break;
                    case "HF": check(Elemente.Hf);
                        break;
                    //5. Nebengruppe
                    case "V": check(Elemente.V);
                        break;
                    case "NB": check(Elemente.Nb);
                        break;
                    case "TA": check(Elemente.Ta);
                        break;
                    //6. Nebengruppe
                    case "CR": check(Elemente.Cr);
                        break;
                    case "MO": check(Elemente.Mo);
                        break;
                    case "W": check(Elemente.W);
                        break;
                    //7. Nebengruppe
                    case "MN": check(Elemente.Mn);
                        break;
                    case "TC": check(Elemente.Tc);
                        break;
                    case "RE": check(Elemente.Re);
                        break;
                    //8. Nebengruppe
                    case "FE": check(Elemente.Fe);
                        break;
                    case "RU": check(Elemente.Ru);
                        break;
                    case "OS": check(Elemente.Os);
                        break;
                    case "CO": check(Elemente.Co);
                        break;
                    case "RH": check(Elemente.Rh);
                        break;
                    case "IR": check(Elemente.Ir);
                        break;
                    case "NI": check(Elemente.Ni);
                        break;
                    case "PD": check(Elemente.Pd);
                        break;
                    case "PT": check(Elemente.Pt);
                        break;
                    //1. Nebengruppe
                    case "CU": check(Elemente.Cu);
                        break;
                    case "AG": check(Elemente.Ag);
                        break;
                    case "AU": check(Elemente.Au);
                        break;
                    //2. Nebengruppe
                    case "ZN": check(Elemente.Zn);
                        break;
                    case "CD": check(Elemente.Cd);
                        break;
                    case "HG": check(Elemente.Hg);
                        break;

                    //3. Hauptgruppe
                    case "B": check(Elemente.B);
                        break;
                    case "AL": check(Elemente.Al);
                        break;
                    case "GA": check(Elemente.Ga);
                        break;
                    case "IN": check(Elemente.In);
                        break;
                    case "TL": check(Elemente.Tl);
                        break;
                    //4. Hauptgruppe
                    case "C": check(Elemente.C);
                        break;
                    case "SI": check(Elemente.Si);
                        break;
                    case "GE": check(Elemente.Ge);
                        break;
                    case "SN": check(Elemente.Sn);
                        break;
                    case "PB": check(Elemente.Pb);
                        break;
                    //5. Hauptgruppe
                    case "N": check(Elemente.N);
                        break;
                    case "P": check(Elemente.P);
                        break;
                    case "AS": check(Elemente.As);
                        break;
                    case "SB": check(Elemente.Sb);
                        break;
                    case "BI": check(Elemente.Bi);
                        break;
                    //6. Hauptgruppe
                    case "O": check(Elemente.O);
                        break;
                    case "S": check(Elemente.S);
                        break;
                    case "SE": check(Elemente.Se);
                        break;
                    case "TE": check(Elemente.Te);
                        break;
                    case "PO": check(Elemente.Po);
                        break;
                    //7. Hauptgruppe
                    case "F": check(Elemente.F);
                        break;
                    case "CL": check(Elemente.Cl);
                        break;
                    case "BR": check(Elemente.Br);
                        break;
                    case "I": check(Elemente.I);
                        break;
                    case "AT": check(Elemente.At);
                        break;
                    //8. Hauptgruppe
                    case "HE": check(Elemente.He);
                        break;
                    case "NE": check(Elemente.Ne);
                        break;
                    case "AR": check(Elemente.Ar);
                        break;
                    case "KR": check(Elemente.Kr);
                        break;
                    case "XE": check(Elemente.Xe);
                        break;
                    case "RN": check(Elemente.Rn);
                        break;
                }
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            versuche++;
            SBIVersuche.Content = "Versuche: " + versuche.ToString();
            SBIRichtige.Content = "Lösung angezeigt";

            info(new Image[] 
            { 
                imgätzend, 
                imgdichte, 
                imgentzündlich, 
                imggiftig, 
                imgmassezahl,
                imgname, 
                imgordnungszahl,
                imgradioaktiv, 
                imgradioaktiv, 
                imgreizend, 
                imgschmelzpkt, 
                imgsiedepkt 
            });
            Allesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/009_HighPriority_48x48_72.png", UriKind.RelativeOrAbsolute));

            //Werte(TextBoxes)
            tbelementname.Text = dummy.Symbol;
            tbelementname.IsReadOnly = false;

            tbordnungszahl.Text = dummy.Ordnungszahl;
            tbordnungszahl.IsReadOnly = false;

            tbmassezahl.Text = dummy.Massezahl;
            tbmassezahl.IsReadOnly = false;

            tbdichte.Text = dummy.Dichte;
            tbdichte.IsReadOnly = false;

            tbschmelzpkt.Text = dummy.Schmelztemperatur;
            tbschmelzpkt.IsReadOnly = false;

            tbsiedepkt.Text = dummy.Siedetemperatur;
            tbsiedepkt.IsReadOnly = false;

            //Werte(CheckBoxes)
            giftig.IsChecked = dummy.Giftig;
            giftig.IsEnabled = false;

            radioaktiv.IsChecked = dummy.Radioaktiv;
            radioaktiv.IsEnabled = false;

            reizend.IsChecked = dummy.Reizend;
            reizend.IsEnabled = false;

            entzündlich.IsChecked = dummy.Entzündlich;
            entzündlich.IsEnabled = false;

            ätzend.IsChecked = dummy.Ätzend;
            ätzend.IsEnabled = false;

            //Werte(ComboBoxes)
            einheitmassezahl.Text = dummy.Massezahleinheit;
            einheitmassezahl.IsEnabled = false;

            einheitdichte.Text = dummy.Dichteeinheit;
            einheitdichte.IsEnabled = false;

            einheitschmelzpkt.Text = dummy.Schmelzpkteinheit;
            einheitschmelzpkt.IsEnabled = false;

            einheitsiedepkt.Text = dummy.Siedepkteinheit;
            einheitsiedepkt.IsEnabled = false;
        }
        #endregion
    }
}