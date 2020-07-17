using General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new DynamicArray<int>(new int[4] { 1, 2, 3, 4 });
            foreach(int i in c)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
