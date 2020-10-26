
using System;
using System.Dynamic;
using System.Globalization;

namespace MembrosEstaticosEX
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual e a cotacao do euro?");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Quantos dolares quer comprar??");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em euros: "+ConversorDeMoeda.CalcularValor(cota, dolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
