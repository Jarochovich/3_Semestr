using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    static class JSADirInfo
    {

        // a)
        public static void PrintCountFiles(string dirName, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                string[] files = Directory.GetFiles(dirName);

                writer.WriteLineAsync($"\tСписок файлов каталога {dirName}");
                foreach (var file in files)
                {
                    writer.WriteLineAsync(file);
                }
                writer.WriteLineAsync($"Количество файлов: {files.Length}\n");
            }
           
        }

        // b)
        public static void PrintTimeCreate(string dirName, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                writer.WriteLineAsync("\tВремя создания");
                writer.WriteLineAsync($"Время создания: {Directory.GetCreationTime(dirName)}\n");
            }
               
        }

        // c)
        public static void PrintCountSybdirectory(string dirName, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                writer.WriteLineAsync("\tПоддиректории");

                string[] directorys = Directory.GetDirectories(dirName);
                foreach (var directory in directorys)
                {
                    writer.WriteLineAsync(directory);
                }

                writer.WriteLineAsync("\n\tКоличество поддиректориев");
                writer.WriteLineAsync($"{Directory.GetDirectories(dirName).Length}\n");
            }
                
        }

        // d)
        public static void PrintListParentsDirectory(string dirName, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                writer.WriteLineAsync("\tРодительская директория");
                writer.WriteLineAsync($"{Directory.GetParent(dirName)}\n");
            }
                
        }
    }
}
