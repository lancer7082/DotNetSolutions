using Xunit;

namespace DotNetSolutionsTests.Algorythms
{
    public class ArrayTests
    {
        [Fact]
        public void TestContainsDuplicate()
        {
            var testCase = new
            {
                Nums = new int[] { 1, 2, 3, 1 },
                Result = true
            };

            var result = DotNetSolutions.DataStructures.ArrayProblem.ContainsDuplicate(testCase.Nums);

            Assert.Equal(testCase.Result, result);
        }

        [Fact]
        public void TestMaxSubArray()
        {
            var testCase = new
            {
                //Nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },
                //Result = 6
                Nums = new int[] { -2, -1, -3, -4, -1 },
                Result = -1
            };

            var result = DotNetSolutions.DataStructures.ArrayProblem.MaxSubArray(testCase.Nums);

            Assert.Equal(testCase.Result, result);
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 })]
        [InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblem.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1, 2, 6, 7, 8, 0, 0 }, 5, new int[] { 2, 3 }, 2, new int[] { 1, 2, 2, 3, 6, 7, 8 })]
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void MergeSortedArrayTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            DotNetSolutions.DataStructures.ArrayProblem.MergeSortedArray(nums1, m, nums2, n);
            Assert.Equal(expected, nums1);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        public void IntersectTest(int[] nums1, int[] nums2, int[] output)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblem.Intersect(nums1, nums2);
            Assert.Equal(output, result);
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 4, 6, 7, 8, 9, 1, 2, 6}, 5)]
        public void MaxProfitTest(int[] prices, int profit)
        {
            var result = DotNetSolutions.DataStructures.ArrayProblem.MaxProfit(prices);
            Assert.Equal(profit, result);
        }
    }
}
