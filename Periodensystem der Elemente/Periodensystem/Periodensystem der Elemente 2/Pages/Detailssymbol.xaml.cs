using System;
using System.Windows;
using System.Windows.Media.Animation;
using Periodensystem_2;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Details.xaml
    /// </summary>
    public partial class Detailssymbol : Window
    {
        public Detailssymbol(Element element)
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
