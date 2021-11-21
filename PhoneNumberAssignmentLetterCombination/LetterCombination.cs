using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumberAssignmentLetterCombination
{
    public class LetterCombination
    {
        public static IList<string> GetLetterCombinations(string str)
        {
            IList<string> res = new List<string>();
            if (string.IsNullOrEmpty(str))
            {
                return res;
            }
            Dictionary<Char, char[]> lettersMap = new Dictionary<Char, char[]>
            {
                { '2', new[] { 'a', 'b', 'c' } },
                { '3', new[] { 'd', 'e', 'f' } },
                { '4', new[] { 'g', 'h', 'i' } },
                { '5', new[] { 'j', 'k', 'l' } },
                { '6', new[] { 'm', 'n', 'o' } },
                { '7', new[] { 'p', 'q', 'r', 's' } },
                { '8', new[] { 't', 'u', 'v' } },
                { '9', new[] { 'w', 'x', 'y', 'z' } }
            };

            res.Add("");
            try
            {

                foreach (char d in str)
                {
                    IList<string> next = new List<string>();
                    var letterList = lettersMap.Where(x => x.Key == d).FirstOrDefault().Value;
                    foreach (string s in res)
                    {
                        foreach (char letter in letterList)
                        {
                            next.Add(s + letter);
                        }
                    }
                    res = next;
                }
            } catch
            {
                Console.WriteLine("Please enter numbers between 2-9.");
            }

            return res;

        }
    }
}
