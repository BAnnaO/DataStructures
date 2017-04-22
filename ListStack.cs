using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ListStack
    {
        private Node _top = null;
        private int Size = 20;
        public int Count
        {
            get;
            private set;
        }
        public int getSize()
        {
            return Size;
        }
        public ListStack()
        {
            this.Count = 0;
        }
        public void Push(Object obj)
        {
            if (_top == null) { _top.data = obj; }
            else if (Count == Size) { Console.WriteLine("Stack is Full! "); }
            else
            {
                Node newNode = new Node();
                newNode.data = obj;
                Node tmp = _top;
                _top = newNode;
                _top.next = tmp;
            }
            Count++;
        }
        public Object Pop()
        {
            Node objToPop = _top;
            _top = _top.next;
            Count--;
            return objToPop.data;
        }
        public void Clear()
        {
            _top = null;
            Count = 0;
        }
        public bool isEmpty()
        {
            return (_top == null);
        }
        public Object top()
        {
            if (_top.data == null)
            {
                Console.WriteLine("Is Empty ");
                return -1;
            }
            else { return _top.data; }
        }
        public bool isFull()
        {
            return (Count == Size);
        }
    }
}
