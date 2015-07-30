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
using System.Windows.Media.Animation;
using Periodensystem_2;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Übung_nach_Ordnungszahl.xaml
    /// </summary>
    public partial class Übung_nach_Ordnungszahl : Page
    {
        public Übung_nach_Ordnungszahl(Window owner)
        {
            InitializeComponent();
            db.Completed += new EventHandler(db_Completed);
            Owner = owner;
        }

        #region Objekte
        DoubleAnimation db = new DoubleAnimation(0.5, new Duration(TimeSpan.FromSeconds(1)));
        Window Owner = new Window();
        Übungdetailsordnungszahl d;
        #endregion
        #region Detailsmethoden
        private void ShowDetails(Element e)
        {
            this.d = new Übungdetailsordnungszahl(e);
            this.d.Owner = Owner;
            Owner.BeginAnimation(Window.OpacityProperty, db);
        }
        private void db_Completed(object sender, EventArgs e)
        {
            this.d.ShowDialog();
        }
        #endregion
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            switch (((sender as Hyperlink).Inlines.FirstInline as Run).Text.ToString())
            {
                //A
                case "89": ShowDetails(Elemente.Ac); break;
                case "13": ShowDetails(Elemente.Al); break;
                case "95": ShowDetails(Elemente.Am); break;
                case "51": ShowDetails(Elemente.Sb); break;
                case "18": ShowDetails(Elemente.Ar); break;
                case "33": ShowDetails(Elemente.As); break;
                case "85": ShowDetails(Elemente.At); break;
                //B
                case "56": ShowDetails(Elemente.Ba); break;
                case "97": ShowDetails(Elemente.Bk); break;
                case "4": ShowDetails(Elemente.Be); break;
                case "83": ShowDetails(Elemente.Bi); break;
                case "82": ShowDetails(Elemente.Pb); break;
                case "5": ShowDetails(Elemente.B); break;
                case "35": ShowDetails(Elemente.Br); break;
                //C
                case "48": ShowDetails(Elemente.Cd); break;
                case "55": ShowDetails(Elemente.Cs); break;
                case "20": ShowDetails(Elemente.Ca); break;
                case "98": ShowDetails(Elemente.Cf); break;
                case "58": ShowDetails(Elemente.Ce); break;
                case "17": ShowDetails(Elemente.Cl); break;
                case "24": ShowDetails(Elemente.Cr); break;
                case "27": ShowDetails(Elemente.Co); break;
                case "96": ShowDetails(Elemente.Cm); break;
                //D
                case "66": ShowDetails(Elemente.Dy); break;
                //E
                case "26": ShowDetails(Elemente.Fe); break;
                case "68": ShowDetails(Elemente.Er); break;
                case "63": ShowDetails(Elemente.Eu); break;
                //F
                case "9": ShowDetails(Elemente.F); break;
                case "87": ShowDetails(Elemente.Fr); break;
                //G
                case "64": ShowDetails(Elemente.Gd); break;
                case "31": ShowDetails(Elemente.Ga); break;
                case "32": ShowDetails(Elemente.Ge); break;
                case "79": ShowDetails(Elemente.Au); break;
                //H
                case "72": ShowDetails(Elemente.Hf); break;
                case "2": ShowDetails(Elemente.He); break;
                case "67": ShowDetails(Elemente.Ho); break;
                //I
                case "49": ShowDetails(Elemente.In); break;
                case "53": ShowDetails(Elemente.I); break;
                case "77": ShowDetails(Elemente.Ir); break;
                //K
                case "19": ShowDetails(Elemente.K); break;
                case "6": ShowDetails(Elemente.C); break;
                case "36": ShowDetails(Elemente.Kr); break;
                case "29": ShowDetails(Elemente.Cu); break;
                //L
                case "57": ShowDetails(Elemente.La); break;
                case "3": ShowDetails(Elemente.Li); break;
                case "71": ShowDetails(Elemente.Lu); break;
                //M
                case "12": ShowDetails(Elemente.Mg); break;
                case "25": ShowDetails(Elemente.Mn); break;
                case "42": ShowDetails(Elemente.Mo); break;
                //N
                case "11": ShowDetails(Elemente.Na); break;
                case "60": ShowDetails(Elemente.Nd); break;
                case "10": ShowDetails(Elemente.Ne); break;
                case "93": ShowDetails(Elemente.Np); break;
                case "28": ShowDetails(Elemente.Ni); break;
                case "41": ShowDetails(Elemente.Nb); break;
                //O
                case "76": ShowDetails(Elemente.Os); break;
                //P
                case "46": ShowDetails(Elemente.Pd); break;
                case "15": ShowDetails(Elemente.P); break;
                case "78": ShowDetails(Elemente.Pt); break;
                case "94": ShowDetails(Elemente.Pu); break;
                case "84": ShowDetails(Elemente.Po); break;
                case "59": ShowDetails(Elemente.Pr); break;
                case "61": ShowDetails(Elemente.Pm); break;
                case "91": ShowDetails(Elemente.Pa); break;
                //Q
                case "80": ShowDetails(Elemente.Hg); break;
                //R
                case "88": ShowDetails(Elemente.Ra); break;
                case "86": ShowDetails(Elemente.Rn); break;
                case "75": ShowDetails(Elemente.Re); break;
                case "45": ShowDetails(Elemente.Rh); break;
                case "37": ShowDetails(Elemente.Rb); break;
                case "44": ShowDetails(Elemente.Ru); break;
                //S
                case "62": ShowDetails(Elemente.Sm); break;
                case "8": ShowDetails(Elemente.O); break;
                case "21": ShowDetails(Elemente.Sc); break;
                case "16": ShowDetails(Elemente.S); break;
                case "34": ShowDetails(Elemente.Se); break;
                case "47": ShowDetails(Elemente.Ag); break;
                case "14": ShowDetails(Elemente.Si); break;
                case "7": ShowDetails(Elemente.N); break;
                case "38": ShowDetails(Elemente.Sr); break;
                //T
                case "73": ShowDetails(Elemente.Ta); break;
                case "43": ShowDetails(Elemente.Tc); break;
                case "52": ShowDetails(Elemente.Te); break;
                case "65": ShowDetails(Elemente.Tb); break;
                case "81": ShowDetails(Elemente.Tl); break;
                case "90": ShowDetails(Elemente.Th); break;
                case "69": ShowDetails(Elemente.Tm); break;
                case "22": ShowDetails(Elemente.Ti); break;
                //U
                case "92": ShowDetails(Elemente.U); break;
                //V
                case "23": ShowDetails(Elemente.V); break;
                //W
                case "1": ShowDetails(Elemente.H); break;
                case "74": ShowDetails(Elemente.W); break;
                //X
                case "54": ShowDetails(Elemente.Xe); break;
                //Y
                case "70": ShowDetails(Elemente.Yb); break;
                case "39": ShowDetails(Elemente.Y); break;
                //Z
                case "30": ShowDetails(Elemente.Zn); break;
                case "50": ShowDetails(Elemente.Sn); break;
                case "40": ShowDetails(Elemente.Zr); break;
            }
        }
    }
}
