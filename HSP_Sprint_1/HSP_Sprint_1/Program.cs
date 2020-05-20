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
            bool checkrestart = false;

            Console.WriteLine("Der Rechteckcalculator");
            Console.WriteLine();

            do
            {

                a = Eingabe_a();                                //Länge a   
                b = Eingabe_b();                                //Länge b
                Flaeche_Ausgabe(a, b);
                Schwerpunkt_Ausgabe(a, b);
                Flaechentraegheitsmoment_Ausgabe(a, b);
                Console.WriteLine("Möchten Sie eine weitere Rechnung durchführen? y/n");
                checkrestart = (Console.ReadKey().KeyChar == 'y');
                Console.WriteLine();
                Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
                Console.WriteLine();
            } while (checkrestart);
            Console.WriteLine("Das Programm wird beendet.");
            Console.ReadKey();
        }

                try
                {


                    // Anweisungen mit Variablen
                    Console.Write("Enter the rectangle's height:");
                    double height = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the rectangle's width:");
                    double width = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the rectangle's length:");
                    double length = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the rectangle's density:");
                    double density = Convert.ToDouble(Console.ReadLine());


                    // Calculations



                    double Volume = (height * width * length);

                    double Area = (width * height);

                    double Mass = (density * Volume);

                    double IXX = ((height * width * width * width) / 12);

                    double IYY = ((height * height * height * width) / 12);


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
                    checkmate = false;
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
                    checkmate = false;

                    Console.WriteLine("Perimeter of rectangle = {0}", Perimeter);
                    Console.WriteLine("Area of rectangle = {0}", Area);
                    Console.WriteLine("Volume of rectangle ={0}", Volume);
                    Console.WriteLine("Mass of rectangle ={0}", Mass);
                    Console.WriteLine("Second Moment of Inertia Ixx ={0}", IXX);
                    Console.WriteLine("Second Moment of Inertia Iyy ={0}", IYY);
                    Console.WriteLine("Moments of resistance Wxx ={0}", WXX);
                    Console.WriteLine("Moments of resistance Wyy ={0}", WYY);
                    Console.ReadKey();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Der eingegebene Wert ist keine Zahl. Bitte geben sie eine Zahl ein.");
                }

            }
            while (checkmate);
            return b;
        }

        static double Flaeche_berechnen(double a, double b)
        {
            double flaeche = a * b;
            return flaeche;
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

        static void Flaechentraegheitsmoment_Ausgabe(double a, double b)
        {
            Console.WriteLine("Das Flächenträgheitsmoment liegt bei:");
            Console.WriteLine("Iy = " + Flaechentraegheitsmoment_Rechteck_Iy_berechnen(a, b));
            Console.WriteLine("Iz = " + Flaechentraegheitsmoment_Rechteck_Iz_berechnen(a, b));
            Console.WriteLine("Iyz = 0");
        }

    }
}
