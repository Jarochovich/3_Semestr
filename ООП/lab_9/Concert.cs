using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    interface IList
    {
        void ChangeDate(string item);
        void Clear();
        void Print();
        void GetInfoSinger();
        void GetInfoConcert();
    }

    internal class Concert: IList
    {
        // Поля класса
        private string nameSinger;
        private int yearSinger;
        private string datePerfomance;
        private int priceTicket;
        private string place;

        // Конструктор класса
        public Concert(string name, int year, string date = "", int price = 0, string place = "Клуб 58")
        {
            this.nameSinger = name;
            this.yearSinger = year;
            this.datePerfomance = date;
            this.priceTicket = price;
            this.place = place;
        }

        // Методы интерфейса IList<T>
        public void GetInfoSinger()
        {
            Console.WriteLine($"Name: {nameSinger}, age: {yearSinger}");
        }

        public void GetInfoConcert()
        {
            Console.WriteLine($"Name: {nameSinger}, age: {yearSinger},\tdate: {datePerfomance}, price: {priceTicket}, place: {place}");
        }

        public string GetNameSinger()
        {
            return this.nameSinger;
        }

        public void ChangeDate(string item) 
        {
            this.datePerfomance = item;
            Console.WriteLine($"Измененная дата выступления {this.datePerfomance}\n");
        }

        public void Clear() 
        {
            this.nameSinger = null;
            this.place = null;
            this.datePerfomance = null;
            this.priceTicket = 0;
            this.yearSinger = 0;
        }

        public void Print() 
        {
            Console.WriteLine($"\t\t\tInfo for singer\nName: {this.nameSinger}\nYear: {this.yearSinger}\nDate Perfomance: {this.datePerfomance}\n" +
                $"Price ticket: {this.priceTicket}\nPlace: {this.place}\n");
        }
    }
}
