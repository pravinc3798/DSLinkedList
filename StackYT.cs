namespace LinkedListYT
{
    public class StackYT
    {
        LinkedListYT stack = new LinkedListYT();
        public void Push(int item)
        {
            stack.AddLast(item);
        }
        public int Pop()
        {
            var item = stack.Last();
            stack.DeleteLast();
            return item;
        }
        public int Peak()
        {
            var item = stack.Last();
            return item;
        }
        public bool isEmpty()
        {
            if (stack.Length() == 0)
                return true;
            return false;
        }
        public int size()
        {
            return stack.Length();
        }
    }
}
