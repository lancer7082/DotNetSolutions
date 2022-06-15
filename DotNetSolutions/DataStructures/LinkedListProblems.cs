namespace DotNetSolutions.DataStructures
{
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

        /// <summary>
        /// 21. Merge Two Sorted Lists
        /// You are given the heads of two sorted linked lists list1 and list2.
        /// Merge the two lists in a one sorted list.
        /// The list should be made by splicing together the nodes of the first two lists.
        /// Return the head of the merged linked list.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static ListNode? MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }

            ListNode? result, dst, src, tmp;

            if (list1.val <= list2.val)
            {
                dst = list1;
                src = list2;
            }
            else
            {
                dst = list2;
                src = list1;
            }

            result = dst;

            while (dst != null && src != null)
            {

                if (dst.next == null)
                {
                    // Append src to dst
                    dst.next = src;
                    return result;
                }
                else if (dst.next.val > src.val)
                {
                    // Switch to src
                    tmp = dst.next;
                    dst.next = src;
                    dst = src;
                    src = tmp;
                    continue;
                }

                dst = dst.next;
            }

            return result;
        }

        /// <summary>
        /// 203. Remove Linked List Elements
        /// Given the head of a linked list and an integer val, remove all the nodes 
        /// of the linked list that has Node.val == val, and return the new head.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ListNode? RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;                 
            ListNode? prev = null, n = head;
            while (n != null)
            {
                if (n.val == val)
                {
                    // Remove item
                    if (prev == null)
                    {
                        if (n.next == null)
                        {
                            return null;
                        }
                        head = n.next;
                        n = head;
                        continue;
                    }
                    else
                    {
                        if (n.next == null)
                        {
                            prev.next = null;
                            break;
                        }
                        prev.next = n.next;
                        n = n.next;
                        continue;
                    }
                }

                prev = n;
                n = n.next;     
            }

            return head;
        }
    }
}
