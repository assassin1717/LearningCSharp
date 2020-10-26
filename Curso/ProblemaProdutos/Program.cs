using System;


namespace ProblemaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x;
            x = new Produto();
            int a;

            Console.WriteLine("Dados do Produto:");
            x.Nome = Console.ReadLine();
            x.Preco = double.Parse(Console.ReadLine());
            x.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + x);

            Console.WriteLine("Numero de produtos adicionados aos stoke:");
            a= int.Parse(Console.ReadLine());
            x.AdicionarProdutos(a);

            Console.WriteLine("Dados atualizados: " + x);

            Console.WriteLine("Numero de produtos removidos stoke:");
            a = int.Parse(Console.ReadLine());
            x.RemoverProdutos(a);

            Console.WriteLine("Dados actualizados: " + x);

        }
    }
}
