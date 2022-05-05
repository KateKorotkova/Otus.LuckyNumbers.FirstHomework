using System;
using System.Linq;

namespace Otus
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 5; i++)
            {
                var luckyNumbers = GetLuckyNumbers(i);

                Console.WriteLine($"Lucky numbers for {i}: {luckyNumbers}");
            }

            Console.ReadKey();
        }

        private static int GetLuckyNumbers(int n)
        {
            var maxNumber = Math.Pow(10, n);

            var counter = 0;
            for (var i = 0; i < maxNumber; i++)
            {
                for (var j = 0; j < maxNumber; j++)
                {
                    var sumA = Sum(i);
                    var sumB = Sum(j);

                    if (sumA == sumB)
                        counter++;
                }
            }

            return counter;
        }

        private static int Sum(int number)
        {
            return number.ToString().Sum(x => x - '0');
        }
    }
}