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
    /// Interaktionslogik für Periodensystem_nach_Gruppe_und_Name.xaml
    /// </summary>
    public partial class Periodensystem_nach_Gruppe : Page
    {
        public Periodensystem_nach_Gruppe()
        {
            InitializeComponent();
        }

        string gruppe;
        Element dummy;
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
        #region Eigenschaften
        private void symbol_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Symbol;
            expander1.IsExpanded = false;
            header.Text = "Symbol";
        }
        private void ordnungszahl_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Ordnungszahl;
            expander1.IsExpanded = false;
            header.Text = "Ordnungszahl";
        }
        private void massezahl_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Massezahl + Element.masseein;
            expander1.IsExpanded = false;
            header.Text = "Massezahl";
        }
        private void dichte_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Dichte + Element.dichteein;
            expander1.IsExpanded = false;
            header.Text = "Dichte";
        }
        private void schmelzpunkt_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Schmelztemperatur + Element.tempein;
            expander1.IsExpanded = false;
            header.Text = "Schmelztemperatur";
        }
        private void siedepunkt_Selected(object sender, RoutedEventArgs e)
        {
            Eigenschaft.Text = dummy.Siedetemperatur + Element.tempein;
            expander1.IsExpanded = false;
            header.Text = "Siedetemperatur";
        }
        private void giftig_Selected(object sender, RoutedEventArgs e)
        {
            switch (dummy.Giftig)
            {
                case true: Eigenschaft.Text = "ja";
                    break;
                case false: Eigenschaft.Text = "nein";
                    break;
            }
            expander1.IsExpanded = false;
            header.Text = "giftig";
        }
        private void radioaktiv_Selected(object sender, RoutedEventArgs e)
        {
            switch (dummy.Radioaktiv)
            {
                case true: Eigenschaft.Text = "ja";
                    break;
                case false: Eigenschaft.Text = "nein";
                    break;
            }
            expander1.IsExpanded = false;
            header.Text = "radioaktiv";
        }
        private void ätzend_Selected(object sender, RoutedEventArgs e)
        {
            switch (dummy.Ätzend)
            {
                case true: Eigenschaft.Text = "ja";
                    break;
                case false: Eigenschaft.Text = "nein";
                    break;
            }
            expander1.IsExpanded = false;
            header.Text = "ätzend";
        }
        private void entzündlich_Selected(object sender, RoutedEventArgs e)
        {
            switch (dummy.Entzündlich)
            {
                case true: Eigenschaft.Text = "ja";
                    break;
                case false: Eigenschaft.Text = "nein";
                    break;
            }
            expander1.IsExpanded = false;
            header.Text = "entzündlich";
        }
        private void reizend_Selected(object sender, RoutedEventArgs e)
        {
            switch (dummy.Reizend)
            {
                case true: Eigenschaft.Text = "ja";
                    break;
                case false: Eigenschaft.Text = "nein";
                    break;
            }
            expander1.IsExpanded = false;
            header.Text = "reizend";
        }
        #endregion
    }
}