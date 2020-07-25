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

        public LogWriter(string path)
        {
            this.path = path;
        }

        public async void OnChanged(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => WriteChange(e));//Console.WriteLine($"File: {e.FullPath} {e.ChangeType}"));
        }

        public async void OnCreated(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => Console.WriteLine($"File: {e.FullPath} {e.ChangeType}"));
        }

        public async void OnRenamed(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => Console.WriteLine($"File: {e.FullPath} {e.ChangeType}"));
        }

        public async void OnDeleted(object source, FileSystemEventArgs e)
        {
            await Task.Run(() => Console.WriteLine($"File: {e.FullPath} {e.ChangeType}"));
        }

        private void WriteChange(FileSystemEventArgs e)
        {
            using (var sw = new StreamWriter((@"log.txt"), true, Encoding.UTF8))
            {
                sw.WriteLine($"File: {e.Name} {e.ChangeType}");
                sw.Close();
            }
        }
    }
}
