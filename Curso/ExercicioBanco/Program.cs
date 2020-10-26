using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b;
            double dinheiro;

            Console.WriteLine("Insira o numero da conta: ");
            int numConta=int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o nome do titular: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Havera deposito inicial (s/n)?");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                Console.WriteLine("Insira o deposito inicial: ");
                dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = new Banco(nome, numConta, dinheiro);
            }
            else
            {
                b = new Banco(nome, numConta);
            }
            

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(b);

            Console.WriteLine("Insira o valor do deposito: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(dinheiro);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);

            Console.WriteLine("Insira o valor do levantamento: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Levantamento(dinheiro);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);
        }
    }
}
