using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Periodensystem_der_Elemente_2
{
    public static class Commands
    {
        private static RoutedUICommand check;
        private static RoutedUICommand schließen;
        private static RoutedUICommand about;
        private static RoutedUICommand übung;
        private static RoutedUICommand übersicht;
        static Commands()
        {
            check = new RoutedUICommand("Überprüfen", "Überprüfen", typeof(Commands));
            check.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt, "Alt+E"));
            schließen = new RoutedUICommand("Schließen", "Schließen", typeof(Commands));
            schließen.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Alt, "Alt+F4"));
            about = new RoutedUICommand("About", "About", typeof(Commands));
            about.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Control, "Strg+A"));
            übung = new RoutedUICommand("Übung", "Übung", typeof(Commands));
            übung.InputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control, "Strg+L"));
            übersicht = new RoutedUICommand("Periodensystem", "Periodensystem", typeof(Commands));
            übersicht.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control, "Strg+L"));
        }

        public static RoutedUICommand Check
        {
            get { return check; }
        }
        public static RoutedUICommand Schließen
        {
            get { return schließen; }
        }
        public static RoutedUICommand About
        {
            get { return about; }
        }
        public static RoutedUICommand Übung
        {
            get { return übung; }
        }
        public static RoutedUICommand Übersicht
        {
            get { return übersicht; }
        }
    }
}
