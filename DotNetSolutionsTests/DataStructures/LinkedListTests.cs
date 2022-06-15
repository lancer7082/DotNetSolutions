using DotNetSolutions.DataStructures;
using System;
using System.Collections.Generic;
using Xunit;

namespace DotNetSolutionsTests.DataStructures
{
    public class LinkedListTests
    {
        [Fact]
        public void HasCycleTest1()
        {
            var n0 = new ListNode(3);
            var n1 = new ListNode(2);
            var n2 = new ListNode(0);
            var n3 = new ListNode(-4);
            n0.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n1;

            var result = LinkedListProblems.HasCycle(n0);
            
            Assert.True(result);
        }

        [Fact]
        public void HasCycleTest2()
        {
            var n0 = new ListNode(1);
            var n1 = new ListNode(2);
            n0.next = n1;
            n1.next = n0;

            var result = LinkedListProblems.HasCycle(n0);

            Assert.True(result);
        }

        [Fact]
        public void HasCycleTest3()
        {
            var n0 = new ListNode(1);

            var result = LinkedListProblems.HasCycle(n0);

            Assert.False(result);
        }

        [Fact]
        public void MergeTwoListsTest1()
        {
            // list1
            var n8 = new ListNode(8);
            var n7 = new ListNode(7, n8);
            var n3 = new ListNode(3, n7);
            var n2 = new ListNode(2, n3);
            var n1 = new ListNode(1, n2);

            // list1
            var n10 = new ListNode(10);
            var n9 = new ListNode(9, n10);
            var n6 = new ListNode(6, n9);
            var n5 = new ListNode(5, n6);
            var n4 = new ListNode(4, n5);

            var result = LinkedListProblems.MergeTwoLists(n1, n4);

            Assert.NotNull(result);

            var expected = "1,2,3,4,5,6,7,8,9,10";

            var actual = "";
            while (result != null)
            {
                actual += result.val.ToString();
                if (result.next != null)
                {
                    actual += ",";
                }
                result = result.next;
            }

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MergeTwoListsTest2()
        {
            // list1
            var n1_4 = new ListNode(4);
            var n1_2 = new ListNode(2, n1_4);
            var n1_1 = new ListNode(1, n1_2);

            // list1
            var n2_4 = new ListNode(4);
            var n2_3 = new ListNode(3, n2_4);
            var n2_1 = new ListNode(1, n2_3);

            var result = LinkedListProblems.MergeTwoLists(n1_1, n2_1);

            Assert.NotNull(result);

            var expected = "1,1,2,3,4";

            var actual = "";
            while (result != null)
            {
                actual += result.val.ToString();
                if (result.next != null)
                {
                    actual += ",";
                }
                result = result.next;
            }

            Assert.Equal(expected, actual);
        }
    
        [Theory]
        [InlineData(new int[] { 1, 2, 6, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 7,7,7,7 }, 7, new int[] {})]
        [InlineData(new int[] {}, 1, new int[] { })]
        [InlineData(new int[] { 1, 2, 2, 1}, 2, new int[] { 1, 1 })]
        public void RemoveElementsTest(int[] input, int val, int[] expectedOutput)
        {
            ListNode? head = null;
            if (input.Length > 0)
            {
                head = new ListNode(input);
            }

            //if (head == null)
            //{
            //    throw new ArgumentNullException(nameof(head));
            //}

            var result = LinkedListProblems.RemoveElements(head, val);

            int[] resultArray;
            if (result != null) resultArray = result.ToArray();
            else resultArray = new int[] { };

            Assert.Equal(expectedOutput, resultArray);
        }
    }
}
