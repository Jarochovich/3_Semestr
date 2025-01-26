using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public class Exsepsion1 : Exception
    {
        public int _id {get;set;}

        public Exsepsion1(int _id)
        {
            this._id = _id;
        }

        public void heightnull()
        {
            if (this._id < 0)
                throw new Exception("Нельзя меньше 0");
        }

        public void MyAssertException()
        {
            Debug.Assert(this._id < 11, "ID не может быть больше 10!");
        }
    }
}
