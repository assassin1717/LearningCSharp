using System;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
