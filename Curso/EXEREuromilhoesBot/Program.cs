using System;

namespace EXEREuromilhoesBot
{
    class Program
    {
        static void Main()
        {
            int Prize = 0;
            int Total = 0, First = 0, Top = 0, Any = 0;
            char Option='s';

            Element person= new Element('s');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("««««««««««BEM VINDO AO SIMULADOR DE PRÉMIOS DE EUROMILHÕES»»»»»»»»»»");
            Console.ResetColor();

            while (Option!='n' && Option!='N')
            {
                
                Euromilhoes euro = new Euromilhoes();

                Console.WriteLine("Quer ver quantas vezes é necessário jogar para ganhar um prémio do euromilhões?");
                Console.WriteLine("1 - para vencedor; 2 - top 3; 3 - ganhar algum prémio.");
                int Type = int.Parse(Console.ReadLine());

                int Search;
                if (Type == 1)
                {
                    Search = 3;
                }
                else if (Type == 2)
                {
                    Search = 2;
                }
                else
                {
                    Search = 1;
                }

                Console.WriteLine("Quer usar uma autogerada? (s/n)");
                char choice = char.Parse(Console.ReadLine());

                if (choice.Equals('n') || choice.Equals('N'))
                {
                    person = new Element(choice);
                }

                while (Prize < Search)
                {
                    if (choice.Equals('s') || choice.Equals('S'))
                    {
                        person = new Element(choice);
                    }
                                        
                    person.ShowNumbers();

                    var PersonNumbers = person.GetNumbers();
                    var PersonStars = person.GetStars();

                    Element machine = new Element('s');

                    machine.ShowNumbers();

                    var MachineNumbers = machine.GetNumbers();
                    var MachineStars = machine.GetStars();

                    Prize = euro.Prizes(PersonNumbers, MachineNumbers, PersonStars, MachineStars);
                    if (Prize == 3)
                    {
                        First++;
                    }
                    else if (Prize > 1)
                    {
                        Top++;
                    }
                    else if (Prize == 1)
                    {
                        Any++;
                    }
                    Total++;
                }
                Prize = 0;
                Console.WriteLine("Numero total de tentativas: " + Total);
                Console.WriteLine("Probabilidade de ganhar qualquer prémio: " + (Any * 100 / Total) + " %");
                Console.WriteLine("Probabilidade de ganhar um dos 3 primeiros prémios: " + (Top * 100 / Total) + " %");
                Console.WriteLine("Probabilidade de ganhar o prémio principal: " + (First * 100 / Total) + " %");

                Console.WriteLine("Desja jogar mais uma vez? (s/n)");
                Option = char.Parse(Console.ReadLine());
            } 
        }
    }
}
