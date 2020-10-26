using System;

namespace Exercicio3_AlunosNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;
            a = new Aluno();
            Console.Write("Nome do Aluno: ");
            a.Nome = a.lerNome();
            Console.WriteLine("Notas do Aluno: ");
            a.N1 = a.lerNota();
            a.N2 = a.lerNota();
            a.N3 = a.lerNota();
            a.finalStep();
        }
    }
}
