namespace LinkedListYT
{
    public class QueueYT
    {
        LinkedListYT queue = new LinkedListYT();
        
        public void Enqueue(int item)
        {
            queue.AddLast(item);
        }

        public int Dequeue()
        {
            var item = queue.Last();
            queue.DeleteFirst();
            return item;
        }

        public bool isEmpty()
        {
            if (queue.Length() == 0)
                return true;
            else
                return false;
        }

        public int Size()
        {
            return queue.Length();
        }
    }
}
