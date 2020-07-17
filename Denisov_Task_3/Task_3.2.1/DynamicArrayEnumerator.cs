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

        public DynamicArrayEnumerator (DynamicArray<T> array)
        {
            this.array = new T[array.Count];
            for(int i = 0; i <= array.Count - 1; i++)
            {
                this.array[i] = array[i];
            }
            index = -1;
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
                if (index == -1 || index > (array.Length - 1))
                {
                    throw new InvalidOperationException();
                }
                return array[index];
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if(index < (array.Length - 1))
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
