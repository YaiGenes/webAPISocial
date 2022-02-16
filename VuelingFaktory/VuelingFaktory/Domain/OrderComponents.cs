using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VuelingFaktory.Domain
{
    public class OrderComponents
    {
        public string ComponentType { get; set; }
        public List<Subcomponent> Subcomponents { get; set; }
        public double PriceIncrement { get; set; }
        public int NumComponents { get; set; }
        public string Color { get; set; }
        public List<string> Tests { get; set; }

    }
}
