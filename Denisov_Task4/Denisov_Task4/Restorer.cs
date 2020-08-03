using System;
using System.IO;

namespace Denisov_Task4
{
    public class Restorer
    {
        private DirectoryHelper directoryHelper;

        private LogWriter logWriter;

        DateTime wantedVersion;

        string backupPath;

        string workPath;

        public Restorer(DirectoryHelper directoryHelper, LogWriter logWriter, DateTime wanted, string backup, string workpath)
        {
            this.directoryHelper = directoryHelper;
            this.logWriter = logWriter;
            wantedVersion = wanted;
            backupPath = backup;
            this.workPath = workpath;
        }

        public void Recover()
        {
            directoryHelper.ClearDirectory();
            var backupFile = FindWantedVersion();
            directoryHelper.CopyDirectory(backupFile, workPath);
            ConsoleHelper.WriteText($"\n{backupFile} has been copied to {workPath}\n");
        }

        private string FindWantedVersion()
        {
            string wantedBackup = null;
            DateTime nearest = new DateTime(0);

            if (Directory.Exists(backupPath))
            {
                string[] backups = Directory.GetDirectories(backupPath);

                foreach(var backup in backups)
                {
                    if (Directory.GetCreationTime(backup) < wantedVersion && nearest < Directory.GetCreationTime(backup))
                    {
                        nearest = Directory.GetCreationTime(backup);
                        wantedBackup = backup;
                    }
                }
            }
            else
            {
                throw new Exception("Unexpected exception");
            }
            return wantedBackup;
        }
    }
}
