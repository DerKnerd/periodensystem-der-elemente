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
    /// Interaktionslogik für Übung_nach_Name.xaml
    /// </summary>
    public partial class Übung_nach_Name : Page
    {
        public Übung_nach_Name(Window owner)
        {
            InitializeComponent();
            db.Completed += new EventHandler(db_Completed);
            Owner = owner;
        }

        #region Objekte
        DoubleAnimation db = new DoubleAnimation(0.5, new Duration(TimeSpan.FromSeconds(1)));
        Window Owner = new Window();
        Übungdetailsname d;
        #endregion
        #region Detailsmethoden
        private void ShowDetails(Element e)
        {
            this.d = new Übungdetailsname(e);
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
                case "Actinium": ShowDetails(Elemente.Ac); break;
                case "Aluminium": ShowDetails(Elemente.Al); break;
                case "Americium": ShowDetails(Elemente.Am); break;
                case "Antimon": ShowDetails(Elemente.Sb); break;
                case "Argon": ShowDetails(Elemente.Ar); break;
                case "Arsen": ShowDetails(Elemente.As); break;
                case "Astat": ShowDetails(Elemente.At); break;
                //B
                case "Barium": ShowDetails(Elemente.Ba); break;
                case "Berkelium": ShowDetails(Elemente.Bk); break;
                case "Beryllium": ShowDetails(Elemente.Be); break;
                case "Bismut": ShowDetails(Elemente.Bi); break;
                case "Blei": ShowDetails(Elemente.Pb); break;
                case "Bor": ShowDetails(Elemente.B); break;
                case "Brom": ShowDetails(Elemente.Br); break;
                //C
                case "Cadmium": ShowDetails(Elemente.Cd); break;
                case "Caesium": ShowDetails(Elemente.Cs); break;
                case "Calcium": ShowDetails(Elemente.Ca); break;
                case "Californium": ShowDetails(Elemente.Cf); break;
                case "Cer": ShowDetails(Elemente.Ce); break;
                case "Chlor": ShowDetails(Elemente.Cl); break;
                case "Chrom": ShowDetails(Elemente.Cr); break;
                case "Cobalt": ShowDetails(Elemente.Co); break;
                case "Curium": ShowDetails(Elemente.Cm); break;
                //D
                case "Dysprosium": ShowDetails(Elemente.Dy); break;
                //E
                case "Eisen": ShowDetails(Elemente.Fe); break;
                case "Erbium": ShowDetails(Elemente.Er); break;
                case "Europium": ShowDetails(Elemente.Eu); break;
                //F
                case "Fluor": ShowDetails(Elemente.F); break;
                case "Francium": ShowDetails(Elemente.Fr); break;
                //G
                case "Gadolinium": ShowDetails(Elemente.Gd); break;
                case "Gallium": ShowDetails(Elemente.Ga); break;
                case "Germanium": ShowDetails(Elemente.Ge); break;
                case "Gold": ShowDetails(Elemente.Au); break;
                //H
                case "Hafnium": ShowDetails(Elemente.Hf); break;
                case "Helium": ShowDetails(Elemente.He); break;
                case "Holmium": ShowDetails(Elemente.Ho); break;
                //I
                case "Indium": ShowDetails(Elemente.In); break;
                case "Iod": ShowDetails(Elemente.I); break;
                case "Iridium": ShowDetails(Elemente.Ir); break;
                //K
                case "Kalium": ShowDetails(Elemente.K); break;
                case "Kohlenstoff": ShowDetails(Elemente.C); break;
                case "Krypton": ShowDetails(Elemente.Kr); break;
                case "Kupfer": ShowDetails(Elemente.Cu); break;
                //L
                case "Lanthan": ShowDetails(Elemente.La); break;
                case "Lithium": ShowDetails(Elemente.Li); break;
                case "Lutetium": ShowDetails(Elemente.Lu); break;
                //M
                case "Magnesium": ShowDetails(Elemente.Mg); break;
                case "Mangan": ShowDetails(Elemente.Mn); break;
                case "Molybdän": ShowDetails(Elemente.Mo); break;
                //N
                case "Natrium": ShowDetails(Elemente.Na); break;
                case "Neodym": ShowDetails(Elemente.Nd); break;
                case "Neon": ShowDetails(Elemente.Ne); break;
                case "Neptunium": ShowDetails(Elemente.Np); break;
                case "Nickel": ShowDetails(Elemente.Ni); break;
                case "Niob": ShowDetails(Elemente.Nb); break;
                //O
                case "Osmium": ShowDetails(Elemente.Os); break;
                //P
                case "Palladium": ShowDetails(Elemente.Pd); break;
                case "Phosphor": ShowDetails(Elemente.P); break;
                case "Platin": ShowDetails(Elemente.Pt); break;
                case "Plutonium": ShowDetails(Elemente.Pu); break;
                case "Polonium": ShowDetails(Elemente.Po); break;
                case "Praseodym": ShowDetails(Elemente.Pr); break;
                case "Promethium": ShowDetails(Elemente.Pm); break;
                case "Protactinium": ShowDetails(Elemente.Pa); break;
                //Q
                case "Quecksilber": ShowDetails(Elemente.Hg); break;
                //R
                case "Radium": ShowDetails(Elemente.Ra); break;
                case "Radon": ShowDetails(Elemente.Rn); break;
                case "Rhenium": ShowDetails(Elemente.Re); break;
                case "Rhodium": ShowDetails(Elemente.Rh); break;
                case "Rubidium": ShowDetails(Elemente.Rb); break;
                case "Ruthenium": ShowDetails(Elemente.Ru); break;
                //S
                case "Samarium": ShowDetails(Elemente.Sm); break;
                case "Sauerstoff": ShowDetails(Elemente.O); break;
                case "Scandium": ShowDetails(Elemente.Sc); break;
                case "Schwefel": ShowDetails(Elemente.S); break;
                case "Selen": ShowDetails(Elemente.Se); break;
                case "Silber": ShowDetails(Elemente.Ag); break;
                case "Silicium": ShowDetails(Elemente.Si); break;
                case "Stickstoff": ShowDetails(Elemente.N); break;
                case "Strontium": ShowDetails(Elemente.Sr); break;
                //T
                case "Tantal": ShowDetails(Elemente.Ta); break;
                case "Technetium": ShowDetails(Elemente.Tc); break;
                case "Tellur": ShowDetails(Elemente.Te); break;
                case "Terbium": ShowDetails(Elemente.Tb); break;
                case "Thallium": ShowDetails(Elemente.Tl); break;
                case "Thorium": ShowDetails(Elemente.Th); break;
                case "Thulium": ShowDetails(Elemente.Tm); break;
                case "Titan": ShowDetails(Elemente.Ti); break;
                //U
                case "Uran": ShowDetails(Elemente.U); break;
                //V
                case "Vanadium": ShowDetails(Elemente.V); break;
                //W
                case "Wasserstoff": ShowDetails(Elemente.H); break;
                case "Wolfram": ShowDetails(Elemente.W); break;
                //X
                case "Xenon": ShowDetails(Elemente.Xe); break;
                //Y
                case "Ytterbium": ShowDetails(Elemente.Yb); break;
                case "Yttrium": ShowDetails(Elemente.Y); break;
                //Z
                case "Zink": ShowDetails(Elemente.Zn); break;
                case "Zinn": ShowDetails(Elemente.Sn); break;
                case "Zirkonium": ShowDetails(Elemente.Zr); break;
            }
        }
    }
}
