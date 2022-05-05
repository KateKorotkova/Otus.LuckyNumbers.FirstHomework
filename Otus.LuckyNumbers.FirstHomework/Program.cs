using System;

namespace Otus.LuckyNumbers.FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            for (var a1 = 0; a1 <= 9; a1++)
            {
                for (var a2 = 0; a2 <= 9; a2++)
                {
                    for (var a3 = 0; a3 <= 9; a3++)
                    {
                        var sumA = a1 + a2 + a3;

                        for (var b1 = 0; b1 <= 9; b1++)
                        {
                            for (var b2 = 0; b2 <= 9; b2++)
                            {
                                var b = sumA - b1 - b2;
                                if (b >= 0 && b <= 9)
                                    counter++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter);

            Console.ReadKey();
        }
    }
}
