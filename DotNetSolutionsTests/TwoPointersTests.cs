using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DotNetSolutionsTests {

    public class TwoPointersTests
    {
        [Fact]
        public void TwoSum2Test()
        {
            var testCase = new {
                Nums = new int[] { 2, 7, 11, 15 },
                Target = 9,
                Result = new int[] { 1, 2 }
            };
            //{2,3,4};
            //{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,1,1};
            //{-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1, 1, 1};           
            var result = DotNetSolutions.TwoPointers.TwoSum(testCase.Nums, testCase.Target);
            Assert.Empty(result.ToList().Except(testCase.Result.ToList()));
            //Console.WriteLine($"result = {string.Join(',', result.ToList())}");
        }

        [Fact]
        public void ReverseStringTest()
        {
            var testCase = new
            {
                //Input = new char[] { 'h', 'e', 'l', 'l', 'o' },
                //Output = new char[] { 'o', 'l', 'l', 'e', 'h' }
                Input = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' },
                Output = new char[] { 'h', 'a', 'n', 'n', 'a', 'H' }
            };
            var input = testCase.Input;
            DotNetSolutions.TwoPointers.ReverseString(input);

            Assert.Equal(input, testCase.Output);
            //Assert.Empty(input.ToList().Except(testCase.Output.ToList()));
        }

        [Fact]
        public void ReverseWordsTest()
        {
            var testCase = new
            {
                //Input = "Let's take LeetCode contest",
                //Output = "s'teL ekat edoCteeL tsetnoc"
                Input = "God Ding",
                Output = "doG gniD"
            };
            var result = DotNetSolutions.TwoPointers.ReverseWords(testCase.Input);

            Assert.Equal(result, testCase.Output);
        }

            //public void TestSquaresOfSortedArray()
            //{
            //    var nums = new int[] 
            //    //{-4,-1,0,3,10};
            //    //{-7,-3,2,3,11};
            //    {-2, -1};
            //    var p = new SquaresOfSortedArrayProblem();
            //    var result = p.SortedSquares(nums);
            //    Console.WriteLine($"result = {string.Join(',', result.ToList())}");
            //}

            //public void TestRotateArray()
            //{
            //    var nums = new int[] 
            //    //{1,2,3,4,5,6,7};
            //    //{-1,-100,3,99};
            //    {1, 2};
            //    var p = new RotateArrayProblem();
            //    p.Rotate(nums, 3);
            //    //Console.WriteLine($"result = {string.Join(',', result.ToList())}");
            //}

            //public void TestMoveZeroes()
            //{
            //    var nums = new int[] 
            //    //{0,1,0,3,12};
            //    //{-1,-100,3,99};
            //    {0, 2};
            //    MoveZeroesProblem.MoveZeroes(nums);
            //    Console.WriteLine($"nums = {string.Join(',', nums.ToList())}");
            //}

        }
}