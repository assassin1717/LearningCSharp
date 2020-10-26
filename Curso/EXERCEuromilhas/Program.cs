using System;

namespace EXERCEuromilhas
{
    class Program
    {
        static void Main()
        {
            Euromilhoes euro = new Euromilhoes();
            Element person;
            char choice = 's';
            
            while (choice != 'n' && choice != 'N')
            {
                Console.WriteLine("Bem vindo a Santa Casa, deseja fazer o Euromilhoes? (s/n)");
                choice = char.Parse(Console.ReadLine());
                if (choice == 's' || choice == 'S')
                {
                    Console.WriteLine("Deseja uma chave autogerada? (s/n)");
                    choice = char.Parse(Console.ReadLine());

                    person = new Element(choice);

                    person.ShowNumbers();

                    var PersonNumbers = person.GetNumbers();
                    var PersonStars = person.GetStars();

                    Element machine = new Element('s');

                    machine.ShowNumbers();

                    var MachineNumbers = machine.GetNumbers();
                    var MachineStars = machine.GetStars();

                    euro.Prizes(PersonNumbers, MachineNumbers, PersonStars, MachineStars);
                }

                Console.WriteLine("Deseja continuar a jogar? (s/n)");
                choice = char.Parse(Console.ReadLine());
                if (choice !='n' && choice!='N')
                {
                    Console.Clear();
                }
            }
        }
    }
}
