namespace DotNetSolutions.DataStructures
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int[] items)
        {
            if ((items == null) || (items.Length == 0))
                throw new ArgumentException(nameof(items));

            ListNode? n, prev = null;

            val = items[0];
            prev = this;

            for (var i = 1; i < items.Length; i++)
            {
                n = new ListNode(items[i]);
                prev.next = n;
                prev = n;
            }
        }

        public int[] ToArray()
        {
            var head = this;
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            return list.ToArray();
        }
    }
}
