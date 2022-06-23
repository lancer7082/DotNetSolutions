using DotNetSolutions.DataStructures;
using System.Collections.Generic;
using Xunit;

namespace DotNetSolutionsTests.DataStructures
{
    public class TreeTests
    {
        [Fact]
        public void InorderTraversalTest1()
        {
            var n3 = new TreeNode(3);
            var n2 = new TreeNode(2, n3);
            var n1 = new TreeNode(1, right: n2);

            var expectedResult = new List<int> { 1, 3, 2};

            var result = TreeProblems.InorderTraversal(n1);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PreorderTraversalTest1()
        {
            var n3 = new TreeNode(3);
            var n2 = new TreeNode(2, n3);
            var n1 = new TreeNode(1, right: n2);

            var expectedResult = new List<int> { 1, 2, 3 };

            var result = TreeProblems.PreorderTraversal(n1);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void PostorderTraversalTest1()
        {
            var n3 = new TreeNode(3);
            var n2 = new TreeNode(2, n3);
            var n1 = new TreeNode(1, right: n2);

            var expectedResult = new List<int> { 3, 2, 1 };

            var result = TreeProblems.PostorderTraversal(n1);

            Assert.Equal(expectedResult, result);
        }
    }
}
