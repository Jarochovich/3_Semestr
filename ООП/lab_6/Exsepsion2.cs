using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Exsepsion2 : Exception
    {
        public string name { get; set; }
        public Exsepsion2(string name)
        {
            this.name = name;
        }

        public void EmptyStr()
        {
            if (name.Length < 1)
                throw new Exception("Строка не может быть пуста");
        }
    }
}
