using System;
using PhoneNumberAssignmentLetterCombination;

namespace PhoneNumberAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter numbers:");
                var str = Console.ReadLine();

                        var res = LetterCombination.GetLetterCombinations(str);

                        foreach (var item in res)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine("\n");

            }
        }
    }
}
