using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VuelingFaktory.Domain
{
    public class OrderInfo
    {
        public string Order { get; set; }
        public List<OrderComponents> Detail { get; set; }

    }
}
