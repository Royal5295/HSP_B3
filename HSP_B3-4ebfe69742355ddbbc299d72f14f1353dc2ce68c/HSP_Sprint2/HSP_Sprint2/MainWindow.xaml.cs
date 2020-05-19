﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                    }


                    txtVolumen.Text = (berechnungVolumen_Rechteckprofil(Breite, Hoehe, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX_Rechteckprofil(Breite, Hoehe) + "mm^4");
                    txtIYY.Text = (berechnungIYY_Rechteckprofil(Breite, Hoehe) + "mm^4");
                    txtWXX.Text = (berechnungWXX_Rechteckprofil(Breite, Hoehe) + "mm^4");
                    txtWYY.Text = (berechnungWYY_Rechteckprofil(Breite, Hoehe) + "mm^4");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Rechteckprofil(Breite) + "mm");
                    SchwerpunktY.Text  = (berechnungSchwerpunktY_Rechteckprofil(Hoehe) + "mm");
                    //txtGewicht.Text = (berechnungGewicht_Rechteckprofil(Breite, Hoehe, Laenge, Stahl) + "g");

            }

                catch (FormatException)
            {
                MessageBox.Show("Error! Keine Buchstaben eingeben!");
            }
            }
            while (checkmate) ;
        }

        // Berechnung
        public double berechnungVolumen_Rechteckprofil(double Breite, double Hoehe, double Laenge)
        {
            double Volumen_Rechteckprofil = Breite * Hoehe * Laenge;
            

            return Volumen_Rechteckprofil;
        }

       public double berechnungIXX_Rechteckprofil(double Breite, double Hoehe)
        { 
            double IXX_Rechteckprofil = (Breite * (Math.Pow(Hoehe, 3)) / 12 );
            
            return IXX_Rechteckprofil;
        }

        public double berechnungIYY_Rechteckprofil(double Breite, double Hoehe)
        {
            double IYY_Rechteckprofil = (Hoehe * (Math.Pow(Breite, 3)) / 12);
           
            return IYY_Rechteckprofil;

        }
  
        public double berechnungWXX_Rechteckprofil(double Breite, double Hoehe)
        {
            double WXX_Rechteckprofil = (Breite * (Math.Pow(Hoehe, 2)) / 6);

            return WXX_Rechteckprofil;
        }

        public double berechnungWYY_Rechteckprofil(double Breite, double Hoehe)
        {
            double WYY_Rechteckprofil = (Hoehe * (Math.Pow(Breite, 2)) / 6);

            return WYY_Rechteckprofil;
        }

        /*public double berechnungGewicht_Rechteckprofil(double Breite, double Hoehe, double Laenge, double Stahl)
            {
                double Gewicht_Rechteckprofil = ((Breite * Hoehe * Laenge) * Stahl);

                return Gewicht_Rechteckprofil;
            }
        */
        public double berechnungSchwerpunktX_Rechteckprofil(double Breite)
        {
            double SchwerpunktX_Rechteckprofil = (Breite / 2);

            return SchwerpunktX_Rechteckprofil;
        }

        public double berechnungSchwerpunktY_Rechteckprofil(double Hoehe)
        {
            double SchwerpunktY_Rechteckprofil = (Hoehe / 2);

            return SchwerpunktY_Rechteckprofil;
        }


        // Rundprofil Ausfuehrung Berechnung
        public void btn_brechnung_Rundprofil_Click(object sender, RoutedEventArgs e)
        
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
        public void btn_berechnung_Rohrprofil_Click(object sender, RoutedEventArgs e)

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

            double Stahl;
            bool checkmate = false;
            do
            {
                try
                {

                    double Breite = double.Parse(txtbox_rechteckrohrprofil_b.Text);
                    double Hoehe = double.Parse(txtbox_rechteckrohrprofil_h.Text);
                    double Laenge = double.Parse(txtbox_rohrprofil_l.Text);
                    double Dicke = double.Parse(txtbox_rohrprofil_d.Text);

                    if (Breite <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Breite muss größer als 0 sein!");
                        checkmate = false;
                        Breite = 0;
                        Hoehe = 0;
                        Laenge = 0;
                        Dicke = 0;
                    }

                    if (Hoehe <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Höhe muss größer als 0 sein!");
                        checkmate = false;
                        Hoehe = 0;
                        Breite = 0;
                        Laenge = 0;
                        Dicke = 0;
                    }

                    if (Laenge <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Laenge muss größer als 0 sein!");
                        checkmate = false;
                        Laenge = 0;
                        Breite = 0;
                        Hoehe = 0;
                        Dicke = 0;


                    }

                    if (Dicke <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Dicke muss größer als 0 sein!");
                        checkmate = false;
                        Dicke = 0;
                        Breite = 0;
                        Hoehe = 0;
                        Laenge = 0;
                    }

/*

                    txtVolumen.Text = (berechnungVolumen_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtIYY.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWXX.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWYY.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    //txtGewicht.Text = (berechnungGewicht_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge, Volumen, Sorte) + "g");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Breite) + "mm");
                    SchwerpunktY.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Hoehe) + "mm");
*/
                }

                catch (FormatException)
                {

                    MessageBox.Show("Error! Keine Buchstaben eingeben!");
                }
            }
            while (checkmate);

        }


                    txtVolumen.Text = (berechnungVolumen_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h, Laenge_l) + "mm³");
                    txtIXX.Text = (berechnungIXX_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h) + "mm");
                    txtIYY.Text = (berechnungIXX_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h) + "mm");
                    txtWXX.Text = (berechnungWXX_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h) + "mm");
                    txtWYY.Text = (berechnungWXX_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h) + "mm");
                    //txtGewicht.Text = (berechnungGewicht_Tprofil(Breite, Hoehe, Dicke, Laenge, Volumen, Sorte) + "g");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Tprofil(Hoehe_H) + "mm");
                    SchwerpunktY.Text = (berechnungSchwerpunktY_Tprofil(Breite_B, Breite_b, Hoehe_H, Hoehe_h) + "mm");
      
        /*
        public void btn_brechnung_Tprofil_Click(object sender, RoutedEventArgs e)
        {

            if (Breite_B <= 0)
            {
                checkmate = true;
                MessageBox.Show("Breite B muss größer als 0 sein!");
                checkmate = false;
                Breite_B = 0;
                Breite_b = 0;
                Hoehe_H = 0;
                Hoehe_h = 0;
                Laenge_l = 0;

            }

            if (Breite_b <= 0) ;
            {
                checkmate = true;
                MessageBox.Show("Breite b muss größer als 0 sein!");
                checkmate = false;
                Breite_b = 0;
                Breite_B = 0;
                Hoehe_H = 0;
                Hoehe_h = 0;
                Laenge_l = 0;
            }

            if (Hoehe_H <= 0)
            {
                checkmate = true;
                MessageBox.Show("Höhe H muss größer als 0 sein!");
                checkmate = false;
                Hoehe_H = 0;
                Breite_B = 0;
                Breite_b = 0;
                Hoehe_h = 0;
                Laenge_l = 0;
            }

            if (Hoehe_h <= 0)
            {
                checkmate = true;
                MessageBox.Show("Höhe h muss größer als 0 sein!");
                checkmate = false;
                Hoehe_h = 0;
                Breite_B = 0;
                Breite_b = 0;
                Hoehe_H = 0;
                Laenge_l = 0;
            }

            if (Laenge_l <= 0)
            {
                checkmate = true;
                MessageBox.Show("Länge muss größer als 0 sein!");
                checkmate = false;
                Laenge_l = 0;
                Hoehe_h = 0;
                Breite_B = 0;
                Breite_b = 0;
                Hoehe_H = 0;
            }

            txtVolumen.Text = (berechnungVolumen_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge) + "mm³");
            txtIXX.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
            txtIYY.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
            txtWXX.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
            txtWYY.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
            //txtGewicht.Text = (berechnungGewicht_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge, Volumen, Sorte) + "g");
            SchwerpunktX.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Breite) + "mm");
            SchwerpunktY.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Hoehe) + "mm");
        }

    */
        private void laenge_anzeigen_rechteck(object sender, MouseEventArgs e)
        {
            laenge_Rechteck.Visibility = Visibility.Visible;
        }

        private void laenge_verdecken_rechteck(object sender, MouseEventArgs e)
        {
            laenge_Rechteck.Visibility = Visibility.Hidden;
        }

        private void breite_anzeigen_rechteck(object sender, MouseEventArgs e)
        {
            breite_Rechteck.Visibility = Visibility.Visible;
        }

        private void breite_verdecken_rechteck(object sender, MouseEventArgs e)
        {
            breite_Rechteck.Visibility = Visibility.Hidden;
        }

        private void hoehe_anzeigen_rechteck(object sender, MouseEventArgs e)
        {
            hoehe_Rechteck.Visibility = Visibility.Visible;
        }

        private void hoehe_verdecken_rechteck(object sender, MouseEventArgs e)
        {
            hoehe_Rechteck.Visibility = Visibility.Hidden;
        }

        private void durchmesser_anzeigen_rund(object sender, MouseEventArgs e)
        {
            durchmesser_Rund.Visibility = Visibility.Visible;
        }

        private void durchmesser_verdecken_rund(object sender, MouseEventArgs e)
        {
            durchmesser_Rund.Visibility = Visibility.Hidden;
        }

        private void laenge_anzeigen_rund(object sender, MouseEventArgs e)
        {
            laenge_Rund.Visibility = Visibility.Visible;
        }

        private void laenge_verdecken_rund(object sender, MouseEventArgs e)
        {
            laenge_Rund.Visibility = Visibility.Hidden;
        }

        private void durchmesser_anzeigen_rohr(object sender, MouseEventArgs e)
        {
            durchmesser_rohr.Visibility = Visibility.Visible;
        }

		private void durchmesser_verdecken_rohr(object sender, MouseEventArgs e)
        {
            durchmesser_rohr.Visibility = Visibility.Hidden;
        }

        private void laenge_anzeigen_rohr(object sender, MouseEventArgs e)
        {
            laenge_rohr.Visibility = Visibility.Visible;
        }
		
        private void laenge_verdecken_rohr(object sender, MouseEventArgs e)
        {
            laenge_rohr.Visibility = Visibility.Hidden;
        }

        private void laenge_anzeigen_rechteckrohr(object sender, MouseEventArgs e)
        {
            laenge_rechteckrohr.Visibility = Visibility.Visible;
        }

        private void laenge_verdecken_rechteckrohr(object sender, MouseEventArgs e)
        {
            laenge_rechteckrohr.Visibility = Visibility.Hidden;
        }

        private void breite_anzeigen_rechteckrohr(object sender, MouseEventArgs e)
        {
            breite_rechteckrohr.Visibility = Visibility.Visible;
        }

        private void breite_verdecken_rechteckrohr(object sender, MouseEventArgs e)
        {
            breite_rechteckrohr.Visibility = Visibility.Hidden;
        }

        private void hoehe_anzeigen_rechteckrohr(object sender, MouseEventArgs e)
        {
            hoehe_rechteckrohr.Visibility = Visibility.Visible;
        }

        private void hoehe_verdecken_rechteckrohr(object sender, MouseEventArgs e)
        {
            hoehe_rechteckrohr.Visibility = Visibility.Hidden;
        }
	
		private void breite_b_anzeigen_tprofil(object sender, MouseEventArgs e)
        {
            breite_b_tprofil.Visibility = Visibility.Visible;
        }

		 private void breite_b_verdecken_tprofil(object sender, MouseEventArgs e)
        {
            breite_b_tprofil.Visibility = Visibility.Hidden;
        }

        private void breite_bigb_anzeigen_tprofil(object sender, MouseEventArgs e)
        {
            breite_B_tprofil.Visibility = Visibility.Visible;
        }		
		
        private void breite_bigb_verdecken_tprofil(object sender, MouseEventArgs e)
        {
            breite_B_tprofil.Visibility = Visibility.Hidden;
        }

        private void hoehe_h_anzeigen_tprofil(object sender, MouseEventArgs e)
        {
            hoehe_h_tprofil.Visibility = Visibility.Visible;
        }

        private void hoehe_h_verdecken_tprofil(object sender, MouseEventArgs e)
        {
            hoehe_h_tprofil.Visibility = Visibility.Hidden;
        }

        private void hoehe_bigh_anzeigen_tprofil(object sender, MouseEventArgs e)
        {
            hoehe_H_tprofil.Visibility = Visibility.Visible;

        }

        private void hoehe_bigh_verdecken_tprofil(object sender, MouseEventArgs e)
        {
            hoehe_H_tprofil.Visibility = Visibility.Hidden;
        }

        private void laenge_anzeigen_tprofil(object sender, MouseEventArgs e)
        {
            laenge_tprofil.Visibility = Visibility.Visible;
        }

        private void laenge_verdecken_tprofil(object sender, MouseEventArgs e)
        {
            laenge_tprofil.Visibility = Visibility.Hidden;
        }
    }
