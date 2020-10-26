using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    class Banco
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Dinheiro { get; private set; }

        public Banco(string nome, int numConta)
        {
            Nome = nome;
            NumConta = numConta;
        }

        public Banco(string nome, int numConta, double dinheiro) : this(nome, numConta)
        {
            Deposito(dinheiro);
        }

        public void Deposito(double dinheiro)
        {
            Dinheiro += dinheiro;
        }
        public void Levantamento(double dinheiro)
        {
            Dinheiro -= (dinheiro + 5);
        }
        public override string ToString()
        {
            return "Conta "
            + NumConta.ToString()
            + ", Titular "
            + Nome
            + ", Saldo: $ "
            + Dinheiro.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
