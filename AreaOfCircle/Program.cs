using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {

             double radius, area;
             Console.WriteLine("What is the radius of the circle?");
             radius = Convert.ToDouble(Console.ReadLine());

             area = Math.PI * radius *radius;

             Console.WriteLine("Area of the Circle with radius {0} is {1}",radius,area);

             Console.WriteLine("Press any Key to continue...");
             Console.ReadLine();
        }
    }
}
