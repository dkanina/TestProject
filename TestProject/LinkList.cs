using System.Collections;
using System.Collections.Generic;

namespace TestProject
{
    //listnode class
    public class ListNode<T>
    {
        public ListNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }
    }
    //linked list class implements IENumebrable
    public class LinkList<T> : IEnumerable<T>
    {
        private ListNode<T> _first;       //first element
        private ListNode<T> _last;        //last element
        private int _count;               //count of elements
        //add element to the end of list
        public void Add(T data)
        {
            var node = new ListNode<T>(data);
            if (_first != null)
            {
                _last.Next = node;
            }
            else
            {
                _first = node;
            }
            _last = node;
            _count++;
        }
        //Add first element to list
        public void AddFirst(T data)
        {
            ListNode<T> node = new ListNode<T>(data) { Next = _first };
            _first = node;
            if (_count == 0)
                _last = _first;
            _count++;
        }
        //add element to direct pos
        public void Insert(int pos, T data)
        {
            if (pos == 0)
                AddFirst(data);
            else if (pos == _count)
                Add(data);
            else if (pos > 0 && pos < _count)
            {
                var previous = _first;
                for (var i = 0; i < pos - 1; i++)
                    previous = previous.Next;
                var next = previous.Next;
                var node = new ListNode<T>(data) { Next = next };
                previous.Next = node;
                _count++;
            }
        }
        //remove first element
        public bool RemoveFirst()
        {
            if (_first != null)
            {
                _first = _first.Next;
                if (_first == null)
                    _last = null;
                _count--;
                return true;
            }
            return false;
        }
        //remove last element
        public bool RemoveLast()
        {
            var previous = _first;
            if (previous != null)
            {
                while (previous.Next != _last)
                {
                    previous = previous.Next;
                }
                previous.Next = null;
                _last = previous;
                _count--;
                return true;
            }
            return false;
        }
        //remove element by index
        public bool Remove(int index)
        {
            if (index >= _count || index < 0)
                return false;
            if (index == _count - 1)
                RemoveLast();
            else if (index == 0)
                RemoveFirst();
            else
            {
                var previous = _first;
                for (var i = 0; i < index - 1; i++)
                {
                    previous = previous.Next;
                }
                var current = previous.Next;
                var next = current.Next;
                previous.Next = next;
                current.Next = null;
                _count--;
                return true;
            }
            return false;
        }
        //reverse list
        public void Reverse()
        {
            ListNode<T> current = _first,
                        previous = null;
            while (current != null)
            {
                ListNode<T> next;
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            _last = _first;
            _first = previous;


        }
        //IEnumerable interface
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = _first;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }



    }
}
