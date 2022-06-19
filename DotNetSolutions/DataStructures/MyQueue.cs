namespace DotNetSolutions.DataStructures
{
    /// <summary>
    /// 232. Implement Queue using Stacks
    /// Implement a first in first out (FIFO) queue using only two stacks. 
    /// The implemented queue should support all the functions of a normal queue 
    /// (push, peek, pop, and empty).
    /// </summary>
    public class MyQueue
    {
        Stack<int> _stack;
        Stack<int> _buffer;

        public MyQueue()
        {
            _stack = new Stack<int>();
            _buffer = new Stack<int>();
        }

        public void Push(int x)
        {
            while (_stack.Count > 0)
            {
                _buffer.Push(_stack.Pop());
            }
            _stack.Push(x);
            while (_buffer.Count > 0)
            {
                _stack.Push(_buffer.Pop());
            }
        }

        public int Pop()
        {
            return _stack.Pop();
        }

        public int Peek()
        {
            return _stack.Peek();
        }

        public bool Empty()
        {
            return _stack.Count == 0;
        }
    }

    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
