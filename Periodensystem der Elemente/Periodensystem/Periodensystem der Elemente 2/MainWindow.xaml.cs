using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Periodensystem_der_Elemente_2.Pages;

namespace Periodensystem_der_Elemente_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            framenändern("Startseite", new Startseite(this.frame1, this));
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region Commands
            CommandBindings.Add(new CommandBinding(Commands.Schließen, close_Execute));
            CommandBindings.Add(new CommandBinding(Commands.About, about_Execute));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Help, help_Execute));
            #endregion
        }

        #region Commands
        private void close_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void about_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            About d = new About();
            d.ShowDialog();
        }
        private void help_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            new Help().ShowDialog();
        }
        #endregion
        #region Pages
        private void framenändern(string name, Page seite)
        {
            frame1.Content = seite;
            this.Title = "Periodensystem der Elemente - " + name;
        }
        #region Übung
        private void übungnachsystem_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Übungen nach Periodensystem", new Übung_nach_System());
        }
        private void übungnachgruppe_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Übung nach Gruppe", new Übung_nach_Gruppe());
        }
        private void übungnachsymbol_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Übung nach Symbol", new Übungen_nach_Symbol(this));
        }
        private void übungnachname_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Übung nach Name", new Übung_nach_Name(this));
        }
        private void übungnachordnungszahl_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Übung nach Ordnungszahl", new Übung_nach_Ordnungszahl(this));
        }
        #endregion
        #region Periodensystem
        private void psenachgruppe_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Periodensystem nach Gruppe", new Periodensystem_nach_Gruppe());
        }
        private void psenachsystem_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Periodensystem", new Periodensystem_nach_System(this));
        }
        private void psenachsymbol_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Periodensystem nach Symbol", new Periodensystem_nach_Symbol(this));
        }
        private void psenachname_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Periodensystem nach Name", new Periodensystem_nach_Name(this));
        }
        private void psenachordnungszahl_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Periodensystem nach Ordnungszahl", new Periodensystem_nach_Ordnungszahl(this));
        }
        #endregion
        private void startseite_Click(object sender, RoutedEventArgs e)
        {
            framenändern("Startseite", new Startseite(this.frame1, this));
        }
        #endregion
    }
}
