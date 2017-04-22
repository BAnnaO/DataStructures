using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MyQueue<T>
    {
        T[] _array;
        private int DefaultSize;
        public MyQueue() {
            _array = new T[0];
        }
        public void Clear()
        {
            _array = new T[0];
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < _array.Length; i++) {
                if (_array[i].Equals(item))
                {
                    return true;
                }                
            }
            return false;
        }
        public uint Count {
        get { return (uint)_array.Length; }
        }
        public T Dequeue()
        {
            if (_array.Length == 0) {
                throw new InvalidOperationException();
            }
            T r = _array[0];
            T[] buf = new T[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                buf[i] = _array[i];
            }
            T[] newArr = new T[_array.Length - 1];
            for (int i = 0; i < _array.Length - 1; i++)
            {
                newArr[i] = buf[i+1];
            }
            _array = newArr;
            return r;
        }

        public void Enqueue(T item) {
           
            T[] newArr = new T[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newArr[i] = _array[i];
            }
            newArr[_array.Length] = item;
            _array = newArr;
        }
        public T[] ToArray() {
            return _array;
        }


    }
}
