using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plant rose = new Rose { Name = "Red Rose" };
            Plant cactus = new Cactus { Name = "Desert Cactus" };
            Plant paper = new Paper { Name = "Recycled Paper" };

            Printer printer = new Printer();
            printer.IAmPrinting(rose);
            printer.IAmPrinting(cactus);
            printer.IAmPrinting(paper);

            UserClass userClass = new UserClass();
            userClass.DoClone();
            ((ICloneable)userClass).DoClone();

            List<Plant> plants = new List<Plant> { rose, cactus, paper };
            foreach (var plant in plants)
            {
                if (plant is Flower flower)
                {
                    Console.WriteLine($"{flower.Name} is a flower.");
                }
                else if (plant is Cactus)
                {
                    Console.WriteLine($"{plant.Name} is a cactus.");
                }
                else
                {
                    Console.WriteLine($"{plant.Name} is a plant.");
                }
            }
        }
    }
}
