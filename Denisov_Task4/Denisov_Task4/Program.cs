using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = @"E:\stydying";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.Attributes;
            watcher.Filter = "*.txt";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"Press q to quit app.");
            while (Console.Read() != 'q') ;

            void OnChanged(object source, FileSystemEventArgs e)
            {
                Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
            }
        }
    }
}
