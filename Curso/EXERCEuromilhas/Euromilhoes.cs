using System;
using System.Collections.Generic;

namespace EXERCEuromilhas
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

        public void Prizes(List<int> nums1, List<int> nums2, List<int> stars1, List<int> stars2)
        {
            int Numbers = CompareLists(nums1, nums2);
            int Stars = CompareLists(stars1, stars2);
            if (Numbers == 5 && Stars == 2)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("Ganhou o 1º prémio!");
            }
            else if (Numbers == 5 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ganhou o 2º prémio!");
            }
            else if (Numbers == 5 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ganhou o 3º prémio!");
            }
            else if (Numbers == 4 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 4º prémio!");
            }
            else if (Numbers == 4 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 5º prémio!");
            }
            else if (Numbers == 3 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 6º prémio!");
            }
            else if (Numbers == 4 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 7º prémio!");
            }
            else if (Numbers == 2 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 8º prémio!");
            }
            else if (Numbers == 3 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 9º prémio!");
            }
            else if (Numbers == 3 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 10º prémio!");
            }
            else if (Numbers == 1 && Stars == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 11º prémio!");
            }
            else if (Numbers == 2 && Stars == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 12º prémio!");
            }
            else if (Numbers == 2 && Stars == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ganhou o 13º prémio!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não ganhou nada, mais sorte para a próxima...");
            }
            Console.ResetColor();
        }
    }
}
