namespace DotNetSolutions.DataStructures
{
    public static class TreeProblems
    {
        /// <summary>
        /// 94. Binary Tree Inorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();

            void InorderTraversalRecursive(TreeNode? root)
            {
                if (root == null) return;
                InorderTraversalRecursive(root.left);
                list.Add(root.val);
                InorderTraversalRecursive(root.right);
            }

            InorderTraversalRecursive(root);

            return list;
        }

        /// <summary>
        /// 145. Binary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            var list = new List<int>();

            void PostorderTraversalRecursive(TreeNode? root)
            {
                if (root == null) return;
                PostorderTraversalRecursive(root.left);
                PostorderTraversalRecursive(root.right);
                list.Add(root.val);
            }

            PostorderTraversalRecursive(root);

            return list;
        }

        /// <summary>
        /// 144. Binary Tree Preorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();

            void PreorderTraversalRecursive(TreeNode? root)
            {
                if (root == null) return;
                list.Add(root.val);
                PreorderTraversalRecursive(root.left);
                PreorderTraversalRecursive(root.right);
            }

            PreorderTraversalRecursive(root);

            return list;
        }
    }
}
