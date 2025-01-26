using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Boss
    {
        // 1 ЗАДАНИЕ

        private string _name;
        private int _salary;
        public Boss(string name = "defaultBoss", int salary = 0)
        {
            this._name = name;
            this._salary = salary;
        }

        public delegate void Office(string Message);
        public event Office Notify;


        public void Promote(int valuePromote) 
        {
            this._salary += valuePromote;
            Notify?.Invoke($"Зарплата работника {this._name} теперь поднята на величину {valuePromote} руб.\n");
        }

        public void Fine(int valueFine)
        {
            this._salary -= valueFine;
            Notify?.Invoke($"Зарплата работника {this._name} была понижена на величину {valueFine} руб.\n");
        }

        public void CurrentSalary() => Notify?.Invoke($"Текущая зарпалата работника {this._name} равна {this._salary}\n");
    }
}
