using System;
using System.Collections.Generic;
using System.Threading;

namespace EXEREuromilhoesBot
{
    public class Element
    {
        private Random _random = new Random();
        private List<int> _numbers = new List<int>();
        private List<int> _stars = new List<int>();
        public Boolean IsYes { get; private set; }

        public Element(char letter)
        {
            Thread.Sleep(25);
            IsYes = (letter == 'S' || letter == 's') ? true : false;
            GenNumbers();
            GenStars();
            _numbers.Sort();
            _stars.Sort();
        }

        public List<int> GetNumbers() {
            return _numbers;
        }

        public List<int> GetStars()
        {
            return _stars;
        }

        private int GenerateNumber()
        {
            return _random.Next(1, 50);
        }

        private int GenerateStar()
        {
            return _random.Next(1, 12);
        }

        private void GenNumbers()
        {
            for (int x = 0; x < 5; x++)
            {
                if (IsYes.Equals(true))
                {
                    _numbers.Add(VerifyExists(_random.Next(1, 50), _numbers, true));
                }
                else
                {
                    Console.WriteLine("Insira o " + (x + 1) + "º numero: ");
                    int number = int.Parse(Console.ReadLine());
                    while (number<1 || number>50)
                    {
                        Console.WriteLine("O numero tem de ser maior que 0 e menor ou igual a 50!");
                        number = int.Parse(Console.ReadLine());
                    }
                    _numbers.Add(number);
                }
            }
        }

        private void GenStars()
        {
            for (int x = 0; x < 2; x++)
            {
                if (IsYes.Equals(true))
                {
                    _stars.Add(VerifyExists(_random.Next(1, 12), _stars, false));
                }
                else
                {
                    Console.WriteLine("Insira o " + (x + 1) + "ª estrela: ");
                    int star = int.Parse(Console.ReadLine());
                    while (star < 1 || star > 12)
                    {
                        Console.WriteLine("A estrela tem de ser maior que 0 e menor ou igual a 12!");
                        star = int.Parse(Console.ReadLine());
                    }
                    _stars.Add(star);
                }
            }
        }

        private int VerifyExists(int number, List<int> list, Boolean isNumber)
        {
            int randomNumber = number;
            Boolean exists = list.Contains(randomNumber);
            while (exists.Equals(true))
            {
                randomNumber = isNumber.Equals(true) ? GenerateNumber() : GenerateStar();
                exists = list.Contains(randomNumber);
            }
            return randomNumber;
        }

        public void ShowNumbers()
        {
            Console.WriteLine("Numeros: " +
                _numbers[0] +
                ", " + _numbers[1] +
                ", " + _numbers[2] +
                ", " + _numbers[3] +
                ", " + _numbers[4]);
            Console.WriteLine("Estrelas: " +
                _stars[0] +
                ", " + _stars[1]);
        }
    }
}
