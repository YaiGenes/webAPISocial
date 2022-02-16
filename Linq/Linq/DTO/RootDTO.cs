using Linq.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.DTO
{
    public class RootDTO
    {
        public string ComponentType { get; set; }
        public List<Subcomponent> Subcomponents { get; set; }
        public int PriceIncrement { get; set; }
        public int NumComponents { get; set; }
        public string Color { get; set; }
        public List<string> Tests { get; set; }
        public string Order { get; set; }
        public List<Detail> Detail { get; set; }

    }
}
