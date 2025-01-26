using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    static class JSALog
    {
        public static void ClearFile(string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, false)) 
            {
                writer.WriteLineAsync();
            }
        }

        // 6 задание
        public static void SaveFile(string logfile)
        {
            using (StreamWriter writer = new StreamWriter(logfile, true))
            {
                string filePath = "SixTaskYSAlogfile.txt";
                string[] logLines = File.ReadAllLines(filePath);

                // Фильтрация по дню, диапазону времени или ключевому слову
                var filteredLogs = logLines.Where(line =>
                    line.Contains("2024-12-03") || // фильтрация по дню
                    (line.Contains("13:00") && line.Contains("14:00")) || // фильтрация по диапазону времени
                    line.Contains("ключевое слово")
                ).ToArray();

                // Подсчет количества записей
                int count = filteredLogs.Length;
                writer.WriteLine();
                writer.WriteLineAsync($"Количество записей: {count}");

                // Удаление части информации, оставляем только записи за текущий час
                string currentHour = DateTime.Now.ToString("HH");
                var currentHourLogs = logLines.Where(line => line.Contains($" {currentHour}:")).ToArray();

                // Перезапись файла с новыми данными
                File.WriteAllLines(filePath, currentHourLogs);

                writer.WriteLineAsync("Файл обновлен. Оставлены только записи за текущий час.");
            }
               
        }
    }
}
