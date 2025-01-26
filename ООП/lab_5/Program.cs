using lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plant bush = new Plant { Name = "Green Bush", Type = PlantType.Bush };
            Plant rose = new Plant { Name = "Red Rose", Type = PlantType.Rose };
            Plant cactus = new Plant { Name = "Desert Cactus", Type = PlantType.Cactus };

            bush.Grow();
            rose.Grow();
            cactus.Grow();

            Printer printer = new Printer();
            printer.IAmPrinting(bush);
            printer.IAmPrinting(rose);
            printer.IAmPrinting(cactus);

            Console.WriteLine("\n-----------------------------------------\n");
            

            ////////////////////////////////////////////////////////////////////////

            
            Controller controller = new Controller();

            controller.AddUnit(new Human { Name = "John", YearOfBirth = 1990 });
            controller.AddUnit(new Transformer { Name = "Optimus Prime", YearOfBirth = 2000, Power = 100 });
            controller.AddUnit(new Transformer { Name = "Bumblebee", YearOfBirth = 2005, Power = 80 });

            Console.WriteLine("All units in the army:");
            controller.DisplayAllUnits();

            Console.WriteLine("\nFinding unit born in 2000:");
            var unit = controller.FindUnitByYear(2000);
            controller?.DisplayInf(unit);

            Console.WriteLine("\nTransformers with power 100:");
            var transformers = controller.GetTransformersByPower(100);
            transformers.ForEach(Console.WriteLine);

            Console.WriteLine($"\nTotal units in the army: {controller.GetTotalUnits()}");
        }
    }
}
