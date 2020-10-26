using System;
using System.Collections.Generic;

namespace EXEREuromilhoesBot
{
    public class Euromilhoes
    {
        private int CompareLists(List<int> list1, List<int> list2)
        {
            int count = 0;
            for (int x = 0; x < list1.Count; x++)
            {
                if (list1[x].Equals(list2[x]))
                {
                    count++;
                }
            }
            return count;
        }

        public int Prizes(List<int> nums1, List<int> nums2, List<int> stars1, List<int> stars2)
        {
            int Numbers = CompareLists(nums1, nums2);
            int Stars = CompareLists(stars1, stars2);
            int Prize = 0;
            if (Numbers == 5 && Stars == 2)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("Ganhou o 1º prémio!");
                Prize = 3;
            }
            else if (Numbers == 5 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ganhou o 2º prémio!");
                Prize = 2;
            }
            else if (Numbers == 5 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ganhou o 3º prémio!");
                Prize = 2;
            }
            else if (Numbers == 4 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 4º prémio!");
                Prize = 1;
            }
            else if (Numbers == 4 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 5º prémio!");
                Prize = 1;
            }
            else if (Numbers == 3 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 6º prémio!");
                Prize = 1;
            }
            else if (Numbers == 4 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 7º prémio!");
                Prize = 1;
            }
            else if (Numbers == 2 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 8º prémio!");
                Prize = 1;
            }
            else if (Numbers == 3 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 9º prémio!");
                Prize = 1;
            }
            else if (Numbers == 3 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 10º prémio!");
                Prize = 1;
            }
            else if (Numbers == 1 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 11º prémio!");
                Prize = 1;
            }
            else if (Numbers == 2 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 12º prémio!");
                Prize = 1;
            }
            else if (Numbers == 2 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 13º prémio!");
                Prize = 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não ganhou nada, mais sorte para a próxima...");
            }
            Console.ResetColor();
            return Prize;
        }
    }
}
