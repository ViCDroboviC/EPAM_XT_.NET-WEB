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
            watcher.NotifyFilter = NotifyFilters.Size | NotifyFilters.Attributes;
        }


        public void StartWatch()
        {
            watcher.EnableRaisingEvents = true;
        }
    }
}
