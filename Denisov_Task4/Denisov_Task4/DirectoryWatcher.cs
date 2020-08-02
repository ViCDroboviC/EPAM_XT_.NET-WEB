using System;
using System.IO;

namespace Denisov_Task4
{
    public class DirectoryWatcher
    {
        public string targetDirectoryPath;
        private FileSystemWatcher watcher;
        private LogWriter logWriter;
        private DirectoryHelper directoryHelper;

        public DirectoryWatcher(string targetPath, LogWriter logWriter, DirectoryHelper directoryHelper)
        {
            if (string.IsNullOrEmpty(targetPath))
            {
                throw new ArgumentNullException("Target path is null or empty!");
            }

            targetDirectoryPath = targetPath;

            this.logWriter = logWriter;

            this.directoryHelper = directoryHelper;

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
            watcher.IncludeSubdirectories = true;

            logWriter.WriteAction($"Directory watch has been started.");

            watcher.Changed += logWriter.OnChanged;
            watcher.Changed += directoryHelper.OnChanged;

            watcher.Created += logWriter.OnCreated;
            watcher.Created += directoryHelper.OnCreated;

            watcher.Deleted += logWriter.OnDeleted;
            watcher.Deleted += directoryHelper.OnDeleted;

            watcher.Renamed += logWriter.OnRenamed;
            watcher.Renamed += directoryHelper.OnRenamed;
        }
    }
}
