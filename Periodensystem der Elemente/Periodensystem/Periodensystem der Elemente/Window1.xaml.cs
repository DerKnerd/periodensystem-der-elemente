using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Periodensystem_der_Elemente
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            bgsound.MediaEnded += new EventHandler(bgsound_MediaEnded);
        }

        private Periodensystem p = new Periodensystem();
        private Übung ü = new Übung();
        private SplashScreen sp = new SplashScreen();
        private MediaPlayer bgsound = new MediaPlayer()
        {
            Volume = 1
        };
        
        //Fenster und Pages
        private void pse_Click(object sender, RoutedEventArgs e)
        {
            Ansichtsframe.Height = p.Height;
            Ansichtsframe.Width = p.Width;
            Ansichtsframe.Content = p;
            textBlock1.Text = p.Title;
            ü.rücksetzensp();
            p.dt.Start();
            ü.dt.Stop();
        }
        private void übung_Click(object sender, RoutedEventArgs e)
        {
            Ansichtsframe.Height = ü.Height;
            Ansichtsframe.Width = ü.Width;
            Ansichtsframe.Content = ü;
            textBlock1.Text = ü.Title;
            p.dt.Stop();
            ü.dt.Start();
        }
        private void überdieanwendung(object sender, RoutedEventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        //Fensteraktionen
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            bgsound.Stop();
            System.Windows.Application.Current.Shutdown();
        }
        private void minimieren_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //Hintergrundmusik
        private void musik_Click(object sender, RoutedEventArgs e)
        {
            stop.IsChecked = true;
            System.Windows.Forms.OpenFileDialog dlg = new System.Windows.Forms.OpenFileDialog();
            dlg.Filter = "mp3-Dateien(.mp3)|*.mp3|Windows Media Audio(.wma)|*.wma|Wave-Dateien|*.wav|Alle Musikdateien(.wma,.mp3,.wav)|*.wma;*.mp3;*.wav";
            dlg.ShowDialog();
            try
            {
                bgsound.Open(new Uri(dlg.FileName.ToString(), UriKind.Relative));
                play.IsChecked = true;
                bgmusik.IsChecked = true;
            }
            catch (FormatException)
            {

            }
        }
        private void bgmusik_Checked(object sender, RoutedEventArgs e)
        {
            musikmenu.Visibility = Visibility.Visible;
        }
        private void bgmusik_Unchecked(object sender, RoutedEventArgs e)
        {
            musikmenu.Visibility = Visibility.Collapsed;
            lautstärke.Visibility = Visibility.Collapsed;
            ton.IsChecked = false;
        }
        private void play_Checked(object sender, RoutedEventArgs e)
        {
            bgsound.Play();
        }
        private void stop_Checked(object sender, RoutedEventArgs e)
        {
            bgsound.Stop();
        }
        private void pause_Checked(object sender, RoutedEventArgs e)
        {
            bgsound.Pause();
        }
        private void bgsound_MediaEnded(object sender, EventArgs e)
        {
            stop.IsChecked = true;
            if (repeat.IsChecked == true)
            {
                play.IsChecked = true;
            }
        }
        //Lautstärke
        private void ton_Checked(object sender, RoutedEventArgs e)
        {
            lautstärke.Visibility = Visibility.Visible;
        }
        private void ton_Unchecked(object sender, RoutedEventArgs e)
        {
            lautstärke.Visibility = Visibility.Collapsed;
        }
        private void Lauter_Click(object sender, RoutedEventArgs e)
        {
            bgsound.Volume = bgsound.Volume + 0.01;
            sli.Value = bgsound.Volume;
        }
        private void Leiser_Click(object sender, RoutedEventArgs e)
        {
            bgsound.Volume = bgsound.Volume - 0.01;
            sli.Value = bgsound.Volume;
        }
        private void Stumm_Checked(object sender, RoutedEventArgs e)
        {
            bgsound.IsMuted = true;
        }
        private void Stumm_Unchecked(object sender, RoutedEventArgs e)
        {
            bgsound.IsMuted = false;
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bgsound.Volume = (sender as Slider).Value;
            Slider s = sender as Slider;
            ToolTip t = new ToolTip();
            t.Content = (s.Value * 100).ToString();
            s.ToolTip = t;
        }

        //Bewegen
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window1 w = new Window1();
            if (w.WindowState != WindowState.Maximized)
            {
                this.DragMove();
            }
        }
        private void rectangle1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        //ContextMenü
        private MenuItem wiederh = new MenuItem()
        {
            Header = "_Wiederherstellen",
            IsEnabled = false
        };
        private MenuItem minim = new MenuItem()
        {
            Header = "_Minimieren"
        };
        private MenuItem maxm = new MenuItem()
        {
            Header = "_Maximieren",
            IsEnabled = false
        };
        private MenuItem close = new MenuItem()
        {
            Header = "_Schließen"
        };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = new ContextMenu();
            cm.Foreground = new SolidColorBrush(Color.FromRgb(0, 38, 255));
            Image i = new Image();
            Image iw = new Image();
            Image im = new Image();
            Image ima = new Image();
            cm.Items.Add(wiederh);
            iw.Source = new BitmapImage(new Uri("Wiederherstellen.png", UriKind.RelativeOrAbsolute));
            wiederh.Icon = iw;
            cm.Items.Add(minim);
            minim.Click += new RoutedEventHandler(minimieren_Click);
            im.Source = new BitmapImage(new Uri("Minimieren.png", UriKind.RelativeOrAbsolute));
            minim.Icon = im;
            cm.Items.Add(maxm);
            ima.Source = new BitmapImage(new Uri("Maximieren.png", UriKind.RelativeOrAbsolute));
            maxm.Icon = ima;
            cm.Items.Add(new Separator());
            cm.Items.Add(close);
            close.Click += new RoutedEventHandler(exit_Click);
            i.Source = new BitmapImage(new Uri("Schließen.png", UriKind.RelativeOrAbsolute));
            close.Icon = i;
            image1.ContextMenu = cm;
        }
    }
}
