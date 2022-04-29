using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLesson_3
{
    public class Generic_Collections
    {

        public void Stack() 
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("1st Added Item");
            myStack.Push("2");
            myStack.Push("3");
            myStack.Push("Last Added Item");
            foreach (var item in myStack)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("|The number of elements in this stack is " + myStack.Count());
            Console.WriteLine("The stack is containing 3 =" + myStack.Contains("3"));
            Console.WriteLine("The peek of the stack is:  " + myStack.Peek());
            myStack.Pop();
            Console.WriteLine("The peek of the stack is:  " + myStack.Pop());
            Console.WriteLine("The stack is containing 3 =" + myStack.Contains("3"));
            Console.WriteLine("The peek of the stack is:  " + myStack.Peek());
            Console.WriteLine("|The number of elements in this stack is " + myStack.Count());
            foreach (var item in myStack)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("The stack is containing 3 =" + myStack.Contains("3"));
            myStack.Clear();
            Console.WriteLine("Stack Cleared");
            foreach (var item in myStack)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine("The stack is containing 3 =" + myStack.Contains("3"));
        }
        
    }
}
