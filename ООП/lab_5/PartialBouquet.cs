using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public partial class PartialBouquet
    {
        public List<Plant> Flowers { get; set; } = new List<Plant>();

        public override string ToString()
        {
            return $"Bouquet with {Flowers.Count} flowers.";
        }
    }
}
