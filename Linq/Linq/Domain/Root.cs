using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Domain
{
    public class Subcomponent
    {
        public string Type { get; set; }
        public double Price { get; set; }
    }

    public class Detail
    {
        public string ComponentType { get; set; }
        public List<Subcomponent> Subcomponents { get; set; }
        public int PriceIncrement { get; set; }
        public int NumComponents { get; set; }
        public string Color { get; set; }
        public List<string> Tests { get; set; }
    }

    public class Root
    {
        public string Order { get; set; }
        public List<Detail> Detail { get; set; }
    }
}
