using System;
using System.IO;

namespace Denisov_Task4
{
    public class DirectoryWatcher
    {
        public string targetDirectoryPath;
        private FileSystemWatcher watcher;
        private LogWriter logWriter;

        public DirectoryWatcher(string targetPath, LogWriter logWriter)
        {
            if (string.IsNullOrEmpty(targetPath))
            {
                throw new ArgumentNullException("Target path is null or empty!");
            }

            targetDirectoryPath = targetPath;

            this.logWriter = logWriter;

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

            watcher.Changed += logWriter.OnChanged;
            watcher.Created += logWriter.OnCreated;
            watcher.Deleted += logWriter.OnDeleted;
            watcher.Renamed += logWriter.OnRenamed;
        }
    }
}
