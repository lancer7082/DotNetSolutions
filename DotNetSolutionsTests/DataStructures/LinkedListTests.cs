using DotNetSolutions.DataStructures;
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
    }
}
