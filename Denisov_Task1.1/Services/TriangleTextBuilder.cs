using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public abstract class TriangleTextBuilder
    {
        public static void Build(int count)
        {
            char star = '*';
            string text = string.Empty;
            for (int i = 0; i < count; i++)
            {
                text = text + star;
                ConsoleHelper.WriteText(text);
            }
        }
    }
}

