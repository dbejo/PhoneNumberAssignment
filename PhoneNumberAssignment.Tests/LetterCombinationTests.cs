using System.Collections.Generic;
using PhoneNumberAssignmentLetterCombination;
using Xunit;

namespace PhoneNumberAssignment.Tests
{
    public class LetterCombinationTests
    {
        [Fact]
        public void GetLetterCombinations_EmptyString()
        {
            var str = string.Empty;

            var result = LetterCombination.GetLetterCombinations(str);

            Assert.Empty(result);
        }
        [Fact]
        public void GetLetterCombinations_SingleCombinationString()
        {
            var str = "2";

            var expected = new List<string> { "a", "b", "c" };

            var result = LetterCombination.GetLetterCombinations(str);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void GetLetterCombinations_DoubleCombinationString()
        {
            var str = "23";

            var expected = new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            var result = LetterCombination.GetLetterCombinations(str);

            Assert.Equal(result, expected);
        }
    }
}
