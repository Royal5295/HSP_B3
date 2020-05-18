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
        }

        private void Rundprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Visible;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Rohrprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Visible;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Rechteckrohrprofil_selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Visible;
            Tprofil_Grid.Visibility = Visibility.Hidden;
        }

        private void Tprofil_Selected(object sender, RoutedEventArgs e)
        {
            RechteckProfil_Grid.Visibility = Visibility.Hidden;
            Rundprofil_Grid.Visibility = Visibility.Hidden;
            Rohrprofil_Grid.Visibility = Visibility.Hidden;
            Rechteckrohrprofil_Grid.Visibility = Visibility.Hidden;
            Tprofil_Grid.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            try
           {
                double zahl1 = double.Parse(txtbox_rechteckprofil_l.Text);
                double zahl2 = double.Parse(txtbox_rechteckprofil_b.Text);
                double zahl3 = double.Parse(txtbox_rechteckprofil_h.Text);
                txtVolumen.Text = (berechnungVolumen(zahl1, zahl2, zahl3) + "mm³");

              

               
            }
            catch (FormatException)
            {
                MessageBox.Show("Error!!! Bitte keine Buchstaben eingeben!");
            }

           





        }
        public double berechnungVolumen(double zahl1, double zahl2, double zahl3)
        {
            double Volumen = zahl1 * zahl2 * zahl3;
            bool checkmate = true;
            
            do
            {





                if (Volumen == 0)
                {
                   checkmate = true;
                    MessageBox.Show("Fehler nicht mit 0 Multiplizieren");

                    checkmate = false;
                    Volumen = 0;
                   // break;
                }
                else if (Volumen <= 0)
                {
                    
                    checkmate = true;
                    MessageBox.Show(" Fehler keine neg. Werte");
                    checkmate = false;
                    Volumen = 0;
                    string ErMessage = ("Eine beliebige Nachricht"+ "");
                    txtVolumen.Text = ErMessage + "";



                    //break;
                }
                else if (Volumen >= 0)
                {
                    checkmate = false;
                   
                }
            }
            while (checkmate);
            return Volumen;
        }

        
             
        
               
            
     
                
               
            
            
        

    }
}
