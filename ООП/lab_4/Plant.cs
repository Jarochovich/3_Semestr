using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    // Базовый класс Растение
    public abstract class Plant
    {
        public string Name { get; set; }
        public abstract void Grow();
        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Name: {Name}";
        }
    }

    // Класс Куст, наследуется от Растение
    public class Bush : Plant
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is growing as a bush.");
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Bush other = (Bush)obj;
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"Bush: {Name}";
        }
    }


    // Класс Цветок, наследуется от Растение
    public class Flower : Plant
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is blooming.");
        }
    }

    // Класс Роза, наследуется от Цветок
    public class Rose : Flower
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is blooming as a rose.");
        }
    }

    // Класс Гладиолус, наследуется от Цветок
    public class Gladiolus : Flower
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is blooming as a gladiolus.");
        }
    }

    // Класс Кактус, наследуется от Растение
    public class Cactus : Plant
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is growing as a cactus.");
        }
    }

    // Класс Бумага, наследуется от Растение
    public class Paper : Plant
    {
        public override void Grow()
        {
            Console.WriteLine($"{Name} is being produced as paper.");
        }
    }

    // Класс Букет, содержит коллекцию Цветов
    public class Bouquet
    {
        public List<Flower> Flowers { get; set; } = new List<Flower>();

        public override string ToString()
        {
            return $"Bouquet with {Flowers.Count} flowers.";
        }
    }

    public interface ICloneable
    {
        bool DoClone();
    }

    public abstract class BaseClone
    {
        public abstract bool DoClone();
    }

    public class UserClass : BaseClone, ICloneable
    {
        public override bool DoClone()
        {
            Console.WriteLine("Cloning in BaseClone way.");
            return true;
        }

        bool ICloneable.DoClone()
        {
            Console.WriteLine("Cloning in ICloneable way.");
            return true;
        }
    }

    public sealed class SealedClass
    {
        public string Description { get; set; }
        public override string ToString()
        {
            return $"SealedClass: {Description}";
        }
    }

    public class Printer
    {
        public void IAmPrinting(Plant plant)
        {
            Console.WriteLine(plant.ToString());
        }
    }

}
