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
                Nums = new int[] { 1, 2, 3, 1},
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
    }
}
