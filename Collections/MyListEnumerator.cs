using System.Collections;
using AksanaChopchytsAutoQATasks.Collections;

namespace AksanaChopchytsAutoQATasks.Collections
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        MyList<T> _list;
        MyNode<T> _currentNode;

        public MyListEnumerator(MyList<T> list)
        {
            _list = list;
            _currentNode = _list.Head;
         }

        public T Current
        {
            get
            {
                return _currentNode.Data;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();
        
        public void Dispose() { }


        public bool MoveNext()
        {
            if (_currentNode == null)
            {
                return false;
            }
            _currentNode = _currentNode.Next;
            //return _currentNode.Next != null;
            return _currentNode != null;
                                  
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    
    }
}
