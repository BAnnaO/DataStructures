using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ArrayStack<T>
    {
        private T[] _array;
        private const int defaultCapacity = 10;
        private int size;

        public ArrayStack()
        {
            this.size = 0;
            this._array = new T[defaultCapacity];
        }

        public bool isEmpty()
        {
            return this.size == 0;
        }

        public virtual int Count
        {
            get { return this.size; }
        }

        public T Pop()
        {
            if (this.size == 0)
            { throw new InvalidOperationException(); }
            else
            {

                return this._array[--size];
            }

        }
        public void Push(T newElement)
        {
            if (this.size == this._array.Length)
            {
                T[] newArray = new T[2 * this._array.Length];
                Array.Copy(this._array, 0, newArray, 0, this.size);
                this._array = newArray;
            }
            this._array[this.size++] = newElement;
        }

        public T Peek()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            return this._array[this.size - 1];
        }
    }
}
