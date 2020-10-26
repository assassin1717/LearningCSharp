using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Medidas do triangulo x:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Medidas do triangulo y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Area de x iugal a: "+ areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y iugal a: " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX>areaY)
            {
                Console.WriteLine("Maior area é do triangulo x");
            }
            else 
            {
                Console.WriteLine("Maior area é do triangulo y");
            }
        }
    }
}
