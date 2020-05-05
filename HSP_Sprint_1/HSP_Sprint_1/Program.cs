using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSP_Sprint_1
{
    class Program
    {
        static void Main(string[] args)
        {



           

            
            
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

                    double WXX = ((width * height * height) / 6);

                    double WYY = ((height * width * width) / 6);

                    double Perimeter = (2 * (width + height));

                    // Ausgaben

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

                catch (Exception e)
                {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error neustart erforderlich");
                Console.ReadKey();

                
                

                }
            
            






            
           




        }
    }
}
