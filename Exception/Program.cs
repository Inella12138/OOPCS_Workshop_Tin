using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PartI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter three sides of a triangle to calculate its perimeter and area.");
                Console.Write("Please enter the length of the first side: ");
                double side1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the length of the second side: ");
                double side2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter the length of the third side: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                Triangle tri = new Triangle(side1, side2, side3);
                Console.WriteLine("The perimeter of the triangle is: {0}.\nThe area of the triangle is: {1}"
                    ,tri.Perimeter(),tri.Area());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, your input is not in the correct format!");
            }
            catch (BadTriangleException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("End of program.");
        }
    }
}
