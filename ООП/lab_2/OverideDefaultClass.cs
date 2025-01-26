using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal partial class Customer
    {

        // Переопределение методов класса Object
        public override bool Equals(object obj)
        {
            if (obj is Customer other)
            {
                return id == other.id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked // Отключает генерацию исключений при переполнении
            {
                int hash = 23;
                hash = hash * 13 + id.GetHashCode();
                hash = hash * 13 + (firstName != null ? firstName.GetHashCode() : 0);
                hash = hash * 13 + (surname != null ? surname.GetHashCode() : 0);
                hash = hash * 13 + (lastName != null ? lastName.GetHashCode() : 0);
                hash = hash * 13 + (adress != null ? adress.GetHashCode() : 0);
                hash = hash * 13 + (creditCardNumber != null ? creditCardNumber.GetHashCode() : 0);
                hash = hash * 13 + balance.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            return $"Customer: {FirstName} {Surname} {LastName}, Address: {Adress}, Credit Card: {CreditCardNumber}, Balance: {Balance}";
        }
    }
}
