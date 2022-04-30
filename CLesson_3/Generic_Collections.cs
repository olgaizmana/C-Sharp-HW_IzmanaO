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
        public void Queue()
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            foreach (var i in myQueue)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("|The number of elements in this queue is " + myQueue.Count());
            Console.WriteLine("|The average of elements in this queue is " + myQueue.Average());
            Console.WriteLine("myQueue contains value 1 - " + myQueue.Contains(1));
            myQueue.Dequeue();
            Console.WriteLine("myQueue contains value 1 - " + myQueue.Contains(1));
            Console.WriteLine("The peek of the queue is:  " + myQueue.Peek());
            myQueue.Enqueue(0);
            Console.WriteLine("|The last element of myQueue is:  " + myQueue.ElementAtOrDefault(myQueue.Count));
            Console.WriteLine("The peek of the queue is:  " + myQueue.Peek());
            foreach (var i in myQueue)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("|The 3rd element of myQueue is:  " + myQueue.ElementAtOrDefault(2));
            Console.WriteLine("|The last element of myQueue is:  " + myQueue.Last());
            var myQueueAsc = myQueue.OrderBy(num => num);
            foreach (var item in myQueueAsc)
            {
                Console.Write(item + ", ");
            }
            var tt1 = new Queue<int>();
            tt1.Enqueue(7);
            // why doesn't work?
            //myQueue.Append(12);
            foreach (var i in myQueue)
            {
                Console.Write(i + ", ");
            }
        }
        //public void 
    }
}
