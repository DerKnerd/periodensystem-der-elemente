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
using Periodensystem_2;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Übung_nach_Gruppe.xaml
    /// </summary>
    public partial class Übung_nach_Gruppe : Page
    {
        public Übung_nach_Gruppe()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBindings.Add(new CommandBinding(Commands.Check, Check_Executed));
        }

        #region Integer
        private static int versuche = 0;
        private static int richtige = 0;
        #endregion

        #region Strings
        string gruppe;
        #endregion

        #region andere
        Element dummy;
        #endregion

        #region Initialisierugen der textBoxes und des Buttons
        #region Zurücksetzen
        public void rücksetzen()
        {
            versuche = 0;
            richtige = 0;

            tbdichte.Text = "";
            tbdichte.IsReadOnly = false;

            tbelementsymbol.Text = "";
            tbelementsymbol.IsReadOnly = false;

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
            imgelementsymbol.Source = null;
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
        #region Gruppen
        private void erstehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "1HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.erstehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void zweitehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "2HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.zweitehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void dritteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "3NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.drittenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void lanthanoide_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "LAN";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.lanthanoide)
            {
                listBox2.Items.Add(item);
            }
        }
        private void actinoide_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "ACT";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.actinoide)
            {
                listBox2.Items.Add(item);
            }
        }
        private void vierteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "4NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.viertenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void fünfteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "5NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.fünftenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void sechsteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "6NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.sechstenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void siebteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "7NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.siebtenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void achteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "8NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.achtenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void ersteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "1NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.erstenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void zweiteng_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "2NG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.zweitenebengruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void drittehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "3HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.drittehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void viertehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "4HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.viertehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void fünftehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "5HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.fünftehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void sechstehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "6HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.sechstehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void siebtehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "7HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.siebtehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        private void achtehg_Selected(object sender, RoutedEventArgs e)
        {
            this.gruppe = "8HG";
            listBox2.Items.Clear();
            foreach (ListBoxItem item in Elemente.achtehauptgruppe)
            {
                listBox2.Items.Add(item);
            }
        }
        #endregion
        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rücksetzen();
            switch (this.gruppe)
            {
                case "1HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.H;
                            break;
                        case 1: dummy = Elemente.Li; 
                            break;
                        case 2: dummy = Elemente.Na;
                            break;
                        case 3: dummy = Elemente.K;
                            break;
                        case 4: dummy = Elemente.Rb;
                            break;
                        case 5: dummy = Elemente.Cs;
                            break;
                        case 6: dummy = Elemente.Fr;
                            break;
                    }
                    break;
                case "2HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Be;
                            break;
                        case 1: dummy = Elemente.Mg;
                            break;
                        case 2: dummy = Elemente.Ca;
                            break;
                        case 3: dummy = Elemente.Sr;
                            break;
                        case 4: dummy = Elemente.Ba;
                            break;
                        case 5: dummy = Elemente.Ra;
                            break;
                    }
                    break;
                case "3NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Sc;
                            break;
                        case 1: dummy = Elemente.Y;
                            break;
                        case 2: dummy = Elemente.La;
                            break;
                        case 3: dummy = Elemente.Ac;
                            break;
                    }
                    break;
                case "LAN":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Ce;
                            break;
                        case 1: dummy = Elemente.Pr;
                            break;
                        case 2: dummy = Elemente.Nd;
                            break;
                        case 3: dummy = Elemente.Pm;
                            break;
                        case 4: dummy = Elemente.Sm;
                            break;
                        case 5: dummy = Elemente.Eu;
                            break;
                        case 6: dummy = Elemente.Gd;
                            break;
                        case 7: dummy = Elemente.Tb;
                            break;
                        case 8: dummy = Elemente.Dy;
                            break;
                        case 9: dummy = Elemente.Ho;
                            break;
                        case 10: dummy = Elemente.Er;
                            break;
                        case 11: dummy = Elemente.Tm;
                            break;
                        case 12: dummy = Elemente.Yb;
                            break;
                        case 13: dummy = Elemente.Lu;
                            break;
                    }
                    break;
                case "ACT":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Th;
                            break;
                        case 1: dummy = Elemente.Pa;
                            break;
                        case 2: dummy = Elemente.U;
                            break;
                        case 3: dummy = Elemente.Np;
                            break;
                        case 4: dummy = Elemente.Pu;
                            break;
                        case 5: dummy = Elemente.Am;
                            break;
                        case 6: dummy = Elemente.Cm;
                            break;
                        case 7: dummy = Elemente.Bk;
                            break;
                        case 8: dummy = Elemente.Cf;
                            break;
                    }
                    break;
                case "4NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Ti;
                            break;
                        case 1: dummy = Elemente.Zr;
                            break;
                        case 2: dummy = Elemente.Hf;
                            break;
                    }
                    break;
                case "5NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.V;
                            break;
                        case 1: dummy = Elemente.Nb;
                            break;
                        case 2: dummy = Elemente.Ta;
                            break;
                    }
                    break;
                case "6NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Cr;
                            break;
                        case 1: dummy = Elemente.Mo;
                            break;
                        case 2: dummy = Elemente.W;
                            break;
                    }
                    break;
                case "7NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Mn;
                            break;
                        case 1: dummy = Elemente.Tc;
                            break;
                        case 2: dummy = Elemente.Re;
                            break;
                    }
                    break;
                case "8NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Fe;
                            break;
                        case 1: dummy = Elemente.Ru;
                            break;
                        case 2: dummy = Elemente.Os;
                            break;
                        case 3: dummy = Elemente.Co;
                            break;
                        case 4: dummy = Elemente.Rh;
                            break;
                        case 5: dummy = Elemente.Ir;
                            break;
                        case 6: dummy = Elemente.Ni;
                            break;
                        case 7: dummy = Elemente.Pd;
                            break;
                        case 8: dummy = Elemente.Pt;
                            break;
                    }
                    break;
                case "1NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Cu;
                            break;
                        case 1: dummy = Elemente.Ag;
                            break;
                        case 2: dummy = Elemente.Au;
                            break;
                    }
                    break;
                case "2NG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.Zn;
                            break;
                        case 1: dummy = Elemente.Cd;
                            break;
                        case 2: dummy = Elemente.Hg;
                            break;
                    }
                    break;
                case "3HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.B;
                            break;
                        case 1: dummy = Elemente.Al;
                            break;
                        case 2: dummy = Elemente.Ga;
                            break;
                        case 3: dummy = Elemente.In;
                            break;
                        case 4: dummy = Elemente.Tl;
                            break;
                    }
                    break;
                case "4HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.C;
                            break;
                        case 1: dummy = Elemente.Si;
                            break;
                        case 2: dummy = Elemente.Ge;
                            break;
                        case 3: dummy = Elemente.Sn;
                            break;
                        case 4: dummy = Elemente.Pb;
                            break;
                    }
                    break;
                case "5HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.N;
                            break;
                        case 1: dummy = Elemente.P;
                            break;
                        case 2: dummy = Elemente.As;
                            break;
                        case 3: dummy = Elemente.Sb;
                            break;
                        case 4: dummy = Elemente.Bi;
                            break;
                    }
                    break;
                case "6HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.O;
                            break;
                        case 1: dummy = Elemente.S;
                            break;
                        case 2: dummy = Elemente.Se;
                            break;
                        case 3: dummy = Elemente.Te;
                            break;
                        case 4: dummy = Elemente.Po;
                            break;
                    }
                    break;
                case "7HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.F;
                            break;
                        case 1: dummy = Elemente.Cl;
                            break;
                        case 2: dummy = Elemente.Br;
                            break;
                        case 3: dummy = Elemente.I;
                            break;
                        case 4: dummy = Elemente.At;
                            break;
                    }
                    break;
                case "8HG":
                    switch (listBox2.SelectedIndex)
                    {
                        case 0: dummy = Elemente.He;
                            break;
                        case 1: dummy = Elemente.Ne;
                            break;
                        case 2: dummy = Elemente.Ar;
                            break;
                        case 3: dummy = Elemente.Kr;
                            break;
                        case 4: dummy = Elemente.Xe;
                            break;
                        case 5: dummy = Elemente.Rn;
                            break;
                    }
                    break;
            }
        }
        #endregion

        #region Überprüfen
        private void check(Element element)
        {
            versuche++;
            richtige = 0;
            //Symbol
            switch (element.Symbol.Equals(tbelementsymbol.Text))
            {
                case true: tbelementsymbol.IsReadOnly = true;
                    richtige++;
                    richtig(imgelementsymbol);
                    break;
                case false: falsch(imgelementsymbol);
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
        private void info(Image[] bild)
        {
            button1.IsEnabled = false;
            Check.IsEnabled = false;
            for (int i = 0; i < bild.Length; i++)
                bild[i].Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Info_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void allesrichtig()
        {
            Allesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/112_Tick_Green_64x64_72.png", UriKind.RelativeOrAbsolute));
        }
        private void Check_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (dummy == null)
            {
            }
            else
            {
                check(dummy);
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
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
                imgelementsymbol, 
                imgordnungszahl,
                imgradioaktiv, 
                imgradioaktiv, 
                imgreizend, 
                imgschmelzpkt, 
                imgsiedepkt 
            });
            Allesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/009_HighPriority_48x48_72.png", UriKind.RelativeOrAbsolute));

            //Werte(TextBoxes)
            tbelementsymbol.Text = dummy.Symbol;
            tbelementsymbol.IsReadOnly = false;

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
            einheitmassezahl.Text = Element.masseein;
            einheitmassezahl.IsEnabled = false;

            einheitdichte.Text = Element.dichteein;
            einheitdichte.IsEnabled = false;

            einheitschmelzpkt.Text = Element.tempein;
            einheitschmelzpkt.IsEnabled = false;

            einheitsiedepkt.Text = Element.tempein;
            einheitsiedepkt.IsEnabled = false;
        }
        #endregion

    }
}
