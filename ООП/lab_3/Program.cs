using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Set set1 = new Set(new string[] { "apple", "banana", "cherry" });
            Set set2 = new Set(new string[] { "banana", "cherry", "date" });
            Set result = set1 * set2;

            foreach (var word in result.GetElements())
            {
                Console.WriteLine(word.AddPeriod());
            }

            Set setWithNulls = new Set(new string[] { "apple", null, "banana" });
            Set cleanedSet = setWithNulls.RemoveNulls();

            foreach (var word in cleanedSet.GetElements())
            {
                Console.WriteLine(word);
            }

            // Пример использования StatisticOperation
            Console.WriteLine($"Сумма кол-ва символов set1: {StatisticOperation.Sum(set1)}");
            Console.WriteLine($"Разница между максимальным и минимальным элементом: {StatisticOperation.Difference(set1)}");
            Console.WriteLine($"Кол-во элементов set1: {StatisticOperation.Count(set1)}");


            // Инициализация класса Production
            Set.Production prod = new Set.Production(Guid.NewGuid(), "BSTU");
            Console.WriteLine(prod.Id);
            Console.WriteLine(prod.OrganizationName);

            // Инициализация класса Developer
            Set.Developer dev = new Set.Developer("Иванов Иван Иванович", Guid.NewGuid(), "IT");
            Console.WriteLine(dev.Id);
            Console.WriteLine(dev.FullName);
            Console.WriteLine(dev.Department);
        }
    }
}
