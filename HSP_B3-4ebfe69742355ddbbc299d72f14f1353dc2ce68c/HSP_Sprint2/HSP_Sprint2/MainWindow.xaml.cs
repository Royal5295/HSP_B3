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



























        private void Rechteckprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Visible;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
            btn_brechnung_Rechteckprofil.Visibility = Visibility.Visible;
            btn_brechnung_rundprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rohrprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rechteckrohrprofil.Visibility = Visibility.Hidden;
            btn_brechnung_Tprofil.Visibility = Visibility.Hidden;



        }

        private void Rundprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Visible;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
            btn_brechnung_Rechteckprofil.Visibility = Visibility.Hidden;
            btn_brechnung_rundprofil.Visibility = Visibility.Visible;
            btn_berechnung_rohrprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rechteckrohrprofil.Visibility = Visibility.Hidden;
            btn_brechnung_Tprofil.Visibility = Visibility.Hidden;
        }

        private void Rohrprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Visible;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
            btn_brechnung_Rechteckprofil.Visibility = Visibility.Hidden;
            btn_brechnung_rundprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rohrprofil.Visibility = Visibility.Visible;
            btn_berechnung_rechteckrohrprofil.Visibility = Visibility.Hidden;
            btn_brechnung_Tprofil.Visibility = Visibility.Hidden;
        }

        private void Rechteckrohrprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Visible;
            Tprofil_Grid.Visibility = Visibility.Hidden;
            btn_brechnung_Rechteckprofil.Visibility = Visibility.Hidden;
            btn_brechnung_rundprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rohrprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rechteckrohrprofil.Visibility = Visibility.Visible;
            btn_brechnung_Tprofil.Visibility = Visibility.Hidden;
        }

        private void Tprofil_Selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Visible;
            btn_brechnung_Rechteckprofil.Visibility = Visibility.Hidden;
            btn_brechnung_rundprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rohrprofil.Visibility = Visibility.Hidden;
            btn_berechnung_rechteckrohrprofil.Visibility = Visibility.Hidden;
            btn_brechnung_Tprofil.Visibility = Visibility.Visible;
        }

       private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        // Rechteckprofil Ausfuehrung Berechnung
        public void btn_brechnung_Rechteckprofil_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double Breite = double.Parse(txtbox_rechteckprofil_b.Text);
                double Hoehe = double.Parse(txtbox_rechteckprofil_h.Text);
                double Laenge = double.Parse(txtbox_rechteckprofil_l.Text);
                txtVolumen.Text = (berechnungVolumen(Breite, Hoehe, Laenge) + "mm³");
                txtIXX.Text = (berechnungIXX(Breite, Hoehe) + "mm^4");
                txtIYY.Text = (berechnungIYY(Breite, Hoehe) + "mm^4");
            }

            catch (FormatException)
            {

                MessageBox.Show("Error! Keine Buchstaben eingeben!");
            }


        }

        public double berechnungVolumen(double Breite, double Hoehe, double Laenge)
        {
            double Volumen = Breite * Hoehe * Laenge;
            bool checkmate = false;


            do
            {
                if (Volumen == 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    Volumen = 0;

                }
                else if (Volumen <= 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    Volumen = 0;

                }

                

            }

            while (checkmate);
            return Volumen;
        }

       public double berechnungIXX(double Breite, double Hoehe)
        { 
            double IXX = (Breite * (Math.Pow(Hoehe, 3)) / 12 );
            bool checkmate = false;

            do
            {
                if (IXX == 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    IXX = 0;

                }
                else if (IXX <= 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    IXX = 0;

                }



            }

            while (checkmate);
            return IXX;
        }

        public double berechnungIYY(double Breite, double Hoehe)
        {
            double IYY = (Hoehe * (Math.Pow(Breite, 3)) / 12);
            bool checkmate = false;

            do
            {
                if (IYY == 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    IYY = 0;

                }
                else if (IYY <= 0)
                {
                    checkmate = true;
                    MessageBox.Show("Werte müssen größer als 0 sein!");

                    checkmate = false;
                    IYY = 0;

                }



            }

            while (checkmate);
            return IYY;
        }

        


        // Rundprofil Ausfuehrung Berechnung
        public void btn_brechnung_rundprofil_Click(object sender, RoutedEventArgs e)
        {
          try
            {
                double Durchmesser = double.Parse(txtbox_rundprofil_d.Text);
                double Durchmesser = double.Parse(txtbox_rundprofil_l.Text);

            }

            catch (FormatException)
            {

                MessageBox.Show("Error! Keine Buchstaben eingeben!");
            }




        }

        private void btn_berechnung_rohrprofil_Click(object sender, RoutedEventArgs e)
        {






        }


        private void btn_berechnung_rechteckrohrprofil_Click(object sender, RoutedEventArgs e)
        {





        }

        private void btn_brechnung_Tprofil_Click(object sender, RoutedEventArgs e)
        {



        }

        private void Stahl_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Titanium_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Aluminium_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Kupfer_Selected(object sender, RoutedEventArgs e)
        {

        }
    }

}
