using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLesson_3
{
    public class Generic_Collections
    {

        public Stack<int> AddElementsStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
                   

            foreach(var item in stack)
            {
                Console.Write(item+",");
            }
            return stack;
        }

    }
}
