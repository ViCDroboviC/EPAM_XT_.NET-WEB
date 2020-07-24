using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    public class DirectoryWatcher
    {
        public string targetDirectoryPath;
        private FileSystemWatcher watcher;

        public DirectoryWatcher(string targetPath)
        {
            if (string.IsNullOrEmpty(targetPath))
            {
                throw new ArgumentNullException("Target path is null or empty!");
            }

            targetDirectoryPath = targetPath;

            watcher = new FileSystemWatcher();

            watcher.Path = targetDirectoryPath;
            watcher.Filter = "*.txt";
            watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.Attributes | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName;
        }


        public void StartWatch()
        {
            watcher.EnableRaisingEvents = true;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }

        private void OnCreated(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }

        private void OnRenamed(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }

        private void OnDeleted(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        }
    }
}
