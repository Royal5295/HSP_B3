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
using System.Windows.Media.Media3D;
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
                    SchwerpunktX.Text = (berechnungSchwerpunktX(Breite) + "mm");
                    SchwerpunktY.Text  = (berechnungSchwerpunktY(Hoehe) + "mm");
                    //txtGewicht.Text = (berechnungGewicht(Breite, Hoehe, Laenge, Stahl) + "g");
                    
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

        /*public double berechnungGewicht(double Breite, double Hoehe, double Laenge, double Stahl)
            {
                double Gewicht = ((Breite * Hoehe * Laenge) * Stahl);

                return Gewicht;
            }
        */
        public double berechnungSchwerpunktX(double Breite)
        {
            double SchwerpunktX = (Breite / 2);

            return SchwerpunktX;
        }

        public double berechnungSchwerpunktY(double Hoehe)
        {
            double SchwerpunktY = (Hoehe / 2);

            return SchwerpunktY;
        }


        // Rundprofil Ausfuehrung Berechnung
        public void btn_brechnung_rundprofil_Click(object sender, RoutedEventArgs e)
        
            {
                double Stahl;
                bool checkmate = false;
                do
                {
                    try
                    {

                        double Durchmesser = double.Parse(txtbox_rundprofil_dm.Text);
                        double Laenge = double.Parse(txtbox_rundprofil_l.Text);

                        if (Durchmesser <= 0)
                        {
                            checkmate = true;
                            MessageBox.Show("Breite muss größer als 0 sein!");
                            checkmate = false;
                            Durchmesser = 0;
                            Laenge = 0;
                        }

                        if (Laenge <= 0)
                        {
                            checkmate = true;
                            MessageBox.Show("Laenge muss größer als 0 sein!");
                            checkmate = false;
                            Laenge = 0;
                            Durchmesser = 0;
                        }

                    txtVolumen.Text = (berechnungVolumen_Rundprofil(Durchmesser, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX_Rundprofil(Durchmesser) + "mm");
                    txtIYY.Text = (berechnungIXX_Rundprofil(Durchmesser) + "mm");
                    txtWXX.Text = (berechnungWXX_Rundprofil(Durchmesser) + "mm");
                    txtWYY.Text = (berechnungWXX_Rundprofil(Durchmesser) + "mm");
                    //txtGewicht.Text = (berechnungGewicht(Durchmesser, Laenge, Sorte) + "g");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Rundprofil(Durchmesser) + "mm");
                    SchwerpunktY.Text = (berechnungSchwerpunktX_Rundprofil(Durchmesser) + "mm");
                       

                    }

                    catch (FormatException)
                    {

                        MessageBox.Show("Error! Keine Buchstaben eingeben!");
                    }
                }
                while (checkmate);
            }
        public double berechnungVolumen_Rundprofil(double Durchmesser, double Laenge)
        {
            double Volumen_Rundprofil = (((Math.PI * Math.Pow(Durchmesser , 2))/ 4) * Laenge);


            return Volumen_Rundprofil;
        }

        public double berechnungIXX_Rundprofil(double Durchmesser)
        {
            double IXX_Rundprofil = ((Math.PI * Math.Pow(Durchmesser, 4)) / 64);

            return IXX_Rundprofil;
        }
        
        public double berechnungWXX_Rundprofil(double Durchmesser)
        {
            double WXX_Rundprofil = ((Math.PI * Math.Pow(Durchmesser, 3))/3);

            return WXX_Rundprofil;
        }

        /*public double berechnungGewicht_Rundprofil(double Durchmesser, double Laenge, Sorte)
        {
            double Gewicht = ((((Math.PI * Math.Pow(Durchmesser, 2)) / 4) * Laenge) * Sorte);

            return Gewicht;
        }
       */

        public double berechnungSchwerpunktX_Rundprofil(double Durchmesser)
        {
            double SchwerpunktX = Durchmesser / 2 ;

            return SchwerpunktX;
        }

        //Rohrprofil Ausführung Berechnung

        public void btn_berechnung_rohrprofil_Click(object sender, RoutedEventArgs e)
        {
           
                double Stahl;
                bool checkmate = false;
                do
                {
                    try
                    {

                        double Durchmesser = double.Parse(txtbox_rohrprofil_dm.Text);
                        double Laenge = double.Parse(txtbox_rohrprofil_l.Text);
                        double Dicke = double.Parse(txtbox_rohrprofil_d.Text);

                        if (Durchmesser <= 0)
                        {
                            checkmate = true;
                            MessageBox.Show("Breite muss größer als 0 sein!");
                            checkmate = false;
                            Durchmesser = 0;
                            Laenge = 0;
                            Dicke = 0;
                        }

                        if (Laenge <= 0)
                        {
                            checkmate = true;
                            MessageBox.Show("Laenge muss größer als 0 sein!");
                            checkmate = false;
                            Laenge = 0;
                            Durchmesser = 0;
                            Dicke = 0;

                        }

                        if (Dicke <=0)
                        {
                        checkmate = true;
                        MessageBox.Show("Dicke muss größer als 0 sein!");
                        checkmate = false;
                        Dicke = 0;
                        Durchmesser = 0;
                        Laenge = 0;
                        }

               

                        txtVolumen.Text = (berechnungVolumen_Rohrprofil(Durchmesser, Dicke, Laenge) + "mm³");
                        txtIXX.Text = (berechnungIXX_Rohrprofil(Durchmesser, Dicke) + "mm");
                        txtIYY.Text = (berechnungIXX_Rohrprofil(Durchmesser, Dicke) + "mm");
                        txtWXX.Text = (berechnungWXX_Rohrprofil(Durchmesser, Dicke) + "mm");
                        txtWYY.Text = (berechnungWXX_Rohrprofil(Durchmesser, Dicke) + "mm");
                        //txtGewicht.Text = (berechnungGewicht(Durchmesser, Dicke, Laenge, Volumen, Sorte) + "g");
                        SchwerpunktX.Text = (berechnungSchwerpunktX_Rohrprofil(Durchmesser) + "mm");
                        SchwerpunktY.Text = (berechnungSchwerpunktX_Rohrprofil(Durchmesser) + "mm");

                    }

                    catch (FormatException)
                    {

                        MessageBox.Show("Error! Keine Buchstaben eingeben!");
                    }
                }
                while (checkmate);
            
        }
        // Berechnung
        public double berechnungVolumen_Rohrprofil(double Durchmesser, double Dicke, double Laenge)
        {
            double Volumen_Rohrprofil = (((Math.PI * Math.Pow(Durchmesser, 2)) / 4) - ((Math.PI * Math.Pow((Durchmesser - (2 * Dicke)), 2)) / 4)) * Laenge;


            return Volumen_Rohrprofil;
        }

        public double berechnungIXX_Rohrprofil(double Durchmesser, double Dicke)
        {
            double IXX_Rohrprofil = (Math.PI * (Math.Pow(Durchmesser, 4)) - (Math.Pow((Durchmesser - (2 * Dicke)), 4))) / 64;

            return IXX_Rohrprofil;
        }

        public double berechnungWXX_Rohrprofil(double Durchmesser, double Dicke)
        {
            double WXX_Rohrprofil = (Math.PI * (Math.Pow(Durchmesser, 4)) - (Math.Pow((Durchmesser - (2 * Dicke)), 4))) / 32;

            return WXX_Rohrprofil;
        }

        /*public double berechnungGewicht_Rohrprofil(double Durchmesser, double Dicke, double Laenge, double Volumen, Material)
        {
            double Geweicht_Rohrprofil = Volumen * Material

            return Geweicht_Rohrprofil;
        }
        */

        public double berechnungSchwerpunktX_Rohrprofil(double Durchmesser)
        {
            double SchwerpunktX = Durchmesser / 2;

            return SchwerpunktX;
        }

        // Rechteckrohr Ausführung Berechnung
        public void btn_berechnung_rechteckrohrprofil_Click(object sender, RoutedEventArgs e)
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
                    double Dicke = double.Parse(txtbox_rechteckrohrprofil_d.Text);

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



                    txtVolumen.Text = (berechnungVolumen_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtIYY.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWXX.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWYY.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    //txtGewicht.Text = (berechnungGewicht_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge, Volumen, Sorte) + "g");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Breite) + "mm");
                    SchwerpunktY.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Hoehe) + "mm");

                }

                catch (FormatException)
                {

                    MessageBox.Show("Error! Keine Buchstaben eingeben!");
                }
            }
            while (checkmate);

        }

        //Berechnung

        public double berechnungVolumen_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke, double Laenge)
        {
            double Volumen_Rechteckrohrprofil = (Breite * Hoehe) - ((Breite - (2 * Dicke)) + (Hoehe - (2 * Dicke))) * Laenge;

            return Volumen_Rechteckrohrprofil;
        }

        public double berechnungIXX_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke)
        {
            double IXX_Rechteckrohrprofil = ((Hoehe * Math.Pow(Breite, 3)) - (((Hoehe - (2 * Dicke))) * Math.Pow(Breite - (2 * Dicke), 3))) / 12;

            return IXX_Rechteckrohrprofil;
        }

        public double berechnungIYY_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke)
        {
            double IYY_Rechteckrohrprofil = ((Breite * Math.Pow(Hoehe, 3)) - (((Breite - (2 * Dicke))) * Math.Pow(Hoehe - (2 * Dicke), 3))) / 12;

            return IYY_Rechteckrohrprofil;
        }

        public double berechnungWXX_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke)
        {
            double WXX_Rechteckrohrprofil = ((Hoehe * Math.Pow(Breite, 3)) + (((Hoehe - (2 * Dicke))) * Math.Pow(Breite - (2 * Dicke), 3))) / 6 * Hoehe;

            return WXX_Rechteckrohrprofil;
        }

        public double berechnungWYY_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke)
        {
            double WYY_Rechteckrohrprofil = ((Breite * Math.Pow(Hoehe, 3)) + (((Breite - (2 * Dicke))) * Math.Pow(Hoehe - (2 * Dicke), 3))) / 6 * Hoehe;

            return WYY_Rechteckrohrprofil;
        }

        /*public double berechnungGewicht_Rechteckrohrprofil(double Breite, double Hoehe, double Dicke, double Laenge, double Volumen, double Dichte_Material)
            {
                double Gewicht_Rechtekrohrprofil = Volumen * Dichte_Material

                return Gewicht_Rechteckrohrprofil;
            }
        */
        public double berechnungSchwerpunktX_Rechteckrohrprofil(double Breite)
        {
            double SchwerpunktX_Rechteckrohrprofil = (Breite / 2);

            return SchwerpunktX_Rechteckrohrprofil;
        }

        public double berechnungSchwerpunktY_Rechteckrohrprofil(double Hoehe)
        {
            double SchwerpunktY_Rechteckrohrprofil = (Hoehe / 2);

            return SchwerpunktY_Rechteckrohrprofil;
        }


        private void btn_brechnung_Tprofil_Click(object sender, RoutedEventArgs e)
        {
            double Stahl;
            bool checkmate = false;
            do
            {
                try
                {

                    double Breite_B = double.Parse(txtbox_Tprofil_B.Text);
                    double Breite_b = double.Parse(txtbox_Tprofil_b.Text);
                    double Hoehe_H = double.Parse(txtbox_Tprofil_H.Text);
                    double Hoehe_h = double.Parse(txtbox_Tprofil_h.Text);
                    double Laenge_l = double.Parse(txtbox_rohrprofil_l.Text);
                    

                    if (Breite_B <= 0)
                    {
                        checkmate = true;
                        MessageBox.Show("Breite muss größer als 0 sein!");
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
                        MessageBox.Show("Breite muss größer als 0 sein!");
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
                        MessageBox.Show("Höhe muss größer als 0 sein!");
                        checkmate = false;
                        Hoehe_H = 0;
                        Breite_B = 0;
                        Breite_b = 0;
                        Hoehe_h = 0;
                        Laenge_l = 0;
                    }

                    if (Hoehe_h <=0)
                    {
                        checkmate = true;
                        MessageBox.Show("Höhe muss größer als 0 sein!");
                        checkmate = false; 
                        Hoehe_h = 0;
                        Breite_B = 0;
                        Breite_b = 0;
                        Hoehe_H = 0;
                        Laenge_l = 0;
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



                    txtVolumen.Text = (berechnungVolumen_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge) + "mm³");
                    txtIXX.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtIYY.Text = (berechnungIXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWXX.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    txtWYY.Text = (berechnungWXX_Rechteckrohrprofil(Breite, Hoehe, Dicke) + "mm");
                    //txtGewicht.Text = (berechnungGewicht_Rechteckrohrprofil(Breite, Hoehe, Dicke, Laenge, Volumen, Sorte) + "g");
                    SchwerpunktX.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Breite) + "mm");
                    SchwerpunktY.Text = (berechnungSchwerpunktX_Rechteckrohrprofil(Hoehe) + "mm");

                }

                catch (FormatException)
                {

                    MessageBox.Show("Error! Keine Buchstaben eingeben!");
                }
            }
            while (checkmate);



        }


    }

}
