using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace lab_12
{
    static class JSADiskInfo
    {
        // a)
        public static void PrintFreeSpace(string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                writer.WriteLineAsync("\tСвободное место на дисках");
                foreach (DriveInfo drive in drives)
                {
                    writer.WriteLineAsync($"Название диска: {drive.Name}");
                    writer.WriteLineAsync($"Всего места на диске (байт): {drive.TotalSize}");
                    writer.WriteLineAsync($"Свободное место (байт): {drive.AvailableFreeSpace}");
                    writer.WriteLineAsync();
                }
            }
                
        }

        // b)
        public static void PrintInfoFileSystem(string logfile) 
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                writer.WriteLineAsync($"\tИнформация о файловой системе");
                foreach (var drive in drives)
                {
                    writer.WriteLineAsync($"Название диска: {drive.Name}");
                    writer.WriteLineAsync($"Тип файловой системы: {drive.DriveType}");
                    writer.WriteLineAsync($"Метка тома: {drive.VolumeLabel}");
                    writer.WriteLineAsync($"Готов ли диск: {drive.IsReady}");
                    writer.WriteLineAsync();
                }
            }
                
        }

        // c)
        public static void PrintFullInfoDisk(string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                writer.WriteLineAsync($"\tПолная информация о дисках");
                foreach (var drive in drives)
                {
                    writer.WriteLineAsync($"Название диска: {drive.Name}");
                    writer.WriteLineAsync($"Всего места на диске (байт): {drive.TotalSize}");
                    writer.WriteLineAsync($"Свободное место (байт): {drive.AvailableFreeSpace}");
                    writer.WriteLineAsync($"Метка тома: {drive.VolumeLabel}");
                    writer.WriteLineAsync();
                }
            }
                
        }

    }
}
