using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HSP_Sprint2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
        }

        double Ergebnis = 0;
        double m = 0;
        double a = 0;
        double b = 0;
        double c = 0;

        static double Flaeche_berechnen(double a, double b)
        {
            double flaeche = a * b;
            return flaeche;
        }
        static double Volume_berechnen(double a, double b, double c)
        {
            double volume = a * b * c;
            return volume;
        }

























        private void Rechteckprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Visible;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Wellenprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Rundprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Visible;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Wellenprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Rohrprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Visible;
            Wellenprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Wellenprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Wellenprofil_Grid.Visibility = Visibility.Visible;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Tprofil_Selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Wellenprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

     /*   private void btn_Ergebnis_Rechteck(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtbox_rechteckprofil_l.Text);
            b = Convert.ToDouble(txtbox_rechteckprofil_b.Text);
            c = Convert.ToDouble(txtbox_rechteckprofil_h.Text);
            
            txtFlaeche.Text = (Ergebnis).ToString();
        }*/
    }
}
