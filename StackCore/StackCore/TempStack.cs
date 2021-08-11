using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCore
{
    public class TempStack
    {
        int capacity;
        int[] stack;
        int position = 0;
        public TempStack(int capacity)
        {
            this.capacity = capacity;
            this.stack = new int[capacity];
        }

        public int Count()
        {
            return position == -1 ? 0 : position;
        }
        public int Push(int val)
        {
            if (position == this.stack.Length)
                return -1;

            position = position == -1 ? 0 : position;
            this.stack[position++] = val;

            return Count();

        }

        public int Pop()
        {
            if (position < 0)
                return -1;

            int val = this.stack[position--];

            return Count();

        }

    }
}
