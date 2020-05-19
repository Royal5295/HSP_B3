﻿using System;
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
        public void Stahl_Selected(object sender, RoutedEventArgs e)
        {
            double Stahl = 0.00787;
        }

        public void Titanium_Selected(object sender, RoutedEventArgs e)
        {
            double Titanium = 0.004506;
        }

        public void Aluminium_Selected(object sender, RoutedEventArgs e)
        {
            double Aluminium = 0.0027;
        }

        public void Kupfer_Selected(object sender, RoutedEventArgs e)
        {
            double Kupfer = 0.00896;
        }
        
        // Rechteckprofil Ausfuehrung Berechnung
        public void btn_brechnung_Rechteckprofil_Click(object sender, RoutedEventArgs e)
        {
            double Stahl;
            bool checkmate = false;
            do
            { 
            try
            {

                double Breite = double.Parse(txtbox_rechteckprofil_b.Text);
                double Hoehe = double.Parse(txtbox_rechteckprofil_h.Text);
                double Laenge = double.Parse(txtbox_rechteckprofil_l.Text);

                if (Breite <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Breite muss größer als 0 sein!");
                        checkmate = false;
                        Breite = 0;
                        Hoehe = 0;
                        Laenge = 0;
                    }

                if (Hoehe <=0)
                    {
                        checkmate = true;
                        MessageBox.Show("Hoehe muss größer als 0 sein!");
                        checkmate = false;
                        Hoehe = 0;
                        Breite = 0;
                        Laenge = 0;
                    }

                if (Laenge <=0)
                    {
                        checkmate = true;
                        MessageBox.Show("Laenge muss größer als 0 sein!");
                        checkmate = false;
                        Laenge = 0;
                        Breite = 0;
                        Hoehe = 0;
                    }

                    txtVolumen.Text = (berechnungVolumen(Breite, Hoehe, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX(Breite, Hoehe) + "mm^4");
                    txtIYY.Text = (berechnungIYY(Breite, Hoehe) + "mm^4");
                    txtWXX.Text = (berechnungWXX(Breite, Hoehe) + "mm^4");
                    txtWYY.Text = (berechnungWYY(Breite, Hoehe) + "mm^4");
                    txtGewicht.Text = (berechnungGewicht(Breite, Hoehe, Laenge, Stahl) + "g");
             }

            catch (FormatException)
            {

                MessageBox.Show("Error! Keine Buchstaben eingeben!");
            }
            }
            while (checkmate) ;
        }
        // Berechnung
        public double berechnungVolumen(double Breite, double Hoehe, double Laenge)
        {
            double Volumen = Breite * Hoehe * Laenge;
            

            return Volumen;
        }

       public double berechnungIXX(double Breite, double Hoehe)
        { 
            double IXX = (Breite * (Math.Pow(Hoehe, 3)) / 12 );
            
            return IXX;
        }

        public double berechnungIYY(double Breite, double Hoehe)
        {
            double IYY = (Hoehe * (Math.Pow(Breite, 3)) / 12);
           
            return IYY;
        }

        public double berechnungWXX(double Breite, double Hoehe)
        {
            double WXX = (Breite * (Math.Pow(Hoehe, 2)) / 6);

            return WXX;
        }

        public double berechnungWYY(double Breite, double Hoehe)
        {
            double WYY = (Hoehe * (Math.Pow(Breite, 2)) / 6);

            return WYY;
        }

        public double berechnungGewicht(double Breite, double Hoehe, double Laenge, double Stahl)
        {
            double Gewicht = ((Breite * Hoehe * Laenge) * Stahl);

            return Gewicht;
        }
        


        // Rundprofil Ausfuehrung Berechnung
        public void btn_brechnung_rundprofil_Click(object sender, RoutedEventArgs e)
        {
          try
            {
               

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
        
        
    }

}
