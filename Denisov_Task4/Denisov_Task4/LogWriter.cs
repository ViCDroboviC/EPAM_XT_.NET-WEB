using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denisov_Task4
{
    public class LogWriter
    {
        private string path;

        public LogWriter()
        {
            this.path = Path.Combine(Environment.CurrentDirectory, "log.txt");
        }

        public async void OnChanged(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => WriteChange(e));
        }

        public async void OnCreated(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => WriteChange(e));
        }

        public async void OnRenamed(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => WriteChange(e));
        }

        public async void OnDeleted(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => WriteChange(e));
        }

        public void WriteAction(string message)
        {
            using (var sw = new StreamWriter((path), true, Encoding.UTF8))
            {
                sw.WriteLine($"\n{DateTime.Now.ToString("dd MMM, yyyy H:mm:ss")} {message}\n");
                sw.Close();
            }
        }

        private void WriteChange(FileSystemEventArgs e)
        {
            using (var sw = new StreamWriter((path), true, Encoding.UTF8))
            {
                sw.WriteLine($"\n{DateTime.Now.ToString("dd MMM, yyyy H:mm:ss")} File: {e.Name} {e.ChangeType}\n");
                sw.Close();
            }
        }


    }
}
