using System;
using System.Globalization;

namespace Exercicio1_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            a.nome = Console.ReadLine();
            a.idade = int.Parse(Console.ReadLine());
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            b.nome = Console.ReadLine();
            b.idade = int.Parse(Console.ReadLine());
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            maisVelho(a,b);
        }

        private static void maisVelho(Pessoa a, Pessoa b)
        {
            if (a.idade>b.idade)
            {
                Console.WriteLine("Pessoa mais velha: "+a.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: "+b.nome);
            }
            double media = (a.salario + b.salario) / 2;
            Console.WriteLine("O salário medio é: "+media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
