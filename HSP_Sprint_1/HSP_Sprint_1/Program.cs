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
            Console.Write("Enter the rectangle's height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rectangle's width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rectangle's length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the rectangle's Mass:");
            double Mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter of rectangle = {0}", 2 * (width + height));
            Console.WriteLine("Area of rectangle = {0}", width * height);
            Console.WriteLine("Volume of rectangle ={0}", height * width * length);
            double Volume = (height * width * length);
            Console.WriteLine("Density of rectangle ={0}", Mass / Volume);
            Console.WriteLine("Second Moment of Inertia Ix ={0}", (height * width * width * width) / 12);
            Console.WriteLine("Secoond Moment of Inertia Iy ={0}", (height * height * height * width) / 12);
            Console.ReadKey();





        }
    }
}
