using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    public class DirectoryHelper
    {
        string workPath; //рабочая папка (где отслеживаются изменения)
        string targetPath; //папка для рабочих файлов программы
        LogWriter logWriter;

        public DirectoryHelper(string path1, LogWriter logWriter)
        {
            workPath = path1;
            targetPath = @"E:\stydying\temp\"; //Environment.CurrentDirectory + @"temp";
            this.logWriter = logWriter;
        }

        public void CreateReserveCopyOfDir(string dateOfCreation)
        {
            foreach (string dirPath in Directory.GetDirectories(workPath, "*", SearchOption.AllDirectories))
            {
                try
                {
                    Directory.CreateDirectory(dirPath.Replace(workPath, targetPath + dateOfCreation));
                }
                catch (Exception e)
                {
                    //TODO обработать исключения
                }
            }

            foreach (string newPath in Directory.GetFiles(workPath, "*.txt", SearchOption.AllDirectories))
            {
                try
                {
                    File.Copy(newPath, newPath.Replace(workPath, targetPath + dateOfCreation), true);
                }
                catch (Exception e)
                {
                    //TODO обработать исключения
                }
            }

            logWriter.WriteAction($"Reserve copy of directory has been created.");
        }

        public async void OnChanged(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => CreateReserveCopyOfDir(DateTime.Now.ToString("ddMMMyyyyHmmss")));
        }

        public async void OnCreated(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => CreateReserveCopyOfDir(DateTime.Now.ToString("ddMMMyyyyHmmss")));
        }

        public async void OnRenamed(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => CreateReserveCopyOfDir(DateTime.Now.ToString("ddMMMyyyyHmmss")));
        }

        public async void OnDeleted(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => CreateReserveCopyOfDir(DateTime.Now.ToString("ddMMMyyyyHmmss")));
        }
    }
}
