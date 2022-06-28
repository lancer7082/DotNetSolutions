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

        [Fact]
        public void LevelOrderTraversalTest1()
        {
            var n15 = new TreeNode(15);
            var n7 = new TreeNode(7);
            var n20 = new TreeNode(20, n15, n7);
            var n9 = new TreeNode(9);
            var n3 = new TreeNode(3, n9, n20);

            var expectedResult = new List<IList<int>> { 
                new List<int> { 3 },
                new List<int> { 9, 20 },
                new List<int> { 15, 7 }
            };

            var result = TreeProblems.LevelOrderTraversal(n3);

            Assert.NotNull(result);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void LevelOrderTraversalTest2()
        {
            var n4 = new TreeNode(4);
            var n5 = new TreeNode(5);
            var n2 = new TreeNode(2, n4, null);
            var n3 = new TreeNode(3, null, n5);
            var n1 = new TreeNode(1, n2, n3);

            var expectedResult = new List<IList<int>> {
                new List<int> { 1 },
                new List<int> { 2, 3 },
                new List<int> { 4, 5 },
            };

            var result = TreeProblems.LevelOrderTraversal(n1);

            Assert.NotNull(result);
            Assert.Equal(expectedResult, result);
        }
    }
}
