using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public struct DynamicArrayEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        private T[] array;
        private int index;
        private T current;

        public DynamicArrayEnumerator (DynamicArray<T> array)
        {
            this.array = new T[array.Count];
            for(int i = 0; i <= array.Count; i++)
            {
                this.array[i] = array[i];
            }
            index = -1;
            current = default(T);
        }

        object IEnumerator.Current
        {                   
            get
            {
                if (index == -1 || index >= array.Length)
                {
                throw new InvalidOperationException();
                }
                return array[index];
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                if (index == -1 || index >= array.Length)
                {
                    throw new InvalidOperationException();
                }
                return array[index];
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if(index <= array.Length)
            {
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
