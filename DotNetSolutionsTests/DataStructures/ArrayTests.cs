using Xunit;

namespace DotNetSolutionsTests.DataStructures
{
    public class ArrayTests
    {
        [Fact]
        public void ContainsDuplicateTest()
        {
            var testCase = new
            {
                Nums = new int[] { 1, 2, 3, 1 },
                Result = true
            };

            var result = DotNetSolutions.DataStructures.ArrayProblems.ContainsDuplicate(testCase.Nums);

            Assert.Equal(testCase.Result, result);
        }

        [Fact]
        public void MaxSubArrayTest()
        {
            var testCase = new
            {
                //Nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
                //Result = 6
                Nums = new int[] { -2, -1, -3, -4, -1 },
                Result = -1
            };

            var result = DotNetSolutions.DataStructures.ArrayProblems.MaxSubArray(testCase.Nums);

            Assert.Equal(testCase.Result, result);
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 })]
        [InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblems.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1, 2, 6, 7, 8, 0, 0 }, 5, new int[] { 2, 3 }, 2, new int[] { 1, 2, 2, 3, 6, 7, 8 })]
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void MergeSortedArrayTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            DotNetSolutions.DataStructures.ArrayProblems.MergeSortedArray(nums1, m, nums2, n);
            Assert.Equal(expected, nums1);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        public void IntersectTest(int[] nums1, int[] nums2, int[] output)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblems.Intersect(nums1, nums2);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 4, 6, 7, 8, 9, 1, 2, 6 }, 5)]
        public void MaxProfitTest(int[] prices, int profit)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblems.MaxProfit(prices);
            Assert.Equal(profit, result);
        }

        [Fact]
        public void MatrixReshapeTest1()
        {
            var input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var expectedOutput = new int[][] { new int[] { 1, 2, 3, 4 } };
            var output = DotNetSolutions.DataStructures.ArrayProblems.MatrixReshape(input, 1, 4);
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void MatrixReshapeTest2()
        {
            var input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var expectedOutput = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var output = DotNetSolutions.DataStructures.ArrayProblems.MatrixReshape(input, 2, 4);
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void MatrixReshapeTest3()
        {
            var input = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };
            var expectedOutput = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
            var output = DotNetSolutions.DataStructures.ArrayProblems.MatrixReshape(input, 2, 3);
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void PascalsTriangleGenerateTest1()
        {
            var numRows = 5;
            var expectedOutput = new int[][] { 
                new int[] { 1 }, 
                new int[] { 1,1 },
                new int[] { 1,2,1 },
                new int[] { 1,3,3,1 },
                new int[] { 1,4,6,4,1 }
            };

            var output = DotNetSolutions.DataStructures.ArrayProblems.PascalsTriangleGenerate(numRows);
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void PascalsTriangleGenerateTest2()
        {
            var numRows = 1;
            var expectedOutput = new int[][] {
                new int[] { 1 }
            };

            var output = DotNetSolutions.DataStructures.ArrayProblems.PascalsTriangleGenerate(numRows);
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void IsValidSudokuTest1()
        {
            var input = new char[][] {
                new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            var expectedResult = true;

            var result = DotNetSolutions.DataStructures.ArrayProblems.IsValidSudoku(input);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IsValidSudokuTest2()
        {
            var input = new char[][] {
                new char[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            var expectedResult = false;

            var result = DotNetSolutions.DataStructures.ArrayProblems.IsValidSudoku(input);
            Assert.Equal(expectedResult, result);
        }
    }
}
