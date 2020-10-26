using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3_AlunosNotas
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3, NFinal;

        public double lerNota()
        {
            return double.Parse(Console.ReadLine());
        }

        public string lerNome()
        {
            return Console.ReadLine();
        }

        public void calcNota()
        {
            NFinal = N1 + N2 + N3;
        }

        public void finalStep()
        {
            calcNota();
            Console.WriteLine("NOTA FINAL = " + NFinal.ToString("F2"));
            if (NFinal < 60)
            {
                Console.WriteLine("REPROVADO");
                Console.Write("FALTARAM " + (60 - NFinal).ToString("F2") + " PONTOS");
            }
            else
            {
                Console.Write("APROVADO");
            }
        }
    }
}
