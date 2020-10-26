using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Insira o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cir = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: "+cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor do PI: "+ Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
