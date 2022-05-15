using System.Collections.Generic;
using System.Linq;
using Xunit;
namespace DotNetSolutionsTests.Algorythms
{
    public class TwoPointersTests
    {
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
            DotNetSolutions.Algorythms.TwoPointersProblems.ReverseString(input);

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
            var result = DotNetSolutions.Algorythms.TwoPointersProblems.ReverseWords(testCase.Input);

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