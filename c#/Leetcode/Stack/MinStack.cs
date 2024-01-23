using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MinStack
    {

        private Stack<int> mainStack;
        private Stack<int> minimumStack;
        public MinStack()
        {
            mainStack = new Stack<int>();
            minimumStack = new Stack<int>();
        }

        public void Push(int val)
        {
            mainStack.Push(val);
           int min = Math.Min(val, minimumStack.Count() != 0 ? minimumStack.Peek():val);
            minimumStack.Push(min);
        }

        public void Pop()
        {
            mainStack.Pop();
            minimumStack.Pop();
        }

        public int Top()
        {         
            return mainStack.Peek();
        }

        public int GetMin()
        {
          return minimumStack.Peek();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
