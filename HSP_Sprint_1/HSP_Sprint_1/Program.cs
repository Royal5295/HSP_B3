using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSP_Sprint_1
{
    class Program
    {
        static public void Main(string[] args)
        {
            double m = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            bool checkrestart = false;

            Console.WriteLine("Der Rechteckcalculator");
            Console.WriteLine();

           
            do
            {

                a = Eingabe_a();                                //Länge a   
                b = Eingabe_b();                                //Länge b 
                c = Eingabe_c();                                //Lange c
                m = Eingabe_m();                                // Material Auswahl
                Ausgabe_Flaeche(a, b);
                Ausgabe_Schwerpunkt(a, b);
                Ausgabe_Flaechentragheitsmoment(a, b);
                Volume_Ausgabe(a, b, c);
                Ausgabe_Gewicht(a, b, c, m);

                Console.WriteLine("Möchten Sie eine weitere Rechnung durchführen? y/n");
                checkrestart = (Console.ReadKey().KeyChar == 'y');
                Console.WriteLine();
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.WriteLine();
            } while (checkrestart);
            Console.WriteLine("Das Programm wird beendet.");
            Console.ReadKey();
        }
                                                                    // Eingaben a, b, c, M,
        static double Eingabe_a()
        {
            double a = 0;
            bool checkmate = true;

            do
            {
                Console.WriteLine("Bitte geben Sie Länge a ein in cm.");
                String eingabe_a = Console.ReadLine();


                try
                {
                    a = Convert.ToDouble(eingabe_a);


                     // Negative oder Null Werte werden abgefangen und Schleife beginnt erneut.
                     
                    if (a == 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Werte müssen größer als Null sein.");
                    }
                    else if(a <= 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Bitte keine negativen Werte eingeben.");
                    }

                    else if ( a >=0)
                    {
                        checkmate = false;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");
                }


            }
            while (checkmate);
            return a;
        }

        static double Eingabe_b()
        {
            double b = 0;
            bool checkmate = true;

            do
            {
                Console.WriteLine("Bitte geben Sie Länge b ein in cm.");
                String eingabe_b = Console.ReadLine();
                try
                {
                    b = Convert.ToDouble(eingabe_b);


                    // Siehe Z. 64

                    if (b == 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Werte müssen größer als Null sein.");
                    }
                    else if (b <= 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Bitte keine negativen Werte eingeben.");
                    }
                    else if (b >= 0)
                    {
                        checkmate = false;   
                    
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");
                }

            }
            while (checkmate);
            return b;
        }
        
        static double Eingabe_c()
        {
            double c = 0;
            bool checkmate = true;

            do
            {
                Console.WriteLine("Bitte geben Sie Länge c ein in cm.");
                String eingabe_c = Console.ReadLine();

                try
                {
                    c = Convert.ToDouble(eingabe_c);


                    // Siehe Z. 64

                    if (c == 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Werte müssen größer als Null sein.");
                    }
                    else if (c <= 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Bitte keine negativen Werte eingeben.");
                    }
                    else if (c >= 0)
                    {
                        checkmate = false;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");
                }

            }
            while (checkmate);
            return c;
            
        }
                                    //Auswahl Material, zwischen Stahl und Alu
        static double Eingabe_m()               
        {
            double m = 0;
            bool checkmate = true;

            do
            {
                Console.WriteLine("Bitte wählen sie zwischen 1 für Stahl und 2 + für Aluminium.");
                Console.WriteLine(" Dichte von Stahl beträgt: 7.85 g/cm^3 und Aluminium: 2.7g/cm^3.");
                String eingabe_m = Console.ReadLine();

                try
                {
                    m = Convert.ToDouble(eingabe_m);


                    // Siehe Z. 64

                    if (m == 1)
                    {
                        checkmate = false;
                        Console.WriteLine("Stahl gewählt.");
                        m = 7.85;

                    }
                    else if (m == 2)
                    {
                        checkmate = false;
                        Console.WriteLine("Aluminium gewählt.");
                        m = 2.7;

                    }
                    else
                    {
                        checkmate = true;
                        Console.WriteLine("Falsche Eingabe, bitte zwischen 1 und 2 wählen.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");
                }

            }
            while (checkmate);
            return m;

        }   

            // Berechnungen



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

            static double Schwerpunkt_x_Rechteck_berechnen(double a)
            {
                double x = a / 2;
                return x;
            }
        static double Schwerpunkt_y_Rechteck_berechnen(double b)
        {
            double y = b / 2;
            return y;
        }

        static double Flaechentraegheitsmoment_Rechteck_Iy_berechnen(double a, double b)
        {
            double Iy = (b * (Math.Pow(a, 3))) / 12;
            return Iy;
        }


        static double Flaechentraegheitsmoment_Rechteck_Iz_berechnen(double a, double b)
        {
            double Iz = (a * (Math.Pow(b, 3))) / 12;
            return Iz;
        }

        static double Gewicht_berechnen(double a, double b, double c, double m)
        {
            double Mass = a * b * c * m;
            return Mass;



        }









        // Ausgaben

        static void Ausgabe_Gewicht(double a, double b, double c, double m)
        {
            Console.WriteLine("Gewicht ist:" + Gewicht_berechnen(a,b,c,m)+ " gramm");


        }


        static void Volume_Ausgabe(double a, double b, double c)
        {
            Console.WriteLine("Volume ist:" + Volume_berechnen(a, b, c) + " cm^3");

        }

        static void Ausgabe_Flaeche(double a, double b)
        {
            Console.WriteLine("Die Fläche beträgt: " + Flaeche_berechnen(a, b)+ "cm^2 ");
          
        }
        static void Ausgabe_Schwerpunkt(double a, double b)
        {
            Console.WriteLine("Der Schwerpunkt liegt bei:");
            Console.WriteLine("x = " + Schwerpunkt_x_Rechteck_berechnen(a));
            Console.WriteLine("y = " + Schwerpunkt_y_Rechteck_berechnen(b));
        }

        static void Ausgabe_Flaechentragheitsmoment(double a, double b)
        {
            Console.WriteLine("Das Flächenträgheitsmoment liegt bei:");
            Console.WriteLine("Iy = " + Flaechentraegheitsmoment_Rechteck_Iy_berechnen(a, b) + "cm^4");
            Console.WriteLine("Iz = " + Flaechentraegheitsmoment_Rechteck_Iz_berechnen(a, b) + "cm^4");
            Console.WriteLine("Iyz = 0");
        }

            
            
        }
    }
