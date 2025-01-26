using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logfile = "JSAlogfile.txt";
            string directory = "C:\\Users\\yarok\\Desktop\\Стасян\\3_СЕМ_ЛАБЫ\\ООП\\lab_12\\bin\\Debug\\";
            string disk = "C:\\Users\\yarok\\Desktop\\Стасян\\";

            string nameDirectory = "JSAInspect";
            string nameFile = "JSAdirinfo.txt";

            string newDirectory = "JSAFiles";

            string zipFiles = "JSAFiles.zip";
            string targetFolder = "zipFiles";

            JSALog.ClearFile(logfile);

            JSADiskInfo.PrintFreeSpace(logfile);
            JSADiskInfo.PrintInfoFileSystem(logfile);

            JSAFileInfo.PrintFullPath(logfile);
            JSAFileInfo.PrintSizeExstensionName(logfile);
            JSAFileInfo.PrintDateCreate(logfile);

            JSADirInfo.PrintCountFiles(directory, logfile);
            JSADirInfo.PrintTimeCreate(directory, logfile);
            JSADirInfo.PrintCountSybdirectory(directory, logfile);
            JSADirInfo.PrintListParentsDirectory(directory, logfile);

            // a)
            JSAFileManager.ReadListFilesAndDirectorys(disk, nameDirectory, nameFile, logfile);
            JSAFileManager.CreateAndCopyAndDeleteFile(nameDirectory, nameFile, logfile);
            // b)
            JSAFileManager.CreateDirectory(directory, newDirectory, ".txt", logfile);

            JSAFileManager.ZipFiles(newDirectory, zipFiles, targetFolder, logfile);

            JSALog.SaveFile(logfile);
        }
    }
}
