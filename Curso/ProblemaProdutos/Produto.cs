using System.Globalization;

namespace ProblemaProdutos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEmStoke()
        {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int a)
        {
            Quant += a;
        }

        public void RemoverProdutos(int a)
        {
            Quant -= a;
        }

        public override string ToString()
        {
            return Nome + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quant + " unidades, Total: $ " + ValorTotalEmStoke().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
