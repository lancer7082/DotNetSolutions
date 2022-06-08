namespace DotNetSolutions.DataStructures
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public static class LinkedListProblems
    {
        /// <summary>
        /// 141. Linked List Cycle
        /// There is a cycle in a linked list if there is some node in the list 
        /// that can be reached again by continuously following the next pointer. 
        /// Internally, pos is used to denote the index of the node that tail's next pointer 
        /// is connected to. Note that pos is not passed as a parameter.
        /// 
        /// Return true if there is a cycle in the linked list.Otherwise, return false
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            ListNode? node1 = head;
            ListNode? node2 = node1.next;

            while (node1 != null && node2 != null)
            {
                if (node1 == node2)
                    return true;

                node1 = node1.next;
                node2 = node2.next?.next;
            }

            return false;
        }
    }
}
