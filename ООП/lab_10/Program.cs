using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ЗАДАНИЕ");

            List<string> month = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            List<string> summerMonth = new List<string> { "June", "July", "August" };
            List<string> winterMonth = new List<string>  { "December", "January", "February" };

            string n;

            Console.WriteLine("Введите n:");
            n = Console.ReadLine();
            Convert.ToInt32(n);

            var nLengthMonth = month.Where(m => m.Length == Convert.ToInt32(n));

            Console.WriteLine("\nМесяцы длинной n:");
            foreach (var item in nLengthMonth)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nТолько летние и зимние месяцы:");
            var sumwinMonth = month.Where(m => summerMonth.Contains(m) || winterMonth.Contains(m));

            Console.WriteLine("Летние и зимние месяцы");
            foreach (var item in sumwinMonth)
            {
                Console.WriteLine(item);
            }


            var orderMonth = from m in month
                             orderby m
                             select m;

            Console.WriteLine("\nВ алфавитном порядке:");
            foreach (var item in orderMonth)
            {
                Console.WriteLine(item);
            }


            var resultMonth = month.Where(m => m.Length >= 4);
            var rresultMonth = resultMonth.Where(m => m.Contains("u"));

            Console.WriteLine("\nСодержащие букву u и длинной более 4");
            foreach (var item in rresultMonth)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n2 ЗАДАНИЕ");

           
            List<Customer> customers = new List<Customer> 
            {
            new Customer(Guid.NewGuid(), "Алексей", "Смирнов", "Петрович", "ул. Ленина, 1", "12345678", 1000),
            new Customer(Guid.NewGuid(), "Борис", "Иванов", "Сергеевич", "ул. Пушкина, 2", "23456789", 2000),
            new Customer(Guid.NewGuid(), "Виктор", "Кудлацкий", "Васильевич", "ул. Чехова, 3", "34569810", 3000),
            new Customer(Guid.NewGuid(), "Артем", "Блатной", "Алексеевич", "ул. Красная", "91237890", 7000),
            new Customer(Guid.NewGuid(), "Сергей", "Петров", "Иванович", "ул. Семашко, 9", "41125795", 9000),
            new Customer(Guid.NewGuid(), "Антон", "Дубина", "Александрович", "ул. Железнодорожная, 9", "74515794", 12000),
            new Customer(Guid.NewGuid(), "Иван", "Иванов", "Иванович", "ул. Газеты \"Звязды\", 9", "94782573", 19000),
            new Customer(Guid.NewGuid(), "Андрей", "Самойлов", "Владиславович", "ул. Бобруйская, 24", "11125795", 2000),
            new Customer(Guid.NewGuid(), "Артем", "Якубинский", "Максимович", "ул. Белорусская, 21", "21125795", 4500),
            new Customer(Guid.NewGuid(), "Максим", "Бандит", "Станиславович", "ул. Королевская, 9", "61122226", 13300),
            };


            Console.WriteLine("\nCписок покупателей в алфавитном порядке:");
            var orderByCustomers = customers.OrderBy(c => c.getFirstName());

            foreach (var item in orderByCustomers)
            {
                Console.WriteLine($"{item.FirstName} {item.Surname} {item.LastName}");
            }

            Console.WriteLine("\nCписок покупателей,  у которых номер кредитной карточки  находится в заданном интервале:");
            var orderNumberCardCustomers = customers.Where(c => Convert.ToInt32(c.CreditCardNumber) > 50000000 && Convert.ToInt32(c.CreditCardNumber) < 90000000);

            foreach (var item in orderNumberCardCustomers)
            {
                Console.WriteLine(item.CreditCardNumber);
            }

            Console.WriteLine("\nМаксимальный покупатель:");
            var maxCustomer = customers.Max(c => c.Balance);

            Console.WriteLine($"Самый большой баланс покупателя составляет {maxCustomer}");

            Console.WriteLine("\nВывод первых пять покупателей с максимальной суммой на карте");
            var firstFiveCustomers = customers.OrderByDescending(c => c.Balance).Take(5);

            foreach (var item in firstFiveCustomers)
            {
                Console.WriteLine(item.Balance);
            }

            Console.WriteLine("\nСвой собственный запрос:");
            var myCustomers = customers.Where(c => c.FirstName.StartsWith("А")).OrderByDescending(c => c.Balance).Take(3);

            foreach (var item in myCustomers)
            {
                Console.WriteLine($"{item.FirstName}, баланс: {item.Balance}");
            }

            Console.WriteLine("\nЗапрос с Join:");

            

            Person[] people =
            {
                new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
                new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
            };

            Company[] companies =
            {
                new Company("Microsoft", "C#"),
                new Company("Google", "Go"),
                new Company("Oracle", "Java")
            };

            var employees = people.Join(companies, // второй набор
             p => p.Company, // свойство-селектор объекта из первого набора
             c => c.Title, // свойство-селектор объекта из второго набора
             (p, c) => new { Name = p.Name, Company = c.Title, Language = c.Language }); // результат

            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Name} - {item.Company} ({item.Language})");
            }
        }
    }
}
