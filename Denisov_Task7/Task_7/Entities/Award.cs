using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Award
    {

        public Award(int id, string title)
        {
            this.id = id;
            this.title = title;
        }

        internal int id { get; }

        internal string title { get; }
    }
}
