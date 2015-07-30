﻿using System;
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

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Übungdetailsname.xaml
    /// </summary>
    public partial class Übungdetailsname : Window
    {
        public Übungdetailsname(Element e)
        {
            InitializeComponent();
            dummy = e;
        }

        Element dummy;
        int richtige = 0;
        int versuche = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CommandBindings.Add(new CommandBinding(Commands.Check, Check_Executed));
            elementname.Text = dummy.Name;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation db = new DoubleAnimation();
            db.To = 1;
            db.Duration = new Duration(TimeSpan.FromSeconds(1));
            Owner.BeginAnimation(Window.OpacityProperty, db);
            this.Close();
        }

        #region Überprüfen
        private void check(Element element)
        {
            versuche++;
            richtige = 0;
            //Smbol
            switch (element.Symbol.Equals(elementsymbol.Text))
            {
                case true: elementsymbol.IsReadOnly = true;
                    richtige++;
                    richtig(imgelementsymbol);
                    break;
                case false: falsch(imgelementsymbol);
                    break;
            }
            //Ordnungszahl
            switch (element.Ordnungszahl.Equals(ordnungszahl.Text))
            {
                case true: ordnungszahl.IsReadOnly = true;
                    richtige++;
                    richtig(imgordnungszahl);
                    break;
                case false: falsch(imgordnungszahl);
                    break;
            }
            //Massezahl
            switch (element.Massezahl.Equals(massezahl.Text))
            {
                case true: massezahl.IsReadOnly = true;
                    richtige++;
                    richtig(imgmasse);
                    //Masseeinheit
                    switch (Element.masseein.Equals(einheitmassezahl.Text))
                    {
                        case true: einheitmassezahl.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgmasse);
                            break;
                    }
                    break;
                case false: falsch(imgmasse);
                    break;
            }
            //Dichte
            switch (element.Dichte.Equals(dichte.Text))
            {
                case true: dichte.IsReadOnly = true;
                    richtige++;
                    richtig(imgdichte);
                    //Dichteeinheit
                    switch (Element.dichteein.Equals(einheitdichte.Text))
                    {
                        case true: einheitdichte.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgdichte);
                            break;
                    }
                    break;
                case false: falsch(imgdichte);
                    break;
            }
            //Schmelzpkt
            switch (element.Schmelztemperatur.Equals(schmelzpkt.Text))
            {
                case true: schmelzpkt.IsReadOnly = true;
                    richtige++;
                    richtig(imgschmelzpkt);
                    //Schmelzpkteinheit
                    switch (Element.tempein.Equals(einheitschmelzpkt.Text))
                    {
                        case true: einheitschmelzpkt.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgschmelzpkt);
                            break;
                    }
                    break;
                case false: falsch(imgschmelzpkt);
                    break;
            }
            //Siedepkt
            switch (element.Siedetemperatur.Equals(siedepkt.Text))
            {
                case true: siedepkt.IsReadOnly = true;
                    richtige++;
                    richtig(imgsiedepkt);
                    //Einheitsiedepkt
                    switch (Element.tempein.Equals(einheitsiedepkt.Text))
                    {
                        case true: einheitsiedepkt.IsEnabled = false;
                            richtige++;
                            break;
                        case false: falscheeinheit(imgsiedepkt);
                            break;
                    }
                    break;
                case false: falsch(imgsiedepkt);
                    break;
            }
            //Giftig
            switch (element.Giftig.Equals(giftig.IsChecked))
            {
                case true: giftig.IsEnabled = false;
                    richtige++;
                    richtig(imggiftig);
                    break;
                case false: falsch(imggiftig);
                    break;
            }
            //Radioaktiv
            switch (element.Radioaktiv.Equals(radioaktiv.IsChecked))
            {
                case true: radioaktiv.IsEnabled = false;
                    richtige++;
                    richtig(imgradioaktiv);
                    break;
                case false: falsch(imgradioaktiv);
                    break;
            }
            //Ätzend
            switch (element.Ätzend.Equals(ätzend.IsChecked))
            {
                case true: ätzend.IsEnabled = false;
                    richtige++;
                    richtig(imgätzend);
                    break;
                case false: falsch(imgätzend);
                    break;
            }
            //Entzündlich
            switch (element.Entzündlich.Equals(entzündlich.IsChecked))
            {
                case true: entzündlich.IsEnabled = false;
                    richtige++;
                    richtig(imgentzündlich);
                    break;
                case false: falsch(imgentzündlich);
                    break;
            }
            //Reizend
            switch (element.Reizend.Equals(reizend.IsChecked))
            {
                case true: reizend.IsEnabled = false;
                    richtige++;
                    richtig(imgreizend);
                    break;
                case false: falsch(imgreizend);
                    break;
            }
            if (richtige == 15)
            {
                allesrichtig();
            }
            SBIRichtige.Content = "Richtige: " + richtige.ToString();
            SBIVersuche.Content = "Versuche: " + versuche.ToString();
        }
        private void richtig(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Default_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void falscheeinheit(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Complete_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void falsch(Image bild)
        {
            bild.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Error_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void info(Image[] bild)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            for (int i = 0; i < bild.Length; i++)
                bild[i].Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/109_AllAnnotations_Info_24x24_72.png", UriKind.RelativeOrAbsolute));
        }
        private void allesrichtig()
        {
            imgallesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/112_Tick_Green_64x64_72.png", UriKind.RelativeOrAbsolute));
            button1.IsEnabled = true;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
        }
        private void Check_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            check(dummy);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            versuche++;
            SBIVersuche.Content = "Versuche: " + versuche.ToString();
            SBIRichtige.Content = "Lösung angezeigt";

            info(new Image[] 
            { 
                imgätzend, 
                imgdichte, 
                imgentzündlich, 
                imggiftig, 
                imgmasse, 
                imgelementsymbol, 
                imgordnungszahl, 
                imgradioaktiv, 
                imgradioaktiv, 
                imgreizend, 
                imgschmelzpkt, 
                imgsiedepkt 
            });
            imgallesrichtig.Source = new BitmapImage(new Uri("pack://application:,,,/Periodensystem der Elemente 2;component/Bilder/009_HighPriority_48x48_72.png", UriKind.RelativeOrAbsolute));

            //Werte(TextBoxes)
            elementsymbol.Text = dummy.Symbol;
            elementsymbol.IsReadOnly = false;

            ordnungszahl.Text = dummy.Ordnungszahl;
            ordnungszahl.IsReadOnly = false;

            massezahl.Text = dummy.Massezahl;
            massezahl.IsReadOnly = false;

            dichte.Text = dummy.Dichte;
            dichte.IsReadOnly = false;

            schmelzpkt.Text = dummy.Schmelztemperatur;
            schmelzpkt.IsReadOnly = false;

            siedepkt.Text = dummy.Siedetemperatur;
            siedepkt.IsReadOnly = false;

            //Werte(CheckBoxes)
            giftig.IsChecked = dummy.Giftig;
            giftig.IsEnabled = false;

            radioaktiv.IsChecked = dummy.Radioaktiv;
            radioaktiv.IsEnabled = false;

            reizend.IsChecked = dummy.Reizend;
            reizend.IsEnabled = false;

            entzündlich.IsChecked = dummy.Entzündlich;
            entzündlich.IsEnabled = false;

            ätzend.IsChecked = dummy.Ätzend;
            ätzend.IsEnabled = false;

            //Werte(ComboBoxes)
            einheitmassezahl.Text = Element.masseein;
            einheitmassezahl.IsEnabled = false;

            einheitdichte.Text = Element.dichteein;
            einheitdichte.IsEnabled = false;

            einheitschmelzpkt.Text = Element.tempein;
            einheitschmelzpkt.IsEnabled = false;

            einheitsiedepkt.Text = Element.tempein;
            einheitsiedepkt.IsEnabled = false;
        }
        #endregion
    }
}
