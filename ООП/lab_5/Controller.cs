using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    internal class Controller : Army
    {
        public List<BattleUnit> FindUnitByYear(int year)
        {
            List<BattleUnit> Arr = new List<BattleUnit>();

            foreach (BattleUnit unit in units)
                if (unit.YearOfBirth == year)
                    Arr.Add(unit);

            return Arr;
        }

        public List<string> GetTransformersByPower(int power)
        {
            List<string> transformerNames = new List<string>();

            foreach (BattleUnit unit in units)
                if (unit is Transformer tranformer && tranformer.Power == power)
                        transformerNames.Add(tranformer.Name);

            return transformerNames;
        }

        public int GetTotalUnits()
        {
            return units.Count();
        }

        public void DisplayAllUnits()
        {
            foreach (var unit in units)
            {
                unit.DisplayInfo();
            }
        }
    }
}
