using System.Windows;
using System.Windows.Controls;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Startseite.xaml
    /// </summary>
    public partial class Startseite : Page
    {
        public Startseite(Frame owner, Window owner2)
        {
            InitializeComponent();
            Owner = owner;
            Owner2 = owner2;
        }

        Frame Owner;
        Window Owner2;
        private void ändern(string title, Page seite)
        {
            Owner.Content = seite;
            Owner2.Title = "Periodensystem der Elemente - " + title;
        }

        private void Periodensystem_Click(object sender, RoutedEventArgs e)
        {
            ändern("Periodensystem nach System", new Periodensystem_nach_System(Owner2));
        }
        private void Periodensystemnachgruppe_Click(object sender, RoutedEventArgs e)
        {
            ändern("Periodensystem nach Gruppe", new Periodensystem_nach_Gruppe());
        }
        private void Periodensystemnachsymbol_Click(object sender, RoutedEventArgs e)
        {
            ändern("Periodensystem nach Symbol", new Periodensystem_nach_Symbol(Owner2));
        }
        private void Periodensystemnachname_Click(object sender, RoutedEventArgs e)
        {
            ändern("Periodensystem nach Name", new Periodensystem_nach_Name(Owner2));
        }   
        private void Periodensystemnachordnungszahl_Click(object sender, RoutedEventArgs e)
        {
            ändern("Periodensystem nach Ordnungszahl", new Periodensystem_nach_Ordnungszahl(Owner2));
        }   

        private void Übung_Click(object sender, RoutedEventArgs e)
        {
            ändern("Übung nach System", new Übung_nach_System());
        }
        private void Übungnachgruppe_Click(object sender, RoutedEventArgs e)
        {
            ändern("Übung nach Gruppe", new Übung_nach_Gruppe());
        }
        private void Übungnachsymbol_Click(object sender, RoutedEventArgs e)
        {
            ändern("Übung nach Symbol", new Übungen_nach_Symbol(Owner2));
        }
        private void Übungnachname_Click(object sender, RoutedEventArgs e)
        {
            ändern("Übung nach Name", new Übung_nach_Name(Owner2));
        }
        private void Übungnachordnungszahl_Click(object sender, RoutedEventArgs e)
        {
            ändern("Übung nach Ordnungszahl", new Übung_nach_Ordnungszahl(Owner2));
        } 
    }
}
