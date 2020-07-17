using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public struct DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] array;
        private int index;
        private T current;

        public DynamicArrayEnumerator (DynamicArray<T> array)
        {
            this.array = new T[array.Count];
            for(int i = 0; i <= array.Count - 1; i++)
            {
                this.array[i] = array[i];
            }
            index = -1;
            this.current = default(T);
        }

        object IEnumerator.Current
        {                   
            get
            {
                return current;
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if(index < array.Length)
            {
                current = array[index];
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
