namespace DotNetSolutions.DataStructures
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
           this.val = val;
           this.left = left;
           this.right = right;
        }

        /// <summary>
        /// Build tree from list
        /// </summary>
        /// <param name="items"></param>
        public TreeNode(int?[] items)
        {
            if ((items == null) || (items.Length == 0) || !items[0].HasValue)
                throw new ArgumentNullException(nameof(items));

            this.val = items[0].Value;

            void AddChildNodesRecursive(TreeNode root, int index)
            {
                if (index + 2 >= items.Length) return;
                if (items[index + 1].HasValue)
                {
                    root.left = new TreeNode(items[index + 1].Value);
                    AddChildNodesRecursive(root.left, index + 3);
                }
                if (items[index + 2].HasValue)
                {
                    root.right = new TreeNode(items[index + 2].Value);
                    AddChildNodesRecursive(root.right, index + 5);
                }
            }

            AddChildNodesRecursive(this, 0);
        }

        public int?[] ToArray()
        {
            var root = this;
            var list = new List<int?>();

            void PreorderTraversalRecursive(TreeNode? root)
            {
                if (root == null)
                {
                    list.Add(null);
                    return;
                }
                list.Add(root.val);
                PreorderTraversalRecursive(root.left);
                PreorderTraversalRecursive(root.right);
            }
            if (root != null)
            {
                PreorderTraversalRecursive(root);
            }

            return list.ToArray();
        }
    }
}
