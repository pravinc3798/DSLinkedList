using System.Reflection.Metadata.Ecma335;

namespace LinkedListYT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("\n-------UC2 : Add elements from Head--------\n");
            var UC2 = new LinkedListYT();
            UC2.AddFirst(70);
            UC2.Display();
            UC2.AddFirst(30);
            UC2.Display();
            UC2.AddFirst(56);
            UC2.Display();

            Console.WriteLine("\n-------UC3 : Add elements to the Last--------\n");
            var UC3 = new LinkedListYT();
            UC3.AddLast(56);
            UC3.Display();
            UC3.AddLast(30);
            UC3.Display();
            UC3.AddLast(70);
            UC3.Display();

            Console.WriteLine("\n-------UC4 : Add 30 in Between 56 and 70--------\n");
            var UC4 = new LinkedListYT();
            UC4.AddFirst(56);
            UC4.AddLast(70);
            UC4.Display();
            UC4.AddAtIndex(30,1);
            UC4.Display();

            Console.WriteLine("\n-------UC5 : Delete Last Element--------\n");
            UC4.Display();
            UC4.DeleteLast();
            UC4.Display();

            Console.WriteLine("\n-------UC6 : Delete First Element--------\n");
            UC4.AddLast(70);
            UC4.Display();
            UC4.DeleteFirst();
            UC4.Display();

            Console.WriteLine("\n-------UC7 : Find Index of node with value 30--------\n");
            UC4.AddFirst(56);
            Console.WriteLine("Index : {0}",UC4.GetIndexOf(30));

            Console.WriteLine("\n-------UC8 : Insert 40 after 30--------\n");
            UC4.AddAfter(40,30);
            UC4.Display();

            Console.WriteLine("\n-------UC9 : Delete 40 from The linkedList--------\n");
            UC4.Display();
            UC4.DeleteValue(40);
            UC4.Display();

            Console.WriteLine("\n-------UC10 : Get the Length of Linked List--------\n");
            Console.WriteLine("Length : {0}",UC4.Length());

            Console.WriteLine("\n-------UC11 : Sort Linked List--------\n");
            Console.WriteLine("Initial List");
            UC4.AddLast(20);
            UC4.AddLast(10);
            UC4.AddFirst(95);
            UC4.Display();
            UC4.SortList();
            Console.WriteLine("Sorted List");
            UC4.Display();

            Console.WriteLine("\n-------xxxxx--------\n");


            var stack = new StackYT();

            Console.WriteLine("\n-------Stack UC1 : Create stack of 56 30 70--------\n");
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);

            Console.WriteLine("\n-------Stack UC2 : Peek and Pop from Stack--------\n");
            Console.WriteLine("Peak : {0}",stack.Peak());
            Console.WriteLine("Pop : {0}",stack.Pop());
            Console.WriteLine("Peak again : {0}",stack.Peak());

            Console.WriteLine("\n-------xxxxxxxxx--------\n");


            var queue = new QueueYT();

            Console.WriteLine("\n-------Queue UC1 : Create queue of 56 30 70--------\n");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("\n-------Queue UC2 : Ability to Dequeue--------\n");
            Console.WriteLine("Size of Queue Before Dequeue : {0}",queue.Size());
            Console.WriteLine("Dequeued Item : {0}",queue.Dequeue());
            Console.WriteLine("Size of Queue After Dequeue : {0}", queue.Size());
        }
    }
}
