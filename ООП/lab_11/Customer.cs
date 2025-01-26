using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface ICustomer
    {
        string GetFirstName();
    }
    public class Customer : ICustomer
    {
        Guid id;

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        private string adress;
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }


        private string creditCardNumber;
        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set
            {
                if (value.Length != 16)
                    return;

                creditCardNumber = value;
            }
        }


        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private static int numberCalls = 0;

        // конструкторы

        public Customer()
        {
            id = Guid.NewGuid();
            firstName = string.Empty;
            surname = string.Empty;
            lastName = string.Empty;
            adress = string.Empty;
            creditCardNumber = string.Empty;
            balance = 0;

            IncrementCalls();
        }

        public Customer(
                int balance,
                string firstName = "Иван",
                string surname = "Иванов",
                string lastName = "Иванович"
                )
        {
            id = Guid.NewGuid();
            this.firstName = firstName;
            this.surname = surname;
            this.lastName = lastName;
            adress = string.Empty;
            creditCardNumber = string.Empty;
            this.balance = balance;

            IncrementCalls();
        }

        public Customer(
                        Guid id,
                        string firstName,
                        string surname,
                        string lastName,
                        string adress,
                        string creditCardNumber,
                        int balance
                        )
        {
            this.id = id;
            this.firstName = firstName;
            this.surname = surname;
            this.lastName = lastName;
            this.adress = adress;
            this.creditCardNumber = creditCardNumber;
            this.balance = balance;

            IncrementCalls();
        }

        // методы класса

        public string GetFirstName()
        {
            return firstName;
        }
        public void Print()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Отчество: {LastName}");
            Console.WriteLine($"Адресс: {Adress}");
            Console.WriteLine($"Номер кредитной карты: {CreditCardNumber}");
            Console.WriteLine($"Баланс: {Balance}\n\n");
        }

        public void DebitFromAccount()
        {

            Console.WriteLine("Какую сумму списать со счёта?\nВведите сумму: ");
            int debit = Convert.ToInt32(Console.ReadLine());


            if (Balance < debit)
            {
                Console.WriteLine("Ошибка! На карте недастаточно средств!");
                return;
            }

            Balance -= debit;
        }

        public void AccrualToAccount()
        {
            int accrual = 0;
            Console.WriteLine("Какую сумму начислить на счёт?\nВведите сумму: ");
            accrual = Convert.ToInt32(Console.ReadLine());

            Balance += accrual;
        }

        public static void IncrementCalls()
        {
            numberCalls++;
        }

        public static void PrintNumCalls()
        {
            Console.WriteLine($"Количество созданных экземпляров класса: {numberCalls}");
        }

        public void UpdateBalance(ref int amount, out bool success)
        {
            if (amount < 0 && Balance + amount < 0)
            {
                success = false;
            }
            else
            {
                Balance += amount;
                success = true;
            }
        }


        // Задания с курсивом

        public static void PrintSortedCustomers(Customer[] customers)
        {
            var sortedCustomers = customers
                .OrderBy(item => item.Surname)
                .ThenBy(item => item.FirstName)
                .ThenBy(item => item.LastName);

            Console.WriteLine("Отсортированный список покупателей:");

            foreach (Customer customer in sortedCustomers)
            {
                customer.Print();
            }
        }

        public static void PrintFilteredCustomers(
                Customer[] customers,
                string startRange,
                string endRange
                                                 )
        {
            Console.WriteLine($"\nПокупатели, чей счет больше чем {startRange} и меньше, чем {endRange}\n\n");

            foreach (Customer customer in customers)
            {
                if (Convert.ToUInt64(customer.creditCardNumber) >= Convert.ToUInt64(startRange)
                    && Convert.ToUInt64(customer.creditCardNumber) <= Convert.ToUInt64(endRange))
                {
                    customer.Print();
                }
            }


        }
    }

