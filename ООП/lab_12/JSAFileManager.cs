using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    static class JSAFileManager
    {
        // a)
        public static async void ReadListFilesAndDirectorys(string disk, string nameDirectory, string nameFile, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                string[] fileInfo = Directory.GetFileSystemEntries(disk);

                writer.WriteLineAsync("\tСписок файлов и каталогов");

                foreach (string file in fileInfo)
                {
                    writer.WriteLineAsync(file);
                }

                Directory.CreateDirectory(nameDirectory);
                writer.WriteLineAsync($"\nДиректория {nameDirectory} создана!");

                FileInfo newFile = new FileInfo($"{nameDirectory}\\{nameFile}");
                using (newFile.Create())
                {

                }
                writer.WriteLineAsync($"Файл {nameFile} создан!");

                // Записываем информацию в файл
                string text = "aaaaabbbbb";

                using (StreamWriter sw = new StreamWriter($"{nameDirectory}\\{nameFile}"))
                {
                    // Поток открывается и сразу же после блока using закрывается
                    await sw.WriteAsync(text);
                }
            }
                
            
        }

        public static void CreateAndCopyAndDeleteFile(string nameDirectory, string nameFile, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                FileInfo file1 = new FileInfo($"{nameDirectory}\\{nameFile}");

                string copyFile = "copyJSAFile.txt";
                FileInfo file2 = new FileInfo($"{nameDirectory}\\{copyFile}");

                // Открываем поток и сразу закрываем его
                using (FileStream fs = file2.Create())
                {
                    // Поток автоматически закроется после выхода из блока using
                }

                file1.CopyTo($"{nameDirectory}\\{copyFile}", true);
                file1.Delete();
            }
                
        }

        // b)
        public static void CreateDirectory(string directory, string newDirectory, string extension, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                FileInfo file1 = new FileInfo("C:\\Users\\yarok\\Desktop\\Стасян\\3_СЕМ_ЛАБЫ\\ООП\\lab_12\\bin\\Debug\\JSAInspect\\copyJSAFile.txt");

                Directory.CreateDirectory(newDirectory);

                string[] files = Directory.GetFiles(directory);

                writer.WriteLineAsync($"\tСписок файлов каталога {directory}\n");

                foreach (var file in files)
                {
                    if (file.EndsWith($"{extension}"))
                    {
                        writer.WriteLineAsync(file);

                        FileInfo fileInfo = new FileInfo(file);

                        if (!file1.Exists)
                            file1.CopyTo($"{directory}\\{newDirectory}\\copyJSAFile.txt");
                    }
                }
            }
               
        }

        // c)
        public static void ZipFiles(string folder, string zipFiles, string targetFolder, string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                try
                {
                    ZipFile.CreateFromDirectory(folder, zipFiles); // исключение
                    writer.WriteLineAsync($"Папка {folder} архивирована в файл {zipFiles}");

                    ZipFile.ExtractToDirectory(zipFiles, targetFolder);
                    writer.WriteLineAsync($"Файл {zipFiles} распакован в в папку {targetFolder}");
                }
                catch (Exception e)
                {
                    writer.WriteLineAsync(e.Message);
                }
                
            }
                
        }

    }
}
