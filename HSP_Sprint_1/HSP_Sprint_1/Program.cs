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

            double a = 0;
            double b = 0;
            double c = 0;
            bool checkrestart = false;

            Console.WriteLine("Der Rechteckcalculator");
            Console.WriteLine();

            /*
            Console.WriteLine("Bitte geben Sie Länge a ein.");
            String eingabe_a = Console.ReadLine();
            double  a = Convert.ToDouble(eingabe_a);
            
            Console.WriteLine("Bitte geben Sie Länge b ein.");
            String eingabe_b = Console.ReadLine();
            b = Convert.ToDouble(eingabe_b);
            

            Console.WriteLine("Bitte geben Sie Laange c ein.");
            String eingabe_c = Console.ReadLine();
            c = Convert.ToDouble(eingabe_c);
            */
            do
            {

                a = Eingabe_a();                                //Länge a   
                b = Eingabe_b();                                //Länge b 
                c = Eingabe_c();                               //Lange c
                Ausgabe_Flaeche(a, b);
                Ausgabe_Schwerpunkt(a, b);
                Ausgabe_Flaechentragheitsmoment(a, b);
                Volume_Ausgabe(a, b, c);


                Console.WriteLine("Möchten Sie eine weitere Rechnung durchführen? y/n");
                checkrestart = (Console.ReadKey().KeyChar == 'y');
                Console.WriteLine();
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.WriteLine();
            } while (checkrestart);
            Console.WriteLine("Das Programm wird beendet.");
            Console.ReadKey();
        }

        static double Eingabe_a()
        {
            double a = 0;
            bool checkmate = true;

            do
            {
                Console.WriteLine("Bitte geben Sie Länge a ein.");
                String eingabe_a = Console.ReadLine();


                try
                {
                    a = Convert.ToDouble(eingabe_a);


                    // Negative oder Null Werte werden abgefangen und Schleife beginnt erneut.
                     
                    if (a == 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Werte müssen größer als Null sein");
                    }
                    else if(a <= 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Bitte keine negativen Werte eingeben");
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
                Console.WriteLine("Bitte geben Sie Länge b ein.");
                String eingabe_b = Console.ReadLine();
                try
                {
                    b = Convert.ToDouble(eingabe_b);


                    // Siehe Z. 64

                    if (b == 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Werte müssen größer als Null sein");
                    }
                    else if (b <= 0)
                    {
                        checkmate = true;
                        Console.WriteLine("Bitte keine negativen Werte eingeben");
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
                Console.WriteLine("Bitte geben Sie Länge c ein.");
                String eingabe_c = Console.ReadLine();
                try
                {
                    c = Convert.ToDouble(eingabe_c);
                    checkmate = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");

                }

            }
            while (checkmate);
            return c;

        }
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


        static void Ausgabe_Flaeche(double a, double b)
        {
            Console.WriteLine("Die Fläche beträgt: ");
            Console.WriteLine(Flaeche_berechnen(a, b));
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
            Console.WriteLine("Iy = " + Flaechentraegheitsmoment_Rechteck_Iy_berechnen(a, b));
            Console.WriteLine("Iz = " + Flaechentraegheitsmoment_Rechteck_Iz_berechnen(a, b));
            Console.WriteLine("Iyz = 0");
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

            static void Flaeche_Ausgabe(double a, double b)
            {
                Console.WriteLine("Die Fläche beträgt: ");
                Console.WriteLine(Flaeche_berechnen(a, b));
            }
            static void Schwerpunkt_Ausgabe(double a, double b)
            {
                Console.WriteLine("Der Schwerpunkt liegt bei:");
                Console.WriteLine("x = " + Schwerpunkt_x_Rechteck_berechnen(a));
                Console.WriteLine("y = " + Schwerpunkt_y_Rechteck_berechnen(b));
            }

           
            
            static void Volume_Ausgabe(double a, double b, double c)
            {
                Console.WriteLine("Volume ist:" + Volume_berechnen(a, b, c));
                
            }
        }
    }
