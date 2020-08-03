using System;
using System.Threading;

namespace Denisov_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteText($"Greetings!\nThis programm will watch folder that you wish.\n" +
                $"You can recover desired version of file after watching.");

            string path = ConsoleHelper.ReadString($"Enter the path to desired folder:");

            LogWriter logWriter = new LogWriter();

            DirectoryHelper directoryHelper = new DirectoryHelper(@"E:\stydying\workdir", logWriter);

            directoryHelper.CreateReserveCopyOfDir(DateTime.Now.ToString("ddMMMyyyyHmmss"));


            //TODO По завершении разработки установить ввод пути к файлу с клавиатуры.
            DirectoryWatcher watcher = new DirectoryWatcher(@"E:\stydying\workdir", logWriter, directoryHelper);//для упрощения тестирования путь задан постоянным.
            Thread threadOfWatcher = new Thread(new ThreadStart(watcher.StartWatch));

            ConsoleHelper.WriteText($"You can choose the next actions:\n\npress 1 to begin watching your folder;\n\n" +
                $"press 2 to stop watching;\n\npress 3 to recover file\n\npress 4 to quit programm.");

            int instance;

            do
            {
                instance = ConsoleHelper.ReadValue($"Enter desired action:");
                switch (instance)
                {
                    case 1:
                        threadOfWatcher.Start();
                        break;
                    case 2:
                        threadOfWatcher.Abort();
                        break;
                    case 3:
                        DateTime wanted = ConsoleHelper.ReadTime($"\nEnter the time that you wish to recover for your directory:");
                        var restorer = new Restorer(directoryHelper, logWriter, wanted, @"E:\stydying\temp\", @"E:\stydying\workdir");
                        restorer.Recover();
                        break;
                }
            }
            while (instance != 4);
        }
    }
}
