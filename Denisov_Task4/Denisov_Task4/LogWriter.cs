using System;
using System.IO;
using System.Text;

namespace Denisov_Task4
{
    public class LogWriter
    {
        private string path;

        private object writerLock = new object();

        public LogWriter()
        {
            path = Path.Combine(Environment.CurrentDirectory, "log.txt");
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {
            WriteChange(e);
        }

        public  void OnCreated(object source, FileSystemEventArgs e)
        {
            WriteChange(e);
        }

        public  void OnRenamed(object source, FileSystemEventArgs e)
        {
            WriteChange(e);
        }

        public  void OnDeleted(object source, FileSystemEventArgs e)
        {
            WriteChange(e);
        }

        public void WriteAction(string message)
        {
            lock (writerLock)
            {
                using (var sw = new StreamWriter((path), true, Encoding.UTF8))
                {
                    sw.WriteLine($"\n{DateTime.Now.ToString("dd MMM, yyyy H:mm:ss")} {message}\n");
                    sw.Close();
                }
            }
        }

        private void WriteChange(FileSystemEventArgs e)
        {
            lock (writerLock)
            {
                using (var sw = new StreamWriter((path), true, Encoding.UTF8))
                {
                    sw.WriteLine($"\n{DateTime.Now.ToString("dd MMM, yyyy H:mm:ss")} File: {e.Name} {e.ChangeType}\n");
                }
            }
        }
    }
}
