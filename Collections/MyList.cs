using System.Collections;

namespace AksanaChopchytsAutoQATasks.Collections
{
    public class MyList<T> : IEnumerable<T>
    {
        public MyNode<T> Head { get; set; }
        //public MyList() { }

        // Method to add data to the head of the list
        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new MyNode<T>(data, null);
            }
            else
            {
                Head = new MyNode<T>(data, Head);
            }
        }

        // Method to find the zero-based position of an element, or -1 if not found
        public int FindPosition(T data)
        {
            int index = 0;
            MyNode<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1; // Element not found
        }

        // Method to get the current number of elements in the list
        public int GetCount()
        {
            int count = 0;
            MyNode<T> current = Head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        // Method to get an element by its position(zero-based)
        public T GetElementByPosition(int index)
        {
            int currentIndex = 0;
            MyNode<T> current = Head;

            while (current != null)
            {
                if (index == currentIndex)
                {
                    return current.Data;
                }

                current = current.Next;
                currentIndex++;
            }

            throw new IndexOutOfRangeException("Position is out of range.");
        }

        // Method to remove an element from the list
        public void Remove(T data)
        {
            if (Head == null)
            {
                return; // List is empty
            }

            if (Head.Data.Equals(data))
            {
                Head = Head.Next; // Remove the head element
                return;
            }

            MyNode<T> current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next; // Remove the element
                    return;
                }

                current = current.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return GetEnumerator();
            throw new NotImplementedException();
        }
    }
}
