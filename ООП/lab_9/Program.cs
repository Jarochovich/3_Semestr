using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ЗАДАНИЕ
            Console.WriteLine("1 ЗАДАНИЕ\n");

            Concert PDidy = new Concert("P.Didy", 34, "29.12.2024",250, "Клуб 58");
            Concert AbyBandit = new Concert("AbyBandit", 25, "11.11.2024", 300, "Октябрьская");
            Concert FichBoy = new Concert("FichBoy", 21, "27.03.2025", 350, "Копейка");
            Concert NUEKI = new Concert("NUEKI", 22, "08.06.2025", 200, "Читальный зал копейки");

            var people = new Dictionary<int, string>
            {
                [1] = PDidy.GetNameSinger(),
                [2] = AbyBandit.GetNameSinger(),
                [3] = FichBoy.GetNameSinger()
            };

            // Добавление элемента коллекции
            people.Add(4, NUEKI.GetNameSinger());

            // Вывод коллекции
            foreach (var singer in people)
                Console.WriteLine($"Key: {singer.Key}, value: {singer.Value}");
            Console.WriteLine();

            // Удаление элемента коллекции
            people.Remove(4);

            // Вывод коллекции
            foreach (var singer in people)
                Console.WriteLine($"Key: {singer.Key}, value: {singer.Value}");
            Console.WriteLine();

            // Поиск элемента коллекции
            foreach (var singer in people)
                if (singer.Value == "AbyBandit")
                    Console.WriteLine($"Элемент {singer.Value} найден!\n");

            // 2 ЗАДАНИЕ
            Console.WriteLine("2 ЗАДАНИЕ\n");

            var application = new Dictionary<int, string>
            {
                [1] = "notepad.exe",
                [2] = "paint.exe",
                [3] = "visualBasic.exe"
            };

            // a)
            foreach (var app in application)
                Console.WriteLine($"Key: {app.Key}, value: {app.Value}");
            Console.WriteLine();

            // b)
            List<int> keysToRemove = new List<int> { 2, 3 };

            // Напрямую в foreach удалять элементы словаря нельзя
            foreach (var key in keysToRemove)
                application.Remove(key);

            foreach (var app in application)
                Console.WriteLine($"Key: {app.Key}, value: {app.Value}");
            Console.WriteLine();

            // c)
            application.Add(2, "Excel.exe");
            application.Add(3, "PhotoShop.exe");

            // d)
            List<string> applicationL = new List<string>
            {
                "notepad.exe",
                "paint.exe",
                "visualBasic.exe"
            };

            // e)
            foreach (var app in applicationL)
                Console.WriteLine($"Value: {app}");
            Console.WriteLine();

            // f)
            foreach (var app in applicationL)
                if (app == "paint.exe")
                    Console.WriteLine($"Значение {app} найдено!");
                
            Console.WriteLine();

            // 3 ЗАДАНИЕ
            Console.WriteLine("3 ЗАДАНИЕ");

            ObservableCollection<Concert> singers = new ObservableCollection<Concert>();

            singers.CollectionChanged += Singer_CollectionChanged;

            // Добавление
            singers.Add(AbyBandit);
            singers.Add(NUEKI);
            singers.Add(PDidy);
            Console.WriteLine();
           
            foreach (var singer in singers)
            {
                Console.WriteLine($"Value: {singer.GetNameSinger()}");
            }
            Console.WriteLine();

            // Удаление
            singers.Remove(PDidy);
            
            foreach (var singer in singers)
            {
                Console.WriteLine($"Value: {singer.GetNameSinger()}");
            }
            Console.WriteLine();

            // Обработчик изменения коллекции
            void Singer_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add: // если добавление
                        if (e.NewItems?[0] is Concert newSinger)
                            Console.WriteLine($"Добавлен новый объект: {newSinger.GetNameSinger()}");
                        break;
                    case NotifyCollectionChangedAction.Remove: // если удаление
                        if (e.OldItems?[0] is Concert oldSinger)
                            Console.WriteLine($"Удален объект: {oldSinger.GetNameSinger()}");
                        break;
                }
            }
        }
    }
}
