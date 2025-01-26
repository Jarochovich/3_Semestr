using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    static class JSAFileInfo
    {
        // a)
        public static void PrintFullPath(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                FileInfo fileInfo = new FileInfo(fileName);

                writer.WriteLineAsync($"\tПолный путь к файлу");
                writer.WriteLineAsync($"Полный путь к файлу {fileName}: {fileInfo.DirectoryName}\n");
            }
                
        }

        // b) 
        public static void PrintSizeExstensionName(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                writer.WriteLineAsync($"\tОбщая информация о файле");

                writer.WriteLineAsync($"Размер файла {fileName}: {fileInfo.Length}");
                writer.WriteLineAsync($"Расширение файла {fileName}: {fileInfo.Extension}");
                writer.WriteLineAsync($"Имя файла: {fileInfo.Name}\n");
            }
               
        }

        // c)
        public static void PrintDateCreate(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                FileInfo fileInfo = new FileInfo(fileName);

                writer.WriteLineAsync("\tВремя и дата создания/изменения");
                writer.WriteLineAsync($"Дата создания: {fileInfo.CreationTime}");
                writer.WriteLineAsync($"Дата изменения: {fileInfo.LastAccessTime}\n");
            }
                

              
        }

    }
}
