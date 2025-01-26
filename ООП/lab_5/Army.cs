using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    abstract class BattleUnit
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public abstract void DisplayInfo();
    }

    class Human : BattleUnit
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Human: {Name}, Year of Birth: {YearOfBirth}");
        }
    }

    class Transformer : BattleUnit
    {
        public int Power { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Transformer: {Name}, Year of Creation: {YearOfBirth}, Power: {Power}");
        }
    }

    class Army
    {
        protected List<BattleUnit> units = new List<BattleUnit>();

        public void AddUnit(BattleUnit unit)
        {
            units.Add(unit);
        }

        public void RemoveUnit(BattleUnit unit)
        {
            units.Remove(unit);
        }
         
        public void DisplayInf(List<BattleUnit> battleUnit)
        {
            foreach (var unit in battleUnit)
                unit.DisplayInfo();
        }
    }
}
