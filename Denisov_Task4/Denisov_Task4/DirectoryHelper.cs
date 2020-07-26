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

        public DirectoryHelper(string path1, string path2, LogWriter logWriter)
        {
            workPath = path1;
            targetPath = path2;
            this.logWriter = logWriter;
        }

        public void CreateReserveCopyOfDir()
        {
            foreach (string dirPath in Directory.GetDirectories(workPath, "*", SearchOption.AllDirectories))
            {
                try
                {
                    Directory.CreateDirectory(dirPath.Replace(workPath, targetPath));
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
                    File.Copy(newPath, newPath.Replace(workPath, targetPath), true);
                }
                catch (Exception e)
                {
                    //TODO обработать исключения
                }
            }

            logWriter.WriteAction($"Reserve copy of directory has been created.");
        }
    }
}
