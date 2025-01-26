using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ЗАДАНИЕ

            void DisplayMessage(string message) => Console.WriteLine(message);

            Boss turner = new Boss("Ivan", 1000);
            turner.Notify += DisplayMessage;

            turner.Promote(500);
            turner.Fine(300);
            turner.CurrentSalary();

            Boss programmer = new Boss("Andrey", 5000);
            programmer.Notify += DisplayMessage;

            programmer.CurrentSalary();
            programmer.Promote(800);
            programmer.CurrentSalary();

            // 2 ЗАДАНИЕ

            string input = "  Привет  , мир ! Это тестовая    строка Декстер.  ";

            Func<string, string> RemovePunctuation = str =>
            {
                foreach (var c in str)
                    if (char.IsPunctuation(c))
                        str = str.Replace(c.ToString(), string.Empty);

                return str;
            };
            Func<string, string> ToUpperCase = str => str.ToUpper();
            Func<string, string> ReplaceSpacesWithUnderscores = str => str.Replace(" ", "");

            input = RemovePunctuation(input);
            input = ToUpperCase(input);
            input = ReplaceSpacesWithUnderscores(input);

            Console.WriteLine(input);
        }
    }
}
