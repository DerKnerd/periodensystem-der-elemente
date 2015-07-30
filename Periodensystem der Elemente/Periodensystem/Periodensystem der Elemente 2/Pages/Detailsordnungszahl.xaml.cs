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
using System.Windows.Media.Animation;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Detailsordnungszahl.xaml
    /// </summary>
    public partial class Detailsordnungszahl : Window
    {
        public Detailsordnungszahl(Element element)
        {
            InitializeComponent();
            dummy = element;
        }

        Element dummy;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation db = new DoubleAnimation();
            db.To = 1;
            db.Duration = new Duration(TimeSpan.FromSeconds(1));
            Owner.BeginAnimation(Window.OpacityProperty, db);
            this.Close();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            elementsymbol.Text = dummy.Symbol;
            elementname.Text = dummy.Name;
            schemlzpkt.Text = dummy.Schmelztemperatur;
            ordnungszahl.Text = dummy.Ordnungszahl;
            massezahl.Text = dummy.Massezahl;
            siedepkt.Text = dummy.Siedetemperatur;
            dichte.Text = dummy.Dichte;

            giftig.IsChecked = dummy.Giftig;
            radioaktiv.IsChecked = dummy.Radioaktiv;
            ätzend.IsChecked = dummy.Ätzend;
            entzündlich.IsChecked = dummy.Entzündlich;
            reizend.IsChecked = dummy.Reizend;
        }
    }
}
