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
using Periodensystem_2;
using Periodensystem_der_Elemente_2.Pages;
using System.Windows.Media.Animation;
using System.Threading;

namespace Periodensystem_der_Elemente_2
{
    /// <summary>
    /// Interaktionslogik für Periodensystem.xaml
    /// </summary>
    public partial class Periodensystem_nach_System : Page
    {
        public Periodensystem_nach_System(Window owner)
        {
            InitializeComponent();
            Owner = owner;
            db.Completed += new EventHandler(db_Completed);
        }

        #region Objekte
        DoubleAnimation db = new DoubleAnimation(0.5, new Duration(TimeSpan.FromSeconds(1)));
        Window Owner = new Window();
        Detailssymbol d;
        #endregion
        #region Detailsmethoden
        private void ShowDetails(Element e)
        {
            this.d = new Detailssymbol(e);
            this.d.Owner = Owner;
            Owner.BeginAnimation(Window.OpacityProperty, db);
        }
        private void db_Completed(object sender, EventArgs e)
        {
            this.d.ShowDialog();
        }
        #endregion
        #region Elemente
        //1. Hauptgruppe
        private void H_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.H);
        }
        private void Li_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Li);
        }
        private void Na_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Na);
        }
        private void K_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.K);
        }
        private void Rb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Rb);
        }
        private void Cs_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cs);
        }
        private void Fr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Fr);
        }
        //2. Hauptgruppe
        private void Be_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Be);
        }
        private void Mg_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Mg);
        }
        private void Ca_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ca);
        }
        private void Sr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Sr);
        }
        private void Ba_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ba);
        }
        private void Ra_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ra);
        }
        //3. Nebengruppe
        private void Sc_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Sc);
        }
        private void Y_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Y);
        }
        private void La_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.La);
        }
        private void Ac_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ac);
        }
        //Lanthanoide
        private void Ce_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ce);
        }
        private void Pr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pr);
        }
        private void Nd_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Nd);
        }
        private void Pm_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pm);
        }
        private void Sm_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Sm);
        }
        private void Eu_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Eu);
        }
        private void Gd_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Gd);
        }
        private void Tb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Tb);
        }
        private void Dy_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Dy);
        }
        private void Ho_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ho);
        }
        private void Er_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Er);
        }
        private void Tm_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Tm);
        }
        private void Yb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Yb);
        }
        private void Lu_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Lu);
        }
        //Actinoide
        private void Th_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Th);
        }
        private void Pa_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pa);
        }
        private void U_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.U);
        }
        private void Np_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Np);
        }
        private void Pu_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pu);
        }
        private void Am_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Am);
        }
        private void Cm_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cm);
        }
        private void Bk_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Bk);
        }
        private void Cf_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cf);
        }
        //4. Nebengruppe
        private void Ti_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ti);
        }
        private void Zr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Zr);
        }
        private void Hf_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Hf);
        }
        //5. Nebengruppe
        private void V_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.V);
        }
        private void Nb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Nb);
        }
        private void Ta_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ta);
        }
        //6. Nebengruppe
        private void Cr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cr);
        }
        private void Mo_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Mo);
        }
        private void W_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.W);
        }
        //7. Nebengruppe
        private void Mn_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Mn);
        }
        private void Tc_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Tc);
        }
        private void Re_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Re);
        }
        //8. Nebengruppe
        private void Fe_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Fe);
        }
        private void Ru_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ru);
        }
        private void Os_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Os);
        }
        private void Co_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Co);
        }
        private void Rh_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Rh);
        }
        private void Ir_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ir);
        }
        private void Ni_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ni);
        }
        private void Pd_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pd);
        }
        private void Pt_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pt);
        }
        //1. Nebengruppe
        private void Cu_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cu);
        }
        private void Ag_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ag);
        }
        private void Au_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Au);
        }
        //2. Nebenngruppe
        private void Zn_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Zn);
        }
        private void Cd_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cd);
        }
        private void Hg_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Hg);
        }
        //3. Hauptgruppe
        private void B_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.B);
        }
        private void Al_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Al);
        }
        private void Ga_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ga);
        }
        private void In_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.In);
        }
        private void Tl_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Tl);
        }
        //4. Hauptgruppe
        private void C_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.C);
        }
        private void Si_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Si);
        }
        private void Ge_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ge);
        }
        private void Sn_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Sn);
        }
        private void Pb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Pb);
        }
        //5. Hauptgruppe
        private void N_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.N);
        }
        private void P_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.P);
        }
        private void As_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.As);
        }
        private void Sb_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Sb);
        }
        private void Bi_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Bi);
        }
        //6. Hauptgruppe
        private void O_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.O);
        }
        private void S_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.S);
        }
        private void Se_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Se);
        }
        private void Te_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Te);
        }
        private void Po_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Po);
        }
        //7. Hauptgruppe
        private void F_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.F);
        }
        private void Cl_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Cl);
        }
        private void Br_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Br);
        }
        private void I_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.I);
        }
        private void At_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.At);
        }
        //8. Hauptgruppe
        private void He_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.He);
        }
        private void Ne_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ne);
        }
        private void Xe_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Xe);
        }
        private void Kr_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Kr);
        }
        private void Ar_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Ar);
        }
        private void Rn_Click(object sender, RoutedEventArgs e)
        {
            ShowDetails(Elemente.Rn);
        }
        #endregion
    }
}
