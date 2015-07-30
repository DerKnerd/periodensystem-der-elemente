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
using System.Windows.Xps.Packaging;
using System.IO;
using Microsoft.Win32;

namespace Periodensystem_der_Elemente_2.Pages
{
    /// <summary>
    /// Interaktionslogik für Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XpsDocument xps = new XpsDocument(Environment.CurrentDirectory + @"\hilfe.xps", FileAccess.Read);
                documentViewer1.Document = xps.GetFixedDocumentSequence();
            }
            catch (Exception)
            {
                switch (MessageBox.Show("Die aktuelle Hilfedatei ist nicht vorhanden bitte wählen Sie eine andere aus",
                    "Datei nicht gefunden",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Error))
                {
                    case MessageBoxResult.No: this.Close();
                        break;
                    case MessageBoxResult.Yes:
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                        ofd.Multiselect = false;
                        ofd.Title = "Hilfedatei öffnen...";
                        ofd.Filter = "XPS-Dokument|*.xps";
                        if (ofd.ShowDialog() == true)
                        {
                            XpsDocument xps = new XpsDocument(ofd.FileName, FileAccess.Read);
                            documentViewer1.Document = xps.GetFixedDocumentSequence();
                        }
                        break;
                }
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
