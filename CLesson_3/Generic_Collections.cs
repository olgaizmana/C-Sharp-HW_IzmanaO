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
        public void LinkedList()
        {
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddFirst("Firstly added element");
            myLinkedList.AddLast("Last element initially added");
            var newNode = myLinkedList.AddLast("Laast element");
            myLinkedList.AddBefore(newNode, "Added before \"Laast element\"");
            myLinkedList.AddAfter(newNode, "Added after \"Laast element\"");
            Console.WriteLine("myLinkedList: ");
            foreach (var item in myLinkedList)
            {
                Console.Write(item + ", ");
            }
            Console.Write(myLinkedList.ElementAt(0));
        }
        public void List()
        {
            List<string> myList = new List<string>();
            myList.Add("1");
            myList.Add("2");
            myList.Add("3");
            myList.Add("4");
            myList.Add("5");
            myList.Add("6");
            myList.Add("7");
            myList.Add("8");
            Console.Write("myList: ");
            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }
            List<string> newList = new List<string>();
            newList.Add("9");
            newList.Add("10");

            myList.AddRange(newList);
            Console.WriteLine("|myList after adding newList: ");
            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }
            //myList.Append("11");

            //Console.WriteLine("|myList after appending 11: ");
            //foreach (var item in myList)
            // {
            //  Console.Write(item + ", ");
            //}
            Console.WriteLine("|the element at the index 2: " + myList[2]);

            myList.InsertRange(5, newList);
            Console.WriteLine("|myList after inserting newList at index 5: ");
            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }
            int index = myList.IndexOf("9");
            if (index >= 0)
            {
                Console.WriteLine($"\"9\" index in List is: {index}");
            }
            else 
            { 
                Console.Write("Item not found");
            }
            myList.Reverse();
            Console.WriteLine("Reversed myList is: ");
            foreach (var item in myList)
            {
                Console.Write(item + ", ");
            }
            myList.Sort();

            Console.Write("Ordered in ascending order myList is: ");
            foreach (var item in myList)
            {
                Console.WriteLine(item + ", ");
            }
            int binarySearch = myList.BinarySearch("5");
            Console.WriteLine($"\"5\" index in OrderedParallelQuery myList is: {binarySearch}");

            Console.WriteLine(" myList capacity is " + myList.Capacity);
            var concatList = myList.Concat(newList);
            Console.Write("ConcatList is: ");
            foreach (var item in concatList)
            {
                Console.Write(item + ", ");
            }

            IEnumerable<string>concatListDistinct = concatList.Distinct();  
            
            Console.Write("ConcatList distinct elements are: ");
            foreach (var item in concatListDistinct)
            {
                Console.Write(item + ", ");
            }
        }
        public void Dictionary()
        {
            Dictionary<string, string> internMentors = new Dictionary<string, string> {
                {"Andrei Puscasu", "Alexandru Todos, Marius Bunescu"},
                {"Adrian Rascovschi", "Olga Izmana, Daniel Pogorevici, Marina Grati"},
                {"Andrei Domenti", "Iuliana Revenco, Chiril Brinzan"},
                {"Anton Smaghin", "Dumitru Rotaru, Alexandru Micu"},
                {"Cristian Botan","Dorina Balaur, Natalia Levinta"}
            };

            Console.Write("Initial Dictionar is: ");
            foreach(KeyValuePair<string, string> kvp in internMentors)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            internMentors.Add("Dina Gritco", "Olga Migalatiev, Irina Chirca");
            internMentors.Add("Ecaterina Rosca", "Tatiana Cecan, Olivia Burlacov");
            internMentors.Add("Irina Popovici", "Antonina Prijelevscaia, Evghenia Valicova, Violeta Putivet, Marian Popov");
            internMentors.Add("Maria Sahaidac", "Cornelia Sirbu, Marina Vinogradova, Xenia Ravenschii");
            Console.Write("Updated Dictionar after adding new pairs is: ");
            foreach (KeyValuePair<string, string> kvp in internMentors)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            if(internMentors.ContainsKey("Andrei Domenti"))
            {
                Console.WriteLine($"Andrei Domenti's mentees are : {(internMentors["Andrei Domenti"])}");
            }
            string mentees;
            if (internMentors.TryGetValue("Anton Smaghin", out mentees))
            {
                Console.WriteLine($"Anton Smaghin's mentees are: {mentees}");
            }
            for (int i = 0; i < internMentors.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        internMentors.ElementAt(i).Key,
                                                        internMentors.ElementAt(i).Value);
            }
            internMentors["Anton Smaghin"] = "Dumitru Rotaru";
            internMentors["Maria Sahaidac"] = "Marina Vinogradova";
            internMentors["Natalia Bodrug"] = "Andrei Siminitchi";
            Console.WriteLine("Updated Mentor-Mentee List after removing interns: ");
            for (int i = 0; i < internMentors.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        internMentors.ElementAt(i).Key,
                                                        internMentors.ElementAt(i).Value);
            }
            internMentors.Remove("Natalia Bodrug");
            if (internMentors.ContainsKey("Natalia Bodrug"))
            {
                internMentors["Natalia Bodrug"] = "Andrei Siminitchi";
            }
            var firstmentor = internMentors.ElementAt(0).Key;
            Console.WriteLine($"First mentor is {firstmentor}");
            var firstmentees = internMentors.ElementAt(0).Value;
            Console.WriteLine($"First mentees are {firstmentees}");
           
            Console.WriteLine(internMentors.First());

            //var groups = internMentors.GroupBy(x => x.Value);
            Console.WriteLine("Print Dictionary after removing Bodrug, trying to update Bodrug value an removing Domenti: ");
            internMentors.Remove("Andrei Domenti");
            for (int i = 0; i < internMentors.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        internMentors.ElementAt(i).Key,
                                                        internMentors.ElementAt(i).Value);
            }
            internMentors.Clear();
        }
    }
}
