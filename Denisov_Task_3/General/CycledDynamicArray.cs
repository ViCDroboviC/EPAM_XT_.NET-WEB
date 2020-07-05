using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>
    {
        public override IEnumerator<T> GetEnumerator()
        {
            return new DynamicArrayEnumerator<T>(this);
        }
    }
}
