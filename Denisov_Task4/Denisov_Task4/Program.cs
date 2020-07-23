using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region watcherTest
            //FileSystemWatcher watcher = new FileSystemWatcher();
            //try
            //{
            //    watcher.Path = @"E:\stydying";
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return;
            //}
            //watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.Attributes;
            //watcher.Filter = "*.txt";
            //watcher.Changed += new FileSystemEventHandler(OnChanged);
            //watcher.EnableRaisingEvents = true;

            //Console.WriteLine($"Press q to quit app.");
            //while (Console.Read() != 'q') ;

            //void OnChanged(object source, FileSystemEventArgs e)
            //{
            //    Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
            //}
            #endregion

            ConsoleHelper.WriteText($"Greetings!\nThis programm will watch folder that you wish.\n" +
                $"You can recover desired version of file after watching.");

            string path = ConsoleHelper.ReadString($"Enter the path to desired folder:");
            DirectoryWatcher watcher = new DirectoryWatcher(path);
            Thread threadOfWatcher = new Thread(new ThreadStart(watcher.StartWatch));

            ConsoleHelper.WriteText($"You can choose the next actions:\n\npress 1 to begin watching your folder;\n\n" +
                $"press 2 to stop watching;\n\npress 3 to recover file\n\npress 4 to quit programm.");

            int instance;

            do
            {
                instance = ConsoleHelper.ReadValue($"Enter desired action:");
                switch (instance)
                {
                    case 1:
                        threadOfWatcher.Start();
                        break;
                    case 2:
                        threadOfWatcher.Abort();
                        break;
                }
            }
            while (instance != 4);

        }
    }
}
