using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class DynamicArray<T> : ICollection<T>, IEnumerable<T>, ICollection, IEnumerable
    {
        protected T[] items;

        public bool IsReadOnly => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public DynamicArray()
        {
            items = new T[8];
        }

        public DynamicArray(int capacity)
        {
            items = new T[capacity];
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            int collectionCapacity = 0;

            foreach(T obj in collection)
            {
                collectionCapacity++;
            }

            items = new T[collectionCapacity];

            int i = 0;

            foreach(T obj in collection)
            {
                items[i] = obj;
            }
        }

        public DynamicArray(ICollection<T> collection)
        {
            items = new T[collection.Count];

            int i = 0;

            foreach(T item in collection)
            {
                items[i] = item;
                i++;
            }
        }

        public int Capacity
        {
            get
            {
                return items.Length;
            }
        }
        public int Count
        {
            get
            {
                return Count;
            }
            protected set { }
        }

        public void Add(T item)
        {
            if(item == null)
            {
                throw new ArgumentNullException();
            }

            if(Capacity > Count)
            {
                items[Count + 1] = item;
            }

            if (Capacity == Count)
            {
                T[] newArray = new T[Capacity * 2];

                items.CopyTo(newArray, 0);
                items = newArray;
                items[Count + 1] = item;
                RecountCount();
            }
            else
            {
                throw new Exception("Unexpected exception");
            }
        }

        public void Clear()
        {
            Array.Clear(items, 0, Count);
        }

        public bool Contains(T item)
        {
            foreach (T obj in items)
            {
                if (obj.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {            
            int FirstRemoovedIndex = 0;
            if(Contains(item))
            {
                for (int i = 0; i < Count; i++)
                {
                    if (items[i].Equals(item))
                    {
                        items[i] = default;

                        FirstRemoovedIndex = i;

                        break;
                    }
                }
                for(int i = FirstRemoovedIndex; i < Count; i++)
                {
                    items[i] = items[i + 1];
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        private void RecountCount()
        {
            int res = items.Length;

            for(int i = items.Length; i >0; i--)
            {
                if(items[i] == null)
                {
                    res--;
                }
                else
                {
                    break;
                }
            }

            Count = res;
        } 

        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }
    }
}
