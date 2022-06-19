namespace DotNetSolutions.DataStructures
{
    public static class StackQueueProblems
    {
        /// <summary>
        /// 20. Valid Parentheses
        /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
        /// determine if the input string is valid.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValidParentheses(string s)
        {
            string openParentheses = "({[";
            string closeParentheses = ")}]";
            var stack = new Stack<char>();
            foreach(var c in s)
            {
                if (openParentheses.Contains(c))
                {
                    stack.Push(c);
                }
                else if (closeParentheses.Contains(c))
                {
                    if (stack.Count == 0)
                        return false;

                    var c1 = stack.Pop();
                    if ((c == ')' && c1 != '(')
                        || (c == '}' && c1 != '{')
                        || (c == ']' && c1 != '['))
                    {
                        return false;   
                    }
                }
            }

            if (stack.Count > 0)
                return false;

            return true;
        }
    }
}
