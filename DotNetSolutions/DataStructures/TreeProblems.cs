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

        /// <summary>
        /// 102. Binary Tree Level Order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null) return result;

            void LevelOrderTraversalRecursive(TreeNode? root, int level)
            {
                if (root == null) return;
                if (result.Count < level + 1) result.Add(new List<int>());
                result[level].Add(root.val);
                if (root.left != null || root.right != null)
                {
                    LevelOrderTraversalRecursive(root.left, level + 1);
                    LevelOrderTraversalRecursive(root.right, level + 1);
                }
            }

            LevelOrderTraversalRecursive(root, 0);

            return result;
        }
    }
}
