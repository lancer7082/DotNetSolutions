using DotNetSolutions.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotNetSolutionsTests.DataStructures
{
    public class StackQueueTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("}{", false)]
        void ValidParenthesesTest(string s, bool expectedResult)
        {
            bool result = StackQueueProblems.IsValidParentheses(s);

            Assert.Equal(expectedResult, result);
        }
    }
}
