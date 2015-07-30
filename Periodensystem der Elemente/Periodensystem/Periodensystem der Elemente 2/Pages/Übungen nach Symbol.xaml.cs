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
using System.Windows.Shapes;
using Periodensystem_2;
using System.Windows.Media.Animation;
using System.Diagnostics;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Übungen_nach_Symbol.xaml
    /// </summary>
    public partial class Übungen_nach_Symbol : Page
    {
        public Übungen_nach_Symbol(Window owner)
        {
            InitializeComponent();
            Owner = owner;
            db.Completed += new EventHandler(db_Completed);
            Debug.Flush();
        }

        #region Objekte
        DoubleAnimation db = new DoubleAnimation(0.5, new Duration(TimeSpan.FromSeconds(1)));
        Window Owner = new Window();
        Übungdetailssymbol d;
        #endregion
        #region Detailsmethoden
        private void ShowDetails(Element e)
        {
            this.d = new Übungdetailssymbol(e);
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
                case "Ac": ShowDetails(Elemente.Ac);
                    break;
                case "Ag": ShowDetails(Elemente.Ag);
                    break;
                case "Al": ShowDetails(Elemente.Al);
                    break;
                case "Am": ShowDetails(Elemente.Am);
                    break;
                case "Ar": ShowDetails(Elemente.Ar);
                    break;
                case "As": ShowDetails(Elemente.As);
                    break;
                case "At": ShowDetails(Elemente.At);
                    break;
                case "Au": ShowDetails(Elemente.Au);
                    break;
                //B
                case "B": ShowDetails(Elemente.B);
                    break;
                case "Ba": ShowDetails(Elemente.Ba);
                    break;
                case "Be": ShowDetails(Elemente.Be);
                    break;
                case "Bi": ShowDetails(Elemente.Bi);
                    break;
                case "Bk": ShowDetails(Elemente.Bk);
                    break;
                case "Br": ShowDetails(Elemente.Br);
                    break;
                //C
                case "C": ShowDetails(Elemente.C);
                    break;
                case "Ca": ShowDetails(Elemente.Ca);
                    break;
                case "Cd": ShowDetails(Elemente.Cd);
                    break;
                case "Ce": ShowDetails(Elemente.Ce);
                    break;
                case "Cf": ShowDetails(Elemente.Cf);
                    break;
                case "Cl": ShowDetails(Elemente.Cf);
                    break;
                case "Cm": ShowDetails(Elemente.Cm);
                    break;
                case "Co": ShowDetails(Elemente.Co);
                    break;
                case "Cr": ShowDetails(Elemente.Cr);
                    break;
                case "Cs": ShowDetails(Elemente.Cs);
                    break;
                case "Cu": ShowDetails(Elemente.Cu);
                    break;
                //D
                case "Dy": ShowDetails(Elemente.Dy);
                    break;
                //E
                case "Er": ShowDetails(Elemente.Er);
                    break;
                case "Eu": ShowDetails(Elemente.Eu);
                    break;
                //F
                case "F": ShowDetails(Elemente.F);
                    break;
                case "Fe": ShowDetails(Elemente.Fe);
                    break;
                case "Fr": ShowDetails(Elemente.Fr);
                    break;
                //G
                case "Ga": ShowDetails(Elemente.Ga);
                    break;
                case "Gd": ShowDetails(Elemente.Gd);
                    break;
                case "Ge": ShowDetails(Elemente.Ge);
                    break;
                //H
                case "H": ShowDetails(Elemente.H);
                    break;
                case "He": ShowDetails(Elemente.He);
                    break;
                case "Hf": ShowDetails(Elemente.Hf);
                    break;
                case "Hg": ShowDetails(Elemente.Hg);
                    break;
                case "Ho": ShowDetails(Elemente.Ho);
                    break;
                //I
                case "I": ShowDetails(Elemente.I);
                    break;
                case "In": ShowDetails(Elemente.In);
                    break;
                case "Ir": ShowDetails(Elemente.Ir);
                    break;
                //K
                case "K": ShowDetails(Elemente.K);
                    break;
                case "Kr": ShowDetails(Elemente.Kr);
                    break;
                //L
                case "La": ShowDetails(Elemente.La);
                    break;
                case "Li": ShowDetails(Elemente.Li);
                    break;
                case "Lu": ShowDetails(Elemente.Lu);
                    break;
                //M
                case "Mg": ShowDetails(Elemente.Mg);
                    break;
                case "Mn": ShowDetails(Elemente.Mn);
                    break;
                case "Mo": ShowDetails(Elemente.Mo);
                    break;
                //N
                case "N": ShowDetails(Elemente.N);
                    break;
                case "Na": ShowDetails(Elemente.Na);
                    break;
                case "Nb": ShowDetails(Elemente.Nb);
                    break;
                case "Nd": ShowDetails(Elemente.Nd);
                    break;
                case "Ne": ShowDetails(Elemente.Ne);
                    break;
                case "Ni": ShowDetails(Elemente.Ni);
                    break;
                case "Np": ShowDetails(Elemente.Np);
                    break;
                //O
                case "O": ShowDetails(Elemente.O);
                    break;
                case "Os": ShowDetails(Elemente.Os);
                    break;
                //P
                case "P": ShowDetails(Elemente.P);
                    break;
                case "Pa": ShowDetails(Elemente.Pa);
                    break;
                case "Pb": ShowDetails(Elemente.Pb);
                    break;
                case "Pd": ShowDetails(Elemente.Pd);
                    break;
                case "Pm": ShowDetails(Elemente.Pm);
                    break;
                case "Po": ShowDetails(Elemente.Po);
                    break;
                case "Pr": ShowDetails(Elemente.Pr);
                    break;
                case "Pt": ShowDetails(Elemente.Pt);
                    break;
                case "Pu": ShowDetails(Elemente.Pu);
                    break;
                //R
                case "Ra": ShowDetails(Elemente.Ra);
                    break;
                case "Rb": ShowDetails(Elemente.Rb);
                    break;
                case "Re": ShowDetails(Elemente.Re);
                    break;
                case "Rh": ShowDetails(Elemente.Rh);
                    break;
                case "Rn": ShowDetails(Elemente.Rn);
                    break;
                case "Ru": ShowDetails(Elemente.Ru);
                    break;
                //S
                case "S": ShowDetails(Elemente.S);
                    break;
                case "Sb": ShowDetails(Elemente.Sb);
                    break;
                case "Sc": ShowDetails(Elemente.Sc);
                    break;
                case "Se": ShowDetails(Elemente.Se);
                    break;
                case "Si": ShowDetails(Elemente.Si);
                    break;
                case "Sm": ShowDetails(Elemente.Sm);
                    break;
                case "Sn": ShowDetails(Elemente.Sn);
                    break;
                case "Sr": ShowDetails(Elemente.Sr);
                    break;
                //T
                case "Ta": ShowDetails(Elemente.Ta);
                    break;
                case "Tb": ShowDetails(Elemente.Tb);
                    break;
                case "Tc": ShowDetails(Elemente.Tc);
                    break;
                case "Te": ShowDetails(Elemente.Te);
                    break;
                case "Th": ShowDetails(Elemente.Th);
                    break;
                case "Ti": ShowDetails(Elemente.Ti);
                    break;
                case "Tl": ShowDetails(Elemente.Tl);
                    break;
                case "Tm": ShowDetails(Elemente.Tm);
                    break;
                //U
                case "U": ShowDetails(Elemente.U);
                    break;
                //V
                case "V": ShowDetails(Elemente.V);
                    break;
                //W
                case "W": ShowDetails(Elemente.W);
                    break;
                //X
                case "Xe": ShowDetails(Elemente.Xe);
                    break;
                //Y
                case "Y": ShowDetails(Elemente.Y);
                    break;
                case "Yb": ShowDetails(Elemente.Yb);
                    break;
                //Z
                case "Zn": ShowDetails(Elemente.Zn);
                    break;
                case "Zr": ShowDetails(Elemente.Zr);
                    break;
            }
        }
    }
}
