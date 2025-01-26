using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Exsepsion3 : Exception
    {
        public int operand1 { get; set; }
        public int operand2 { get; set; }

        public char operation { get; set; }

        public Exsepsion3(int operand1, int operand2, char operation)
        {
            this.operand1 = operand1;
            if (this.operand1 > int.MaxValue || this.operand1 < int.MinValue)
                throw new Exception("Первый операнд выходит за границы допустимых чисел!");

            this.operand2 = operand2;
            if (this.operand1 > int.MaxValue || this.operand2 < int.MinValue)
                throw new Exception("Второй операнд выходит за границы допустимых чисел!");

            this.operation = operation;
            if (this.operation != '+' && this.operation != '-' &&
                this.operation != '*' && this.operation != '/')
            {
                throw new Exception($"Операции {this.operation} не предусмотрено!");
            }
        }

        public int Result()
        {
            switch (this.operation)
            {
                case '+':
                    {
                        return this.operand1 + this.operand2;
                    }
                case '-':
                    {
                        return this.operand1 - this.operand2;
                    }
                case '*':
                    {
                        return this.operand1 * this.operand2;
                    }
                case '/': 
                    {
                        if (this.operand2 == 0)
                            throw new Exception("Делить на 0 нельзя!");
                        
                        return this.operand1 / this.operand2;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
