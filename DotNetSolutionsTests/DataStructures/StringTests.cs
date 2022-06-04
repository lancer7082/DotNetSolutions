using Xunit;

namespace DotNetSolutionsTests.DataStructures
{
    public class StringTests
    {
        [Theory]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        void FirstUniqCharTest(string input, int expectedOutput)
        {
            var result = DotNetSolutions.DataStructures.StringProblems.FirstUniqChar(input);
            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        void CanConstructTest(string ransomNote, string magazine, bool expectedResult)
        {
            var result = DotNetSolutions.DataStructures.StringProblems.CanConstruct(ransomNote, magazine);
            Assert.Equal(expectedResult, result);
        }
    }
}