/*
        public double berechnungVolumen_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h, double Laenge_l)
        {
            double Volumen_Tprofil = ((Breite_B * Hoehe_H) + (Breite_b * Hoehe_h)) * Laenge_l;

            return Volumen_Tprofil;
        }

        public double berechnungIXX_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h)
        {
            double IXX_Tprofil = (Hoehe_H * Math.Pow(Breite_B, 3) + Hoehe_h * Math.Pow(Breite_b, 3)) / 12;

            return IXX_Tprofil;
        }

        public double berechnungIYY_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h)
        {
            double IYY_Tprofil = (Breite_B * Math.Pow(Hoehe_H, 3) + Breite_b * Math.Pow(Hoehe_h, 3)) / 12;


*/
   /*    public double berechnungIYY_Tprofil()
    {

    }
    
            return IYY_Tprofil;
        }
	*/
        public double berechnungWXX_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h)
        {
            double WXX_Tprofil = (Hoehe_H * Math.Pow(Breite_B, 3) + Hoehe_h * Math.Pow(Breite_b, 3)) / 6 * Hoehe_H;

            return WXX_Tprofil;
        }

        public double berechnungWYY_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h)
        {
            double WYY_Tprofil = (Breite_B * Math.Pow(Hoehe_H, 3) + Breite_b * Math.Pow(Hoehe_h, 3)) / 6 * Hoehe_H;

            return WYY_Tprofil;
        }

       /* public double berechnungGewicht_Tprofil(double Volumen, double Dichte_Material)
        {
            double Gewicht_Tprofil = Volumen * Dichte_Material;

            return Gewicht_Tprofil;
        }
        */
        public double berechnungSchwerpunktX_Tprofil( double Hoehe_H)
        {
            double SchwerpunktX_tProfil = Hoehe_H / 2;

            return SchwerpunktX_tProfil;
        }

        public double berechnungSchwerpunktY_Tprofil(double Breite_B, double Breite_b, double Hoehe_H, double Hoehe_h)
        {
            double SchwerpunktY_tProfil = 0.5 * (((Breite_B * Math.Pow(Hoehe_H, 2)) + (Breite_b * Math.Pow(Hoehe_h, 2))) / (Breite_B * Hoehe_H) + (Breite_b * Hoehe_h));

            return SchwerpunktY_tProfil;
        }

}

   
    


}

