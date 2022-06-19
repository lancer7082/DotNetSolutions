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

        [Fact]
        void MyQueueTest1()
        {
            var q = new MyQueue();
            q.Push(1);
            q.Push(2);
            Assert.Equal(1, q.Peek());
            Assert.Equal(1, q.Pop());
            Assert.Equal(2, q.Peek());
            Assert.False(q.Empty());
        }
    }
}
