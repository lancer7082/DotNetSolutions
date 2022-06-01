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
    }
}
