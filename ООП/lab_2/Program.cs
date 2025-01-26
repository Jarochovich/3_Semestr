using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
            new Customer(Guid.NewGuid(), "Алексей", "Смирнов", "Петрович", "ул. Ленина, 1", "1234567812345678", 1000),
            new Customer(Guid.NewGuid(), "Борис", "Иванов", "Сергеевич", "ул. Пушкина, 2", "2345678923456789", 2000),
            new Customer(Guid.NewGuid(), "Виктор", "Кудлацкий", "Васильевич", "ул. Чехова, 3", "3456981074567890", 3000),
            new Customer(Guid.NewGuid(), "Артем", "Блатной", "Алексеевич", "ул. Чехова, 5", "9123789034016890", 7000),
            new Customer(Guid.NewGuid(), "Сергей", "Петров", "Иванович", "ул. Некрасова, 9", "1112579567567999", 9000)
            };

            Customer.PrintSortedCustomers(customers);
            Customer.PrintFilteredCustomers(customers, "1234567812345678", "9123789034016890");

            Customer obj = new Customer();

            // Пример использования метода с ref и out параметрами
            int amount = -500;
            customers[0].UpdateBalance(ref amount, out bool success);
            Console.WriteLine($"Обновление баланса выполнено успешно: {success}, Новый баланс: {customers[0].Balance}\n");

            // Создание анонимного типа
            var anonymousCustomers = customers.Select(c => new
            {
                FullName = $"{c.FirstName} {c.Surname} {c.LastName}",
                c.CreditCardNumber
            });

            // Вывод анонимного типа
            Console.WriteLine("Анонимный тип покупателей:");
            foreach (var customer in anonymousCustomers)
            {
                Console.WriteLine($"Имя: {customer.FullName}, Номер кредитной карты: {customer.CreditCardNumber}");
            }


        }
    }
}
