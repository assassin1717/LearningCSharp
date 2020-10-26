using System;

namespace EXERCICIOFib
{
    class Program
    {
        static void Main(string[] args)
        {
            fib t = new fib();
            Console.WriteLine("Insira um numero: ");
            int num=int.Parse(Console.ReadLine());

            Console.WriteLine(t.Fibona(num));
        }
    }
}
