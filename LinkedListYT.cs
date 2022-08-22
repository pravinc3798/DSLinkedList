namespace LinkedListYT
{
    public class LinkedListYT
    {
        private class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node Head;
        private Node Tail;
        int Size;

        public int Length()
        {
            return Size;
        }

        public int Last()
        {
            return Tail.Value;
        }

        public void Display()
        {
            var temp = Head;

            while (temp != null)
            {
                Console.Write("{0} -> ", temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("END");
        }

        public void GetItemAt(int index)
        {
            var temp = Find(index + 1);
            Console.WriteLine(temp.Value);
        }

        public int GetIndexOf(int value)
        {
            var count = 0;
            var temp = Head;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    return count;
                }
                temp = temp.Next;
                count++;
            }
            return -2;
        }

        public void AddLast(int item)
        {
            var newNode = new Node(item);
            if (Head == null)
                Head = Tail = newNode;
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Size += 1;
        }

        public void AddFirst(int item)
        {
            var newNode = new Node(item);
            if (Head == null)
                Head = Tail = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Size += 1;
        }

        public void AddAtIndex(int item, int index)
        {
            if (index < 0 || index > Size)
                Console.WriteLine("Index provided is out of range.");

            else if (index == 0)
                AddFirst(item);

            else if (index == Size)
                AddLast(item);

            else
            {
                var temp = Head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }

                var newNode = new Node(item);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                Size++;
            }
        }

        public void AddAfter(int valueAdd, int afterValue)
        {
            var index = GetIndexOf(afterValue);
            AddAtIndex(valueAdd, index+1);
        }

        public void DeleteFirst()
        {
            if (Head == Tail)
                Head = Tail = null;
            else
            {
                var temp = Head.Next;
                Head = temp;
                Size--;
            }
        }

        private Node Find(int index)
        {
            if (index < 1 || index >= Size)
                throw new ArgumentOutOfRangeException();
            var temp = Head;
            for (int i = 1; i < index; i++)
                temp = temp.Next;
            return temp;
        }

        public void DeleteLast()
        {
            if (Head == Tail)
                Head = Tail = null;
            else
            {
                var temp = Find(Size - 1);
                Tail = temp;
                Tail.Next = null;
                Size--;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0)
                DeleteFirst();
            else if (index == Size - 1)
                DeleteLast();
            else
            {
                var temp = Find(index);
                temp.Next = temp.Next.Next;
            }
        }

        public void DeleteValue(int value)
        {
            var index = GetIndexOf(value);
            DeleteAtIndex(index);
        }

        public void SortList()
        {
            var previous = Head;
            var current = Head.Next;

            while (current != null)
            {
                if (current.Value < previous.Value)
                {
                    previous.Next = current.Next;
                    current.Next = Head;
                    Head = current;

                    current = previous;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }
    }
}
